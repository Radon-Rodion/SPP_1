using System;
using SortLibrary;
//using static SortLibrary.Class1;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using SPP1_GUI;

namespace SPP_1
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                Application.SetHighDpiMode(HighDpiMode.SystemAware);
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
                //throw new Exception("NArgs must be 2: input and output files' addresses!");
            }
            Class1.ProcessFile(args[0], args[1]);
        }
    }
}
