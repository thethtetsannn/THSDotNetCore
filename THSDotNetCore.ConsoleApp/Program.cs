using System.Data;
using System.Data.SqlClient;
using THSDotNetCore.ConsoleApp;

//Console.WriteLine("Hello Thet Htet San");

//SqlConnectionStringBuilder stringbuilder = new SqlConnectionStringBuilder();
//stringbuilder.DataSource = "DESKTOP-J7SLJLC";
//stringbuilder.InitialCatalog = "AceInternship";
//stringbuilder.UserID = "sa";
//stringbuilder.Password = "sa@123";

//SqlConnection connection = new SqlConnection();
//connection.Open();
//Console.WriteLine("Connection Open");

//string query = "select * from tbl_blog";
//SqlCommand cmd = new SqlCommand(query,connection);
//SqlDataAdapter ad = new SqlDataAdapter(cmd);   
//DataTable dt = new DataTable();
//ad.Fill(dt);

//connection.Close();
//Console.WriteLine("Connection Close");

//foreach(DataRow dr in dt.Rows)
//{
//.WriteLine("Blog Id => " + dr["BlogId"]);
//Console.WriteLine("Blog Title => " + dr["BlogTitle"]);
//Console.WriteLine("Blog Author => " + dr["BlogAuthor"]);
//Console.WriteLine("Blog Content => " + dr["BlogContent"]);
//Console.WriteLine("----------");
//}
//Console.ReadKey();
AdoDotNetExample adt = new AdoDotNetExample();
adt.Read();
adt.Create("title", "author", "content");

Console.ReadLine();