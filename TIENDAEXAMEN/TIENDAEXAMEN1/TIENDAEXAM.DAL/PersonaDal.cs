using System;
using TIENDAEXAM.MODELOS;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using SISTEMASVENTAS.DAL;

namespace TIENDAEXAM.DAL
{
    public class PersonaDal
    {
        public DataTable ListaPersonasDal()
        {
            string cosulta = "select * from persona";
            DataTable Lista = conexion.EjecutarDataTabla(cosulta, "tabla");
            return Lista;
        } 

        public void InsertarPersonaDal(PERSONA persona)
        {
            string consulta = "insert into persona values('" + persona.Nombre + "'," + "'" + persona.Apellido + "'," + "'Activo')";
            conexion.Ejecutar(consulta);
        }

        public PERSONA ObtenerPersonaId(int Id)
        {
            string consulta = "select * from persona where idpersona=" + Id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            PERSONA p = new PERSONA();
            if (tabla.Rows.Count > 0)
            {
                p.IdPersona = Convert.ToInt32(tabla.Rows[0]["IdPersona"]);
                p.Nombre = tabla.Rows[0]["nombre"].ToString();
                p.Apellido = tabla.Rows[0]["apellido"].ToString();
                p.Estado = tabla.Rows[0]["estado"].ToString();
            }
            return p;
        }
        public void EditarPersonaDal(PERSONA p)
        {
            string consulta = "update persona set nombre='" + p.Nombre + "'," + "apellido='" + p.Apellido +  "' " + "where idpersona=" + p.IdPersona;
            conexion.Ejecutar(consulta);
        }

        public void EliminarPersonaDal(int id)
        {
            string consulta = "delete from persona where idpersona=" + id;
            conexion.Ejecutar(consulta);
        }
    }
}
