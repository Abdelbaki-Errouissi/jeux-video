using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PtojetJeuxVideos
{
    //Classe représentant un objet boule 
    class BingoBall
    {
        private int number;
        private char letter;
        public int Number { get => number; set => number = value; }
        public char Letter { get => letter; set => letter = value; }
        //Le constructeur de la classe
        public BingoBall(int number, char letter)
        {
            this.number = number;
            this.letter = letter;
        }
        public BingoBall(int number)
        {
            this.number = number;
            this.letter = letter;
        }



    }
    

}
