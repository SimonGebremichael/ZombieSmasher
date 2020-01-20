using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using C3.XNA;
using Microsoft.Xna.Framework.Audio;

namespace testing
{
    public class resources
    {
        public float bloodScreenOpacity;

        public float disapear = 1f;
        public float disapearGame = 1f;


        public bool screenDir = true;
        public bool clickable = true;
        public bool shootOneBullet = false;
        public bool clickableShield = true;
        public bool blast = false;
        public bool blast2 = false;
        public bool ShieldDown = true;
        public bool action = false;
        
        public bool lighteningAttack = false;
        public bool gunControl = true;
        public bool showenemy = true;
        
        public bool blowup = false;
        public bool blowupdeath = false;
        public bool keyisup = true;
        public bool EndGame = false;//bbbbbbbbb
        public bool added = false;

        public bool gameStartAnimation = false;
        public bool gameover2 = true;
        public bool startMenu = true;//aaaaaaaa
        public bool start = true;
        public bool help = false;
        public bool howTOplay = false;
        public bool About = false;
        public bool pause = true;
        public int gamePos = 1;


        public int HitHealth = 0;
        public int pointWidth = 10;
        public int pointHeight = 10;
        public int EnemySpeed = 10;
        public int healCount = 0;
        public int fireCount = 0;
        public int Damage = 1;
        public int bottomMenu = 245;
        public int nameCount = 0;
        public int gameoverCount = 0;


        //packs
        public float heartOpacity = 1f;
        public float deathOpacity = 1f;
        public float doubleOpacity = 1f;
        public bool heartAlive = false;
        public bool deathAlive = false;
        public bool doubleAlive = false;
        public int pack = 15;
        public int pack2 = 20;
        public int pack3 = 25;

        //the only valid characters
        public string[] LETTERS =
            {
            "A", "B", "C", "D",
            "E", "F", "G", "H", "I",
            "J", "K", "L", "M", "N",
            "O", "P", "Q", "R", "S",
            "T", "U", "V", "W", "X",
            "Y", "Z" };

        public string[] col1 = { "SIM", "FDS", "SSD", "LKL", "JHF", "GFA", "MON" };
        public string col1Names = "SIM\nFDS\nSSD\nLKL\nJHF\nGFA\nMON";
        public int[] col2 = { 1032, 490, 230, 130, 101, 50, 20 };
        public string col2Names = "1032\n490\n230\n130\n101\n50\n20";
        public string reload = "";
        public Vector2 reloadPos;

        public string DisplayInfo = "";
        public string DisplayInfo2 = "";
        public string DisplayInfo3 = "";
        public Vector2 displayPos;
        public Vector2 DisplayInfo2Pos;
        public Vector2 DisplayInfo3Pos;


        public Texture[] cloudArr = new Texture[6];
        public Texture[] shockArr = new Texture[4];
        public Texture[] dogStateArr = new Texture[7];
        public Texture[] shieldArr = new Texture[6];
        public Texture[] ElectricArr = new Texture[8];
        public Texture[] blastArr = new Texture[8];
        public Texture[] avatarArr = new Texture[8];
        public Texture[] walkArr = new Texture[7];
        public Texture[] avatar_blowArr = new Texture[7];

        public Texture2D background1;
        public Texture2D background2;
        public Texture2D gun;
        public Texture2D bloodDrip;
        public Texture2D double_pack;
        public Rectangle shootPoint;
        public Texture2D bloodScreen;
        public Texture2D gunFire;
        public Texture2D heart;
        public Texture2D death;
        public Texture2D healthbar;
        public Texture2D healthbar2;
        public Texture2D dog_shield;
        public Texture2D Mask;
        public Texture2D block;
        public Texture2D shock1, shock2, shock3;
        public Texture2D avatar1, avatar2, avatar3, avatar4, avatar5, avatar6;
        public Texture2D walk1, walk2, walk3, walk4, walk5, walk6;
        public Texture2D fire1, fire2, fire3, fire4;
        public Texture2D shield, shield1, shield2, shield3, shield4, shield5;
        public Texture2D electric1, electric2, electric3, electric4, electric5, electric6, electric7, electric8;
        public Texture2D dog1, dog2, dog3, dog4, dog5, dog6;
        public Texture2D cloud1, cloud2, cloud3, cloud4, cloud5, cloud6;
        public Texture2D avatar_blow1, avatar_blow2, avatar_blow3, avatar_blow4, avatar_blow5, avatar_blow6, avatar_blow7;

        public Vector2 startSelect;
        public Vector2 healthbarPos;
        public Vector2 blockPos;
        public Vector2 heartPos;
        public Vector2 shieldPos;
        public Vector2 gunPos;
        public Vector2 backgroundPos;
        public Vector2 backgroundPos2;
        public Vector2 point;
        public Vector2 deathPos;
        public Vector2 doublePos;
        public Vector2 bloodDripPos;


        public Color GunColour = Color.White;
        public Color HealthColor = Color.LightGreen;


        public SoundEffect Shot;
        public SoundEffect blowUp;
        public SoundEffect background;
        public SoundEffect DoublePoints;
        public SoundEffect Heal;
        public SoundEffect GetPoint;
        public SoundEffect GameOver;
        public SoundEffect Electric;
        public SoundEffect wolf;
    }
}
