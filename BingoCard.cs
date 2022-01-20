using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PtojetJeuxVideos
{
    // Classe représentant un objet carte pour le joueur.
    // Un joueur a au minimum une carte.
    class BingoCard
    {
        private int[,] carteJoeur;
        public int[,] CarteJoeur { get => carteJoeur; set => carteJoeur = value; }
        // Le constructeur de la classe        private int[,] carte = new int[5,5];

        public BingoCard()
        {
            carteJoeur = new int[5, 5];
            this.GenerateRandomCard();
        }

        public List<int> generateRandomNumber(int minimum, int maximum)
        {
            //créer une liste ou arraylist qui contient de 1 à 15
            // tirer au hazard un élément de cette liste
            //Ajouter ce numéro à la carte (5,5)

            //List<int> chiffre = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            List<int> liste = new List<int>();
            for (int item = minimum; item <= maximum; item++)
            {
                liste.Add(item);
            }
            return liste;
            }
        // Fonction qui permet de tirer 5 nombres aleatoires d'une liste pour les 4 colonnes exculuant celui du milieu
        public List<int> TirerCinqNombresAleatoire(List<int> listeNombreEntiers)
        {
            List<int> listeTampon = new List<int>();
            Random random = new Random();
            int indice;
            int valeur;
            while (listeTampon.Count < 5)
            {
                indice = random.Next(0, listeNombreEntiers.Count);
                valeur = listeNombreEntiers[indice];
                if (!listeTampon.Contains(valeur))
                {
                    listeTampon.Add(valeur);
                    
                }
                

            }
            return listeTampon;

        }
        // Fonction  qui permet de tirer 4 nombres aleatoires pour la colonne N
        public List<int> TirerQuatreNombreAleatoire(List<int> listeNombreEntiers)
        {
            List<int> listeTampon = new List<int>();
            Random random = new Random();
            int indice;
            int valeur;
            while (listeTampon.Count < 4)
            {
                indice = random.Next(0, listeNombreEntiers.Count);
                valeur = listeNombreEntiers[indice];
                if (!listeTampon.Contains(valeur))
                {
                    listeTampon.Add(valeur);
                }
                else
                {

                }

            }
            return listeTampon;
        }
        // Fonction qui Construire une carte du Joeur
        public void GenerateRandomCard() 
        {
            List<int> listeB = generateRandomNumber(1, 15);
            List<int> listeI = generateRandomNumber(16, 30);
            List<int> listeN = generateRandomNumber(31, 45);
            List<int> listeG = generateRandomNumber(46, 60);
            List<int> listeO = generateRandomNumber(61, 75);
            // Construire les listes de cinq ou 4  nombres entiers aleatoires
            List<int> colonneB = TirerCinqNombresAleatoire(listeB);
            colonneB.Sort();
            List<int> colonneI = TirerCinqNombresAleatoire(listeI);
            colonneI.Sort();
            List<int> colonneN = TirerQuatreNombreAleatoire(listeN);
            //la fonction sort trie la liste par ordre croissant
            colonneN.Sort();
            List<int> colonneG = TirerCinqNombresAleatoire(listeG);
            colonneG.Sort();
            List<int> colonneO = TirerCinqNombresAleatoire(listeO);
            colonneO.Sort();
            // Ajouter les nombres dans la carte du Joueur
            for (int i = 0; i< 5; i++)
            {
                carteJoeur[i, 0] = colonneB[i];
                carteJoeur[i, 1] = colonneI[i];
                carteJoeur[i, 3] = colonneG[i];
                carteJoeur[i, 4] = colonneO[i];


            }
            // remplissage de la colonne N du milieu
            carteJoeur[2, 2] = 0;
            carteJoeur[0, 2] = listeN[0];
            carteJoeur[1, 2] = listeN[1];
            carteJoeur[3, 2] = listeN[2];
            carteJoeur[4, 2] = listeN[3];
        }

        // Fonction qui affiche une carte 
        public void AfficherCarteJoueur()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine($"{'B'}\t| {'I'}\t| {'N'}\t| {'G'}\t| {'O'}\t |");
            Console.WriteLine("------------------------------------------");
            int ligne = 0;
            while(ligne < carteJoeur.GetLength(0))
            {
                for(int j = 0; j < carteJoeur.GetLength(1); j++)
                {
                    Console.Write($"{carteJoeur[ligne,j]}\t | ");
                }
                Console.WriteLine();
                ligne++;

            }
            Console.WriteLine("------------------------------------------");

        }

       
    }
}
