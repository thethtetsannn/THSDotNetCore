using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THSDotNetCore.ConsoleApp
{
    internal class AdoDotNetExample
    {
        private readonly SqlConnectionStringBuilder sql = new SqlConnectionStringBuilder()
        {
            DataSource = "DESKTOP-J7SLJLC",
            InitialCatalog = "AceInternship",
            UserID = "sa",
            Password = "sa@123",
        };
        public void Read()
        {
            SqlConnection connection = new SqlConnection(sql.ConnectionString);
            connection.Open();
            Console.WriteLine("Connection Open");

            string query = "select * from tbl_blog";
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);

            connection.Close();
            Console.WriteLine("Connection Close");

            foreach (DataRow dr in dt.Rows)
            {
                Console.WriteLine("Blog Id => " + dr["BlogId"]);
                Console.WriteLine("Blog Title => " + dr["BlogTitle"]);
                Console.WriteLine("Blog Author => " + dr["BlogAuthor"]);
                Console.WriteLine("Blog Content => " + dr["BlogContent"]);
                Console.WriteLine("----------");
            }
        }
        public void Create(string title, string author, string content)
        {
            SqlConnection connection = new SqlConnection(sql.ConnectionString);
            connection.Open();
            string query = @"INSERT INTO [dbo].[Tbl_Blog]
                     ([BlogTitle], [BlogAuthor], [BlogContent])
                     VALUES
                     (@BlogTitle, @BlogAuthor, @BlogContent)";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@BlogTitle", title);
            cmd.Parameters.AddWithValue("@BlogAuthor", author);
            cmd.Parameters.AddWithValue("@BlogContent", content);
            int result = cmd.ExecuteNonQuery();
            connection.Close();
            string message = result > 0 ? "Saving Successful." : "Saving Failed.";
            Console.WriteLine(message);
        }

    }
}
