﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCAJ_EmpresaHerencia
{
    class Operador:Empleado
    {
        private int Piezas;

        public Operador()
        {
            Piezas = 0;
        }

        public void SetPiezas(int Piezas)
        {
            this.Piezas = Piezas;
        }

        public void CalcularTotalPagarO()
        {
            float Pz;
            Pz = Piezas * 2;

            Sueldo = HorasT * 100;
            Sueldo = Sueldo + Pz;
        }

        public int GetPiezas()
        {
            return Piezas;
        }

    }
}
