using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto3
{
    public partial class Form1 : Form
    {
        Conexion o = new Conexion();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Ingresar())
            {
                
                FMenu f = new FMenu();
                this.Visible = false;
                f.Show(this);
            }
            else
                MessageBox.Show("No Existe Usuario o Error");
        }
        private bool Ingresar()
        {
            string cadena = "select password from usuario where usuario='" + this.textBox1.Text + "' and password='" + this.textBox2.Text + "'";
            DataTable dt = new DataTable();
            dt = o.LlenarDatos(cadena).Tables[0];
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
