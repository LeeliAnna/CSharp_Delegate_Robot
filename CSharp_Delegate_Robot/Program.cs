using System.Drawing;
using System.Reflection.Metadata;
using System.Runtime.ConstrainedExecution;
using System.Threading.Channels;
using System;
using CSharp_Delegate_Robot.Models;

namespace CSharp_Delegate_Robot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //        Délégué: Robot
            //Créer une class Grille qui a :

            //pour propriétés en lecture seule :

            //Width type entier : représente la largeur de la grille(toujours positive)
            //Height type entier : représente la hauteur de la grille(toujours positive)
            //FinalX type entier : Représente la position du point final à atteindre sur un axe horizontal(entre 0 et Width)
            //FinalY type entier : Représente la position du point final à atteindre sur un axe veritcal(entre 0 et Height)
            //pour méthodes publiques :

            //InitGame
            //Aucun paramètre, ni retour : Permet d'initialiser le jeu en créant un Robot en position 0,0 sur la grille et de définir un point final aléatoire à atteindre.

            //Créer une class Robot qui a :

            //pour propriétés en lecture seule:

            //PositionX type entier : Représente la position du robot sur un axe horizontal(entre 0 et Width)
            //PositionY type entier : Représente la position du robot sur un axe vertical(entre 0 et Height)
            //Direction type Direction : Repésente l'axe de direction que le robot regarde (une énumération contenant Nord, Est, Sud, Ouest défini la direction)
            //Grille type Grille : Représente la grille sur laquelle le robot se promène.

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

            Grille grille = new Grille();
            grille.InitGame();
            grille.AfficherGrille();
            
        }
    }
}