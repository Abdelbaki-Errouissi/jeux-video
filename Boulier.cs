using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PtojetJeuxVideos
{
    // Classe qui représente le boulier. On y retire les boules au hazard
    //il ya 75 boules à retirer
    class Boulier:IBingoBoulier
    {
        private Player player;
        private BingoBall[] carteAnnonceur;
        private List<BingoBall­> listeboule;

        public Player Player { get => player; set => player = value; }
        internal BingoBall[] CarteAnnonceur { get => carteAnnonceur; set => carteAnnonceur = value; }
        internal List<BingoBall> ListeBoule { get => listeboule; set => listeboule = value; }

        public void add(BingoBall element)
        {
            this.listeboule.Add(element);
        }

        public BingoBall getRanbomBall()
        {
            //déclarer un random
            Random random = new Random();
            int next = random.Next(this.listeboule.Count);
            //retirer la boule
            BingoBall ball = this.listeboule[next];//changer le deux par un random
            return ball;
        }

        public int getSize()
        {
            return this.listeboule.Count;
        }

        public bool isEmpty()
        {
            throw new NotImplementedException();
        }

        public void restartBoulier()
        {
            throw new NotImplementedException();
        }
    }
}
