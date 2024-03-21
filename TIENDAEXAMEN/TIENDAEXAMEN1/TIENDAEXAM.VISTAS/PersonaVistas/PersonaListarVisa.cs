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
using TIENDAEXAM.VISTAS.EmpleadoVistas;

namespace TIENDAEXAM.VISTAS.PersonaVistas
{
    public partial class PersonaListarVisa : Form
    {
        public PersonaListarVisa()
        {
            InitializeComponent();
        }
        PersonaBss bss = new PersonaBss();
        private void PersonaListarVisa_Load(object sender, EventArgs e)//cargar
        {
            dataGridView1.DataSource = bss.ListaPersonaBss();
        }

        private void button1_Click(object sender, EventArgs e)//SELECCIONAR
        {
            EmpleadoVistas.EmpleadoInsertarVista.IdPersonaSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            EmpleadoVistas.EmpleadoEditarVista.IdPersonaSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
        }

        private void button4_Click(object sender, EventArgs e)//ELIMINAR
        {
            int IdSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("¿Esta seguro de Eliminar esta persona?", "Eliminando", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarPersonaBss(IdSeleccionada);
                dataGridView1.DataSource = bss.ListaPersonaBss();
            }
        }

        private void button3_Click(object sender, EventArgs e)//INSERTAR
        {
            PersonaInsertarVista fr = new PersonaInsertarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListaPersonaBss();
            }
        }

        private void button2_Click(object sender, EventArgs e)//EDITAR
        {
            int IdSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            PersonaEditarVista fr = new PersonaEditarVista(IdSeleccionada);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListaPersonaBss();
            }
        }
    }
}
