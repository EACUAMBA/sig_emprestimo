using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestão_de_Emprestimos.Util
{
    public class SetTextBoxesText
    {
        public static void setFromString(TextBox textBox, String text)
        {
            if (textBox == null || text == null) return;
            textBox.Text = text;
        }
    }

    public class SetRadioButtonsCheck
    {
        public static void setFromString(RadioButton[] radioButtons, String text)
        {
            if (radioButtons.Length <= 0 || text == null) return;

            foreach(RadioButton radioButton in radioButtons)
            {
                if (radioButton.Text == text) radioButton.Checked = true;
            }
        }
    }
    public class SetRichTextBoxesText
    {
        public static void setFromString(RichTextBox richTextBox, String text)
        {
            if (richTextBox == null || text == null) return;
            richTextBox.Text = text;
        }
    }
    public class SetDateTimePickerValue
    {
        public static void setFromDateTime(DateTimePicker dateTimePicker, DateTime dateTime)
        {
            if (dateTimePicker == null || dateTime == new DateTime(1910,1,1)) return;
            dateTimePicker.Value = dateTime;

        }
    }
}
