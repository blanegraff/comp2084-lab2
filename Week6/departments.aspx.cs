using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

// Add 2 refrences to access the database
using System.Web.ModelBinding;


namespace Week6
{
    public partial class departments : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            // get the departments and display in the gridview
            getDepartments();
        }

        protected void getDepartments()
        {
            // connect to db
            var conn = new ContosoEntities();

            // run the query using LINQ
            var Departments = from d in conn.Departments
                              select d;

            // display query result in gridview
            gridDepartments.DataSource = Departments.ToList();
            gridDepartments.DataBind();
        }
    }
}