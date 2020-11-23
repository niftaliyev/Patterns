using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyChat
{
    static class Program
    {


        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            
            Form1 Forma = new Form1();

            new ChatMediator(Forma);

            Application.Run(Forma);
        }
    }
}
