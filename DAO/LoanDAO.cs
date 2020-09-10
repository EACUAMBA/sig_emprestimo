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
using System.Windows.Forms;

namespace Gestão_de_Emprestimos.DAO
{
    public class LoanDAO : ILoanDAO
    {
        private OleDbConnection oleDbConnection;
        private IInstallmentDAO iInstallmentDAO;
        public LoanDAO()
        {
            this.oleDbConnection = Connection.getConnection();
            this.iInstallmentDAO = new InstallmentDAO();
        }

        public bool delete(Loan loan)
        {
            try
            {
                Connection.closeConnection(this.oleDbConnection);
                this.oleDbConnection.Open();

                String cmdText = "UPDATE loan SET [_deleted] =  @deleted, [_message] =@message WHERE [_code] = @code AND [_clientCode] = @clientCode";

                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, this.oleDbConnection);

                oleDbCommand.Prepare();
                oleDbCommand.Parameters.AddWithValue("@deleted", loan.Deleted);
                oleDbCommand.Parameters.AddWithValue("@message", loan.Message);
                oleDbCommand.Parameters.AddWithValue("@code", loan.Code);
                oleDbCommand.Parameters.AddWithValue("@clientCode", loan.ClientCode);

                int result = oleDbCommand.ExecuteNonQuery();

                return (result > 0);
            }
            catch (OleDbException ex)
            {
                Util.Message.showErrorMessage("Delete Loan", ex);
            }
            finally
            {
                Util.Connection.closeConnection(this.oleDbConnection);
            }

            return false;
        }

        public Loan findByCode(string code, String clientCode)
        {
            OleDbDataReader oleDbDataReader = null;
            ArrayList loans = new ArrayList();

            try
            {
                Connection.closeConnection(this.oleDbConnection);
                this.oleDbConnection.Open();
                String cmdText = "SELECT * FROM loan WHERE [_clientCode] = @clientCode AND [_code] = @code";

                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, this.oleDbConnection);

                oleDbCommand.Prepare();
                oleDbCommand.Parameters.AddWithValue("@clientCode", clientCode);
                oleDbCommand.Parameters.AddWithValue("@code", code);

                oleDbDataReader = oleDbCommand.ExecuteReader();

                oleDbDataReader.Read();
                Loan loan = new Loan();
                loan.Code = oleDbDataReader.GetValue(0) != DBNull.Value ? (String)oleDbDataReader.GetValue(0) : string.Empty;
                loan.ClientCode = oleDbDataReader.GetValue(1) != DBNull.Value ? (String)oleDbDataReader.GetValue(1) : string.Empty;
                loan.Capital = oleDbDataReader.GetDouble(2);
                loan.StartDate = oleDbDataReader.GetValue(3) != DBNull.Value ? oleDbDataReader.GetDateTime(3) : DateTimePicker.MinimumDateTime;
                loan.EndDate = oleDbDataReader.GetValue(4) != DBNull.Value ? oleDbDataReader.GetDateTime(4) : DateTimePicker.MinimumDateTime;
                loan.Percent = oleDbDataReader.GetByte(5);
                loan.ResidualValue = oleDbDataReader.GetDouble(6);
                loan.Paid = oleDbDataReader.GetBoolean(7);
                loan.Deleted = oleDbDataReader.GetBoolean(8);
                loan.Message = oleDbDataReader.GetValue(9) != DBNull.Value ? (String)oleDbDataReader.GetValue(9) : string.Empty;



                return loan;
            }
            catch (OleDbException ex)
            {
                Util.Message.showErrorMessage("findByCode Loan", ex);
            }
            finally
            {
                Connection.closeConnection(this.oleDbConnection, oleDbDataReader);
            }

