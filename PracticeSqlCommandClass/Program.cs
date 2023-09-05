using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
namespace PracticeSqlCommandClass
{
    class Program
    {
        static void Main(string[] args)
        {
            MethodSqlCommandParameterTextCommand methodSqlCommandParameterTextCommand = new MethodSqlCommandParameterTextCommand();
            //Without Parameter
            //methodSqlCommandParameterTextCommand.TestSqlCommand();

            //With Parameter
            //methodSqlCommandParameterTextCommand.TestSqlCommandWithParameter();

            //SqlCommand With Two Parameter
            //methodSqlCommandParameterTextCommand.TestSqlCommandTwoParameters();

            //SqlCommand With Three Parameter
            //methodSqlCommandParameterTextCommand.TestSqlCommandThreeParameter();

            //SqlCommand With Four Parameter Pending


        }
    }
}
