using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PtojetJeuxVideos
{
    //notre classe là ou on va travailler tout le programme
    //La classe sert de fondation à la construction
    //Une Class est donc un modèle qui définit les champs et les méthodes qui sont communes à une collection d'objets. 


    class SimiliPendu
    {
        //les champs (on va avoir besoin d'une liste des mots choisis par nous donc liste de string)
        //Les variables de classes doivent être private ou protected

        private List<string> listmots;

        // l'encapsulation(directement bouton droit actions rapides + encapsuler la propriétes)
        //permet de protéger les membres d'une classe afin qu'ils ne soient pas modifiés à l'extérieur de sa propre classe.
        public List<string> Listmots {
            get =>listmots;
            set =>listmots = value; }

        // Le constructeur de la classe doit avoir le même nom
        // Un constructeur permet à un objet d’avoir une instance(initialiser un objet)
        //Les classes peuvent avoir plusieurs constructeurs mais les signatures doivent être différentes


        public SimiliPendu()
        {
            listmots = new List<string>();//ca va marcher meme si le constructeur est vide (a faire le test...)
        }
        //on va créer un fonction de bienvenue avec un petit menu de demarage
        //
        public void JouerSimiliPendu()
        {
            Random random = new Random();
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("\t Bienvenue dans le SimiliPendu");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("il faut trover le mot caché derriérre les traits suivant :");
            Console.WriteLine();
            Console.WriteLine();
           // var Listmots = new List<string>();
           // Listmots.AddRange(new List<string>() { "banane", "orange", "poire", "avocat", "kiwi" });
           // int cpuchoice = random.Next(0, listmots.Count);
            //string mot = Listmots[cpuchoice];
           // Console.WriteLine(mot);
        }
        
            //fonction qui va choisir au hazard un mot parmis la liste de mots
            //on utilise le Next qui va nous generer un numero qui correpond a un indice dans notre tableau ou notre liste dans notre cas
            //cpucoice c'est notre resultat de random qui est juste une position
            //et cette position on va le correpondre a notre mot dans lismots
            //ensuiste on retourne le mot choisie
             public string GetrandomMot()
            {
                Random random = new Random();
                int cpuchoice = random.Next(0, 5);
                string mot = Listmots[cpuchoice];
                return mot;

            }
            //fonction qui va transformer le mot trouver en -----
            //
            public string TransformMot(string mot)
            {
            //la prmière ligne prend le mot et le transforme en un tableau de char appélé motCache
            //
            char[] motCache = mot.ToCharArray(); // mot = bonjour =>[ 'b', 'o','n','j','o','u','r']
                
                for (int i = 0; i < motCache.Length; i++)
                {
                    motCache[i] = '-';
                }
                //création d'un objet str de la classe string qui prend en paramètre le motCahe
                //ensuite on va retourner cette str qui est enfaite le mot representé par le signe ------
               string str = new string(motCache);
                return str;
            }

        public List<int> GetListeIndices(char[] tableau, char caracter)
        {
            List<int> liste = new List<int>();
            int indice = 0;
            while(indice < tableau.Length)
            {
                if(tableau[indice] == caracter)
                {
                    liste.Add(indice);
                }
                indice++;
            }
            return liste;
        }
        // Fonction qui demande au joueur de saisir une lettre
         public void ValidationMot(string motADevinner)
        {
            string motCache = TransformMot(motADevinner);
            char[] tabChar = motCache.ToCharArray();
           
            while (Verifier(motCache))
            {
                Console.WriteLine("entrer une lettre");
                string lettre = Console.ReadLine();
                
                bool conversion = Char.TryParse(lettre, out char charsSaisie);
                if (conversion && char.IsLetter(charsSaisie))
                {
                    if (motADevinner.Contains(charsSaisie))
                    {
                        List<int> listeIndice = new List<int>();
                        listeIndice = GetListeIndices(motADevinner.ToCharArray(), charsSaisie);
                        int compteur = listeIndice.Count;
                        while (compteur > 0)
                        {
                            int indice = listeIndice[0];
                            tabChar[indice] = charsSaisie;
                            listeIndice.RemoveAt(0);
                            compteur--;

                        }
                        Console.WriteLine(new string(tabChar));
                    }
                    else
                    {
                        Console.WriteLine($"le mot a deviner ne contient pas la lettre {charsSaisie}");
                    }
                }
                else
                {
                    Console.WriteLine("entrer une lettre valide");
                } 
                motCache =  new string(tabChar);
            }
        }
        public bool Verifier(string motCache)
        {
            return motCache.Contains('-');
            
        }
    }
}
