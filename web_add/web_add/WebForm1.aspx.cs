using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using web_add.Servicios;
using web_add.Servicios.Models;

namespace web_add
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            servicioAutenticar oservicioAutentificar = new servicioAutenticar();
            usuarioLogin ousuarioLogin = oservicioAutentificar.RecuperaToken("ricardo", "12345");
            
            if (ousuarioLogin.token != null) 
            {
                Session.Add("ousuarioLogin", ousuarioLogin);

                Response.Redirect("./wfclStock.aspx");
            }
        }
    }
}