using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASSIGNMENT6
{
    public partial class designation : System.Web.UI.Page
    {
        BAL.desBAL objbal = new BAL.desBAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DropDownList1.DataSource = objbal.getdept();
                DropDownList1.DataTextField = "depname";
                DropDownList1.DataValueField = "depid";
                DropDownList1.DataBind();
                DropDownList1.Items.Insert(0, new ListItem("-- Select --", "0"));
                GridView1.DataSource = objbal.viewdesign();
                GridView1.DataBind();
            }

        }
        protected void Button1_Click(object sender, EventArgs e)
        {

            objbal._deptid = Convert.ToInt32(DropDownList1.SelectedValue);
            objbal._designation = Designation.Text;
            int i = objbal.insertDesig();
            if (i == 1)
            {
                Response.Write("<script>alert('Designation Registered Successfully');</script>");



            }
            GridView1.DataSource = objbal.viewdesign();
            GridView1.DataBind();

        }


        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());

            TextBox txtdesg = new TextBox();
            txtdesg = (TextBox)GridView1.Rows[e.RowIndex].Cells[1].Controls[0]; objbal._desid = id; objbal._designation = txtdesg.Text; int i = objbal.Desigupdate();

            GridView1.DataSource = objbal.viewdesign(); GridView1.DataBind();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            GridView1.DataSource = objbal.viewdesign();
            GridView1.DataBind();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            objbal._desid = id;
            int i = objbal.deletedesig();
            GridView1.DataSource = objbal.viewdesign();
            GridView1.DataBind();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            GridView1.DataSource = objbal.viewdesign();
            GridView1.DataBind();
        }

    }
}