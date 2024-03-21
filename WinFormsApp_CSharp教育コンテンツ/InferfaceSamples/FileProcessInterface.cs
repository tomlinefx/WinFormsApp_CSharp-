using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp_CSharp教育コンテンツ.InferfaceSamples
{
    internal class FileProcessInterface
    {
        ISelectData SelectData { get; }
        public FileProcessInterface(ISelectData selectData)
        {
            SelectData = selectData;
        }

        public void Start(string name)
        {
            ReadFile();

            SelectData.GetList(name);

            WriteFile();

            DisplayData();
        }

        void ReadFile()
        {
            Console.WriteLine("沖縄CSVファイル読込");
        }


        void WriteFile()
        {
            Debug.WriteLine("抽出データCSVファイル保存");
        }


        void DisplayData()
        {
            Debug.WriteLine("抽出データ画面表示");
        }
    }
}
