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

namespace TIENDAEXAM.VISTAS.EmpleadoVistas
{
    public partial class EmpleadoListarVista : Form
    {
        public EmpleadoListarVista()
        {
            InitializeComponent();
        }
        EmpleadoBss bss = new EmpleadoBss();

        private void EmpleadoListarVista_Load(object sender, EventArgs e)//cargar
        {
            dataGridView1.DataSource = bss.ListaEmpleadoBss();
        }

        private void button1_Click(object sender, EventArgs e)//EDITAR
        {
            int IdSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            EmpleadoEditarVista fr = new EmpleadoEditarVista(IdSeleccionada);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListaEmpleadoBss();
            }
        }

        private void button2_Click(object sender, EventArgs e)//INSERTAR
        {
            EmpleadoInsertarVista fr = new EmpleadoInsertarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListaEmpleadoBss();
            }
        }

        private void button3_Click(object sender, EventArgs e)//ELIMINAR
        {
            int IdSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("¿Esta seguro de Eliminar este Empleado?", "Eliminando", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarEmpleadoBss(IdSeleccionada);
                dataGridView1.DataSource = bss.ListaEmpleadoBss();
            }
        }

        private void button4_Click(object sender, EventArgs e)//SELECCIONAR
        {
            //especificar ruta
        }
    }
}
