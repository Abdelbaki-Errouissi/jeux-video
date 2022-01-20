using System;
using System.Collections;
using System.Collections.Generic;

namespace PtojetJeuxVideos
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.AfficherMenuPrincipale();

            //classe similPendu
            
            Random random = new Random();
            //on va instantier notre objet et on va lui passer des parametres de type string pour mettre les mots à cherher
            SimiliPendu similiPendu = new SimiliPendu()
            {
                Listmots = new List<string>(){ "banane", "mangue", "ordinateur", "developpement", "orange", "poire", "citron" }
            };

            //mais qu'on a choisis nos mots on va passer à l'étape de choisir un mot au hazard par la fonction GetrandomMot

            string mot = similiPendu.GetrandomMot();
           // Console.WriteLine(mot);
           //rendu le random à choisie un mot et maintenant on va le transformer en ----avce la fonction TransforMot
            string motTransformer = similiPendu.TransformMot(mot);
            Console.WriteLine(motTransformer);
            similiPendu.ValidationMot(mot);

            program.AfficherMenuPrincipale();

            
            CarteAnnonceur carteAnnonceur = new CarteAnnonceur();
            carteAnnonceur.AfficherCarteAnnonceur();

            BingoCard bingoCard = new BingoCard();
            
            bingoCard.AfficherCarteJoueur();
            
          

        }

        public void startBingoGame()
        {
            Boulier boulier = new Boulier();
            for (int i=1; i<=75; i++){
                BingoBall bingoBall = new BingoBall(i);
                boulier.add(bingoBall);
            }
        }
        public  void AfficherMenuPrincipale()
            {
                Console.WriteLine("---------------Menu Jeux-----------");
                
                Console.WriteLine("--------Veuillez choisir l'une des actions suivantes------");
                Console.WriteLine();
                Console.WriteLine("1- Le pendu. ");
                Console.WriteLine("2- Simili black jack. ");
                Console.WriteLine("3-Bingo");
                Console.WriteLine("4-Quitter. ");
                Console.WriteLine();
                Console.WriteLine();

                Console.WriteLine("Donner votre choix :");
                int choix;
                choix = Convert.ToInt32(Console.ReadLine());
                switch (choix)
                {
                    case 1:
                    SimiliPendu similiPendu = new SimiliPendu();
                    similiPendu.JouerSimiliPendu();
                    break;
                    case 2:
                       // SimiliBlackJack();
                        break;
                    case 3:
                    BingoCard bingoCard = new BingoCard();
                    bingoCard.AfficherCarteJoueur();
                    CarteAnnonceur carteAnnonceur = new CarteAnnonceur();
                    carteAnnonceur.AfficherCarteAnnonceur();


                    break;
                    case 4:
                        FermerSession(); ;
                        break;
                }
            }
            static void FermerSession()
            {

            }
            





                //on va creer un tableau ou un ArrayListe qui contient toutes les lettres de l'alphabet
                //et on va essayer de choisire des mots au hazard avec Random
                /* ArrayList lettres = new ArrayList();
                 lettres.AddRange(new ArrayList() { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' });
                 foreach (var lettre in lettres)
                 {
                     Console.WriteLine(lettre);
                 }
                */

                /*
                string alphabet = "ABCDEFGHIJKLMNOPQRSTUVQXYZ";
                for (int i = 0; i < 26; ++i)
                {
                    Console.WriteLine(alphabet[i]);
                }

                foreach (char c in alphabet)
                {
                    Console.WriteLine(c);
                }
                */

            }
        }
    

