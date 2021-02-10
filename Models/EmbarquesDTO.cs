using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LtxApi2020.Models
{
    public class EmbarquesDTO
    {
        public int Recibo { get; set; }
        public DateTime Fecha { get; set; }
        public string Shipper { get; set; }
        public int Piezas { get; set; }
        public string Peso { get; set; }
        public string PesoVolumetrico { get; set; }
        public string Volumen { get; set; }
    }
}