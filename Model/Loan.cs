using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestão_de_Emprestimos.Model
{
    public class Loan
    {
        private String code;
        private String clientCode;
        private Double capital;
        private DateTime startDate;
        private DateTime endDate;
        private Byte percent;
        private Double residualValue;
        private Boolean paid;
        private Boolean deleted;
        private String message;
        private ArrayList installment;

        public Loan() { }

        public Loan(string clientCode, double capital, DateTime startDate, DateTime endDate, byte percent, double residualValue, bool paid)
        {
            
            
            this.capital = capital;
            this.startDate = startDate;
            this.endDate = endDate;
            this.percent = percent;
            this.residualValue = residualValue;
            this.paid = paid;
            
        }
        public Loan(string code, string clientCode, double capital, DateTime startDate, DateTime endDate, byte percent, double residualValue, bool paid)
        {
            this.code = code;
            this.clientCode = clientCode;
            this.capital = capital;
            this.startDate = startDate;
            this.endDate = endDate;
            this.percent = percent;
            this.residualValue = residualValue;
            this.paid = paid;
            
        }
        public Loan(string clientCode, double capital, DateTime startDate, DateTime endDate, byte percent, double residualValue, bool paid, ArrayList installment)
        {
            
            this.clientCode = clientCode;
            this.capital = capital;
            this.startDate = startDate;
            this.endDate = endDate;
            this.percent = percent;
            this.residualValue = residualValue;
            this.paid = paid;
            this.installment = installment;
        }
        public Loan(string code, string clientCode, double capital, DateTime startDate, DateTime endDate, byte percent, double residualValue, bool paid, ArrayList installment)
        {
            this.code = code;
            this.clientCode = clientCode;
            this.capital = capital;
            this.startDate = startDate;
            this.endDate = endDate;
            this.percent = percent;
            this.residualValue = residualValue;
            this.paid = paid;
            this.installment = installment;
        }

        public string Code
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

        public string ClientCode
        {
            get
            {
                return clientCode;
            }

            set
            {
                clientCode = value;
            }
        }

        public double Capital
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

        public DateTime StartDate
        {
            get
            {
                return startDate;
            }

            set
            {
                startDate = value;
            }
        }

        public DateTime EndDate
        {
            get
            {
                return endDate;
            }

            set
            {
                endDate = value;
            }
        }

        public byte Percent
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

        public double ResidualValue
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

        public ArrayList Installment
        {
            get
            {
                return installment;
            }

            set
            {
                installment = value;
            }
        }

        public bool Deleted
        {
            get
            {
                return deleted;
            }

            set
            {
                deleted = value;
            }
        }

        public string Message
        {
            get
            {
                return message;
            }

            set
            {
                message = value;
            }
        }

        override
        public String ToString()
        {
            return "Loan:{\nCode: " +
                this.code + "\nCliente Code: " +
                this.clientCode + "\nCapital: " +
                this.capital + "\nPercent: " +
                this.percent + "\nStart Date: " +
                Util.Convert.dateTimeToString(this.startDate, null) + "\nEnd Date: " +
                Util.Convert.dateTimeToString(endDate, null) + "\nResidual Value: " +
                this.residualValue + "\n}"; 

        }
    }
}
