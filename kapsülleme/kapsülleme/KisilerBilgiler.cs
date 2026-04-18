using System;
using System.Collections.Generic;
using System.Text;

namespace kapsülleme
{
    internal class KisilerBilgiler
    {
        private string ad = "Davut";
        private string soyad = "Kızılkaya";
        private int tcNo = 1234567890;

        private bool bilgiler = false; 

        public string Ad
        {
            get { return ad; }
            
        }
        public string Soyad { 
            get { return soyad; } 

        }
        public int TcNo { 
            get { return tcNo; } 
        }
         public bool Bilgiler
        {
            get { return bilgiler; }
            set { bilgiler = value; }
        }


    }
}
