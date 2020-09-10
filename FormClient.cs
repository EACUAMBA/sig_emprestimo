using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gestão_de_Emprestimos.DAO;
using Gestão_de_Emprestimos.Util;
using Gestão_de_Emprestimos.Model;
using System.Collections;
using Gestão_de_Emprestimos.DAO.Interface;
using System.Threading;
using System.Data.OleDb;

namespace Gestão_de_Emprestimos
{
    public partial class FormClient : Form
    {
        private OleDbConnection oleDbConnection;
        private IClientDAO iClientDAO;
        private ILoanDAO iLoanDAO;
        private Form formLoan;
        private Form formLoanList;
        public FormClient()
        {
            this.oleDbConnection = Connection.getConnection();
            this.iClientDAO = new ClientDAO_OleDb(this.oleDbConnection);
            this.iLoanDAO = new LoanDAO(this.oleDbConnection);
            
            InitializeComponent();
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Client client = createClientFromForm();
            if (client == null)
            {
                Status.setStatus(null, null, null, lbInformation);
                return;
            }
            if(this.iClientDAO.save(client))
            fillOneLineListView(client);
            //MessageBox.Show(client.ToString());
            cleanFormFields();
            Status.setStatus(null, null, null, lbInformation);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Client client = createClientFromForm();
            if (client == null)
            {
                Status.setStatus(null, null, null, lbInformation);
                return;
            }
            this.iClientDAO.update(client);
            fillOneLineListView(client);
            MessageBox.Show(client.ToString());
            cleanFormFields();
            Status.setStatus(null, null, null, lbInformation);
        }

        private String codeGenerator()
        {
            ArrayList clients = this.iClientDAO.list();
            return Generator.newCode(clients, "CT");
        }

        private Client createClientFromForm()
        {
            Status.setStatus("Saving/Updating Client...", null, null, lbInformation);
            String code = GetFromTextBoxes.toString(txtBoxCode);
            if (code == null)
            {
                code = codeGenerator();
                if (code == null)
                {
                    return null;
                }

            }

            String name = GetFromTextBoxes.toString(txtBoxName, lbName);
            if (name == null) return null;


            String genre = GetFromRadioButtons.toString(new RadioButton[2] { rbFemale, rbMale }, gbGenre);
            if (genre == null) return null;


            String contact_1 = GetFromTextBoxes.toString(txtBoxContact_1, lbContact);
            if (contact_1 == null) return null;

            String contact_2 = GetFromTextBoxes.toString(txtBoxContact_2, lbContact);
            if (contact_2 == null) return null;

            String adress = GetFromRichTextBoxes.toString(rTxtBoxAdress, lbAdress);
            if (adress == null) return null;

            String numberBi = GetFromTextBoxes.toString(txtBoxNumberBi, lbNumberBi);
            if (numberBi == null) return null;

            String nuit = GetFromTextBoxes.toString(txtBoxNUIT, lbNumNUIT);
            if (nuit == null) return null;

            DateTime bornDate = GetFromDateTimePicker.toDateTime(dtpBornDate, lbBornDate);
            if (bornDate == DateTimePicker.MinimumDateTime) return null;

            String email = GetFromTextBoxes.toString(txtBoxEmail, lbEmail);
            if (email == null) return null;


            //Creating Client Object to return
            Client client = new Client();

            client.Code = code;
            client.Name = name;
            client.Genre = genre;
            client.Contact_1 = contact_1;
            client.Contact_2 = contact_2;
            client.Adress = adress;
            client.BornDate = bornDate;
            client.NumberBi = numberBi;
            client.Nuit = nuit;
            client.Email = email;

            return client;
        }

        private void FormClient_Load(object sender, EventArgs e)
        {
           
            txtBoxCode.Enabled = false;
            fillAllLinesListView();
            dtpBornDate.Value = DateTimePicker.MinimumDateTime;
        }

        private void fillOneLineListView(Client client)
        {
            ListViewItem lviClients = new ListViewItem();
            lviClients.Text = client.Code;
            lviClients.SubItems.Add(client.Name);
            lviClients.SubItems.Add(client.Genre);
            lviClients.SubItems.Add(Util.Convert.dateTimeToString(client.BornDate, null));
            lviClients.SubItems.Add(client.Contact_1 + ", " + client.Contact_2);
            lviClients.SubItems.Add(client.Email);
            lviClients.SubItems.Add(client.Adress);
            lviClients.SubItems.Add(client.NumberBi);
            lviClients.SubItems.Add(client.Nuit);

            Boolean deleted = client.Deleted;
            if (deleted)
            {
                lviClients.ForeColor = Color.Gray;

                lviClients.Font = new Font(new Font(new FontFamily("Gilroy Light"), lvClients.Font.Size), FontStyle.Strikeout);
            }

            lvClients.Items.Add(lviClients);


        }

