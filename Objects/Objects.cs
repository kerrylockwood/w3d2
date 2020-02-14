using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    public class BirdInfo
    {
        public string BirdType;
        public int BirdPoints;

        public BirdInfo(string birdType, int birdPoints)
        {
            BirdType = birdType;
            BirdPoints = birdPoints;
        }
    }
}
