using Raamen.Controller;
using Raamen.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Raamen.View
{
    public partial class UpdatePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["id"]);
            Raman ramen = UserController.findRamenWithId(id);
            meatTxt.Text = ramen.MeatId.ToString();
            ramenTxt.Text = ramen.Name;
            brothTxt.Text = ramen.Broth;
            priceTxt.Text = ramen.Price;
        }

        protected void updateBtn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["id"]);
            int meatid = int.Parse(meatTxt.Text);
            string name = ramenTxt.Text;
            string broth = brothTxt.Text;
            string price = priceTxt.Text;

            UserController.updateRamen(id, meatid, name, broth, price);
        }
    }
}