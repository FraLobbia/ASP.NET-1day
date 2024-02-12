using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

namespace WebApplication1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
            
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string name = ConfigurationManager.AppSettings["Name"];
            string surname = ConfigurationManager.AppSettings["surname"];
            testParagrafo.InnerText = "Il mio nome è "+ surname + " " + name;
        }
    }
}