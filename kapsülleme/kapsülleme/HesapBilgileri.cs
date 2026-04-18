using System;
using System.Collections.Generic;
using System.Text;

namespace kapsülleme
{
    internal class HesapBilgileri
    {
        private double hesapToplami = 15000000;

        public double HesapToplami
        {
            get { return hesapToplami; }
            set {
                if (value<=hesapToplami&&value>0)
                    hesapToplami = value;
            }
        }
    }
}