        private void fillAllLinesListView()
        {
            ArrayList clients = this.iClientDAO.list();

            lvClients.Items.Clear();

            foreach (Client client in clients)
            {
                fillOneLineListView(client);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Status.setStatus("Deleting Client...", null, null, lbInformation);

            String selectedRowCode = GetFromListViewes.getCodeSelectedRow(lvClients);
            if (selectedRowCode == null)
            {
                Status.setStatus(null, null, null, lbInformation);
                return;
            }

            this.iClientDAO.delete(selectedRowCode);

            fillAllLinesListView();

            Status.setStatus(null, null, null, lbInformation);
        }

        

        private void btnCleanForm_Click(object sender, EventArgs e)
        {
            cleanFormFields();
        }

        private void cleanFormFields()
        {
            Status.setStatus("Cleaning form fields", null, null, lbInformation);
            txtBoxCode.Clear();
            txtBoxName.Clear();
            rTxtBoxAdress.Clear();
            txtBoxContact_1.Clear();
            txtBoxContact_2.Clear();
            txtBoxEmail.Clear();
            txtBoxNUIT.Clear();
            txtBoxNumberBi.Clear();
            dtpBornDate.Value = DateTimePicker.MinimumDateTime;
            rbFemale.Checked = false;
            rbMale.Checked = false;
            
            Status.setStatus(null, null, null, lbInformation);
        }

        
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnToLoan_Click(object sender, EventArgs e)
        {
            String clientCode = GetFromListViewes.getCodeSelectedRow(lvClients);
            if (clientCode != null)
            {
                Client client = this.iClientDAO.findByCode(clientCode);
                if(client != null)
                {
                    if (client.Deleted)
                    {
                        Util.Message.showErrorMessage("loan, you cannot loan to deleted person please, add this person again and loan then!", null);
                        return;
                    } 
                        this.formLoan = new FormLoan(client, this.iLoanDAO);
                        this.formLoan.ShowDialog();
                }
                else
                {
                    return;
                }
            }
            else
            {
                return;
            }


        }

        private void btnToEdit_Click(object sender, EventArgs e)
        {
            fillFormFieldsWithSelectedRow();
        }

        private void fillFormFieldsWithSelectedRow()
        {
            Status.setStatus("Putting data on fields", null, null, lbInformation);
            String selectedRowCode = GetFromListViewes.getCodeSelectedRow(lvClients);
            fillAllLinesListView();
            
            if (selectedRowCode == null) return;

            Client selectedClient = this.iClientDAO.findByCode(selectedRowCode);


            SetTextBoxesText.setFromString(txtBoxCode, selectedClient.Code);
            SetTextBoxesText.setFromString(txtBoxName, selectedClient.Name);
            SetRadioButtonsCheck.setFromString(new RadioButton[2] { rbFemale, rbMale}, selectedClient.Genre);
            SetTextBoxesText.setFromString(txtBoxContact_1, selectedClient.Contact_1);
            SetTextBoxesText.setFromString(txtBoxContact_2, selectedClient.Contact_2);
            SetRichTextBoxesText.setFromString(rTxtBoxAdress, selectedClient.Adress);
            SetTextBoxesText.setFromString(txtBoxContact_2, selectedClient.Contact_2);
            SetDateTimePickerValue.setFromDateTime(dtpBornDate,selectedClient.BornDate);
            SetTextBoxesText.setFromString(txtBoxNumberBi, selectedClient.NumberBi);
            SetTextBoxesText.setFromString(txtBoxNUIT, selectedClient.Nuit);
            SetTextBoxesText.setFromString(txtBoxEmail, selectedClient.Email);

            Status.setStatus(null, null, null, lbInformation);

        }

        private void btnSeeLoan_Click(object sender, EventArgs e)
        {
            String clientCode = GetFromListViewes.getCodeSelectedRow(lvClients);
            if (clientCode == null) return;

            Client client = this.iClientDAO.findByCode(clientCode);

            if(client.Loan == null)
            {
                Util.Message.showErrorMessage("Cliente não tem emprestimos realizados, por favor realize um para ver os emprestimos dele.", null);
                return;
            }

            this.formLoanList = new FormLoanList(client);
            this.formLoanList.ShowDialog();

        }
    }
}
