using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldOrder.DataAccessLayer.Interfaces
{
    public interface IGenericSqlDataRepository
    {
        IEnumerable<T> RunRawSql<T>(string sql);
        int ExecuteSqlCommand(string query, params object[] parameters);
        IEnumerable<dynamic> RunRawSqlDynamic(string sql);
    }
}
