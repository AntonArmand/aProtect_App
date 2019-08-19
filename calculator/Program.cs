using aProtect;
using System;
using System.Threading;
using System.Windows.Forms;

namespace calculator
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            /**Thread t1 = new Thread(() =>
            {
                DateTime nextCheck = DateTime.Now.AddSeconds(3);
                int numberOfSeconds = 0;
                bool threadOn = true;
                while (threadOn)
                {
                    nextCheck = DateTime.Now.AddSeconds(3);
                    Console.WriteLine("1");
                    if ((licence.checkLicence()) && !calc.Visible)
                    {
                        Console.WriteLine("2");

                        threadOn = false;
                    }
                    Thread.Sleep(1000);
                    numberOfSeconds++;
                }


                Console.WriteLine("I ran for 5 seconds");

            });
            t1.Start();
            if(licence.checkLicence())
            {
                calc.Show();
            }**/

            Application.Run(new calculatorForm());

        }
    }
}
