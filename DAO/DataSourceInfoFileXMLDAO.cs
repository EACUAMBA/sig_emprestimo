using Gestão_de_Emprestimos.DAO.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gestão_de_Emprestimos.Model;
using System.IO;
using Gestão_de_Emprestimos.Util;

namespace Gestão_de_Emprestimos.DAO
{
    public class DataSourceInfoFileXMLDAO : IDataSourceInfoXMLFileDAO
    {

        public Boolean createAndWriteXMLFile(DataSourceInfo dataSourceInfo)
        {

            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/SIG Emprestimos";
            try
            {
                System.Xml.Serialization.XmlSerializer writer = new System.Xml.Serialization.XmlSerializer(typeof(DataSourceInfo));
                System.IO.Directory.CreateDirectory(path);
                System.IO.FileStream file = System.IO.File.Create(path + "/DataSourceInfoFile.xml");

                writer.Serialize(file, dataSourceInfo);

                file.Flush();
                file.Close();

                return true;
            }
            catch (Exception ex)
            {
                if (ex is IOException || ex is PathTooLongException)

                    Message.showErrorMessage("creating and saving new XML DataSourceInfo File in your computer", ex);

            }

            return false;
        }



        public DataSourceInfo readXMLFile()
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/SIG Emprestimos";
            try
            {
                System.Xml.Serialization.XmlSerializer reader = new System.Xml.Serialization.XmlSerializer(typeof(DataSourceInfo));
                System.IO.Directory.CreateDirectory(path);
                
                System.IO.StreamReader file = new System.IO.StreamReader(path + "/DataSourceInfoFile.xml");

                DataSourceInfo dataSourceInfo = (DataSourceInfo)reader.Deserialize(file);
                
                file.Close();

                return dataSourceInfo;
            }
            catch (IOException ex)
            {
                Message.showErrorMessage("read XML DataSourceInfo File in your computer", ex);
            }
            return null;
        }

    }
}
