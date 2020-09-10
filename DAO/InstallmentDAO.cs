using Gestão_de_Emprestimos.DAO.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gestão_de_Emprestimos.Model;
using System.Collections;
using System.Data.OleDb;
using Gestão_de_Emprestimos.Util;

namespace Gestão_de_Emprestimos.DAO
{
    public class InstallmentDAO : IInstallmentDAO
    {

        private OleDbConnection oleDbConnection;

        public InstallmentDAO(OleDbConnection oleDbConnection)
        {
            this.oleDbConnection = Connection.getConnection();
        }

        public bool delete(int code, string loanCode)
        {
            throw new NotImplementedException();
        }

        public Installment findByCode(string code)
        {
            throw new NotImplementedException();
        }

        public ArrayList findByCodeAndLoanCode(int code, string loanCode)
        {
            throw new NotImplementedException();
        }

        public ArrayList list()
        {
            throw new NotImplementedException();
        }

        public bool save(Installment installment)
        {
            try
            {
                Connection.closeConnection(this.oleDbConnection);
                this.oleDbConnection.Open();

                String cmdText = "INSERT INTO installment ([_code], [_loanCode], [_value], [_dateToPay]) VALUES (@code, @loanCode, @value, @dateToPay)";

                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, this.oleDbConnection);

                oleDbCommand.Prepare();
                oleDbCommand.Parameters.AddWithValue("@code", installment.Code);
                oleDbCommand.Parameters.AddWithValue("@loanCode", installment.LoanCode);
                oleDbCommand.Parameters.AddWithValue("@value", installment.Value);
                oleDbCommand.Parameters.AddWithValue("@dateToPay", installment.DateToPay);

                int result = oleDbCommand.ExecuteNonQuery();

                return (result > 0);

            }catch(OleDbException ex)
            {
                Util.Message.showErrorMessage("saving Installment \n" + installment, ex);
            }
            finally
            {
                Connection.closeConnection(this.oleDbConnection);
            }


            return false;
        }

        public bool update(Installment installment)
        {
            throw new NotImplementedException();
        }

        public ArrayList findByLoanCode(String loanCode)
        {
            OleDbDataReader oleDbDataReader = null;
            ArrayList installments = new ArrayList();
            try
            {
                Connection.closeConnection(this.oleDbConnection);
                this.oleDbConnection.Open();

                String cmdText = "SELECT * FROM installment WHERE [_loanCode] = @loanCode";

                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, this.oleDbConnection);

                oleDbCommand.Prepare();
                oleDbCommand.Parameters.AddWithValue("@loanCode", loanCode);

                oleDbDataReader = oleDbCommand.ExecuteReader();

                while (oleDbDataReader.Read())
                {
                    Installment installment= new Installment();
                    installment.Code = oleDbDataReader.GetInt32(0);
                    installment.LoanCode = oleDbDataReader.GetString(1);
                    installment.Value = oleDbDataReader.GetDouble(2);
                    installment.DateToPay = oleDbDataReader.GetDateTime(3);
                    installment.Paid = oleDbDataReader.GetBoolean(4);

                    installments.Add(installment);
                }

                return installments;
            }catch(OleDbException ex)
            {
                Util.Message.showErrorMessage("findByInstallmentCode", ex);
            }
            finally
            {
                Connection.closeConnection(this.oleDbConnection);
            }

            return null;
        }
    }
}
