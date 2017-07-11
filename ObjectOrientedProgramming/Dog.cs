using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming
{
    class Dog
    {
        //Create a Dog class
        //Your dog class should have fields for hair length, height, running speed, and weight
        

        //creating fields
        private string hairLength;
        private int height;
        private int runningSpeed;
        private int weight;
        private bool crap = true;

        public string HairLength
        {
            get { return this.hairLength; }
            set { this.hairLength = value; }
        }
        public int Height
        {
            get { return this.height; }
            set { this.height = value; }
        }
        public int RunningSpeed
        {
            get { return this.runningSpeed; }
            set { this.runningSpeed = value; }
        }
        public int Weight
        {
            get { return this.weight; }
            set { this.weight = value; }
        }
        //This is my default constructor
        public Dog(string hairLength, int height, int runningSpeed, int weight)
        {
            this.hairLength = hairLength;
            this.height = height;
            this.runningSpeed = runningSpeed;
            this.weight = weight;
        }
        //Your class should have the following behaviors: run,bark,potty,cuddle
        public int Run()
        {
            Console.WriteLine("Go doggy go.");
            RunningSpeed -= 1;
            return RunningSpeed;
        }
        public void Bark()
        {
            Console.WriteLine("Bark Bark Bark!!");
        }
        public void Potty()
        {
            if(crap == true)
            {
                Console.WriteLine("Your dog just made a mess.");
            }
            else
            {
                Console.WriteLine("Your dog has to relieve itself.");
            }
            public void Cuddle()
        {
            Console.WriteLine("Awww, doggo is so sweet.");
        }
        }


    }
}
