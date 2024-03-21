using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp_CSharp教育コンテンツ.AbstructSamples
{
    public abstract class FileProcess
    {
        public void Start(string name)
        {
            ReadFile();

            SelectData(name);

            WriteFile();
        }

        void ReadFile()
        {
            Console.WriteLine("沖縄CSVファイル読込");
        }

        public abstract List<string> SelectData(string name);


        void WriteFile()
        {
            Debug.WriteLine("抽出データCSVファイル保存");
        }
    }
}
