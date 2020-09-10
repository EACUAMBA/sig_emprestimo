using Gestão_de_Emprestimos.DAO;
using Gestão_de_Emprestimos.DAO.Interface;
using Gestão_de_Emprestimos.Model;
using Gestão_de_Emprestimos.Util;
using Gestão_de_Emprestimos.Util.Enum;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestão_de_Emprestimos
{
    public partial class FormLoan : Form
    {
        private Client client;
        private ILoanDAO iLoanDAO;
        public FormLoan(
            Client client, ILoanDAO iloanDAO)
        {
            this.iLoanDAO = iloanDAO;
            this.client = client;
            InitializeComponent();
        }

        public void installmentStartLoadConfig()
        {
            if (checkBoxInstallment.Checked == true)
            {
                maskedTxtBoxResidualValue.Enabled = true;
                comboBoxFrequency.Enabled = true;
                comboBoxFrequency.Refresh();
                maskedTxtBoxResidualValue.Refresh();
                btnGenerateInstallment.Enabled = true;
                comboBoxFrequency.SelectedIndex = 2;
                dtpFirstPayment.Enabled = true;
                dgvParcelas.Enabled = true;
            }
            else if (checkBoxInstallment.Checked == false)
            {
                dtpFirstPayment.Enabled = false;
                maskedTxtBoxResidualValue.Enabled = false;
                maskedTxtBoxResidualValue.Refresh();
                comboBoxFrequency.Enabled = false;
                comboBoxFrequency.Refresh();
                btnGenerateInstallment.Enabled = false;
                dgvParcelas.Enabled = false;
            }
        }
        private void checkBoxInstallment_CheckedChanged(object sender, EventArgs e)
        {
            installmentStartLoadConfig();
        }

        private void FormLoan_Load(object sender, EventArgs e)
        {
            maskedTxtBoxResidualValue.Enabled = false;
            comboBoxFrequency.Enabled = false;
            comboBoxFrequency.Items.Clear();
            comboBoxFrequency.Items.Add(Frequency.Semanalmente);
            comboBoxFrequency.Items.Add(Frequency.Quinzenalmente);
            comboBoxFrequency.Items.Add(Frequency.Mensalemnte);
            comboBoxFrequency.Items.Add(Frequency.Trimestralmente);
            dtpFirstPayment.Enabled = false;
            btnGenerateInstallment.Enabled = false;
            comboBoxFrequency.SelectedIndex = 2;
            dgvParcelas.Enabled = false;
            dtpStartDate.Value = DateTime.Now;
            dtpFirstPayment.Value = DateTime.Now;


            txtBoxCode.Enabled = false;
            txtBoxClientCode.Enabled = false;
            txtBoxCode.Text = Generator.newCode(this.iLoanDAO.list(), "LN");

            if (!fillTextFieldWithCodeAndName()) this.Close();

        }

        public Boolean fillTextFieldWithCodeAndName()
        {

            //Certified the client isn't null
            if (this.client == null) return false;

            // Put in the label the values of code and name of the client
            txtBoxClientCode.Text = this.client.Code + " | " + this.client.Name;

            //returning true if the code have success
            return true;
        }

        public ArrayList installmentGeneratorByResidualValueAndFrequency()
        {
            //Get the frequency value
            Object frequency = GetFromComboBoxes.toItem(comboBoxFrequency, lbFrequency, false);
            int days = 0;
            //Some validations, to determines if the frequency exists, or if is null value;
            if (frequency != null)
            {
                days = (int)((Frequency)frequency);
            }
            if (days == 0) return null;

            // Get the date of the firstpayment
            DateTime firstPayment = dtpFirstPayment.Value;

            // Get the Loan Object from Fields in form
            Loan loan = createLoanFromForm();
            if (loan == null) return null;//Some validations

            // Some calcs to get the value of capital with percent of juros
            double valueWithPercent = ((loan.Capital * loan.Percent) / 100) + loan.Capital;

            // Getting the number of the installments
            byte numberOfInstallmentNecessary = (byte)(valueWithPercent / loan.ResidualValue);

            // Geting the rest, the value that we can't creat a new installment.
            double restOfValue = valueWithPercent % loan.ResidualValue;


            //Creating a instance of a new array o put the installment created
            ArrayList installments = new ArrayList();

            //Making a for to add in each position each installment, start from the 0 and ends in the nember in installments necessary -1
            for (int i = 0; i <= numberOfInstallmentNecessary - 1; i++)
            {


                // Giving the number of the installment
                int installmentCode = i;
                
                //Giving the code of the Loan which is relationed with the client
                String loanCode = (loan.Code);

                //Getting the Value to pay in this installment only
                Double installmentValue = 0;

                //Here i'm certify that the number of Installment is not the last, because if it is the last i wanto to add with the rest of the division. above
                if (i != (numberOfInstallmentNecessary - 1))
                {
                    installmentValue = loan.ResidualValue;
                }
                else
                {
                    installmentValue = (loan.ResidualValue + restOfValue);
                }

                //Verify if the position is not e the first becouse i want to Add some days, the days of the frequency! if it ism't the first one position
                if (i != 0)
                {
                    firstPayment = firstPayment.AddDays(days);
                }


                //Addiding the created installment into the array.
                installments.Add(new ArrayList() { (installmentCode + 1), loanCode, installmentValue, firstPayment.ToString("dd/MMMM/yyyy") });
            }

            //After create all installment i return the populated array;
            return installments;
        }
        private void btnGenerateInstallment_Click(object sender, EventArgs e)
        {
            dgvParcelas.Rows.Clear();
            ArrayList installments = installmentGeneratorByResidualValueAndFrequency();
            if (installments == null) return;
            if (installments.Count <= 0) { return; }
            dgvParcelas.Rows.Add(installments.Count - 1);
            for (int j = 0; j < installments.Count; j++)
            {
                ArrayList list = (ArrayList)installments[j];
                dgvParcelas.Rows[j].Cells[0].Value = list[0].ToString();
                dgvParcelas.Rows[j].Cells[1].Value = list[1].ToString();
                dgvParcelas.Rows[j].Cells[2].Value = list[2].ToString();
                dgvParcelas.Rows[j].Cells[3].Value = list[3].ToString();

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Status.setStatus("Saving Loan...", Color.Green, null, lbInformation);
            Loan loan = createLoanFromForm();
            if (loan == null) return;

            if (checkBoxInstallment.Checked)
            {
                if (installmentGeneratorFromDataGridView() == null)
                {
                    Status.setStatus("Loan not Saved!", Color.Red, null, lbInformation);
                    return;
                }

                loan.Installment = installmentGeneratorFromDataGridView();


            }

            if (!this.iLoanDAO.save(loan)) Status.setStatus("Loan not Saved!", Color.Red, null, lbInformation);

            MessageBox.Show("Salvo com sucesso!");
            this.Close();



            Status.setStatus(null, null, null, lbInformation);
        }

        private Loan createLoanFromForm()
        {
            String code = GetFromTextBoxes.toString(txtBoxCode, lbCode);
            if (code == null) return null;

            String clientCode = this.client.Code;
            if (clientCode == null) return null;

            Double capital = GetFromMeskedTextBoxes.toDouble(maskedTxtBoxCapital, lbCapital);
            if (capital == 0) return null;

            Int32 percent = GetFromMeskedTextBoxes.toInt32(maskedTxtBoxPercent, lbPercent);

            if (percent <= 0 || percent >= 100)
            {
                MessageBox.Show("Juros não pode ser menor ou igual a 0% ou maior ou igual a 100%");
                return null;
            }

            DateTime startDate = GetFromDateTimePicker.toDateTime(dtpStartDate, lbStartDate);


            DateTime endDate = GetFromDateTimePicker.toDateTime(dtpEndDate, lbEndDate);
            if (endDate == new DateTime()) return null;

            Loan loan = new Loan();
            loan.Code = Generator.newCode(this.iLoanDAO.findByClientCode(clientCode), "LN");
            loan.ClientCode = clientCode;
            byte percentage = (byte)percent;
            loan.Capital = capital;
            loan.Percent = (byte)percent;
            loan.StartDate = startDate;
            loan.EndDate = endDate;

            if (!checkBoxInstallment.Checked)
            {
                return loan;
            }
            else
            {
                double residualValue = GetFromMeskedTextBoxes.toDouble(maskedTxtBoxResidualValue, lbResidualValue);
                if (residualValue == 0) return null;

                loan.ResidualValue = residualValue;
                return loan;
            }
        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxFrequency_SelectedIndexChanged(object sender, EventArgs e)
        {
            Object frequency = GetFromComboBoxes.toItem(comboBoxFrequency, lbFrequency, false);
            int days = 0;
            if (frequency != null)
            {
                days = (int)((Frequency)frequency);
            }
            if (days == 0) return;

            dtpFirstPayment.Value = DateTime.Now.AddDays(days);
        }

        private void dgvParcelas_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvParcelas.Rows.Count > 1)
            {
                String lastDate = dgvParcelas.Rows[dgvParcelas.Rows.Count - 1].Cells[3].Value != DBNull.Value ? (String)dgvParcelas.Rows[dgvParcelas.Rows.Count - 1].Cells[3].Value : null;
                if (lastDate != null)
                {
                    DateTime lastDayToPay = DateTime.ParseExact(lastDate, "dd/MMMM/yyyy", CultureInfo.InvariantCulture);
                    dtpEndDate.Value = lastDayToPay;
                }
            }
        }

        private void btnCleanForm_Click(object sender, EventArgs e)
        {
            installmentStartLoadConfig();
            cleanFormFields();
            
           
        }

        public void cleanFormFields()
        {
            maskedTxtBoxCapital.Clear();
            maskedTxtBoxPercent.Clear();
            maskedTxtBoxResidualValue.Clear();
            dtpEndDate.Value = DateTime.Now;
            dtpStartDate.Value = DateTime.Now;
            Object frequency = GetFromComboBoxes.toItem(comboBoxFrequency, lbFrequency, false);
            int days = 0;
            if (frequency != null)
            {
                days = (int)((Frequency)frequency);
            }
            if (days == 0) return;
            dtpFirstPayment.Value = DateTime.Now.AddDays(days);
            dgvParcelas.Rows.Clear();
        }

        public ArrayList installmentGeneratorFromDataGridView()
        {
            ArrayList installments = new ArrayList();

            

            if (dgvParcelas.Rows.Count < 0) return null;
            for(int i = 0; i<= dgvParcelas.Rows.Count-1; i++)
            {
                Int32 installmentCode = Int32.Parse((String)dgvParcelas.Rows[i].Cells[0].Value);

                String installmentLoanCode = (String)dgvParcelas.Rows[i].Cells[1].Value;

                double installmentValue = Double.Parse((String)dgvParcelas.Rows[i].Cells[2].Value);

                String dateToPay = dgvParcelas.Rows[i].Cells[3].Value != DBNull.Value ? (String)dgvParcelas.Rows[i].Cells[3].Value : null;

                DateTime installmentDateOfPayment = DateTime.ParseExact(dateToPay, "dd/MMMM/yyyy", CultureInfo.InvariantCulture);

                installments.Add(new Installment(installmentCode, installmentLoanCode, installmentValue, installmentDateOfPayment));
            }

            return installments;
        }

        private void maskedTxtBoxPercent_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTxtBoxPercent_TextChanged(object sender, EventArgs e)
        {
            Double Capital = GetFromMeskedTextBoxes.toDouble(maskedTxtBoxCapital, null);
            Int32 percent = GetFromMeskedTextBoxes.toInt32(maskedTxtBoxPercent, null);

            

            double valueWithPercent = ((Capital * percent) / 100) + Capital;



            lbValueWithPercent.Text = "Va. C/ J.: " + valueWithPercent.ToString("C", CultureInfo.CreateSpecificCulture("pt-mz"));
            lbValueWithPercent.Refresh();

        }

        private void btnNewRow_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRemoveRow_Click(object sender, EventArgs e)
        {

            if (this.dgvParcelas.SelectedRows.Count > 0)
            {
                this.dgvParcelas.Rows.RemoveAt(this.dgvParcelas.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Selecione uma linha, clique na primeira coluna a esquerda!");
            }
            
        }

        private void btnUpdateDataGrid_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
