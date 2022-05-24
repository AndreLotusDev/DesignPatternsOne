using Adapter.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Devices
{
    public class Vga : IVGA
    {
        public void SetImage(string image)
        {
            Console.WriteLine($"Esta é uma image: {image}");
        }
    }
}
