using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace POOI_T1_PEÑA.Models
{
    public class Empleado
    {
        public string idEmpleado { get; set; }
        public string nomapeEmpleado { get; set; }
        public string categoriaEmpleado { get; set; }
        public int nHijos { get; set; }
        public string tipoContrato { get; set; }


        public decimal SueldoBasico()  
        {
            decimal sueldobasico;

            if (categoriaEmpleado == "E1")
            {
                return sueldobasico = 1500;
            }
            else if (categoriaEmpleado == "E2")
            {
                return sueldobasico = 2500;
            }
            else if (categoriaEmpleado == "E3")
            {
                return sueldobasico = 2200;
            }
            else
            {
                return sueldobasico = 1700;
            }
        }


        public decimal Escolaridad()
        {
            decimal montEscolaridad;

            montEscolaridad = nHijos * 108;

            return montEscolaridad;
        }


        public virtual decimal Bonificacion()
        {
            decimal montBonificacion;

            if (tipoContrato == "Indefinido")
            {
                montBonificacion = SueldoBasico() * 0.15m;
            }

            else if (tipoContrato == "Contratado")
            {
                montBonificacion = SueldoBasico() * 0.10m;
            }

            else
            {
                montBonificacion = 0;
            }

            return montBonificacion;
        }


        public virtual decimal MontoAPagar()
        {
           decimal montoPago;
           montoPago = SueldoBasico() + Escolaridad() + Bonificacion();
           return montoPago;
        }



    }
}