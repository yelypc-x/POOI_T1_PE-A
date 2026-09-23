using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace POOI_T1_PEÑA.Models
{
    public class Administrativo : Empleado
    {
        public int anioIngreso { get; set; }
        public bool postGrado { get; set; }

        public decimal Incentivo()
        {
            decimal montoIncentivo;

            if (postGrado == false)
            {
                montoIncentivo = 0;
            }
            else
            {
                montoIncentivo = 500;
            }

            return montoIncentivo;
        }

        public override decimal Bonificacion()
        {
            decimal montoBonificacion;
            int aniosServicio = DateTime.Now.Year - anioIngreso;

            if (aniosServicio < 5)
            {
                montoBonificacion = 200;
            }
            else if (aniosServicio >= 5 && aniosServicio <= 10)
            {
                montoBonificacion = 450;
            }
            else
            {
                montoBonificacion = 300;
            }

            return montoBonificacion;
        }

        public override decimal MontoAPagar()
        {
            decimal montoPago;
            montoPago = SueldoBasico() + Bonificacion() + Escolaridad() + Incentivo();
            return montoPago;
        }
    }
}