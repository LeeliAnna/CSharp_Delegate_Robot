using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Delegate_Robot.Models
{
    internal class Robot
    {
        //Créer une class Robot qui a :

        #region Propriétés
        //pour propriétés en lecture seule:

        //PositionX type entier : Représente la position du robot sur un axe horizontal(entre 0 et Width)
        //PositionY type entier : Représente la position du robot sur un axe vertical(entre 0 et Height)
        //Direction type Direction : Repésente l'axe de direction que le robot regarde (une énumération contenant Nord, Est, Sud, Ouest défini la direction)
        //Grille type Grille : Représente la grille sur laquelle le robot se promène. 
        #endregion

        #region Méthodes
        //pour méthodes publiques :

        //Avancer
        //Aucun paramètre nécessaire, et ne retourne rien : Permet de faire d'avancer le robot dans l'axe qu'il regarde.
        //TournerGauche
        //Aucun paramètre nécessaire, et ne retourne rien : Permet de changer la direction du robot vers la gauche.
        //TournerDroite
        //Aucun paramètre nécessaire, et ne retourne rien : Permet de changer la direction du robot vers la droite.
        //EnregistrerOrdre
        //Un paramètre de type OrdreRobot, et ne retourne rien : permet de sauvegarder une action du robot associer à un ordre.
        //(OrdreRobot est une énumération contenant : Avancer, Gauche, Droite)
        //Executer
        //Aucun paramètre nécessaire, et ne retourne rien : Permet de lancer plusieurs ordre au robot qui ont été défini par l'utilisateur. 
        #endregion
    }
}
