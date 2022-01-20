using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PtojetJeuxVideos
{
    interface IBingoBoulier
    {
        public abstract BingoBall getRanbomBall();
        public abstract void restartBoulier();
        public abstract void add(BingoBall element);
        public abstract bool isEmpty();
        public abstract int getSize();
    }

}
