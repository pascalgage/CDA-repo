﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrom

{
    class Program
    {
        static void Main(string[] args)
        {

            string phrase, finDePhrase;
            bool palindrom = false;

            Console.WriteLine("veuillez saisir une phrase terminer par un point:");
            phrase = Console.ReadLine().ToLower();
            

            // teste de phrase vide.
            finDePhrase = phrase.Substring(phrase.Length - 1);
            if (finDePhrase == "." && phrase.Length < 1)
            {
                Console.WriteLine("la phrase est vide");
            }
            else

            {
                phrase = phrase.Substring(0, phrase.Length - 1);


                char[] phraseChar = phrase.ToCharArray();

                char[] phraseReverse = new char[phrase.Length];

                for (int i = 0; i < phraseChar.Length; i++)
                {   // ajouter -i a phrasechar.lenght
                    phraseReverse[i] = phraseChar[(phraseChar.Length - 1) - i];
                    //debug
                    //Console.WriteLine(phraseReverse[i]);
                }
                for (int i = 0; i < phraseChar.Length; i++)
                {
                    if (phraseChar[i] != phraseReverse[i])
                    {
                        palindrom = false;
                        //debug
                        Console.Write(phraseReverse[i]);
                    }
                    else
                    {//debug
                        Console.Write(phraseReverse[i]);
                        palindrom = true;
                    }

                }
                if (palindrom == true)
                {
                    Console.WriteLine(" la phrase est un palindrome");
                }
                else
                {
                    Console.WriteLine(" la phrase est pas un palindrome");
                }
            }

            Console.ReadLine();


        }

        }
    }
