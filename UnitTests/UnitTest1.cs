using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Objects;
// using static Objects.Objects;

namespace UnitTests
{
    [TestClass]
    public class BirdManTests
    {
        Repo repo = new Repo();   // creates new instance of repository "Repo" for use throughout

        [TestMethod]
        public void ProgramTest()
        {
            repo.buildBirdList();
            repo.BuildDataList();

            int points = 5000;
            int lives = 3;
            int newPoints = 0;
            string bird = "";
            int nextHunterPts = 200;
            int nextLifePts = 10000;

            do
            {
                bird = repo.readQueue();
                if (bird == "")
                {
                    break;
                }
                if (bird == "InvincibleBirdHunter")
                {
                    newPoints = 0;
                    lives -= 1;
                    Console.WriteLine("You lost a life");
                    if (lives <= 0)
                    {
                        break;
                    }
                }
                else if (bird == "VulnerableBirdHunter")
                {
                    newPoints = nextHunterPts;
                    nextHunterPts = nextHunterPts * 2;
                }
                else
                {
                    newPoints = repo.getPoints(bird);
                }
                points += newPoints;
                if (points >= nextLifePts)
                {
                    lives += 1;
                    nextLifePts += 10000;
                    Console.WriteLine("You gained a life");
                }
                Console.WriteLine($"{bird}  {newPoints}  {points}   {lives}");
            } while (bird != "");
            Console.WriteLine($"Total Points: {points}");
            Console.WriteLine($"Remaining Lives: {lives}");
        }

        [TestMethod]
        public void BuildBirdListTest()
        {
            List<BirdInfo> brdLst = new List<BirdInfo>();

            brdLst = repo.rtnBirdList();

            List<BirdInfo> bL = new List<BirdInfo>();

            foreach (BirdInfo birdL in brdLst) 
            {
                Console.WriteLine($"{birdL.BirdType} {birdL.BirdPoints}");
            }
        }

        [TestMethod]
        public void TestBuildData()
        {
            Repo reposit = new Repo();
            reposit.BuildDataList();

            string bird;
            Console.WriteLine("Test");
            do
            {
                bird = reposit.readQueue();
                if (bird == "")
                {
                    break;
                }
                if (bird == null)
                {
                    break;
                }
                Console.WriteLine(bird);
            } 
            while (bird != "");
        }

        [TestMethod]
        public void OneTest()
        {
            Repo reposit = new Repo();

            reposit.BuildDataList();
            
        }

        [TestMethod]
        public void MyTestMethod()
        {

            repo.BuildDataList();
        }
    }
}
