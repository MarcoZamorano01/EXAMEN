using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIENDAEXAM.MODELOS
{
    public class EMPLEADO
    {
        public int IdEmpleado { get; set; }
        public int IdPersona { get; set; }
        public string Puesto { get; set; }
        public decimal Salario { get; set; }
        public DateTime FechaContra { get; set; }
    }
}
