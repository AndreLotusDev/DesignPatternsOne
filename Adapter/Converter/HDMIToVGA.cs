using Adapter.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Converter
{
    public class HDMIToVGA : IHDMI
    {
        private readonly IVGA _ivga;
        public HDMIToVGA(IVGA vga)
        {
            _ivga = vga;
        }

        public void SetImage(string image)
        {
            _ivga.SetImage(image);
        }

        public void SetSound(string sound)
        {
            throw new NotImplementedException("VGA não pode sair som");
        }
    }
}
