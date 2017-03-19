using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParexasAnxo.Clases
{
    class Partida
    {

        public int tamanoColFil
        {
            get { return mtamanoColFil; }
            set { mtamanoColFil = value; }
        }

        public int contMovementos
        {
            get { return mContMovementos; }
            set { mContMovementos = value; }
        }

        public int contCantidadCartasXiradas
        {
            get { return mContCantidadCartasXiradas; }
            set { mContCantidadCartasXiradas = value; }
        }

        public List<Carta> listaCartas
        {
            get { return mCartasEnumeradas; }
            set { mCartasEnumeradas = value; }
        }
        public List<Carta> cartasBaraxadas
        {
            get { return mCartasBaraxadas; }
            set { mCartasBaraxadas = value; }
        }





        public Partida(int tamanoColFil, int contMovementos, int contCantidadCartasXiradas)
        {
            this.tamanoColFil = tamanoColFil;
            this.contMovementos = contMovementos;
            this.contCantidadCartasXiradas = contCantidadCartasXiradas;
            this.listaCartas = new List<Carta>();
            this.cartasBaraxadas = new List<Carta>();
        }

        private int mtamanoColFil;
        private int mContMovementos;
        private int mContCantidadCartasXiradas = 0;
        private List<Carta> mCartasEnumeradas;
        private List<Carta> mCartasBaraxadas;
    }
}
