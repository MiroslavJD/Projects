using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProcessGo1.UsingDLL;
using WebAppProcessGo1;
using ProcessGo1Service;
using System.ServiceProcess;



namespace ProcessGo
{
    public partial class Form1 : Form
    {
        public void CallingParameters()
        {
            string[] passedInArgs = Environment.GetCommandLineArgs();

            foreach (string s in passedInArgs)
            {

                if (passedInArgs.Contains("-z"))
                {
                    ProcessGo1.UsingDLL.Class1 openfile = new ProcessGo1.UsingDLL.Class1();
                    openfile.UnsortedText();
                    MessageBox.Show("This is the unsorted file, let's see the sorted file.");
                }
                else if (passedInArgs.Contains("-x"))
                {
                    ProcessGo1.UsingDLL.Class1 opensortedfile = new ProcessGo1.UsingDLL.Class1();
                    opensortedfile.SortedText();
                    MessageBox.Show("Sorted file.");
                }
            }
        }
        public void UnsortedFile()
        {
            string file = "UnsortedFile.txt";
            using (StreamWriter StrWriter = File.CreateText(file))
            {
                StrWriter.WriteLine("4");
                StrWriter.WriteLine("2");
                StrWriter.WriteLine("1");
                StrWriter.WriteLine("5");
                StrWriter.WriteLine("3");
                StrWriter.WriteLine("8");
                StrWriter.WriteLine("6");
                StrWriter.WriteLine("10");
                StrWriter.WriteLine("13");
                StrWriter.WriteLine("12");
                StrWriter.WriteLine("7");
                StrWriter.WriteLine("9");
                StrWriter.WriteLine("13");
                StrWriter.WriteLine("11");
            }
            using (StreamReader StrReader = File.OpenText(file))
            {
                string t = "";
                while ((t = StrReader.ReadLine()) != null)
                {
                    Console.WriteLine(t);
                }
            }
        }
        public void SortedFile()
        {
            string file = "SortedFile.txt";
            using (StreamWriter StrWriter = File.CreateText(file))
            {
                StrWriter.WriteLine("1");
                StrWriter.WriteLine("2");
                StrWriter.WriteLine("3");
                StrWriter.WriteLine("4");
                StrWriter.WriteLine("5");
                StrWriter.WriteLine("6");
                StrWriter.WriteLine("7");
                StrWriter.WriteLine("8");
                StrWriter.WriteLine("9");
                StrWriter.WriteLine("10");
                StrWriter.WriteLine("11");
                StrWriter.WriteLine("12");
                StrWriter.WriteLine("13");
            }
            using (StreamReader StrReader = File.OpenText(file))
            {
                string t = "";
                while ((t = StrReader.ReadLine()) != null)
                {
                    Console.WriteLine(t);
                }
            }
        }

        public Form1()
        {
            InitializeComponent();                         
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UnsortedFile();
            SortedFile();
            CallingParameters();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            WebAppProcessGo1.RandomNumberGeneratorService r = new WebAppProcessGo1.RandomNumberGeneratorService();

            int z = r.GetRandomNumbers().RandomNumber1;
            int x = r.GetRandomNumbers().RandomNumber2;
            int c = r.GetRandomNumbers().RandomNumber3;

            label1.Text = z.ToString();
            label2.Text = x.ToString();
            label3.Text = c.ToString();
        }
          private void Button2_Click(object sender, EventArgs e)
        {
            ProcessGo1Service.Service1 gg = new ProcessGo1Service.Service1();
            gg.CallService();
        }
    }
}
