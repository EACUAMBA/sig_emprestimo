using Gestão_de_Emprestimos.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestão_de_Emprestimos.DAO.Interface
{
    public interface IClientDAO
    {
        Boolean save(Client client);
        Boolean update(Client client);
        Boolean delete(String code);
        Client findByCode(String code);
        ArrayList list();
    }
}
