using Gestão_de_Emprestimos.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestão_de_Emprestimos.DAO.Interface
{
    public interface ILoanDAO
    {
        Boolean save(Loan loan);
        Boolean update(Loan loan);
        Boolean delete(Loan loan);
        Loan findByCode(String code, String clientCode);
        ArrayList list();
        ArrayList findByClientCode(String clientCode);
    }
}
