using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp_CSharp教育コンテンツ.InferfaceSamples
{
    internal class FileProcess
    {
        ISelectData SelectData { get; }
        public FileProcess(ISelectData selectData)
        {
            SelectData = selectData;
        }

        public void Start(string name)
        {
            ReadFile();

            SelectData.GetList(name);

            WriteFile();
        }

        void ReadFile()
        {
            Console.WriteLine("沖縄CSVファイル読込");
        }


        void WriteFile()
        {
            Debug.WriteLine("抽出データCSVファイル保存");
        }
    }
}
