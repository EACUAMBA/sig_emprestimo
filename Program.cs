using Gestão_de_Emprestimos.DAO;
using Gestão_de_Emprestimos.Util;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestão_de_Emprestimos
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DataSourceInfoFileXMLDAO dataSourceInfoFileXMLDAO = new DataSourceInfoFileXMLDAO();
            Boolean result = dataSourceInfoFileXMLDAO.readXMLFile() != null;
            if (result)
            {
                if (File.Exists(dataSourceInfoFileXMLDAO.readXMLFile().Path))
                {
                    Application.Run(new FormMain());

                }else
                {
                    Application.Run(new InputMessageDialog());
                }
            }
            else
            {
                Application.Run(new InputMessageDialog());
            }
            
                
            
        }
    }
}
