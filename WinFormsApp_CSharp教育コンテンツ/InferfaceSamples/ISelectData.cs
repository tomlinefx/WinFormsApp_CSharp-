using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp_CSharp教育コンテンツ.InferfaceSamples
{
    public interface ISelectData
    {
        List<string> GetList(string name);
    }
}
