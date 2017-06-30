using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TareaAplicada.Models
{
    public class Cobro
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string Referencia { get; set; }
        public int IdRemoto  { get; set; }
        public double Mora { get; set; }
        public double Monto { get; set; }
        public double Latitude { get; set; }
        public double Longitud { get; set; }
        public int esNulo { get; set; }
    }
}
