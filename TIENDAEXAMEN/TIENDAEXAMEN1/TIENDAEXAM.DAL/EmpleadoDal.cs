using SISTEMASVENTAS.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TIENDAEXAM.MODELOS;

namespace TIENDAEXAM.DAL
{
    public class EmpleadoDal
    {
        public DataTable ListaEmpleadoDal()
        {
            string cosulta = "select * from empleado";
            DataTable Lista = conexion.EjecutarDataTabla(cosulta, "tabla");
            return Lista;
        }

        public void InsertarEmpleadoDal(EMPLEADO empleado)
        {
            string consulta = "insert into empleado values('" + empleado.IdPersona + "'," + "'" + empleado.Puesto + "'," + "'" + empleado.Salario + "'," + "'" + empleado.FechaContra + "')";
            conexion.Ejecutar(consulta);
        }

        public EMPLEADO ObtenerEmpleadoId(int Id)
        {
            string consulta = "select * from cliente where idcliente=" + Id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            EMPLEADO p = new EMPLEADO();
            if (tabla.Rows.Count > 0)
            {
                p.IdEmpleado = Convert.ToInt32(tabla.Rows[0]["IdPersona"]);
                p.IdPersona = Convert.ToInt32(tabla.Rows[0]["IdPersona"]);
                p.Puesto = tabla.Rows[0]["nombre"].ToString();
                p.Salario = Convert.ToDecimal(tabla.Rows[0]["apellido"]);
                p.FechaContra = Convert.ToDateTime(tabla.Rows[0]["estado"]);
            }
            return p;
        }
        public void EditarEmpleadoDal(EMPLEADO p)
        {
            string consulta = "update empleado set idpersona='" + p.IdPersona + "'," + "puesto = '" + p.Puesto + "'," + "salario = '" + p.Salario + "'," + "fechacontra ='" + p.FechaContra + "' " + "where idempleado=" + p.IdEmpleado;
            conexion.Ejecutar(consulta);
        }

        public void EliminarEmpleadoDal(int id)
        {
            string consulta = "delete from empleado where idempleado=" + id;
            conexion.Ejecutar(consulta);
        }
    }
}
