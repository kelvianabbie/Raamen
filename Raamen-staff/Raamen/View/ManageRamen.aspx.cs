using Raamen.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Raamen.View
{
    public partial class ManageRamen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            raamenView.DataSource = UserController.getAllRamen();
            raamenView.DataBind();
        }

        protected void raamenView_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = raamenView.Rows[e.RowIndex];
            int id = int.Parse(row.Cells[1].Text);
            UserController.deleteRamen(id);
        }

        protected void raamenView_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = raamenView.Rows[e.NewEditIndex];
            int id = int.Parse(row.Cells[1].Text);
            Response.Redirect("~/View/UpdatePage.aspx?id=" +id);
        }

        protected void insertBtn_Click(object sender, EventArgs e)
        {
            int meatid = int.Parse(meatTxt.Text);
            string name = ramenTxt.Text;
            string broth = brothTxt.Text;
            string price = priceTxt.Text;

            UserController.insertRamen(meatid, name, broth, price);
        }
    }
}