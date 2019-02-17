using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace canvasproject
{
    class client
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MyCanvas.CreateNewButton(2, 4, 6, 8));
            Console.WriteLine(MyCanvas.CreateNewButton(3, 5, 7, 9));
            Console.WriteLine(MyCanvas.CreateNewButton(1, 2, 3, 4));
            Console.WriteLine(MyCanvas.GetCurrentNumberOfButtons());
            Console.WriteLine(MyCanvas.GetMaxNumberOfButtons());
            Console.WriteLine(MyCanvas.GetMaxWidthOffAButton());
            Console.WriteLine(MyCanvas.GetMaxHeightOffAButtoon());
        }  
    }
}
