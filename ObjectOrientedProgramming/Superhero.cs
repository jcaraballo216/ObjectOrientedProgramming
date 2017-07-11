using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming
{
    class Superhero
    {
        //5 fields
        private string costume;
        private string name;
        private int strengthLevel;
        private string power;
        private bool hasCape;

        //5 properties
        public string Costume
        {
            get { return this.costume; }
            set { this.costume = value; }
        }
        public string Name
        {
            get { return this.name; }
        }
        public int StrengthLevel
        {
            get { return this.strengthLevel; }
            set { this.strengthLevel = value; }
        }
        public string Power
        {
            get { return this.power; }
        }
        public bool HasCape
        {
            get { return this.hasCape; }
            set { this.hasCape = value; }
        }

        //3 contructors
        public Superhero()
        {
            //This is my default constructor
        }
        public Superhero(string name)
        {
            this.name = name;
            this.strengthLevel = 100;
        }
        public Superhero(string name,string costume,string power,int strengthLevel,bool hasCape)
        {
            this.name = name;
            this.costume = costume;
            this.power = power;
            this.strengthLevel = strengthLevel;
            this.hasCape = hasCape;
        }

        //2 Methods
    }
}
