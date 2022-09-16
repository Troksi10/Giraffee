using System;
using System.Collections.Generic;
using System.Text;

namespace Giraffee
{
    public class Italian_Chef : Chef
    {
        public void MakePasta()
        {
            Console.WriteLine("The Chef makes pasta");
        }

        public override void MakeSpecialDish()
        {
            Console.Write("The chef makes chicken parm");
        }
    }
}
