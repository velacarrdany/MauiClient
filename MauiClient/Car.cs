using System;
using System.Collections.Generic;
using System.Text;

namespace MauiClient
{
    public class Car
    {
        public int Id {  get; set; }
        public string? Marca { get; set; }
        public string? Modelo { get; set; }
        public double Precio { get; set; }
        public DateTime Lanzamiento { get; set; }
    }
}
