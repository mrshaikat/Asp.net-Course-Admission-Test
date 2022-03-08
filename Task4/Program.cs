// See https://aka.ms/new-console-template for more information
using System.Data.SqlClient;

class Program
{
    public static void Main(String[] args)
    {
        SqlConnection connection = new SqlConnection("server=DESKTOP-BKLQA5S\\ESQL; Initial Catalog = TestDatabase; Integrated Security = SSPI");
        try
        {
            

            string sql = @"IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Student' AND xtype='U')
                            CREATE TABLE [dbo].[Student](
	                        [id] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	                        [name] [nchar](100) NULL,
	                        [age] [date](10) NULL,
                            )";
            connection.Open();
            SqlCommand cmd = new SqlCommand(sql, connection);
            cmd.ExecuteNonQuery();
            connection.Close();


            Console.WriteLine("Number of Input: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <=n; i++)
            {
                Console.WriteLine("Name: ");
                string name = Console.ReadLine();

                Console.WriteLine("Age: ");
                DateTime date = Convert.ToDateTime(Console.ReadLine());


                connection.Open();
                string query = "INSERT INTO Student(name, age) VALUES (@name, @age)";
                SqlCommand sqlCmd = new SqlCommand(query, connection);
                sqlCmd.Connection = connection;
                sqlCmd.Parameters.AddWithValue("@name", name);
                sqlCmd.Parameters.AddWithValue("@age", date);
                sqlCmd.ExecuteNonQuery();
            }




        }
        catch
        {

            connection.Close();
        }

    }
}
