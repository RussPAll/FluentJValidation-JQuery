using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebFormsApp.App_Code;
using Domain;

namespace WebFormsApp
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var validation = new FluentJQueryValidation();
            string script = validation.GenerateScript<Address>(new AddressValidator());
            Response.Write(script);
        }
    }
}
