using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsEventoDeportivo.Model
{
    internal class EventoDeportivoModel
    {
        public int Id { get; set; }
        public string? NombreEvento { get; set; }
        public string? Tipo { get; set; }
        public DateTime Fecha { get; set; }
        public string? Lugar { get; set; }
        public int Participantes { get; set; }
        public decimal CostoInscripción { get; set; }
    }
}