            return null;
        }

        public ArrayList list()
        {
            OleDbDataReader oleDbDataReader = null;
            ArrayList loans = new ArrayList();

            try
            {
                Connection.closeConnection(this.oleDbConnection);
                this.oleDbConnection.Open();
                String cmdText = "SELECT * FROM loan";

                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, this.oleDbConnection);

                oleDbDataReader = oleDbCommand.ExecuteReader();

                while (oleDbDataReader.Read())
                {
                    Loan loan = new Loan();
                    loan.Code = oleDbDataReader.GetValue(0) != DBNull.Value ? (String)oleDbDataReader.GetValue(0) : string.Empty;
                    loan.ClientCode = oleDbDataReader.GetValue(1) != DBNull.Value ? (String)oleDbDataReader.GetValue(1) : string.Empty;
                    loan.Capital = oleDbDataReader.GetDouble(2);
                    loan.StartDate = oleDbDataReader.GetValue(3) != DBNull.Value ? oleDbDataReader.GetDateTime(3) : DateTimePicker.MinimumDateTime;
                    loan.EndDate = oleDbDataReader.GetValue(4) != DBNull.Value ? oleDbDataReader.GetDateTime(4) : DateTimePicker.MinimumDateTime;
                    loan.Percent = oleDbDataReader.GetByte(5);
                    loan.ResidualValue = oleDbDataReader.GetDouble(6);
                    loan.Paid = oleDbDataReader.GetBoolean(7);
                    loan.Deleted = oleDbDataReader.GetBoolean(8);
                    loan.Message = oleDbDataReader.GetValue(9) != DBNull.Value ? (String)oleDbDataReader.GetValue(9) : string.Empty;



                    loans.Add(loan);
                }

                return loans;
            }
            catch (OleDbException ex)
            {
                Util.Message.showErrorMessage("list Loans", ex);
            }
            finally
            {
                Connection.closeConnection(this.oleDbConnection, oleDbDataReader);
            }

            return new ArrayList();
        }
        public ArrayList findByClientCode(String clientCode)
        {
            OleDbDataReader oleDbDataReader = null;
            ArrayList loans = new ArrayList();

            try
            {
                Connection.closeConnection(this.oleDbConnection);
                this.oleDbConnection.Open();
                String cmdText = "SELECT * FROM loan WHERE [_clientCode] = @clientCode";

                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, this.oleDbConnection);

                oleDbCommand.Prepare();
                oleDbCommand.Parameters.AddWithValue("@clientCode", clientCode);

                oleDbDataReader = oleDbCommand.ExecuteReader();

                while (oleDbDataReader.Read())
                {
                    Loan loan = new Loan();
                    loan.Code = oleDbDataReader.GetValue(0) != DBNull.Value ? (String)oleDbDataReader.GetValue(0) : string.Empty;
                    loan.ClientCode = oleDbDataReader.GetValue(1) != DBNull.Value ? (String)oleDbDataReader.GetValue(1) : string.Empty;
                    loan.Capital = oleDbDataReader.GetDouble(2);
                    loan.StartDate = oleDbDataReader.GetValue(3) != DBNull.Value ? oleDbDataReader.GetDateTime(3) : DateTimePicker.MinimumDateTime;
                    loan.EndDate = oleDbDataReader.GetValue(4) != DBNull.Value ? oleDbDataReader.GetDateTime(4) : DateTimePicker.MinimumDateTime;
                    loan.Percent = oleDbDataReader.GetByte(5);
                    loan.ResidualValue = oleDbDataReader.GetDouble(6);
                    loan.Paid = oleDbDataReader.GetBoolean(7);
                    loan.Deleted = oleDbDataReader.GetBoolean(8);
                    loan.Message = oleDbDataReader.GetValue(9) != DBNull.Value ? (String)oleDbDataReader.GetValue(9) : string.Empty;

                    ArrayList installments = new InstallmentDAO().findByLoanCode(loan.Code);

                    loan.Installment = installments;
                    loans.Add(loan);
                }

                return loans;
            }
            catch (OleDbException ex)
            {
                Util.Message.showErrorMessage("findByClientCode Loan", ex);
            }
            finally
            {
                Connection.closeConnection(this.oleDbConnection);
            }

            return new ArrayList();
        }
        public bool save(Loan loan)
        {

            try
            {

                Connection.closeConnection(this.oleDbConnection);
                this.oleDbConnection.Open();

                String cmdText = "INSERT INTO loan([_code], [_clientCode], [_capital], [_startDate], [_endDate], [_percent], [_residualValue]) VALUES (@code, @clientCode, @capital, @startDate, @endDate, @percent, @residualValue)";

                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, this.oleDbConnection);

                oleDbCommand.Prepare();
                oleDbCommand.Parameters.AddWithValue("@code", loan.Code);
                oleDbCommand.Parameters.AddWithValue("@clientCode", loan.ClientCode);
                oleDbCommand.Parameters.AddWithValue("@capital", loan.Capital);
                oleDbCommand.Parameters.AddWithValue("@startDate", loan.StartDate);
                oleDbCommand.Parameters.AddWithValue("@endDate", loan.EndDate);
                oleDbCommand.Parameters.AddWithValue("@percent", loan.Percent);
                oleDbCommand.Parameters.AddWithValue("@residualValue", loan.ResidualValue);

                int result = oleDbCommand.ExecuteNonQuery();

                if (result > 0)
                {
                    if (loan.Installment != null)
                    {
                        foreach (Installment installment in loan.Installment)
                        {
                            bool saved = this.iInstallmentDAO.save(installment);
                            if (saved == false)
                            {
                                foreach (Installment installmentRollBackAction in loan.Installment)
                                {
                                    bool deleted = this.iInstallmentDAO.delete(installment.Code, installment.LoanCode);
                                    if (!deleted) Util.Message.showErrorMessage("Delete installment, not created!", null);
                                }
                                this.delete(loan);
                                return false;
                            }

                        }

                    }
                }

                return (result > 0);
            }
            catch (OleDbException ex)
            {
                Util.Message.showErrorMessage("save Loan", ex);
            }
            finally
            {
                Util.Connection.closeConnection(this.oleDbConnection);
            }

            return false;
        }

        public bool update(Loan loan)
        {
            try
            {
                Connection.closeConnection(this.oleDbConnection);
                this.oleDbConnection.Open();

                String cmdText = "UPDATE loan SET [_capital] =  @capital, [_startDate] =@startDate, [_endDate] = @endDate, [_percent] = @percent, [_residualValue] = @residualValue WHERE [_code] = @code AND [_clientCode] = @clientCode";

                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, this.oleDbConnection);

                oleDbCommand.Prepare();
                oleDbCommand.Parameters.AddWithValue("@capital", loan.Capital);
                oleDbCommand.Parameters.AddWithValue("@startDate", loan.StartDate);
                oleDbCommand.Parameters.AddWithValue("@endDate", loan.EndDate);
                oleDbCommand.Parameters.AddWithValue("@percent", loan.Percent);
                oleDbCommand.Parameters.AddWithValue("@residualValue", loan.ResidualValue);
                oleDbCommand.Parameters.AddWithValue("@code", loan.Code);
                oleDbCommand.Parameters.AddWithValue("@clientCode", loan.ClientCode);

                int result = oleDbCommand.ExecuteNonQuery();

                return (result > 0);
            }
            catch (OleDbException ex)
            {
                Util.Message.showErrorMessage("Update Loan", ex);
            }
            finally
            {
                Util.Connection.closeConnection(this.oleDbConnection);
            }

            return false;
        }

        public bool setAsPaid(String code, String clientCode)
        {
            try
            {
                Connection.closeConnection(this.oleDbConnection);
                this.oleDbConnection.Open();

                String cmdText = "UPDATE loan SET [_paid] = @paid WHERE [_code] = @code AND [_clientCode] = @clientCode";

                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, this.oleDbConnection);

                oleDbCommand.Prepare();
                oleDbCommand.Parameters.AddWithValue("@paid", true);
                oleDbCommand.Parameters.AddWithValue("@code", code);
                oleDbCommand.Parameters.AddWithValue("@clientCode", clientCode);

                int result = oleDbCommand.ExecuteNonQuery();

                return (result > 0);
            }
            catch (OleDbException ex)
            {
                Util.Message.showErrorMessage("Set as paid Loan", ex);
            }
            finally
            {
                Util.Connection.closeConnection(this.oleDbConnection);
            }

            return false;
        }


    }
}
