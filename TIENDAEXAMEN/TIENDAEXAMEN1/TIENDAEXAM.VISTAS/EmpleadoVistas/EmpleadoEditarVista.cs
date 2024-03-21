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
using TIENDAEXAM.VISTAS.PersonaVistas;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TIENDAEXAM.VISTAS.EmpleadoVistas
{
    public partial class EmpleadoEditarVista : Form
    {
        int idx = 0;
        EMPLEADO p = new EMPLEADO();
        EmpleadoBss bss = new EmpleadoBss();
        public EmpleadoEditarVista(int id)
        {
            idx = id;
            InitializeComponent();
        }

        private void EmpleadoEditarVista_Load(object sender, EventArgs e)//cargar
        {
            p = bss.ObtenerEmpleadoIdBss(idx);
            textBox1.Text = p.IdPersona.ToString();
            textBox2.Text = p.Puesto.ToString();
            textBox3.Text = p.Salario.ToString();
            dateTimePicker1.Value = p.FechaContra;
        }

        private void button1_Click(object sender, EventArgs e)//guardar
        {
            p.IdPersona = IdPersonaSeleccionada;
            p.Puesto = textBox2.Text;
            p.Salario = Convert.ToDecimal(textBox3.Text);
            p.FechaContra = dateTimePicker1.Value;

            bss.EditarEmpleadoBss(p);
            MessageBox.Show("Datos Actualizados");
        }
        public static int IdPersonaSeleccionada = 0;
        PersonaBss bssper = new PersonaBss();
        private void button2_Click(object sender, EventArgs e)//seleccionar
        {
            PersonaListarVisa fr = new PersonaListarVisa();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                PERSONA persona = bssper.ObtenerPersonaIdBss(IdPersonaSeleccionada);
                textBox1.Text = persona.Nombre;
            }
        }
    }
}
