using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using web_add.Servicios.Models;

namespace web_add
{
    public partial class CU_clStock : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack) 
            {
                CargarGrid();
            }
        }
        void CargarGrid()
        {
            ServicioclStock oServicioclStock = new ServicioclStock();
            rgvclStock.DataSource = oServicioclStock.GetList(((usuarioLogin)Session["ousuariologin"]).token);
            rgvclStock.DataBind();
        }
    }
}