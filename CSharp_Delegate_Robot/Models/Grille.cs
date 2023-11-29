using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Delegate_Robot.Models
{
    internal class Grille
    {
        #region Propriétés

        // Definition de la largeur de la grille toujours positive
        public int Width 
        {
            get { return Width; }
            private set 
            {
                Width = 10;
            }
        }

        // Definition de la hauteur de la grille toujours positive
        public int Height 
        {
            get { return Height; }
            private set
            {
                Height = 10;
            }
        }

        //Représente la position du point final à atteindre sur un axe horizontal(entre 0 et Width)
        private int _finalX;
        public int FinalX 
        {
            get { return _finalX; }
            private set 
            { 
                if (value > 0 && value < Width) 
                { 
                    _finalX = value; 
                }; 
            } 
        }

        //Représente la position du point final à atteindre sur un axe veritcal(entre 0 et Height)
        private int _finalY;
        public int FinalY 
        {
            get
            {
                return _finalY;
            }
            private set 
            {
                if( value > 0 && value < Height)
                {
                    _finalY = value;
                }
            }
        }
        #endregion


        #region Méthodes
        //pour méthodes publiques :

        //InitGame
        //Aucun paramètre, ni retour : Permet d'initialiser le jeu en créant un Robot en position 0,0 sur la grille et de définir un point final aléatoire à atteindre. 

        public void InitGame()
        {

        }

        public void AfficherGrille()
        {
            for (int i = 0; i < Width; i++)
            {
                Console.WriteLine("----------------------------------");
                for (int j = 0; j < Height; j++)
                {
                    Console.WriteLine("|  |");
                }
            }
        }

        #endregion
    }
}
