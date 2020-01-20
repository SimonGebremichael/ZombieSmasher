using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing
{
    class Dog
    {
        public bool alive = false;
        public bool showing = false;
        public bool blast = true;
        public bool blast2 = false;
        public bool shooting = false;
        public bool shieldOn = false;
        public bool exit = false;

        public int width = 250;
        public int height = 250;
        public int blastState = 0;
        public int bodyState = 0;
        public int count2 = 0;
        public int count3 = 0;
        public int count4 = 0;
        public int count5 = 0;
        public int count6 = 0;
        public int electricState = 0;
        public int lightCounter = 0;
        public int lightNUM = 1;
        public int dogCounter = 0;
        public int repeatAT = 25;
        
        public void reset()
        {
            showing = false;
            exit = false;
            alive = false;
            blast = true;
            blast2 = false;
            shooting = false;
            shieldOn = false;
            bodyState = 0;
            lightCounter = 0;
            dogCounter = 0;
            blastState = 0;
            count2 = 0;
            count3 = 0;
            count4 = 0;
            count5 = 0;
            count6 = 0;
        }
    }
}
