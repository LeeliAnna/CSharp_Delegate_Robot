using CSharp_Delegate_Robot.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Delegate_Robot.Models
{
    //public delegate void RobotAction();
    public class Robot
    {
        #region Champs
        private int _positionX;
        private int _positionY;

        //private RobotAction _mouvement;
        private Action _mouvement;

        public Action<object , RobotEventArgs> robotEvent;
        #endregion

        #region Propriétés

        public int PositionX
        {
            get { return _positionX; }
            private set
            {
                if (value < 0) robotEvent?.Invoke(this, new RobotEventArgs(MessageType.Erreur, "Aoutch, un mur!"));

                if (value >= Grille.Width) robotEvent?.Invoke(this, new RobotEventArgs(MessageType.Erreur, "Aoutch, un mur!"));

                _positionX = value;
            }
        }
        public int PositionY
        {
            get { return _positionY; }
            private set
            {
                if (value < 0) robotEvent?.Invoke(this, new RobotEventArgs(MessageType.Erreur, "Aoutch, un mur!"));
                if (value >= Grille.Height) robotEvent?.Invoke(this, new RobotEventArgs(MessageType.Erreur, "Aoutch, un mur!"));

                _positionY = value;
            }
        }

        public Direction Direction { get; private set; }

        public Grille Grille { get; private set; }
        #endregion

        #region Constructeur

        public Robot(int psotionX, int positionY, Grille grille)
        {
            Grille = grille;
            PositionX = psotionX;
            PositionY = positionY;
            Direction = Direction.Droite;
            
        }

        #endregion

        #region Méthodes

        public void Avancer() 
        {
            switch (Direction)
            {
                case Direction.Haut:
                    {
                        PositionY++;
                        break;
                    }
                case Direction.Bas:
                    {
                        PositionY--;
                        break;
                    }
                case Direction.Droite:
                    {
                        PositionX--;
                        break;
                    }
                case Direction.Gauche:
                    {
                        PositionX++;
                        break;
                    }
            }
            robotEvent?.Invoke(this, new RobotEventArgs(MessageType.Info, $"Se dirige vers le {Direction}."));
        }

        public void TournerGauche() 
        {
            if ((int)Direction == 0)
            {
                Direction = Direction.Gauche;
            }
            else
            {
                Direction -= 1;
            }
            robotEvent?.Invoke(this, new RobotEventArgs(MessageType.Info, $"Tourne à gauche en direction du {Direction}."));

        }

        public void TournerDroite() 
        {
            if ((int)Direction == 0)
            {
                Direction = Direction.Droite;
            }
            else
            {
                Direction += 1;
            }
            robotEvent?.Invoke(this, new RobotEventArgs(MessageType.Info, $"Tourne à droite en direction du {Direction}."));
        }

        public void EnregistrerOrdre(OrdreRobot ordre) 
        {
            //EnregistrerOrdre
            //Un paramètre de type OrdreRobot, et ne retourne rien : permet de sauvegarder une action du robot associer à un ordre.
            //(OrdreRobot est une énumération contenant : Avancer, Gauche, Droite)
            //if ((int)ordre == 0)
            //{
            //    _mouvement += Avancer;
            //}
            //else if ((int)ordre == 1)
            //{
            //    _mouvement += TournerGauche;
            //}
            //else if ((int)ordre == 2) 
            //{
            //    _mouvement += TournerDroite;
            //}

            switch (ordre)
            {
                case OrdreRobot.Avancer:
                    _mouvement += Avancer;
                    break;
                case OrdreRobot.Gauche:
                    _mouvement += TournerGauche;
                    break;
                case OrdreRobot.Droite:
                    _mouvement += TournerDroite;
                    break;
            }
            robotEvent?.Invoke(this, new RobotEventArgs(MessageType.Info, "Mouvement enregistré!"));
        }

        public void Executer() 
        {
            //Executer
            //Aucun paramètre nécessaire, et ne retourne rien : Permet de lancer plusieurs ordre au robot qui ont été défini par l'utilisateur. 
            //int choix;
            //do
            //{
            //    Console.WriteLine("Que voulez-vous enregistrer comme action?");
            //    Console.WriteLine("1 - Le faire avancer");
            //    Console.WriteLine("2 - Le faire tourner à gauche");
            //    Console.WriteLine("3 - Le faire tourner à droite");
            //    Console.WriteLine("4 - Executer les ordres enregistrés.");
            //    Console.WriteLine("5 - Quitter");
            //    do
            //    {
            //        choix = int.Parse(Console.ReadLine());
            //    } while (!int.TryParse(Console.ReadLine(), out _));
            //} while (choix != 5);

            if (_mouvement is null) throw new NullReferenceException("Pas d'ordre enregistrer...");
            _mouvement();
            robotEvent?.Invoke(this, new RobotEventArgs(MessageType.Info, "Début du processus."));
        }

        #endregion
    }
}
