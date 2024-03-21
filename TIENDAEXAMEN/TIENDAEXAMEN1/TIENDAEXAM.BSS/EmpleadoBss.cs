using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TIENDAEXAM.DAL;
using TIENDAEXAM.MODELOS;

namespace TIENDAEXAM.BSS
{
    public class EmpleadoBss
    {
        EmpleadoDal dal = new EmpleadoDal();
        public DataTable ListaEmpleadoBss()
        {
            return dal.ListaEmpleadoDal();
        }
        public void InsertarEmpleadoBss(EMPLEADO empleado)
        {
            dal.InsertarEmpleadoDal(empleado);
        }
        public EMPLEADO ObtenerEmpleadoIdBss(int id)
        {
            return dal.ObtenerEmpleadoId(id);
        }
        public void EditarEmpleadoBss(EMPLEADO p)
        {
            dal.EditarEmpleadoDal(p);
        }
        public void EliminarEmpleadoBss(int id)
        {
            dal.EliminarEmpleadoDal(id);
        }
    }
}
