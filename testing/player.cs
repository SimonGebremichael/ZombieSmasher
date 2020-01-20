using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing
{
    class player
    {
        public string name = "";
        public int Ammo = 10;
        public int HealthBar = 0;
        public int shieldHealth = 4000;
        public int shieldStatus = 0;
        public int blastNum = 0;
        public int blow = 0;
        public int blowUpState = 0;
        public int killCount = 0;
        public bool doublePoint = false;
        public int doubleCount = 0;

        public int leftSideScreen = -200;
        public int centerScreen = 500;
        public int rightSideScreen = 900;
    }
}
