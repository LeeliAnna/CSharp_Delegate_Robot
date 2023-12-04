using CSharp_Delegate_Robot.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Delegate_Robot.Models
{
    public class Grille
    {
        #region Champs
        private int _width;
        private int _height;

        private int _finalX;
        private int _finalY;

        private Robot _robot;
        private Random _rng;
        #endregion

        #region Propriétés

        // Definition de la largeur de la grille toujours positive
        public int Width
        {
            get { return _width; }
            private set 
            {
                if (value < 0) throw new ArgumentOutOfRangeException(nameof(Width));
                _width = value;
            }
        }

        // Definition de la hauteur de la grille toujours positive
        public int Height
        {
            get { return _height; }
            private set
            {
                if (value < 0) throw new ArgumentOutOfRangeException(nameof(Height));
                _height = value;
            }
        }

        //Représente la position du point final à atteindre sur un axe horizontal(entre 0 et Width)
        public int FinalX 
        {
            get { return _finalX; }
            private set 
            {
                if (value < 0) throw new ArgumentOutOfRangeException(nameof (FinalX));
                if (value >= Width) throw new ArgumentOutOfRangeException(nameof (FinalX));
                _finalX = value;  
            } 
        }

        //Représente la position du point final à atteindre sur un axe veritcal(entre 0 et Height)
        public int FinalY 
        {
            get
            {
                return _finalY;
            }
            private set 
            {
                if (value < 0) if (value < 0) throw new ArgumentOutOfRangeException(nameof(FinalY));
                if (value >= Height) throw new ArgumentOutOfRangeException(nameof(FinalY));
                _finalY = value;
            }
        }

        public Robot robot 
        {
            get { return _robot; } 
            private set
            {  if (value is null) throw new ArgumentNullException(nameof(Robot));
                _robot = value; }
         }

        public RobotUI UI { get; set; }


        #endregion

        #region Constructeur
        public Grille(int width, int height)
        {
            _rng = new Random();
            Width = width;
            Height = height;
        }
        #endregion

        #region Méthodes
        //pour méthodes publiques :

        //InitGame
        //Aucun paramètre, ni retour : Permet d'initialiser le jeu en créant un Robot en position 0,0 sur la grille et de définir un point final aléatoire à atteindre. 
        Grille[,] grille = new Grille[10,10];
        public void InitGame()
        {
            robot = new Robot(0, 0, this);
            FinalX = _rng.Next(Width);
            FinalY = _rng.Next(Height);

            //do
            //{

            //} while ((int)OrdreRobot. != 3);
            
            //int randWidth;
            //int randHeight;
            //do
            //{
                
            //    randWidth = new Random().Next(0 , 11);
            //    randHeight = new Random().Next(0 , 11);
            //} while (randWidth == 0 && randHeight == 0);

            //grille[0, 0] = "►";
            //grille[randWidth, randHeight] = "X";

            //for (int i = 0; i <= Height; i++)
            //{
            //    for (int j = 0; j <= Width; j++)
            //    {
            //        if (grille[i, j] != "►" && grille[i,j] != "X")
            //        {
            //            grille[i, j] = " ";
            //        }
            //    }
            //}

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

            for (int i = 0; i <= Height; i++)
            {
                for (int j = 0; j <= Width; j++)
                {
                    if (j == 0)
                    {
                        Console.Write("┃  " + grille[i,j]);
                    }
                    else
                    {   
                        if(j != Width)
                        {
                            Console.Write(" ┃  " + grille[i, j]);
                        }
                        else
                        {
                            Console.Write(grille[i,j] + "┃");
                        }
                    }
                    if(j == Width)
                    {
                        if (i <= Height - 1)
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
            Console.Write("━━┛");
            Console.WriteLine();
        }

        #endregion

        //Quand l'ensemble des actions seront terminées, alors exécuter la méthode CheckVictory de la Grille, si elle retourne True alors enclenchez l'event avec un message de Victoire : "Arrivé à bonne destination!", sinon avec un message d'Erreur : "N'a pas atteind la cible..."
    }
}
