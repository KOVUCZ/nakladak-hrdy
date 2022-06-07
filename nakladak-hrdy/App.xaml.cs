using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace nakladak_hrdy
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    
    
        public class Nakladak
        {
            public string název = "";
            public int nosnost { get; set; }

            public int Spotřeba_Nádrže { get; set; }

            public int ObjemNadrze { get; set; }

            public int CelkováVzdalenost { get; set; }

            public int náklad { get; set; }

            public Nakladak()
            {
                název = "";
                nosnost = 25000;
                náklad = 0;
                ObjemNadrze = 1000;
                Spotřeba_Nádrže = 25;
                CelkováVzdalenost = 0;
            }

            public void jet()
            {
                CelkováVzdalenost += 100;
                ObjemNadrze -= 25;
                if (ObjemNadrze <= 0)
                {
                    ObjemNadrze = 0;
                    CelkováVzdalenost -= 100;
                }
            }

            public void natankovat()
            {
                ObjemNadrze += 100;
                if (ObjemNadrze >= 1000)
                {
                    ObjemNadrze = 1000;
                }
            }

            public void naložit()
            {
                náklad += 1000;
                if (náklad >= 25000)
                {
                    náklad = 25000;
                }
            }

            public void vyložit()
            {
                náklad -= 1000;
                if (náklad <= 0)
                {
                    náklad = 0;
                }
            }

        }
    }



