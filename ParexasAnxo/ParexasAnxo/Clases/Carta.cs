using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParexasAnxo.Clases
{
    class Carta
    {

        public int idCarta {
            get { return mIdCarta; }
            set { mIdCarta = value; }
        }

        public string rutaImagenReverso {
            get { return mRutaImagenReverso; }
            set { mRutaImagenReverso = value; }
        }
        public string rutaImagen {
            get { return mRutaImagen; }
            set { mRutaImagen = value; }
        }
        public Carta(int idCarta, string rutaImagenReverso, string rutaImagen)
        {
            this.idCarta = idCarta;
            this.rutaImagenReverso = rutaImagenReverso;
            this.rutaImagen = rutaImagen;
        }

        private int mIdCarta;
        private string mRutaImagenReverso;
        private string mRutaImagen;



    }
}
