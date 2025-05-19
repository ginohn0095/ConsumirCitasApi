using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using ConsumirCitasApi.Models;

namespace ConsumirCitasApi.Services
{
    public class ApiService
    {
        private readonly HttpClient _httpClient;
        private string _token = string.Empty;

        public ApiService()
        {
            var handler = new HttpClientHandler
            {
                ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => true
            };

            _httpClient = new HttpClient(handler)
            {
                BaseAddress = new Uri("https://localhost:5178/")
            };
        }

        public async Task<bool> LoginAsync(string username, string password)
        {
            var loginData = new LoginRequest { Username = username, Password = password };
            var json = JsonSerializer.Serialize(loginData);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("api/auth/login", content);

            if (response.IsSuccessStatusCode)
            {
                var responseBody = await response.Content.ReadAsStringAsync();
                var auth = JsonSerializer.Deserialize<AuthResponse>(responseBody, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                _token = auth?.Token ?? string.Empty;

                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _token);

                return !string.IsNullOrEmpty(_token);
            }

            return false;
        }

        public async Task<List<Cita>> GetCitasAsync()
        {
            var response = await _httpClient.GetAsync("api/Citas");

            if (!response.IsSuccessStatusCode)
                return new List<Cita>();

            var content = await response.Content.ReadAsStringAsync();
            var citas = JsonSerializer.Deserialize<List<Cita>>(content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            return citas ?? new List<Cita>();
        }

        public async Task<bool> CrearCitaAsync(Cita nuevaCita, string token)
        {
            AgregarToken(token);

            var content = new StringContent(JsonSerializer.Serialize(nuevaCita), Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("api/Citas", content);

            return response.IsSuccessStatusCode;
        }

        public async Task<bool> ActualizarCitaAsync(Cita cita, string token)
        {
            AgregarToken(token);

            var content = new StringContent(JsonSerializer.Serialize(cita), Encoding.UTF8, "application/json");
            var response = await _httpClient.PutAsync($"api/Citas/{cita.IdCita}", content); // Ruta corregida

            return response.IsSuccessStatusCode;
        }

        public async Task<bool> EliminarCitaAsync(int id, string token)
        {
            AgregarToken(token);

            var response = await _httpClient.DeleteAsync($"api/Citas/{id}"); // Ruta corregida

            return response.IsSuccessStatusCode;
        }

        private void AgregarToken(string token)
        {
            if (_httpClient.DefaultRequestHeaders.Authorization == null || _httpClient.DefaultRequestHeaders.Authorization.Parameter != token)
            {
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            }
        }
    }
}
