using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessGo1.UsingDLL
{
    public class Class1
    {
        public void UnsortedText()
        {
            string path = "C:\\Users\\MiroslavJD1\\Desktop\\UnsortedFile.txt";
            Process.Start(path);
        }
        public void SortedText()
        {
            string path2 = "C:\\Users\\MiroslavJD1\\Desktop\\SortedFile.txt";
            Process.Start(path2);
        }
    }
}
