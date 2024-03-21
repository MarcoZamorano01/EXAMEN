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
    public partial class EmpleadoInsertarVista : Form
    {
        public EmpleadoInsertarVista()
        {
            InitializeComponent();
        }
        EmpleadoBss bss = new EmpleadoBss();

        private void button1_Click(object sender, EventArgs e)//GUARDAR
        {
            EMPLEADO p = new EMPLEADO();
            p.IdPersona = IdPersonaSeleccionada;
            p.Puesto = textBox2.Text;
            p.Salario = Convert.ToDecimal(textBox3.Text);
            p.FechaContra = dateTimePicker1.Value;

            bss.InsertarEmpleadoBss(p);
            MessageBox.Show("Se guardó correctamente el empleado");
        }
        public static int IdPersonaSeleccionada = 0;
        PersonaBss bssper = new PersonaBss();
        private void button2_Click(object sender, EventArgs e)//SELECCIONAR PERSONA
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
