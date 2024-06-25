using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;

Console.WriteLine("Hello, World!");

SqlConnectionStringBuilder stringbuilder = new SqlConnectionStringBuilder();
stringbuilder.DataSource = "DESKTOP-J7SLJLC";
stringbuilder.InitialCatalog = "AceInternship";
stringbuilder.UserID = "sa";
stringbuilder.Password = "sa@123";

SqlConnection connection = new SqlConnection(stringbuilder.ConnectionString);
connection.Open();
Console.WriteLine("Connection Oepn");

string query = "select * from tbl_blog";
SqlCommand cmd = new SqlCommand(query, connection); 
SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
DataTable dt = new DataTable();
sqlDataAdapter.Fill(dt);
connection.Close();
Console.WriteLine("Connection Close");

foreach (DataRow dr in dt.Rows)
{
    Console.WriteLine("Blog Id => " + dr["BlogId"]);
    Console.WriteLine("Blog Title => " + dr["BlogTitle"]);
    Console.WriteLine("Blog Author => " + dr["BlogAuthor"]);
    Console.WriteLine("Blog Content => " + dr["BlogContent"]);
    Console.WriteLine("The End ");
}
Console.ReadKey(); 