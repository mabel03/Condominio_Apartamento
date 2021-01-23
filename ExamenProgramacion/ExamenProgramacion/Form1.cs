using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using CapaEntidad;
using CapaNegocio;

namespace ExamenProgramacion
{
    public partial class Form1 : Form
    {
        EntidadClases habitantes = new EntidadClases();
        Clasenegocio ejecutor = new Clasenegocio();
        public Form1()
        {
            InitializeComponent();
        }

        private void TercerEliminar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TercerMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }


        public void Manzana()
        {
            CbManzana.DataSource = ejecutor.CampoManzana();
            CbManzana.ValueMember = "CodigoManzana";
            CbManzana.DisplayMember = "Manzana";
            CbManzana.SelectedIndex = -1;
        }

        public void Edificio()
        {
            cbEdificio.DataSource = ejecutor.CampoEdificio();
            cbEdificio.ValueMember = "CodigoEdificio";
            cbEdificio.DisplayMember = "Edificio";
            cbEdificio.SelectedIndex = -1;
        }

        public void Apartamento()
        {
            cbApartamento.DataSource = ejecutor.CampoApartamento();
            cbApartamento.ValueMember = "CodigoApartamento";
            cbApartamento.DisplayMember = "Nombre";
            cbApartamento.SelectedIndex = -1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Manzana();
            Edificio();
            Apartamento();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                habitantes.Cedula = txtCed.Text;
                habitantes.Nombre = txtNom.Text;
                habitantes.Manzana = CbManzana.SelectedValue.ToString();
                habitantes.Edificio = cbEdificio.SelectedValue.ToString();
                habitantes.Apto = cbApartamento.SelectedValue.ToString();

                ejecutor.Creador(habitantes);
                MessageBox.Show("Los datos estan insertaron");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btBuscar_Click_1(object sender, EventArgs e)
        {
            try
            {
                habitantes.Cedula = txtBuscar.Text;
                dataGridView1.DataSource = ejecutor.Buscar(habitantes);

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                habitantes.Cedula = txtCed.Text;
                habitantes.Nombre = txtNom.Text;
                habitantes.Manzana = CbManzana.SelectedValue.ToString();
                habitantes.Edificio = cbEdificio.SelectedValue.ToString();
                habitantes.Apto = cbApartamento.SelectedValue.ToString();

                ejecutor.Modificar(habitantes);
                MessageBox.Show("Datos actualizados");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                habitantes.Cedula = txtCed.Text;
                ejecutor.Eliminar(habitantes);
                MessageBox.Show("Datos eliminados");

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ejecutor.Lector();
        }
    }
}
