using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestão_de_Emprestimos.Util.Interface
{
    interface IConnectionOleDb
    {
        OleDbConnection getConnection();
        Boolean closeConnection(OleDbConnection oleDbConnection);
        Boolean closeConnection(OleDbConnection oleDbConnection, OleDbDataReader oleDbDataReader);
    }
}
