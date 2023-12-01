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
        public int Width {get; private set;} = 10;

        // Definition de la hauteur de la grille toujours positive
        public int Height { get; private set; } = 10;

        //Représente la position du point final à atteindre sur un axe horizontal(entre 0 et Width)
        private int _finalX;
        public int FinalX 
        {
            get { return _finalX; }
            private set 
            {
                _finalX = value;  
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
                _finalY = value;
            }
        }

        private string[,] grille = new string[11,11];
        #endregion

        #region MyRegion

        #endregion

        #region Méthodes
        //pour méthodes publiques :

        //InitGame
        //Aucun paramètre, ni retour : Permet d'initialiser le jeu en créant un Robot en position 0,0 sur la grille et de définir un point final aléatoire à atteindre. 

        public void InitGame()
        {
            int randWidth;
            int randHeight;
            do
            {
                randWidth = new Random().Next(0 , 11);
                randHeight = new Random().Next(0 , 11);
            } while (randWidth == 0 && randHeight == 0);

            FinalX = randWidth;
            FinalY = randHeight;
            
            grille[0, 0] = "R";
            grille[FinalX, FinalY] = "X";

            for (int i = 0; i < Height - 1; i++)
            {
                for (int j = 0; j < Width - 1; j++)
                {
                    if (grille[i, j] != "r" && grille[i,j] != "x")
                    {
                        grille[i, j] = "y";
                    }
                }
            }


            

        }

        public void AfficherGrille()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //Affichage haut grille
            Console.Write("┏━━");
            for (int i = 0; i < Width - 1 ; i++)
            {
                Console.Write("━━┳━━");
            }
            Console.WriteLine("━━┓");


            for (int i = 0; i <= Height - 1 ; i++)
            {
                for (int j = 0; j <= Width; j++)
                {
                    if (j == 0)
                    {
                       Console.Write("┃" + grille[i,j]);
                    }
                    else
                    {
                        Console.Write(grille[i, j] + " ┃");
                    }
                    if(j == Width)
                    {
                        if (i < Height - 1)
                        {
                            Console.Write("\n┣━━");
                            for (int k = 0; k <= Width - 2; k++)
                            {
                                Console.Write("━━╋━━");
                            }
                            Console.Write("━━┫");
                            
                        }
                        
                    }
                    
                }
                Console.WriteLine();

            }

            //Affiche bas grille
            Console.Write("┗━━");
            for (int i = 0; i < Width - 1; i++)
            { 
                Console.Write("━━┻━━");
            }
            Console.WriteLine("━━┛");
        }

        #endregion
    }
}
