using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SesUygulamasi_290323_
{
    internal class Samsung : Telefon
    {
        public override void SesCal()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\İREM İLGİN\Desktop\ses\samsung.wav");
            simpleSound.Play();
        }
    }
}
