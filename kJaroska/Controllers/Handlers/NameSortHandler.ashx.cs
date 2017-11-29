using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.Script.Serialization;

namespace kJaroska.Controllers.Handlers
{
    public class EmployeeHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            List<string> employeeNames = new List<string>();

            string term = context.Request["term"] ?? "";
            string cs = ConfigurationManager.ConnectionStrings["EmployeeDb"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("GetEmployeeNames", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter()
                {
                    ParameterName = "@term",
                    Value = term
                });

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    employeeNames.Add(rdr["LastName"].ToString());
                }
            }

            JavaScriptSerializer js = new JavaScriptSerializer();
            context.Response.Write(js.Serialize(employeeNames));
           
        }

        public bool IsReusable => true;
    }
}