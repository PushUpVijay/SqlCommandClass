using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace PracticeSqlCommandClass
{
    class MethodSqlCommandParameterTextCommand
    {
        public SqlConnection DatabaseConnection()
        {
            string connectionString = "Data Source=(local);Initial Catalog=PracticeDatabase;Integrated Security=SSPI";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
                return sqlConnection;
            
        }
        //SqlCommand Without Parameter
        public void TestSqlCommand()
        {
            SqlCommand sqlCommand = new SqlCommand();
             
            sqlCommand.Connection = DatabaseConnection();


            sqlCommand.CommandText = "Insert into TestTblTwo (Id) Values (201)";
            sqlCommand.Connection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlCommand.Connection.Close();            
        }
        public void TestSqlCommandWithParameter()
        {
            string cmdText = "Update TestTblTwo set Id=768 where Id=505";
            SqlCommand sqlCommand = new SqlCommand(cmdText);
            sqlCommand.Connection = DatabaseConnection();
            
            
            sqlCommand.Connection.Open();
            sqlCommand.ExecuteNonQuery();
           
            sqlCommand.Connection.Close();

        }

        //2 Parameters of SqlCommand
        public void TestSqlCommandTwoParameters()
        {
            string cmdText = "delete TestTblTwo where Id=768";
            SqlConnection sqlConnection = DatabaseConnection();
            SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            sqlCommand.Connection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlCommand.Connection.Close();

        }
        //3 parameter of SqlCommand
        public void TestSqlCommandThreeParameter()
        {
           
            string txtCmd = "Insert into TestTblTwo (Id) Values (850)";
            SqlConnection sqlConnection = DatabaseConnection();
            sqlConnection.Open();
            SqlTransaction sqlTransaction;
            sqlTransaction = sqlConnection.BeginTransaction();
            SqlCommand sqlCommand = new SqlCommand(txtCmd, sqlConnection, sqlTransaction);
            /**
            sqlCommand.CommandText = txtCmd;
            sqlCommand.Connection = sqlConnection;
            sqlCommand.Transaction = sqlTransaction;
            **/
                
                
                sqlCommand.ExecuteNonQuery();
                sqlTransaction.Commit();
            

            
            /**
            catch (Exception ex)
            {
                Console.WriteLine("  Message: {0}", ex.Message);
                try
                {
                    sqlTransaction.Rollback();
                }
                catch (Exception ex2)
                {
                    // This catch block will handle any errors that may have occurred
                    // on the server that would cause the rollback to fail, such as
                    // a closed connection.
                    Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType());
                    Console.WriteLine("  Message: {0}", ex2.Message);
                }
            }
            **/
            sqlCommand.Connection.Close();

        }
    }
}
