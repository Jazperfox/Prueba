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
    public partial class inicio : Form
    {
        private DataTable dt;
        public inicio()
        {
            InitializeComponent();
            //DateTime fecha= DateTime.Now;
            //lblfecha.Text = fecha.ToString();
            timer1.Enabled = true;

        }

       

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblfecha.Text = DateTime.Now.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
            //Program.form1.Show();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string fecha, hora,date;
            date = DateTime.Now.ToString();
            fecha = DateTime.Now.ToShortDateString();
            hora = DateTime.Now.ToLongTimeString();

            dgvTabla.Rows.Add(fecha, hora);

            label1.Text = hora;
            label2.Text = fecha;
        }
    }
}
