using Gestão_de_Emprestimos.DAO.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gestão_de_Emprestimos.Model;
using System.Collections;
using Gestão_de_Emprestimos.Util.Interface;
using Gestão_de_Emprestimos.Util;
using System.Data.OleDb;

namespace Gestão_de_Emprestimos.DAO
{
    public class ClientDAO_OleDb : IClientDAO
    {
        private OleDbConnection oleDbConnection;
        public ClientDAO_OleDb(OleDbConnection oleDbConnection)
        {
            this.oleDbConnection = Connection.getConnection();
        }

        public bool delete(string code)
        {
            try
            {
                this.oleDbConnection.Open();
                String cmdText = "UPDATE client SET [_deleted] = @deleted WHERE [_code] = @code";
                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, this.oleDbConnection);

                oleDbCommand.Prepare();
                oleDbCommand.Parameters.AddWithValue("@deleted", true);
                oleDbCommand.Parameters.AddWithValue("@code", code);

                Int32 result = oleDbCommand.ExecuteNonQuery();

                return (result > 0);
            }
            catch (OleDbException ex)
            {
                Message.showErrorMessage("deleting Client", ex);
            }
            finally
            {
                Connection.closeConnection(this.oleDbConnection);
            }
            return false;
        }

        public Client findByCode(string code)
        {
            OleDbDataReader oleDbDataReader = null;
            try
            {
                this.oleDbConnection.Open();
                String cmdText = "SELECT * FROM client WHERE [_code] = @code";

                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, this.oleDbConnection);

                oleDbCommand.Prepare();
                oleDbCommand.Parameters.AddWithValue("@code", code);

                oleDbDataReader = oleDbCommand.ExecuteReader();
                oleDbDataReader.Read();

                Client client = new Client();
                client.Code = oleDbDataReader.GetString(0);
                client.Name = oleDbDataReader.GetString(1);
                client.Genre = oleDbDataReader.GetString(2);
                client.Contact_1 = oleDbDataReader.GetString(3);
                client.Contact_2 = oleDbDataReader.GetString(4);
                client.Adress = oleDbDataReader.GetString(5);
                client.NumberBi = oleDbDataReader.GetString(6);
                client.Nuit = oleDbDataReader.GetString(7);
                client.Email = oleDbDataReader.GetString(8);
                client.BornDate = oleDbDataReader.GetDateTime(9);
                client.Deleted = oleDbDataReader.GetBoolean(10);

                ArrayList loans = new LoanDAO(this.oleDbConnection).findByClientCode(oleDbDataReader.GetString(0));


                client.Loan = loans;


                return client;
            }
            catch (OleDbException ex)
            {
                Message.showErrorMessage("findById Client", ex);
            }
            finally
            {
                Connection.closeConnection(this.oleDbConnection);
            }
            return null;
        }

        public ArrayList list()
        {
            OleDbDataReader oleDbDataReader = null; ;
            ArrayList clients = new ArrayList();
            try
            {
                Connection.closeConnection(this.oleDbConnection);
                this.oleDbConnection.Open();
                String cmdText = "SELECT * FROM client";

                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, this.oleDbConnection);

                oleDbDataReader = oleDbCommand.ExecuteReader();

                while (oleDbDataReader.Read())
                {
                    Client client = new Client();
                    client.Code = oleDbDataReader.GetString(0);
                    client.Name = oleDbDataReader.GetString(1);
                    client.Genre = oleDbDataReader.GetString(2);
                    client.Contact_1 = oleDbDataReader.GetString(3);
                    client.Contact_2 = oleDbDataReader.GetString(4);
                    client.Adress = oleDbDataReader.GetString(5);
                    client.NumberBi = oleDbDataReader.GetString(6);
                    client.Nuit = oleDbDataReader.GetString(7);
                    client.Email = oleDbDataReader.GetString(8);
                    client.BornDate = oleDbDataReader.GetDateTime(9);
                    client.Deleted = oleDbDataReader.GetBoolean(10);

                    clients.Add(client);
                }

                return clients;
            }
            catch (OleDbException ex)
            {
                Message.showErrorMessage("list Clients", ex);
            }
            finally
            {
                Connection.closeConnection(this.oleDbConnection, oleDbDataReader);
            }
            return null;
        }

        public bool save(Client client)
        {

            try
            {
                this.oleDbConnection.Open();
                String cmdText = "INSERT INTO client (_code, _name, _genre, _contact_1, _contact_2, _adress, _numberBi, _nuit, _email, _bornDate) VALUES (@code, @name, @genre, @contact_1, @contact_2, @adress, @numberBi, @nuit, @email, @bornDate)";

                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, this.oleDbConnection);

                oleDbCommand.Prepare();
                oleDbCommand.Parameters.AddWithValue("@code", client.Code);
                oleDbCommand.Parameters.AddWithValue("@name", client.Name);
                oleDbCommand.Parameters.AddWithValue("@genre", client.Genre);
                oleDbCommand.Parameters.AddWithValue("@contact_1", client.Contact_1);
                oleDbCommand.Parameters.AddWithValue("@contact_2", client.Contact_2);
                oleDbCommand.Parameters.AddWithValue("@adress", client.Adress);
                oleDbCommand.Parameters.AddWithValue("@numberBi", client.NumberBi);
                oleDbCommand.Parameters.AddWithValue("@nuit", client.Nuit);
                oleDbCommand.Parameters.AddWithValue("@email", client.Email);
                oleDbCommand.Parameters.AddWithValue("@bornDate", client.BornDate);

                int result = oleDbCommand.ExecuteNonQuery();

                return (result > 0);

            }
            catch (OleDbException ex)
            {
                Message.showErrorMessage("save Client", ex);
            }
            finally
            {
                Connection.closeConnection(this.oleDbConnection);
            }


            return false;
        }

        public bool update(Client client)
        {
            try
            {
                this.oleDbConnection.Open();
                String cmdText = "UPDATE client SET [_name] = @name, [_genre] = @genre, [_contact_1] = @contact_1, [_contact_2] = @contact_2, [_adress] =  @adress, [_numberBi] = @numberBi, [_nuit] = @nuit, [_email] = @email, [_bornDate] = @bornDate WHERE [_code] = @code";

                OleDbCommand oleDbCommand = new OleDbCommand(cmdText, this.oleDbConnection);

                oleDbCommand.Prepare();
                oleDbCommand.Parameters.AddWithValue("@name", client.Name);
                oleDbCommand.Parameters.AddWithValue("@genre", client.Genre);
                oleDbCommand.Parameters.AddWithValue("@contact_1", client.Contact_1);
                oleDbCommand.Parameters.AddWithValue("@contact_2", client.Contact_2);
                oleDbCommand.Parameters.AddWithValue("@adress", client.Adress);
                oleDbCommand.Parameters.AddWithValue("@numberBi", client.NumberBi);
                oleDbCommand.Parameters.AddWithValue("@nuit", client.Nuit);
                oleDbCommand.Parameters.AddWithValue("@email", client.Email);
                oleDbCommand.Parameters.AddWithValue("@bornDate", client.BornDate);
                oleDbCommand.Parameters.AddWithValue("@code", client.Code);

                int result = oleDbCommand.ExecuteNonQuery();

                return (result > 0);

            }
            catch (OleDbException ex)
            {
                Message.showErrorMessage("update Client", ex);
            }
            finally
            {
                Connection.closeConnection(this.oleDbConnection);
            }


            return false;
        }
    }
}
