﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace joursMoisAnnée
{
    class Program
    {
        static void Main(string[] args)
        {
            // Déclaration.
            int jour, mois, année;
            int resultat4;
            int valeurMois = 0;
            int rest7;
            string joursTouver;

            // Affichage demande à l'utilisateur.
            Console.WriteLine("ce programme permet de définir le jour de la semaines par raport a une date donnée entre 1900 et 1999 .\n");
            Console.WriteLine("Veulliez saisir votre date sous la forme jj/mm/aa:");

            // Traitement de la saisi année, déclaration et initialisation  du tableau ,split de celle ci et assignations des valeurs aux différentes variables.
            string[] dateComplete = Console.ReadLine().Split('/');
            int.TryParse(dateComplete[0], out jour);
            int.TryParse(dateComplete[1], out mois);
            int.TryParse(dateComplete[2], out année);
            // Console.WriteLine("j: {0} m: {1} a: {2}", jour, mois, année);

            // Calcule et appelle des méthodes. 
            resultat4 = année / 4;
            valeurMois = MoisDonné(mois, année);
            rest7 = (année + resultat4 + valeurMois + jour) % 7;
            joursTouver = JourSemaine(rest7);

            // affichage resultat 
            Console.WriteLine(joursTouver);
        }
        /// <summary>
        /// Permet de retrouver un jour grace à un int sous forme de switch.
        /// </summary>
        /// <param name="_numJour"></param>
        /// <returns>nomJour</returns>
        static string JourSemaine(int _numJour)
        {
            string nomJour;

            switch (_numJour)
            {
                case 0:
                    nomJour = "Samedi";
                    break;
                case 1:
                    nomJour = "Dimanche";
                    break;
                case 2:
                    nomJour = "Lundi";
                    break;
                case 3:
                    nomJour = "Mardi";
                    break;
                case 4:
                    nomJour = "Mercredi";
                    break;
                case 5:
                    nomJour = "Jeudi";
                    break;
                case 6:
                    nomJour = "Vendredi";
                    break;
                default:
                    nomJour = "Nombre de jour invalide";
                    break;
            }
            return nomJour;
        }
        /// <summary>
        /// Permet de retrouver la valeur associer à un mois  grace à deux int sous forme de 
        /// switch et permet de dissocier les mois dans une année bissextille.
        /// </summary>
        /// <param name="_mois"></param>
        /// <param name="_année"></param>
        /// <returns>valeurMois</returns>
        static int MoisDonné(int _mois, int _année)
        {
            int valeurMois;

            switch (_mois)
            {
                case 1:
                    if (DateTime.IsLeapYear(_année))
                        valeurMois = 0;
                    else
                        valeurMois = 1;
                    break;
                case 2:
                    if (DateTime.IsLeapYear(_année))
                        valeurMois = 3;
                    else
                        valeurMois = 4;
                    break;
                case 3:
                    
                        valeurMois = 4;
                        break;
                    
                case 4:
                    valeurMois = 0;
                    break;
                case 5:
                    valeurMois = 2;
                    break;
                case 6:
                    valeurMois = 5;
                    break;
                case 7:
                    valeurMois = 0;
                    break;
                case 8:
                    valeurMois = 3;
                    break;
                case 9:
                    valeurMois = 6;
                    break;
                case 10:
                    valeurMois = 1;
                    break;
                case 11:
                    valeurMois = 4;
                    break;

                case 12:
                    valeurMois = 6;
                    break;



                default:
                    throw new Exception("mois invalide");


            }
            return valeurMois;
        }

    }
}
