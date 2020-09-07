using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestão_de_Emprestimos.Util
{
    public class GetFromDateTimePicker
    {
        public static DateTime toDateTime(DateTimePicker dateTimePicker, Label lb)
        {
            DateTime preValue = dateTimePicker.Value.Date;
            if (preValue == DateTimePicker.MinimumDateTime)
            {
                preValue = DateTimePicker.MinimumDateTime;
                MessageBox.Show("Por favor preencha o campo \" " + lb.Text + " \"");
            }
            return preValue;
        }
    }
    public class GetFromRichTextBoxes
    {
        public static String toString(RichTextBox rtxtBox, Label lb)
        {
            String value = rtxtBox.Text.Trim();
            if (value == "")
            {
                value = null;
                MessageBox.Show("Por favor preencha o campo \" " + lb.Text + " \"");
            }
            return value;
        }
        public static String toStringNoWarnings(RichTextBox rtxtBox, Label lb, String message)
        {
            String value = rtxtBox.Text.Trim();
            if (lb == null)
                if (value == "")
                {
                    MessageBox.Show(message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return value;
                }
            return "";

        }
    }
    public class GetFromTextBoxes
    {
        public static String toString(TextBox txtBox, Label lb)
        {
            String value = txtBox.Text.Trim();
            if (value == "")
            {
                value = null;
                MessageBox.Show("Por favor preencha o campo \" " + lb.Text + " \"");
            }
            return value;
        }
        public static String toString(TextBox txtBox)
        {
            String value = txtBox.Text.Trim();
            if (value == "")
            {
                value = null;
            }
            return value;
        }
        public static Int32 toInt32(TextBox txtBox, Label lb)
        {
            String preValue = txtBox.Text.Trim();
            try
            {
                if (preValue == "")
                {
                    preValue = "0";
                    MessageBox.Show("Por favor preencha o campo \" " + lb.Text + " \"");
                }
                return Int32.Parse(preValue);
            }
            catch (System.FormatException ex)
            {
                Message.showErrorMessage("No campo " + lb.Text + " Insira um numero", ex);
            }
            return 0;
        }

        public static Double toDouble(TextBox txtBox, Label lb)
        {
            String preValue = txtBox.Text.Trim();
            try
            {

                if (preValue == "")
                {
                    preValue = "0";
                    MessageBox.Show("Por favor preencha o campo \" " + lb.Text + " \"");
                }
                return Double.Parse(preValue);
            }
            catch (System.FormatException ex)
            {
                Message.showErrorMessage("No campo " + lb.Text + " Insira um numero", ex);
            }
            return 0;
        }


    }
    public class GetFromRadioButtons
    {
        public static String toString(RadioButton[] radioButtons, GroupBox groupBox)
        {
            String preValue = null;
            foreach (RadioButton radioButton in radioButtons)
            {
                if (radioButton.Checked == true)
                {
                    preValue = radioButton.Text;
                }
            }
            if (preValue == null)
            {
                MessageBox.Show("Selecione um dos campos em \" " + groupBox.Text + " \"");
            }
            return preValue;
        }

    }

    public class GetFromComboBoxes
    {
        public static String toString(ComboBox comboBox, Label lb)
        {
            String preValue = null;
            if (comboBox.SelectedIndex != 0)
            {
                preValue = comboBox.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("Selecione uma opção na ComboBox \" " + lb.Text + " \"");
                return null;
            }



            return preValue;
        }

        internal static Object toItem(ComboBox comboBox, Label lb, Boolean firstValueValid)
        {
            Object preValue = 0;
            if (firstValueValid)
            {
                if (comboBox.SelectedIndex != 0)
                {
                    preValue = comboBox.SelectedItem;
                }
                else
                {
                    MessageBox.Show("Selecione uma opção na ComboBox \" " + lb.Text + " \"");
                    return null;
                }
            }
            else
            {
                preValue = comboBox.SelectedItem;
            }


            return preValue;
        }
    }
    public class GetFromListViewes
    {
        public static String getCodeSelectedRow(ListView listView)
        {
            if (listView.Items.Count <= 0 || listView.SelectedItems.Count <= 0)
            {
                Message.showErrorMessage("getting code from ListView", new Exception("ListView is empty OR you don't selected any ROW"));
                return null;
            }


            return listView.SelectedItems[0].Text;
        }
    }
    public class GetFromMeskedTextBoxes
    {
        public static Double toDouble(MaskedTextBox maskedTxtBox, Label lb)
        {
            String preValue = maskedTxtBox.Text.Trim();
            preValue = preValue.Replace(",", "").Replace("00 MZN", "").Trim();
            
            try
            {

                if (preValue == "")
                {
                    preValue = "0";
                    if (lb != null)
                        MessageBox.Show("Por favor preencha o campo \" " + lb.Text + " \"");
                }
                return Double.Parse(preValue);
            }
            catch (System.FormatException ex)
            {
                if (lb != null)
                    Message.showErrorMessage("No campo " + lb.Text + " Insira um numero", ex);
            }
            return 0;
        }
        public static Int32 toInt32(MaskedTextBox maskedTxtBox, Label lb)
        {
            String preValue = maskedTxtBox.Text.Trim();
            preValue = preValue.Replace(",", "").Replace(" %", "").Trim();
            
            try
            {
                if (preValue == "")
                {

                    preValue = "0";
                    if (lb != null)
                        MessageBox.Show("Por favor preencha o campo \" " + lb.Text + " \"");
                }
                return Int32.Parse(preValue);
            }
            catch (System.FormatException ex)
            {
                if (lb != null)
                    Message.showErrorMessage("No campo " + lb.Text + " Insira um numero", ex);

                
            }
            return 0;
        }
    }
}
