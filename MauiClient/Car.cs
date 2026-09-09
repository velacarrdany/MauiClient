using System;
using System.Collections.Generic;
using System.Text;

namespace MauiClient
{
    public class Car
    {
        public int Id {  get; set; }
        public string? Brand { get; set; }
        public string? Model { get; set; }
        public double Price { get; set; }
        public DateTime Release { get; set; }
    }
}
