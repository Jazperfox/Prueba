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
            string mensaje;
            inicio formulario = new inicio();

            MessageBox.Show("Su usuario es: " + txtUser.Text + "\nSu contraseña es: " + txtPassword.Text);
            usuarios obj = new usuarios();
            //MessageBox.Show(obj.valida(txtUser.Text, txtPassword.Text));
            mensaje = obj.valida(txtUser.Text, txtPassword.Text);
            if (mensaje=="valido")
            {
                MessageBox.Show("Las credenciales ingresadas son " + mensaje);
                
                formulario.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("Las credenciales ingresadas son " + mensaje);
            }
            

        }

        private void userInsert(object sender, EventArgs e)
        {
            if(txtUser.Text=="Ingrese su usuario")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.Black;
            }
        }

        private void userLeave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "Ingrese su usuario";
                txtUser.ForeColor = Color.Gray;
            }
        }

        private void passInsert(object sender, EventArgs e)
        {
            if (txtPassword.Text == "password")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
            }
        }

        private void passLeave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "password";
                txtPassword.ForeColor = Color.Gray;
            }
        }
    }
}
