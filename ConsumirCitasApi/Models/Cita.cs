using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumirCitasApi.Models
{
    public class Cita
    {
        public int IdCita { get; set; }
        public int PacienteId { get; set; }
        public int DoctorId { get; set; }
        public int ConsultorioId { get; set; }
        public DateTime FechaCita { get; set; }
        public string? Estado { get; set; }
    }
}
