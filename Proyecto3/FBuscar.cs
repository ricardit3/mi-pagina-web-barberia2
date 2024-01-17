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

namespace Proyecto3
{
    public partial class FBuscar : Form
    {
        Conexion o = new Conexion();
        public FBuscar()
        {
            InitializeComponent();
        }

        private void FBuscar_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(this.textBox1.Text!="")
            {
                string cade = "";
               if(this.radioButton1.Checked==true)
               {
                  cade= "select id,nombre from categoria where id=" + this.textBox1.Text;
                }
              else
               {

                    cade = "select id,nombre from categoria where nombre like '%" + this.textBox1.Text + "%'";

               }
                DataTable dt = new DataTable();
                dt = o.LlenarDatos(cade).Tables[0];
                if(dt.Rows.Count>0)
                {
                    this.dataGridView1.DataSource = dt;
                }

            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            string id = this.dataGridView1.Rows[this.dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
            string no= this.dataGridView1.Rows[this.dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
            FCategoria.co = id;
            FCategoria.nom = no;
            this.Close();
        }
    }
}
