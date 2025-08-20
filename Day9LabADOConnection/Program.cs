//using System.Data.SqlClient;
using Microsoft.Data.SqlClient; // Microsoft.Data.SqlClient is a data provider for SQL Server that is optimized for .NET Core and .NET 5+ applications.
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Day9LabADOConnection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Day 9 Part 1
            // ADO.NET - ADO.NET is a set of classes that expose data access services for .NET Framework programmers.
            // ADO .NET Data Provider - ADO.NET provides a set of classes that expose data access services for .NET Framework programmers.
            //Console.WriteLine(" ---------------------- SQl Server ADO.Net ------------------");
            //////1) Create Object From SQL Connection To Open Connection with Database 
            //SqlConnection con = new SqlConnection();
            //// SqlConnection - Represents a connection to a SQL Server database.

            //////2) Connection string (Server ; Database ; Security)
            //string connection = "Data Source=Belal-2004;Initial Catalog=ADOTest;Integrated Security=True;Trust Server Certificate=True";
            //con.ConnectionString = connection; 
            ////Server=myServerName,myPortNumber;Database=myDataBase;User Id=myUsername;Password=myPassword;
            //// ConnectionString - Specifies the string used to open a database connection.

            ////3) Open Connection
            //con.Open();// Open - Opens a database connection with the property settings specified by the ConnectionString.

            //// 4) Create Command Object
            //SqlCommand cmd = new SqlCommand(); // here we are creating a new query as in SSMS
            //// SqlCommand - Represents a SQL statement or stored procedure to execute against a SQL Server database.
            
            //// 5) Specify Command Type
            //cmd.CommandType = System.Data.CommandType.Text; // here we are specifying the type of command we are executing
            //                                                // CommandType - Gets or sets a value that indicates how the CommandText property is interpreted.

            //////6) Command Statment
            //cmd.CommandText = "Select * from Students";// CommandText - Gets or sets the SQL statement to execute against the data source.

            ////7) Link Connection With Command 
            //cmd.Connection = con; // here we are specifying the connection to the database

            //// 8) Execute Command With Return SQLDataReader
            //SqlDataReader reader = cmd.ExecuteReader(); // ExecuteReader - Executes the CommandText against the Connection and returns a SqlDataReader.
            //// SqlDataReader - Provides a way of reading a forward-only stream of rows from a SQL Server database.

            //// 9) Loop to Read Data
            //if (reader.HasRows) // HasRows - Gets a value that indicates whether the SqlDataReader contains one or more rows.
            //{
            //    while (reader.Read()) // Read - Advances the SqlDataReader to the next record.
            //    // reader.Read() - Reads the next record from the data reader.
            //    {
            //        Console.WriteLine($"ID {reader[0]} , Name {reader[1]} , Mark {reader[2]} "); // 0 ,1 ,2 are the index of the columns in the table
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("No records found.");
            //}

            //// 10) Close Connection
            //con.Close();// Close - Closes the connection to the database.

            Console.WriteLine(" ----------------------------------------------------------");
            Console.WriteLine(" ---------------------- Advanced SQl Server ADO.Net With CRUD ------------------");
            // Block Using
            ////1) Create Object From SQL Connection To Open Connection with Database 
            using(SqlConnection con = new SqlConnection("Data Source=Belal-2004;Initial Catalog=ADOTest;Integrated Security=True;Trust Server Certificate=True"))
            {
                con.Open();

                // Scalar Counter - Executes the query and returns the first column of the first row in the result set returned by the query.
                SqlCommand cmdCounter = new SqlCommand("Select count(*) from Students", con);
                int rowCount=(int)cmdCounter.ExecuteScalar(); // ExecuteScalar - Executes the query and returns the first column of the first row in the result set returned by the query.
                Console.WriteLine($"Row Numbers of Student Table is {rowCount}"); 
                Console.WriteLine("------------------------------------------------");
                // DataReader - Executes the query and returns a SqlDataReader object that can be used to read the data returned by the query.
                SqlCommand cmd = new SqlCommand("Select * from Students" , con); // here the constrctor of SqlCommand takes the command text and the connection object

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows) // HasRows - Gets a value that indicates whether the SqlDataReader contains one or more rows.
                {
                    while (reader.Read()) // Read - Advances the SqlDataReader to the next record.
                                          // reader.Read() - Reads the next record from the data reader.
                    {
                        Console.WriteLine($"ID {reader[0]} , Name {reader[1]} , Mark {reader[2]} "); // 0 ,1 ,2 are the index of the columns in the table
                    }
                }
                else
                {
                    Console.WriteLine("No records found.");
                }
            }
            Console.WriteLine("------------------------------------------------");
            // CRUD Operations
            //Insert Operation
            Console.WriteLine("------------------C -> Create------------------------------");
            using (SqlConnection con = new SqlConnection("Data Source=Belal-2004;Initial Catalog=ADOTest;Integrated Security=True;Trust Server Certificate=True"))
            {
                Console.WriteLine(" ---------------------- Insert Operation ------------------");
                con.Open();
                Console.WriteLine("Enter Student Name : ");
                string name = Console.ReadLine(); // Read the name from the console
                Console.WriteLine("Enter Student Mark : ");
                int mark;
                int.TryParse(Console.ReadLine(), out mark); // Read the mark from the console and parse it to int
                string insertQuery = $"Insert into Students (Name, Mark) values ('{name}', '{mark}')"; // Insert Query
                // Scalar Counter - Executes the query and returns the first column of the first row in the result set returned by the query.
                SqlCommand cmdinsert = new SqlCommand(insertQuery , con);
                int rowInsert = cmdinsert.ExecuteNonQuery(); // ExecuteNonQuery - Executes a Transact-SQL statement against the connection and returns the number of rows affected.
                if (rowInsert > 0)
                {
                    Console.WriteLine($"{rowInsert} Rows Inserted Successfully.");
                }
                else
                {
                    Console.WriteLine("Record Insertion Failed.");
                }
                Console.WriteLine("------------------------------------------------");
                // DataReader - Executes the query and returns a SqlDataReader object that can be used to read the data returned by the query.
                SqlCommand cmd = new SqlCommand("Select * from Students", con); // here the constrctor of SqlCommand takes the command text and the connection object

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows) // HasRows - Gets a value that indicates whether the SqlDataReader contains one or more rows.
                {
                    while (reader.Read()) // Read - Advances the SqlDataReader to the next record.
                                          // reader.Read() - Reads the next record from the data reader.
                    {
                        Console.WriteLine($"ID {reader[0]} , Name {reader[1]} , Mark {reader[2]} "); // 0 ,1 ,2 are the index of the columns in the table
                    }
                }
                else
                {
                    Console.WriteLine("No records found.");
                }
            }
            Console.WriteLine("------------------------------------------------");
            //Update Operation
            Console.WriteLine("------------------U -> Update------------------------------");
            using (SqlConnection con = new SqlConnection("Data Source=Belal-2004;Initial Catalog=ADOTest;Integrated Security=True;Trust Server Certificate=True"))
            {
                Console.WriteLine(" ---------------------- Update Operation ------------------");
                con.Open();
                Console.WriteLine("Enter Student ID to Update : ");
                int id;
                int.TryParse(Console.ReadLine(), out id);
                Console.WriteLine("Enter Student Name to Update : ");
                string name = Console.ReadLine(); // Read the name from the console
                Console.WriteLine("Enter Student Mark to Update : ");
                int mark;
                int.TryParse(Console.ReadLine(), out mark);
                string updateQuery = $"Update Students set Name = '{name}', Mark = '{mark}' where ID = {id}"; // Update Query
                // Scalar Counter - Executes the query and returns the first column of the first row in the result set returned by the query.
                SqlCommand cmdupdate = new SqlCommand(updateQuery, con);
                int rowUpdate = cmdupdate.ExecuteNonQuery(); // ExecuteNonQuery - Executes a Transact-SQL statement against the connection and returns the number of rows affected.
                if (rowUpdate > 0)
                {
                    Console.WriteLine($"{rowUpdate} Rows Updated Successfully.");
                }
                else
                {
                    Console.WriteLine("Record Update Failed.");
                }
                Console.WriteLine("------------------------------------------------");
                // DataReader - Executes the query and returns a SqlDataReader object that can be used to read the data returned by the query.
                SqlCommand cmd = new SqlCommand("Select * from Students", con); // here the constrctor of SqlCommand takes the command text and the connection object

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows) // HasRows - Gets a value that indicates whether the SqlDataReader contains one or more rows.
                {
                    while (reader.Read()) // Read - Advances the SqlDataReader to the next record.
                                          // reader.Read() - Reads the next record from the data reader.
                    {
                        Console.WriteLine($"ID {reader[0]} , Name {reader[1]} , Mark {reader[2]} "); // 0 ,1 ,2 are the index of the columns in the table
                    }
                }
                else
                {
                    Console.WriteLine("No records found.");
                }
            }
            Console.WriteLine("------------------------------------------------");
            // Delete Operation
            Console.WriteLine("------------------D -> Delete------------------------------");
            using (SqlConnection con = new SqlConnection("Data Source=Belal-2004;Initial Catalog=ADOTest;Integrated Security=True;Trust Server Certificate=True"))
            {
                Console.WriteLine(" ---------------------- Delete Operation ------------------");
                con.Open();
                Console.WriteLine("Enter Student ID to Delete : ");
                int id;
                int.TryParse(Console.ReadLine(), out id);
                string deleteQuery = $"Delete from Students where ID = {id}"; // Delete Query
                // Scalar Counter - Executes the query and returns the first column of the first row in the result set returned by the query.
                SqlCommand cmdDelete = new SqlCommand(deleteQuery, con);
                int rowDelete = cmdDelete.ExecuteNonQuery(); // ExecuteNonQuery - Executes a Transact-SQL statement against the connection and returns the number of rows affected.
                if (rowDelete > 0)
                {
                    Console.WriteLine($"{rowDelete} Rows Deleted Successfully.");
                }
                else
                {
                    Console.WriteLine("Record Deletion Failed.");
                }
                Console.WriteLine("------------------------------------------------");
                // DataReader - Executes the query and returns a SqlDataReader object that can be used to read the data returned by the query.
                SqlCommand cmd = new SqlCommand("Select * from Students", con); // here the constrctor of SqlCommand takes the command text and the connection object

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows) // HasRows - Gets a value that indicates whether the SqlDataReader contains one or more rows.
                {
                    while (reader.Read()) // Read - Advances the SqlDataReader to the next record.
                                          // reader.Read() - Reads the next record from the data reader.
                    {
                        Console.WriteLine($"ID {reader[0]} , Name {reader[1]} , Mark {reader[2]} "); // 0 ,1 ,2 are the index of the columns in the table
                    }
                }
                else
                {
                    Console.WriteLine("No records found.");
                }
            }

            #endregion
        }
    }
}
