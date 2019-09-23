using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.Entity;
using System.Dynamic;
using FieldOrder.DataAccessLayer.Context;
using FieldOrder.DataAccessLayer.Interfaces;

namespace FieldOrder.DataAccessLayer.Repositories
{
    public class GenericSqlDataRepository : IGenericSqlDataRepository
    {
        internal FieldOrderEntities Context;

        public GenericSqlDataRepository(FieldOrderEntities context)
            
        {
            this.Context = context;
        }

        public IEnumerable<T> RunRawSql<T>(string sql)
        {
            return Context.Database.SqlQuery<T>(sql);
        }

        public IEnumerable<dynamic> RunRawSqlDynamic(string sql)
        {
            using (var cmd = Context.Database.Connection.CreateCommand())
            {
                cmd.CommandText = sql;
                using (var dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        var dataRow = GetDataRow(dataReader);
                        yield return dataRow;
                    }
                }
            }
        }

        public int ExecuteSqlCommand(string query, params object[] parameters)
        {
            return Context.Database.ExecuteSqlCommand(query, parameters);
        }

        private static dynamic GetDataRow(DbDataReader dataReader)
        {
            var dataRow = new ExpandoObject() as IDictionary<string, object>;
            for (var fieldCount = 0; fieldCount < dataReader.FieldCount; fieldCount++)
                dataRow.Add(dataReader.GetName(fieldCount), dataReader[fieldCount]);
            return dataRow;
        }
    }
}
