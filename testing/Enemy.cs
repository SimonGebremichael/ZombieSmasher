using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing
{
    class Enemy
    {
        public bool alive = true;
        public bool shooting = false;
        public bool Direction = false;
        private bool found = false;
        public int Y;
        public int X;



        public int blow = 0;
        public int blowState = 0;
        public int width = 200;
        public int height = 200;
        public int count = 0;
        public int OpenFire = 0;
        public int Respawn = 0;
        public int bodyState = 1;
        public int walkState = 1;
        public int position = 1;
        public int arrange;

        public float showingFire = 0f;

        public int ChangePlace()
        {
            Random rnd = new Random();
            int right = rnd.Next(1000, 1400);
            int left = rnd.Next(-800, -400);
            bool way = rnd.Next(100) <= 50 ? true : false;
            if (way == true) { return right; }
            else { return left; }
        }
        public void checkHit(int x, int y, int point)
        {
            for (int j = x+100; j <= x + width; j++)
            {
                for (int i = y; i <= y + height; i++)
                {
                    if (point == j) { found = !found; }
                }
            }
            if(found == true && shooting == true) { alive = false; }
        }
        public void reset()
        {
            alive = true;
            shooting = false;
            count = 0;
            Direction = false;
            found = false;
        }

    }
}
