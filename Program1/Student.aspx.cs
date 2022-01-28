using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            IEnumerable<Student> queryResult = Student.GetAllStudents().Where(student => student.Gender == "Male");
            GridView1.DataSource = queryResult;
            GridView1.DataBind();

            //linq simple query simple
            
            // from student in Student.GetAllStudents()
            // where Student.Gender == "Male"
            // select Students
        }  
    }
}