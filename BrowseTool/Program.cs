using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrowseTool
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main(string[] args)
        {
            int launch = args.Length;
            Console.Write("Args " + launch);
            if (launch < 1)
            {
                System.Windows.Forms.MessageBox.Show("No launch arguments provided", "BrowseTool");
                return;
            }

            if (args[0] == null)
            {
                System.Windows.Forms.MessageBox.Show("No adress provided", "BrowseTool");
                return;
            }


            if (args[1] == null)
            {
                System.Windows.Forms.MessageBox.Show("Terminate on open not provided", "BrowseTool");
                return;
            }

            string urlexecption = "";

            if (args[2] == null)
            {
                System.Windows.Forms.MessageBox.Show("Url exception not provided", "BrowseTool");
            }
            else
            {
                urlexecption = args[2];
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(args[0], Boolean.Parse(args[1]), urlexecption));

        }
    }
}
