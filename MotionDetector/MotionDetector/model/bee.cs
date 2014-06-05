using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotionDetector.model
{
    public class Bee
    {
        public Bee()
        {

        }

        public Bee(int initalBees,int initialSites)
        {

        }

        private int initialBeesCount;

        public int InitialBeesCount
        {
            get { return initialBeesCount; }
            set { initialBeesCount = value; }
        }
        private int initialSitesCount;

        public int InitialSitesCount
        {
            get { return initialSitesCount; }
            set { initialSitesCount = value; }
        }
        private int bestBlocsCount;

        public int BestBlocsCount
        {
            get { return bestBlocsCount; }
            set { bestBlocsCount = value; }
        }
        private int beesForBestBlocsCount;

        public int BeesForBestBlocsCount
        {
            get { return beesForBestBlocsCount; }
            set { beesForBestBlocsCount = value; }
        }
        private int beesForDiversificationCount;

        public int BeesForDiversificationCount
        {
            get { return beesForDiversificationCount; }
            set { beesForDiversificationCount = value; }
        }
        private double quality;

        public double Quality
        {
            get { return quality; }
            set { quality = value; }
        }
        private double direction;

        public double Direction
        {
            get { return direction; }
            set { direction = value; }
        }

        private Bloc coordinates;

        public Bloc Coordinates
        {
            get { return coordinates; }
            set { coordinates = value; }
        }

    }
}
