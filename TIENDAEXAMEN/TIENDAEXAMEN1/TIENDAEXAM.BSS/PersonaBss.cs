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
    public class PersonaBss
    {
        PersonaDal dal = new PersonaDal();
        public DataTable ListaPersonaBss()
        {
            return dal.ListaPersonasDal();
        }
        public void InsertarPersonaBss(PERSONA persona)
        {
            dal.InsertarPersonaDal(persona);
        }
        public PERSONA ObtenerPersonaIdBss(int id)
        {
            return dal.ObtenerPersonaId(id);
        }
        public void EditarPersonaBss(PERSONA p)
        {
            dal.EditarPersonaDal(p);
        }
        public void EliminarPersonaBss(int id)
        {
            dal.EliminarPersonaDal(id);
        }
    }
}
