using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp_CSharp教育コンテンツ.AbstructSamples
{
    public class AbstructSample
    {
        public AbstructSample() 
        {
            var inst町名 = new SelectData町名();
            var inst郵便 = new 郵便番号抽出();

            inst町名.Start("東町");
            inst郵便.Start("880129");
        }
    }
}
