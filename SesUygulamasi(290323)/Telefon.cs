using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace SesUygulamasi_290323_
{
    internal abstract class Telefon
    {
        public virtual void SesCal()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\İREM İLGİN\Desktop\ses\default.wav");
            simpleSound.Play();

        }
    }
}
