using Gestão_de_Emprestimos.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestão_de_Emprestimos
{
    public partial class FormLoanList : Form
    {

        private Client client;
        public FormLoanList(Client client)
        {
            this.client = client;
            InitializeComponent();
        }

        private void FormLoanList_Load(object sender, EventArgs e)
        {
            lbClientName.Text = this.client.Name;

            fillListView();
        }

        private void fillListView()
        {

            ArrayList loans = this.client.Loan;
            foreach(Loan loan in loans)
            {
                fillLoan(loan);
            }

            
        }

        private void fillLoan(Loan loan)
        {
            ListViewItem lvi = new ListViewItem(loan.Code);
            lvi.SubItems.Add(loan.ClientCode);
            lvi.SubItems.Add(Util.Convert.moneyToString(loan.Capital, null));
            lvi.SubItems.Add(loan.Percent + " %");
            lvi.SubItems.Add(Util.Convert.dateTimeToString(loan.StartDate, "dd - MMMM - yyyy"));
            lvi.SubItems.Add(Util.Convert.dateTimeToString(loan.EndDate, "dd - MMMM - yyyy"));
            lvi.SubItems.Add(Util.Convert.moneyToString(loan.ResidualValue, null));

            if (loan.Paid)
            {
                lvi.ForeColor = Color.GreenYellow;
                lvi.Font = new Font("Arial", 12, FontStyle.Bold);
            }
            else
            {
                lvi.ForeColor = Color.PaleVioletRed;
                lvi.Font = new Font("Arial", 12, FontStyle.Bold);
            }

            lvi.SubItems.Add(Util.Convert.paidBooleanToStringPT_PT(loan.Paid));

            this.lvLoans.Items.Add(lvi);
        }

        private void fillInstallment(Installment installment)
        {
            ListViewItem lvi = new ListViewItem(installment.Code.ToString());
            lvi.SubItems.Add(installment.LoanCode);
            lvi.SubItems.Add(Util.Convert.moneyToString(installment.Value, null));
            lvi.SubItems.Add(Util.Convert.dateTimeToString(installment.DateToPay, "dd - MMMM - yyyy"));

            if (installment.Paid)
            {
                lvi.ForeColor = Color.GreenYellow;
                lvi.Font = new Font("Arial", 12, FontStyle.Bold);
            }
            else
            {
                lvi.ForeColor = Color.PaleVioletRed;
                lvi.Font = new Font("Arial", 12, FontStyle.Bold);
            }

            lvi.SubItems.Add(Util.Convert.paidBooleanToStringPT_PT(installment.Paid));

            this.lviInstallments.Items.Add(lvi);
        }

        private void lvLoans_MouseClick(object sender, MouseEventArgs e)
        {
            if(lvLoans.SelectedItems.Count > 0)
            {
                String code = (String)lvLoans.SelectedItems[0].Text;

                foreach(Loan loan in this.client.Loan)
                {
                    if(loan.Code == code)
                    {
                        foreach (Installment installment in loan.Installment)
                        {
                            fillInstallment(installment);
                        }

                        break;
                    }
                    else
                    {
                        lviInstallments.Items.Clear();
                        break;
                    }
                }
            }
        }

        private void btnDefineAsPaid_Click(object sender, EventArgs e)
        {
            String loanCode = Util.GetFromListViewes.getCodeSelectedRow(lvLoans);
            

            String installmentCode = Util.GetFromListViewes.getCodeSelectedRow(lviInstallments);

            if(loanCode != "" && loanCode != null)
            {
                
            }
        }
    }
}
