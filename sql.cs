using Microsoft.Data.SqlClient;
//Data Source=5CG7324TYL;Initial Catalog = TryDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False
namespace WorkingWithSQL
{
    internal class sql
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!"); 
            SqlConnection connection = new SqlConnection("Data Source=5CG7324TYL;Initial Catalog = TryDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");

            connection.Open();

            SqlCommand command = connection.CreateCommand();

            command.CommandText = "SELECT * FROM TStudents";
            var reader = command.ExecuteReader();
            int i = 0;

            while (reader.Read())
            {
                for(int j=0; j<reader.FieldCount; j++)
                {
                    Console.Write(reader[j] + " ");
                }
                Console.WriteLine();
                i++;
            }

            /*
            int studentId = Convert.ToInt32(Console.ReadLine());
            command.CommandText = $"SELECT * FROM StudentTable WHERE StudentId = {studentId}";

            var reader = command.ExecuteReader();
            //reader.GetDateTime(2).ToShortDateString
            //reader.GetDateTime(2).Date
            while (reader.Read())
            {
                Console.WriteLine($"{reader.GetInt32(0)}    {reader.GetString(1)}   {reader.GetDateTime(2).ToShortDateString}");
            }*/

            /*
            SqlDataReader reader = command.ExecuteReader();
            command.CommandText = "SELECT * FROM TStaffs";

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {

                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Console.Write(reader[i] + " ");
                }
                Console.WriteLine();

            }

            while (reader.Read())
            {
                Console.WriteLine(reader.GetInt32(0));
                Console.WriteLine(reader.GetString(1));
                Console.WriteLine(reader.GetInt32(2));
                Console.WriteLine(reader.GetString(3));
                Console.WriteLine(reader.GetString(4));
                Console.WriteLine(reader.GetInt32(5));
                Console.WriteLine(reader.GetInt32(6));
                Console.WriteLine();
            }
            

            while (reader.Read())
            {
                Console.WriteLine(reader.GetString(1));
            }
            reader.Close();
             */

            //

            /*int studentId = Convert.ToInt32(Console.ReadLine());
            string studentName = Console.ReadLine();
            string StudentDept = Console.ReadLine();
            string studentMail = Console.ReadLine();
            command.CommandText = $"INSERT INTO StudentInfo VALUES ({studentId},'{studentName}','{StudentDept}', '{studentMail}')";
            command.ExecuteReader().Close();
            command.CommandText = "SELECT s.studentName, s.studentDept, d.deptHOD FROM dbo.StudentInfo s INNER JOIN dbo.DeptMaster d ON s.studentDept=d.deptName\r\n";
            var reader = command.ExecuteReader();
            while(reader.Read())
            {
                Console.WriteLine($"{ reader.GetString(0)} {reader.GetString(1)}    {reader.GetString(2)} ");
            }
            reader.Close();*/
            connection.Close();
        }
    }
}