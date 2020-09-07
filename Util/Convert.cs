using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestão_de_Emprestimos.Util
{
    public class Convert
    {
        public static String dateTimeToString(DateTime datetime, String format)
        {
            String convertedDate = datetime.ToString("dd/MMMM/yyyy", CultureInfo.CreateSpecificCulture("PT-MZ"));
            if (format != null) {
                 convertedDate = datetime.ToString(format);
            }
            return convertedDate;
        }
        public static String moneyToString(Double value, String format)
        {
            String convertedDate = value.ToString(CultureInfo.CreateSpecificCulture("PT-MZ"));
            if (format != null)
            {
                convertedDate = value.ToString(format);
            }
            return convertedDate;
        }

        internal static string paidBooleanToStringPT_PT(bool paid)
        {
            if (paid == true) return "Sim";

            return "Não";
        }
    }
}
