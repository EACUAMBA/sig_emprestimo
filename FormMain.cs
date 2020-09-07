using Gestão_de_Emprestimos.Util;
using System;
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

        }

        private void btnListInstallment_Click(object sender, EventArgs e)
        {

        }

        private void btnFormLoan_Click(object sender, EventArgs e)
        {

        }
    }
}
