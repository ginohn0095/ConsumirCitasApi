using System;
using System.Windows.Forms;
using ConsumirCitasApi.Services;
using ConsumirCitasApi.Models;

namespace ConsumirCitasApi
{
    public partial class Form1 : Form
    {
        private ApiService _apiService;
        private string _token;
        private int? citaSeleccionadaId = null;



        public Form1()
        {
            InitializeComponent();
            _apiService = new ApiService();
            this.dgvCitas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCitas_CellClick);


        }

        private async void btnLogin_Click_1(object sender, EventArgs e)
        {
            var success = await _apiService.LoginAsync("admin", "1234");

            if (success)
            {
                MessageBox.Show("Inicio de sesión exitoso");
                await CargarCitasAsync();
                pnlLogin.Enabled = false;
                pnlCRUD.Enabled = true;

            }
            else
            {
                MessageBox.Show("Credenciales incorrectas");
            }
        }


        private async Task CargarCitasAsync()
        {
            var citas = await _apiService.GetCitasAsync();
            dgvCitas.DataSource = citas;
        }

        private async void btnCrear_Click(object sender, EventArgs e)
        {
            var cita = new Cita
            {
                IdCita = int.Parse(txtIDCita.Text),
                PacienteId = int.Parse(txtPaciente.Text),
                DoctorId = int.Parse(txtDoctor.Text),
                ConsultorioId = int.Parse(txtConsultorio.Text),
                FechaCita = dtpFechaCita.Value,
                Estado = txtEstado.Text
            };

            bool creada = await _apiService.CrearCitaAsync(cita, _token);

            if (creada)
            {
                MessageBox.Show("Cita creada.");
                await CargarCitasAsync();


            }
            else
            {
                MessageBox.Show("Error al crear la cita.");
            }
        }


        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            if (citaSeleccionadaId == null)
            {
                MessageBox.Show("Selecciona una cita.");
                return;
            }

            var cita = new Cita
            {
                IdCita = citaSeleccionadaId.Value,
                PacienteId = int.Parse(txtPaciente.Text),
                DoctorId = int.Parse(txtDoctor.Text),
                ConsultorioId = int.Parse(txtConsultorio.Text),
                FechaCita = dtpFechaCita.Value,
                Estado = txtEstado.Text
            };

            bool actualizada = await _apiService.ActualizarCitaAsync(cita, _token);

            if (actualizada)
            {
                MessageBox.Show("Cita actualizada.");
                await CargarCitasAsync();
                LimpiarFormulario();

            }
            else
            {
                MessageBox.Show("Error al actualizar.");
            }
        }


        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            if (citaSeleccionadaId == null)
            {
                MessageBox.Show("Selecciona una cita.");
                return;
            }

            var confirm = MessageBox.Show("¿Estás seguro de eliminar esta cita?", "Confirmar", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                bool eliminada = await _apiService.EliminarCitaAsync(citaSeleccionadaId.Value, _token);

                if (eliminada)
                {
                    MessageBox.Show("Cita eliminada.");
                    await CargarCitasAsync();
                    LimpiarFormulario();

                }
                else
                {
                    MessageBox.Show("Error al eliminar la cita.");
                }
            }
        }




        private void dgvCitas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvCitas.Rows[e.RowIndex];

                citaSeleccionadaId = Convert.ToInt32(fila.Cells["IdCita"].Value); // Esto es importante para que eliminar/actualizar funcione

                txtIDCita.Text = fila.Cells["IdCita"].Value?.ToString();
                txtPaciente.Text = fila.Cells["PacienteId"].Value?.ToString();
                txtDoctor.Text = fila.Cells["DoctorId"].Value?.ToString();
                txtConsultorio.Text = fila.Cells["ConsultorioId"].Value?.ToString();

                if (DateTime.TryParse(fila.Cells["FechaCita"].Value?.ToString(), out DateTime fecha))
                {
                    dtpFechaCita.Value = fecha;
                }

                txtEstado.Text = fila.Cells["Estado"].Value?.ToString();
            }
        }
        private void LimpiarFormulario()
        {
            txtIDCita.Clear();
            txtPaciente.Clear();
            txtDoctor.Clear();
            txtConsultorio.Clear();
            txtEstado.Clear();
            citaSeleccionadaId = null;
        }



    }
}

