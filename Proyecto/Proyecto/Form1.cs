using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Su usuario es: " + txtUser.Text + "\nSu contraseña es: " + txtPassword.Text);
            usuarios obj = new usuarios();
            MessageBox.Show(obj.valida(txtUser.Text, txtPassword.Text));
            

        }
    }
}
