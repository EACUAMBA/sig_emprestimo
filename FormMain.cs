using Gestão_de_Emprestimos.Util;
using Gestão_de_Emprestimos.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using Gestão_de_Emprestimos.Model;

namespace Gestão_de_Emprestimos
{
    public partial class FormMain : Form
    {
        private Form formClient;
        
        public FormMain()
        {
            this.formClient = new FormClient();
            InitializeComponent();


        }

        private void btnListClient_Click(object sender, EventArgs e)
        {
            
        }

        private void btnFormClient_Click(object sender, EventArgs e)
        {
            this.formClient.ShowDialog();
        }

        private void formMain_Load(object sender, EventArgs e)
        {
            ClientDAO_OleDb clientDAO = new ClientDAO_OleDb();
            ArrayList clients = clientDAO.list();
            ArrayList mlvs = new ArrayList();
            lvMainLoan.Items.Clear();

            foreach (Client client in clients)
            {
                

                foreach(Loan loan in client.Loan)
                {
                    if (!loan.Paid)
                    {
                        MainLaonView mLV = new MainLaonView();
                        mLV.Name = client.Name;
                        mLV.Capital = Util.Convert.moneyToString(loan.Capital, null);
                        mLV.Percent = loan.Percent + " %";
                        mLV.ResidualValue = Util.Convert.moneyToString(loan.ResidualValue, null);
                        mLV.DateStart = Util.Convert.dateTimeToString(loan.StartDate, null);
                        mLV.DateEnd = Util.Convert.dateTimeToString(loan.EndDate, null);

                        TimeSpan daysLeft = loan.EndDate.Subtract(loan.StartDate);

                        mLV.DaysLeft = daysLeft.Days;
                        mlvs.Add(mLV);
                    }
                }

                
                
            }

            mlvs.Sort(new ComparatorByInt());

            foreach(MainLaonView mlv in mlvs)
            {
                ListViewItem lvi = new ListViewItem(mlv.Name);
                lvi.SubItems.Add(mlv.Capital);
                lvi.SubItems.Add(mlv.Percent);
                lvi.SubItems.Add(mlv.ResidualValue);
                lvi.SubItems.Add(mlv.DateStart);
                lvi.SubItems.Add(mlv.DateEnd);
                if(mlv.DaysLeft < 0)
                {
                    lvi.ForeColor = Color.Black;
                    lvi.BackColor = Color.Red;
                }else if (mlv.DaysLeft <= 3)
                {
                    lvi.ForeColor = Color.Black;
                    lvi.BackColor = Color.Yellow;
                }else if(mlv.DaysLeft <= 15)
                {
                    lvi.ForeColor = Color.White;
                    lvi.BackColor = Color.Green;
                }
                lvi.Font = new Font("Arial", 12);
                lvi.SubItems.Add(mlv.DaysLeft.ToString());

                lvMainLoan.Items.Add(lvi);
            }

           

        }

        private void btnListInstallment_Click(object sender, EventArgs e)
        {

        }

        private void btnFormLoan_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateList_Click(object sender, EventArgs e)
        {
            formMain_Load(null, null);
        }
    }
    class MainLaonView
    {
        private String name;
        private String capital;
        private String percent;
        private String residualValue;
        private String dateStart;
        private String dateEnd;
        private int daysLeft;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Capital
        {
            get
            {
                return capital;
            }

            set
            {
                capital = value;
            }
        }

        public string Percent
        {
            get
            {
                return percent;
            }

            set
            {
                percent = value;
            }
        }

        public string ResidualValue
        {
            get
            {
                return residualValue;
            }

            set
            {
                residualValue = value;
            }
        }

        public string DateStart
        {
            get
            {
                return dateStart;
            }

            set
            {
                dateStart = value;
            }
        }

        public string DateEnd
        {
            get
            {
                return dateEnd;
            }

            set
            {
                dateEnd = value;
            }
        }

        public int DaysLeft
        {
            get
            {
                return daysLeft;
            }

            set
            {
                daysLeft = value;
            }
        }
    }
    public class ComparatorByInt : IComparer
    {
        public int Compare(object x, object y)
        {
            return (new CaseInsensitiveComparer()).Compare(((MainLaonView)x).DaysLeft, ((MainLaonView)y).DaysLeft);
        }
    }
}
