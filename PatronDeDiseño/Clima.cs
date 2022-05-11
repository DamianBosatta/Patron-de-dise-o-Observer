﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronDeDiseño
{
    public class Clima
    {
        public double temperatura;
        private int humedad;
        public int Humedad { get => humedad; }
        public double Temperatura { get => temperatura; }
        public Clima(double temperatura, int humedad)
        {
            this.temperatura = temperatura;
            this.humedad = humedad;
        }

    }
}
