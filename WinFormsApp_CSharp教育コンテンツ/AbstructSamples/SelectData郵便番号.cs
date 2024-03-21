using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp_CSharp教育コンテンツ.AbstructSamples
{
    public class SelectData郵便番号 : FileProcess
    {
        public override List<string> SelectData(string name)
        {
            return new List<string>() { "TEST" };
        }
    }
}
