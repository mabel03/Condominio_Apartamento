using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;

namespace ExamenProgramacion
{
    public partial class Listados : Form
    {
        EntidadClases habitantes = new EntidadClases();
        Clasenegocio ejecutor = new Clasenegocio();

        private string opcionFiltro;
        public Listados()
        {
            InitializeComponent();
        }


        private void TercerEliminar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TercerMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ejecutor.Lector();
        }

        private void cbValor_SelectedIndexChanged(object sender, EventArgs e)
        {
            opcionFiltro = cbCampo.SelectedItem.ToString();
            if (opcionFiltro == "Manzana")
            {
                cbValor.DataSource = null;
                cbValor.ValueMember = "CodigoManzana";
                cbValor.DisplayMember = "Manzana";
                cbValor.DataSource = ejecutor.CampoManzana();
                cbValor.SelectedIndex = -1;

            }
            else
            {
                cbValor.DataSource = null;
                cbValor.ValueMember = "CodigoEdificio";
                cbValor.DisplayMember = "Edificio";
                cbValor.DataSource = ejecutor.CampoEdificio();
                cbValor.SelectedIndex = -1;

            }
        }

        private void Listados_Load_1(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Manzana();
            form.Edificio(); 

        }


        private void cbValor_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string valor = cbValor.Text;
            if (opcionFiltro == "Manzana")
            {
                dataGridView1.DataSource = ejecutor.ListadoManzana(valor);
            }
            else
            {
                dataGridView1.DataSource = ejecutor.ListadoEdificio(valor);
            }
        }
    }
}
