using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;

namespace Objects
{
    public class Repo
    {
        List<BirdInfo> _birdList = new List<BirdInfo>();

        Queue _birdQueue = new Queue();
        
        List<string> _dataList = new List<string>();

        //===============================
        public void BuildDataList()
        {
            string filePath = @"C:\1150Projects\Gold.NET\ChallengeW3D2\ChallengeW3D2\game-sequence.txt";
            string data = File.ReadAllText(filePath).ToString();
            string[] entries = data.Split(',');
            List<string> fields = entries.ToList();

            foreach (string field in fields)
            {
                _birdQueue.Enqueue(field);
            }
        }

        //===============================
        public void buildBirdList()
        {
            //BirdInfo bL = new BirdInfo();

            //Bird: 10 points each
            _birdList.Add(new BirdInfo("Bird", 10));

            //Crested Ibis: 100 points
            _birdList.Add(new BirdInfo("CrestedIbis", 100));

            //Great Kiskudee: 300 points
            _birdList.Add(new BirdInfo("GreatKiskudee", 300));

            //Red Crossbill: 500 points
            _birdList.Add(new BirdInfo("RedCrossbill", 500));

            //Red-necked Phalarope: 700 points
            _birdList.Add(new BirdInfo("Red-neckedPhalarope", 700));

            //Evening Grosbeak: 1000 points
            _birdList.Add(new BirdInfo("EveningGrosbeak", 1000));

            //Greater Prairie Chicken: 2000 points
            _birdList.Add(new BirdInfo("GreaterPrairieChicken", 2000));

            //Iceland Gull: 3000 points
            _birdList.Add(new BirdInfo("IcelandGull", 3000));

            //Orange-Bellied Parrot: 5000 points
            _birdList.Add(new BirdInfo("Orange-belliedParrot", 5000));

        }
        //===============================
        public string readQueue()
        {
            string rtnData = "";
            // if no entries in queue, returns ""
            rtnData = _birdQueue.Dequeue().ToString();
            return rtnData;
        }//==============================
        public int getPoints(string newBirdType)
        {
            List<BirdInfo> bL = new List<BirdInfo>();

            foreach (BirdInfo bl in _birdList)
            {
                if (bl.BirdType == newBirdType)
                {
                    return bl.BirdPoints;
                }
            }
            return 0;
        }
        public List<BirdInfo> rtnBirdList()
        {
            buildBirdList();
            return _birdList;
        }
    }
}
