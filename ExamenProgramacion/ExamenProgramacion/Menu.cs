using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenProgramacion
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void TercerEliminar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TercerMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btCliente_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.ShowDialog();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Listados form = new Listados();
            form.ShowDialog();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
