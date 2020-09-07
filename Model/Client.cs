using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestão_de_Emprestimos.Model
{
    public class Client
    {
        private String code;
        private String name;
        private String genre;
        private String contact_1;
        private String contact_2;
        private String adress;
        private String numberBi;
        private String nuit;
        private String email;
        private DateTime bornDate;
        private ArrayList loan;
        private Boolean deleted;

        public Client() { }

        public Client( string name, string genre, string contact_1, string contact_2, string adress, string numberBi, string nuit, string email, DateTime bornDate)
        {
            
            this.Name = name;
            this.Genre = genre;
            this.Contact_1 = contact_1;
            this.Contact_2 = contact_2;
            this.Adress = adress;
            this.NumberBi = numberBi;
            this.Nuit = nuit;
            this.Email = email;
            this.BornDate = bornDate;
        }
        public Client(string code, string name, string genre, string contact_1, string contact_2, string adress, string numberBi, string nuit, string email, DateTime bornDate)
        {
            this.Code = code;
            this.Name = name;
            this.Genre = genre;
            this.Contact_1 = contact_1;
            this.Contact_2 = contact_2;
            this.Adress = adress;
            this.NumberBi = numberBi;
            this.Nuit = nuit;
            this.Email = email;
            this.BornDate = bornDate;
        }

        public Client(string name, string genre, string contact_1, string contact_2, string adress, string numberBi, string nuit, string email, DateTime bornDate, ArrayList loan)
        {
            this.name = name;
            this.genre = genre;
            this.contact_1 = contact_1;
            this.contact_2 = contact_2;
            this.adress = adress;
            this.numberBi = numberBi;
            this.nuit = nuit;
            this.email = email;
            this.bornDate = bornDate;
            this.loan = loan;
        }

        public Client(string code, string name, string genre, string contact_1, string contact_2, string adress, string numberBi, string nuit, string email, DateTime bornDate, ArrayList loan)
        {
            this.code = code;
            this.name = name;
            this.genre = genre;
            this.contact_1 = contact_1;
            this.contact_2 = contact_2;
            this.adress = adress;
            this.numberBi = numberBi;
            this.nuit = nuit;
            this.email = email;
            this.bornDate = bornDate;
            this.loan = loan;
        }

        override
        public String ToString()
        {
            return "Client{\n" +
                "Code:" + this.code +
                "\nName: " + this.name +
                "\nGenre: " + this.genre +
                "\nContacts: " + this.contact_1 + ", " + this.contact_2 +
                "\nAdress: " + this.adress +
                "\nBorn Date: " + Util.Convert.dateTimeToString(this.bornDate, null) + 
                "\nNumber of BI: " + this.numberBi +
                "\nNUIT: " + this.nuit
                + "\n}";
        }

        //Getters and Setters
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

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Genre
        {
            get
            {
                return genre;
            }

            set
            {
                genre = value;
            }
        }

        public string Contact_1
        {
            get
            {
                return contact_1;
            }

            set
            {
                contact_1 = value;
            }
        }

        public string Contact_2
        {
            get
            {
                return contact_2;
            }

            set
            {
                contact_2 = value;
            }
        }

        public string Adress
        {
            get
            {
                return adress;
            }

            set
            {
                adress = value;
            }
        }

        public string NumberBi
        {
            get
            {
                return numberBi;
            }

            set
            {
                numberBi = value;
            }
        }

        public string Nuit
        {
            get
            {
                return nuit;
            }

            set
            {
                nuit = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public DateTime BornDate
        {
            get
            {
                return bornDate;
            }

            set
            {
                bornDate = value;
            }
        }

        public ArrayList Loan
        {
            get
            {
                return loan;
            }

            set
            {
                loan = value;
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
    }
}
