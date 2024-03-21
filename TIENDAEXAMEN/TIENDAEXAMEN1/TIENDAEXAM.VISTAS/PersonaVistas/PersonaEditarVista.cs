using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TIENDAEXAM.BSS;
using TIENDAEXAM.MODELOS;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TIENDAEXAM.VISTAS.PersonaVistas
{
    public partial class PersonaEditarVista : Form
    {
        int idx = 0;
        PERSONA p = new PERSONA();
        PersonaBss bss = new PersonaBss();
        public PersonaEditarVista(int id)
        {
            idx = id;
            InitializeComponent();
        }

        private void PersonaEditarVista_Load(object sender, EventArgs e)//cargar
        {
            p = bss.ObtenerPersonaIdBss(idx);
            textBox1.Text = p.Nombre.ToString();
            textBox2.Text = p.Apellido.ToString();
        }

        private void button2_Click(object sender, EventArgs e)//guardar
        {
            
            p.Nombre = textBox1.Text;
            p.Apellido = textBox2.Text;

            bss.EditarPersonaBss(p);
            MessageBox.Show("Datos Actualizados");
        }
    }
}
