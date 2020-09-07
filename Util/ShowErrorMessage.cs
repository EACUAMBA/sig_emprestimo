using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Drawing;

namespace Gestão_de_Emprestimos.Util
{
    public class Message
    {
        public static void showErrorMessage(String action, Exception ex)
        {
            if(ex != null)
            {
                MessageBox.Show("Error on \" " + action + " \" \n\nError\t" + ex.Message);
                return;
            }
            MessageBox.Show("Error on \" " + action + " \"");
        }

        public static void showErrorMessage(String action, OleDbException ex)
        {
            if (ex != null)
            {
                MessageBox.Show("Error on \" " + action + " \" \n\nError\t" + ex.Message);
                return;
            }
            MessageBox.Show("Error on \" " + action + " \"");
        }
    }
    public class Status
    {
        public static void setStatus(String information, Object backColor, Object foreColor, Label lb)
        {
            if (information != null)
            {
                lb.Text = "Status: " + information;
                if (backColor != null) lb.BackColor = (Color)backColor;
                if (foreColor != null) lb.ForeColor = (Color)foreColor;
                lb.Refresh();
            }
            else
            {

                lb.Text = "Status: No activity!";
                lb.BackColor = Color.Black;
                lb.ForeColor = Color.White;
                lb.Refresh();
            }
        }
    }
}
