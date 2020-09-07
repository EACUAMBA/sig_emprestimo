using Gestão_de_Emprestimos.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestão_de_Emprestimos.Util
{
    public class ComparatorLoanByCode : IComparer
    {
        public int Compare(object x, object y)
        {
            return (new CaseInsensitiveComparer()).Compare(((Loan)x).Code, ((Loan)y).Code);
        }
    }

    public class ComparatorClientByCode : IComparer
    {
        public int Compare(Object x, object y)
        {
            return (new CaseInsensitiveComparer()).Compare(((Client)x).Code, ((Client)x).Code);
        }
    }
    public class Generator
    {


        public static String newCode(ArrayList arrayList, String prefix)
        {
            Client client = null;
            Loan loan = null;
            if (arrayList != null && arrayList.Count != 0)
            {
                if (arrayList[0] is Client) {

                    arrayList.Sort(new ComparatorClientByCode());
                    client = (Client)arrayList[arrayList.Count - 1];
                    Int32 preValue = Int32.Parse(client.Code.Replace("CT", ""));

                    Int32 posValue = preValue + 1;

                    return "CT" + posValue;
                }
                else if(arrayList[0] is Loan)
                {
                    arrayList.Sort(new ComparatorLoanByCode());
                    loan = (Loan)arrayList[arrayList.Count - 1];

                    Int32 preValue = Int32.Parse(loan.Code.Replace("LN", ""));

                    Int32 posValue = preValue + 1;

                    return "LN" + posValue;
                }
                else
                {
                    MessageBox.Show("Unknown array!");
                }
            }
            else
            {
                Message.showErrorMessage("newCode", new Exception("Empty array!"));
                return prefix + 1;
            }
            return null;
        }
    }
}
