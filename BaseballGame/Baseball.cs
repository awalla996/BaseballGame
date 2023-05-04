using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballGame
{
    class Baseball
    {
        private int[] player1 = new int[10];
        private int[] computer = new int[10];

        private int hit;
        private int index;
        private int outs;
        public Baseball()
        {
            this.index = 0;
        }
        public int PlayerSwing
        {
            get{
                player1[index] = player1[index] / 4;
                return player1[index]; }
            set {
                hit = 0;
                outs = 0;
                var randNum = new Random();
                int swing = randNum.Next(0, 101);
                while (outs != 3)
                {
                    if (swing >= 0 && swing <= 20)
                    {
                        outs++;
                        Console.WriteLine("Strike " + outs);
                        hit = hit + 0;
                        player1[index] = hit;
                        swing = randNum.Next(0, 101);
                    }
                    else if (swing >= 21 && swing <= 69)
                    {
                        Console.WriteLine("A single was hit");
                        hit = hit + 1;
                        player1[index] = hit;
                        swing = randNum.Next(0, 101);

                    }
                    else if (swing >= 70 && swing <= 90)
                    {
                        Console.WriteLine("A double was hit");
                        hit = hit + 2;
                        player1[index] = hit;
                        swing = randNum.Next(0, 101);
                    }
                    else if (swing >= 91 && swing <= 99)
                    {
                        Console.WriteLine("A triple was hit");
                        hit = hit + 3;
                        player1[index] = hit;
                        swing = randNum.Next(0, 101);
                    }
                    else
                    {
                        Console.WriteLine("A homerun was hit!!");
                        hit = hit + 4;
                        player1[index] = hit;
                        swing = randNum.Next(0, 101);
                    }
                }
            }

        }
        public int ComputerSwing
        {
            get
            {
                computer[index] = hit / 4;
                return computer[index];
            }
            set
            {
                hit = 0;
                outs = 0;
                var compNum = new Random();
                while (outs != 3)
                {
                    hit = compNum.Next();
                    if (hit >= 0 && hit <= 20)
                    {
                        hit = hit + 0;
                        outs++;
                    }
                    else if (hit >= 21 && hit <= 69)
                    {
                        hit = hit + 1;
                    }
                    else if (hit >= 70 && hit <= 90)
                    {
                        hit = hit + 2;
                    }
                    else if (hit >= 91 && hit <= 99)
                    {
                        hit = hit + 3;
                    }
                    else
                    {
                        hit = hit + 4;
                    }
                }

            }
        }
        public int full
        {
            //Returns each value stored in the array signifying the full game
            get { return player1[index]; }
            set { }
        }
        
    }
}
