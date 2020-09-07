using Gestão_de_Emprestimos.Util.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
using Gestão_de_Emprestimos.DAO;

namespace Gestão_de_Emprestimos.Util
{
    public class Connection
    {
        public static bool closeConnection(OleDbConnection oleDbConnection)
        {
            if (oleDbConnection != null)
            {
                try
                {
                    oleDbConnection.Close();
                    return true;
                }
                catch (OleDbException ex)
                {
                    Message.showErrorMessage("close OleDbConnection", ex);
                }
            }
            return false;
        }

        public static bool closeConnection(OleDbConnection oleDbConnection, OleDbDataReader oleDbDataReader)
        {
            closeConnection(oleDbConnection);
            if(oleDbDataReader != null)
            {
                try
                {
                    oleDbDataReader.Close();
                    return true;
                }catch(OleDbException ex)
                {
                    Message.showErrorMessage("close OleDbDataReader", ex);
                }
            }
            return false;
        }

        public static OleDbConnection getConnection()
        {
            try
            {
                DataSourceInfoFileXMLDAO dataSourceInfoFileXMLDAO = new DataSourceInfoFileXMLDAO();
                OleDbConnection oleDbConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source =" + dataSourceInfoFileXMLDAO.readXMLFile().Path);
                return oleDbConnection;
            }
            catch(OleDbException ex)
            {
                Message.showErrorMessage("creating connection", ex);
            }
            return null;
        }
    }
}
