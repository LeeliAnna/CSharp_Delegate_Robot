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
            try
            {
                Grille grille = new Grille(6, 6);
                grille.InitGame();
                grille.robot.EnregistrerOrdre(Enums.OrdreRobot.Avancer);
                grille.robot.EnregistrerOrdre(Enums.OrdreRobot.Avancer);
                grille.robot.EnregistrerOrdre(Enums.OrdreRobot.Avancer);
                grille.robot.EnregistrerOrdre(Enums.OrdreRobot.Droite);
                grille.robot.EnregistrerOrdre(Enums.OrdreRobot.Avancer);
                grille.robot.EnregistrerOrdre(Enums.OrdreRobot.Avancer);
                grille.robot.EnregistrerOrdre(Enums.OrdreRobot.Gauche);
                grille.robot.EnregistrerOrdre(Enums.OrdreRobot.Avancer);
                grille.robot.EnregistrerOrdre(Enums.OrdreRobot.Avancer);
                grille.robot.Executer();

                grille.AfficherGrille();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}