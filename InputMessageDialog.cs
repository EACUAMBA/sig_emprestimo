using Gestão_de_Emprestimos.DAO;
using Gestão_de_Emprestimos.Model;
using Gestão_de_Emprestimos.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestão_de_Emprestimos
{
    public partial class InputMessageDialog : Form
    {
        public InputMessageDialog()
        {
            InitializeComponent();
        }


        private void InputMessageDialog_Load(object sender, EventArgs e)
        {

        }

        private void btnCloseProgram_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void newApplicationFormMain()
        {
            Application.Run(new FormMain());
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            DataSourceInfo dataSourceInfo = createDataSourceInfoFromForm();
            if (dataSourceInfo != null)
            {
                DataSourceInfoFileXMLDAO dataSourceInfoFileXMLDAO = new DataSourceInfoFileXMLDAO();
                Boolean result = dataSourceInfoFileXMLDAO.createAndWriteXMLFile(dataSourceInfo);
                if (result)
                {
                    if (File.Exists(dataSourceInfoFileXMLDAO.readXMLFile().Path))
                    {
                        MessageBox.Show("Bem vindo ao SIG Emprestimo");
                        new Thread(new ThreadStart(newApplicationFormMain)).Start();
                        Application.Exit();
                        return;
                    }
                }
                Util.Message.showErrorMessage("database file", null);
                    return;
            }
        }
        private DataSourceInfo createDataSourceInfoFromForm()
        {
            DataSourceInfo dataSourceInfo = new DataSourceInfo();

            String path = GetFromTextBoxes.toString(txtLocalPathName, lbLocalPathName);
            if (path == null) return null;
            String url = GetFromRichTextBoxes.toStringNoWarnings(rTxtBoxWebURLDataBase, null, "Você não informou o banco de dados online, mas poderá fazer isso mais tarde.");
            //if (url == null) return null;


            dataSourceInfo.Path = path;
            dataSourceInfo.Url = url;


            return dataSourceInfo;
        }
    }
}
