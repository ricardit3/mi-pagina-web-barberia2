using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net.Http.Headers;

namespace Proyecto3
{
    public partial class FCategoria : Form
    {

        Conexion o = new Conexion();
        public static string co;
        public static string nom;
        public FCategoria()
        {
            InitializeComponent();
        }

        private void CargarLista()
        {
            string cade = "select id,nombre from categoria order by nombre";
            DataTable dt = new DataTable();
            dt = o.LlenarDatos(cade).Tables[0];
            this.dataGridView1.DataSource = dt;
        }

        private void Limpiar()
        {
            this.textBox1.Text = "";
            this.textBox2.Text = "";
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.HabilitarDes();
            this.textBox1.Enabled = !this.textBox1.Enabled;
            this.textBox2.Enabled = !this.textBox2.Enabled;
            this.textBox1.Focus();
            this.Limpiar();
        }

        private void HabilitarDes()
        {
            for(int i=0;i<this.menuStrip1.Items.Count;i++)
            {
                this.menuStrip1.Items[i].Enabled = !this.menuStrip1.Items[i].Enabled;
            }
        }


        private void FCategoria_Load(object sender, EventArgs e)
        {
            this.CargarLista();
        }

        private bool Validar()
        {
            if(this.textBox1.Text!="" && this.textBox2.Text!="")
            {
                try
                {
                    int x = int.Parse(this.textBox1.Text);
                    string cade = "select id from categoria where id=" + this.textBox1.Text;
                    DataTable dt = o.LlenarDatos(cade).Tables[0];
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Código Repetido");
                        return false;

                    }
                    else
                    {
                        string cade1 = "select id from categoria where nombre='" + this.textBox2.Text+"'";
                        DataTable dt1 = o.LlenarDatos(cade1).Tables[0];
                        if (dt1.Rows.Count > 0)
                        {
                            MessageBox.Show("Nombre Repetido");
                            return false;

                        }
                        else
                            return true;


                    }
                    
                }
                catch(Exception e)
                {
                    MessageBox.Show("Error. Codigo Numerico");
                    return false;
                }
            }
            else
            { MessageBox.Show("Falta Llenar Datos");

                return false;
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Validar()==true)
            {
                if (this.GuardarN() == true)
            {
                MessageBox.Show("Registro Grabado");
                this.CargarLista();
                this.HabilitarDes();
                this.textBox1.Enabled = !this.textBox1.Enabled;
                this.textBox2.Enabled = !this.textBox2.Enabled;
            }
            else
            {
                MessageBox.Show("Error al Grabar");
                
            }
            }

        }

        private bool GuardarN()
        {
            string cade = "insert into categoria(id,nombre) values (" + this.textBox1.Text + ",'" + this.textBox2.Text + "')";
            if (o.EjecutarComando(cade))
                return true;
            else
                return false;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            co = "";
            nom = "";
            FBuscar fb = new FBuscar();
            fb.ShowDialog();

        }

        private void FCategoria_Activated(object sender, EventArgs e)
        {
            if (co != "")
            {
                this.textBox1.Text = co;
                this.textBox2.Text = nom;
            }
        }
    }
}