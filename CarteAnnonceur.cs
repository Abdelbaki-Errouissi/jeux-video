using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PtojetJeuxVideos
{
    class CarteAnnonceur
    {
        public  void AfficherCarteAnnonceur()
        {

            int[,] CarteAnnonceur = new int[15, 5];
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("---------< Carte Annonceur>----------");
            Console.WriteLine("B          I       N       G       O");
            Console.WriteLine("-------------------------------------");

            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine("{0}  {1}  {2}  {3}  {4} ", CarteAnnonceur[i, 0] + "\t", CarteAnnonceur[i, 1] + "\t", CarteAnnonceur[i, 2] + "\t", CarteAnnonceur[i, 3] + "\t", CarteAnnonceur[i, 4] + "\t");
            }
            Random random = new Random();

            //int i, j, k;
            //k = 1;
            //for (i = 0; i < CarteAnnonceur.Length; i++)
            //{
            //    for (j = 0; j < CarteAnnonceur.Length; j++)
            //    {
            //        CarteAnnonceur[i, j] = k++;
            //    }
            //}


            //for (i = 0; i < CarteAnnonceur.Length; i++)
            //{
            //    for (j = 0; j < CarteAnnonceur.Length; j++)
            //    {
            //        Console.Write(CarteAnnonceur[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine();

        }
    }
  
}

