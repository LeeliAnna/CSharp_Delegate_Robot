using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp_Delegate_Robot.Enums;

namespace CSharp_Delegate_Robot.Models
{
    public interface RobotUI
    {
        //        pour méthodes publiques :

        
        
        

        #region Méthodes

        public void AfficherMessage(Robot robot, RobotEventArgs eventRobot)
        {
            //AfficherMessage
            //avec en paramètre un Robot et un RobotEventArgs, et ne retourne rien.
            //Il permet l'affichage d'un message coloré selon le type de message.

        }

        public void RefreshGrille(Robot robot, RobotEventArgs eventRobot) 
        {
            //RefreshGrille
            //avec en paramètre un Robot et un RobotEventArgs, et ne retourne rien.
            //Il permet d'effacer la console et de réaffichez la grille.

        }

        public OrdreRobot MenuRobot() 
        {
            //MenuRobot
            //avec aucun paramètre et retourne un RobotOrdre.
            //Avec un affichage en console, il permet de définir un mouvement que le robot va effectuer lors de l'exécution.
            OrdreRobot ordre = new OrdreRobot();

            return ordre; }


        #endregion
    }
}
