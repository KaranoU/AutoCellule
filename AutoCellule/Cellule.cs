using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCellule
{
    class Cellule
    {
        protected bool Etat = true;//etat de la cellule(true = blanc)

        protected int CoordoX;//coordonnées de la cellule 

        protected int CoordoY;

        public Cellule()// par defaut
        {
            this.CoordoX = 0;
            this.CoordoY = 0;
        }

        public Cellule(int x,int y)//placement de cellules blanches
        {
            this.CoordoX = x;
            this.CoordoY = y;
        }
    }
}
