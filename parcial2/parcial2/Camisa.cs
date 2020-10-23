using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcial2
{
    class Camisa : Prenda
    {
        private bool MangaCorta;

        public Camisa (bool calidad, int precio, int cantidad,bool MangaCorta ) : base (calidad,precio,cantidad)
        {
            this.MangaCorta = MangaCorta;
        }

        public bool MangaCorta1
        {
            get
            {
                return MangaCorta;
            }

            set
            {
                MangaCorta = value;
            }
        }

        public double calcularp (int precio, int cantidad)
        {
            int preciofinal=0 ;
            int mc = 0;
            int C = 0;

            if(MangaCorta == true)
            {
                mc = mc - (precio * 10) / 100;
            }

            if(calidad == true)
            {
                C = C + (precio * 30) / 100;
            }

            preciofinal =( C + mc + precio) * cantidad;
            return preciofinal;
        }







    }
}
