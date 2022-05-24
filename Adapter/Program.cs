using Adapter.Converter;
using Adapter.Devices;
using Adapter.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            IVGA vga = new Vga();

            IHDMI entradaHDMI = new HDMIToVGA(vga);
            //IHDMI entradaHDMI = new Hdmi();

            entradaHDMI.SetImage("Super mario bros");
            entradaHDMI.SetSound("Bethoven");

            Console.ReadLine();
        }
    }
}
