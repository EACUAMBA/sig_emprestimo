using Gestão_de_Emprestimos.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestão_de_Emprestimos.DAO.Interface
{
    public interface IDataSourceInfoXMLFileDAO
    {
        Boolean createAndWriteXMLFile(DataSourceInfo dataSourceInfo);
        DataSourceInfo readXMLFile();

    }
}
