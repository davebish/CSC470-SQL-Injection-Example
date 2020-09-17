using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SQL_Injection_Example_Code
{
    public class DBAccess
    {
        // My personal database connection info - won't work on your machine
        private const string CONNECT_INFO = "Data Source=.\\SQLExpress; Initial Catalog=CSC470SQLInjectionExample;" +
                                            "Integrated Security=True; MultipleActiveResultSets=True";

        public string GetStudentInfo(string filter)
        {

            string studentInfo = "";
            SqlConnection conn = new SqlConnection(CONNECT_INFO);
            try
            {
                conn.Open();
                /*************************************************************
                 * Bad Practice - Only here for an example of what NOT TO DO
                 *************************************************************/
                string query = "SELECT CONVERT(varchar(5),Id) + ' ' + " +
                                       "LastName + ', ' + FirstName + ' ' + " +
                                       "CONVERT(varchar(4),GPA) " +
                                "FROM Student " + 
                                "WHERE LastName LIKE '" + filter + "%'";
                SqlCommand cmdGetStudentInfo = new SqlCommand(query, conn);
                cmdGetStudentInfo.CommandType = CommandType.Text;
                SqlDataReader reader = cmdGetStudentInfo.ExecuteReader();

                // Loop through all rows from the reader
                while (reader.Read())
                {
                    int numColumns = reader.FieldCount;
                    for (int colNum = 0; colNum < numColumns; colNum++)
                    {
                        studentInfo += reader[colNum].ToString() + " ";
                    }
                    studentInfo += Environment.NewLine;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return studentInfo;
        }
    }
}
