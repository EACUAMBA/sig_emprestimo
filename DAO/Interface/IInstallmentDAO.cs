using Gestão_de_Emprestimos.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestão_de_Emprestimos.DAO.Interface
{
    public interface IInstallmentDAO
    {
        Boolean save(Installment installment);
        Boolean update(Installment installment);
        Boolean delete(Int32 code, String loanCode);
        Installment findByCode(String code);
        ArrayList findByCodeAndLoanCode(Int32 code, String loanCode);
        ArrayList list();
    }
}
