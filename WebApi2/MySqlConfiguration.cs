using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi2
{
    public class MySqlConfiguration : DbConfiguration
    {
        public MySqlConfiguration()
        {

            SetHistoryContext("MySql.Data.MySqlClient", (conn, schema) => new MySqlHistoryContext(conn, schema));

        }
    }
}