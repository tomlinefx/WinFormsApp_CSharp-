using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp_CSharp教育コンテンツ.InferfaceSamples
{
    public class InterfaceSample
    {
        public InterfaceSample() 
        {
            var inst町名 = new SelectData町名();
            var inst郵便 = new SelectData郵便番号();

            var proc町名 = new FileProcess(inst町名);
            proc町名.Start("東町");

            var proc郵便 = new FileProcess(inst郵便);
            proc郵便.Start("880129");
        }
    }
}
