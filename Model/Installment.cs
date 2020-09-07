using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestão_de_Emprestimos.Model
{
    public class Installment
    {
        private Int32 code;
        private String loanCode;
        private Double value;
        private DateTime dateToPay;
        private Boolean paid;

        public Installment() { }
        public Installment(string loanCode, double value, DateTime dateToPay, bool paid)
        {
            this.loanCode = loanCode;
            this.value = value;
            this.dateToPay = dateToPay;
            this.paid = paid;
        }

        public Installment(int code, string loanCode, double value, DateTime dateToPay, bool paid)
        {
            this.code = code;
            this.loanCode = loanCode;
            this.value = value;
            this.dateToPay = dateToPay;
            this.paid = paid;
        }

        public Installment(int code, string loanCode, double value, DateTime dateToPay)
        {
            this.code = code;
            this.loanCode = loanCode;
            this.value = value;
            this.dateToPay = dateToPay;
        }

        override
        public String ToString()
        {
            return "Installment{\nCode or Nmmber:" + this.code +
                "\nLoan Code: " + this.loanCode +
                "\nValue: " + this.value +
                "\nDate To Pay: " + Util.Convert.dateTimeToString(this.dateToPay, "dd / MMMM / yyyy") +
                "\nPaid: " + Util.Convert.paidBooleanToStringPT_PT(this.paid);   
        }

        public int Code
        {
            get
            {
                return code;
            }

            set
            {
                code = value;
            }
        }

        public string LoanCode
        {
            get
            {
                return loanCode;
            }

            set
            {
                loanCode = value;
            }
        }

        public double Value
        {
            get
            {
                return value;
            }

            set
            {
                this.value = value;
            }
        }

        public DateTime DateToPay
        {
            get
            {
                return dateToPay;
            }

            set
            {
                dateToPay = value;
            }
        }

        public bool Paid
        {
            get
            {
                return paid;
            }

            set
            {
                paid = value;
            }
        }
    }
}
