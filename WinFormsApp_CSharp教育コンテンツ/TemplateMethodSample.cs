using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp_CSharp教育コンテンツ
{
    public class TemplateMethodSample
    {
        public TemplateMethodSample()
        {
            var inst町名 = new 町名抽出();
            var inst郵便 = new 郵便番号抽出();

            inst町名.Start("東町");
            inst郵便.Start("880129");

            // TEST
        }
    }


    public class 町名抽出 : FileProcess
    {
        public override List<string> SelectData(string name)
        {
            return new List<string>() { "TEST" };
        }
    }

    public class 郵便番号抽出 : FileProcess
    {
        public override List<string> SelectData(string name)
        {
            return new List<string>() { "TEST" };
        }
    }


    public abstract class FileProcess
    {
        public void Start(string name)
        {
            ReadFile();

            SelectData(name);

            WriteFile();

            DisplayData();
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


        void DisplayData()
        {
            Debug.WriteLine("抽出データ画面表示");
        }
    }
}
