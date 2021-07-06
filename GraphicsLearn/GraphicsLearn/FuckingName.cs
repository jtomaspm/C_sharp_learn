using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsLearn
{
    class FuckingGame
    {
        [STAThread]
        public static void notMain() 
        {
            FormWindow window = new FormWindow();
            Application.Run(window);
            Console.WriteLine(window.G == null); 
            Console.ReadKey();
        }
    }
}
