using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp_CSharp教育コンテンツ.InferfaceSamples
{
    public class SelectData町名 : ISelectData
    {
        public SelectData町名()
        {

        }

        public List<string> GetList(string name)
        {
            return new List<string>();
        }
    }
}
