using Adapter.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Devices
{
    public class Hdmi : IHDMI
    {
        public void SetImage(string image)
        {
            Console.WriteLine($"Esta é uma image: {image}");
        }

        public void SetSound(string sound)
        {
            Console.WriteLine($"Isto é um som: {sound}");
        }
    }
}
