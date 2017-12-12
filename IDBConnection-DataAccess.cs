using System;
using System.Collections.Generic;
using System.Ling;
using System.Text;
using System.Threading.Tasks;
using Dapper; (Don't know if can use this as it will have to be downloaded)
using System.Data;

namespace FormUI
{
    public class DataAccess
    {
        public List<Person> GetPeople(string lastName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SampleDB")))
            {
                return connection.Query<Person>($"select * from People where LastName = '{ lastName }'").ToList();
                //Not recommended to use direct sql query like this as it is vulenerable. Use stored procedeures instead.
            }
        }
    }
}
