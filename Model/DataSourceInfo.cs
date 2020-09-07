using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestão_de_Emprestimos.Model
{
    public class DataSourceInfo
    {
        public String path;
        public String url;


        public DataSourceInfo() { }
        public DataSourceInfo(string path, string url)
        {
            this.path = path;
            this.url = url;
        }

        public string Path
        {
            get
            {
                return path;
            }

            set
            {
                path = value;
            }
        }

        public string Url
        {
            get
            {
                return url;
            }

            set
            {
                url = value;
            }
        }
    }
}
