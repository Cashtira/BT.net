using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm.DAL.Model
{
    internal class Cattle
    {
        const int MAX_OFFSPRING = 5;

        private int id;
        private string type;
        private float minMilk;
        private float maxMilk;
        private string sound;

        public Cattle(int id, string type, float minMilk, float maxMilk, string sound)
        {
            this.id = id;
            this.type = type;
            this.minMilk = minMilk;
            this.maxMilk = maxMilk;
            this.sound = sound;
        }

        public int breed()
        {
            Random random = new Random();
            return random.Next(MAX_OFFSPRING + 1);
        }

        public string call()
        {
            return sound;
        }

        public float giveMilk()
        {
            Random random = new Random();
            float milk = minMilk + (float)random.NextDouble() * (maxMilk - minMilk);
            return (float)Math.Round(milk,2);
        }
    }
}
