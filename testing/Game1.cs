                                                                                        //Simon Gebremichael (final) - Zombie Smasher
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using C3.XNA;
using System;
using Microsoft.Xna.Framework.Audio;

namespace testing
{
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch ZombieGame;
        SpriteFont display;
        SpriteFont startFont;
        SpriteFont description;

        resources Game = new resources();
        player player1 = new player();
        Enemy enemy1 = new Enemy();
        Enemy enemy2 = new Enemy();
        Enemy enemy3 = new Enemy();
        Enemy enemy4 = new Enemy();
        Enemy enemy5 = new Enemy();
        Enemy enemy6 = new Enemy();
        Vector2 enemyPos1;
        Vector2 enemyPos2;
        Vector2 enemyPos3;
        Vector2 enemyPos4;
        Vector2 enemyPos5;
        Vector2 enemyPos6;

        Dog dog = new Dog();
        Vector2 dogPos;

        Enemy[] zombies = new Enemy[6];
        Vector2[] positions = new Vector2[6];

        Random rnd = new Random();

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            graphics.PreferredBackBufferHeight = 600;
            graphics.PreferredBackBufferWidth = 1000;

            //display Info
            Game.displayPos = new Vector2(20, 80);
            Game.DisplayInfo2Pos = new Vector2(20, 550);
            Game.DisplayInfo3Pos = new Vector2(graphics.PreferredBackBufferWidth - 180, 0);


            //enemies
            enemyPos1 = new Vector2(1000, (graphics.PreferredBackBufferHeight / 2) - 10);
            enemyPos2 = new Vector2(1300, (graphics.PreferredBackBufferHeight / 2) - 10);
            enemyPos3 = new Vector2(-400, (graphics.PreferredBackBufferHeight / 2) - 10);
            enemyPos4 = new Vector2(-800, (graphics.PreferredBackBufferHeight / 2) - 10);
            enemyPos5 = new Vector2(-3000, (graphics.PreferredBackBufferHeight / 2) - 10);
            enemyPos6 = new Vector2(3000, (graphics.PreferredBackBufferHeight / 2) - 10);

            //spread enemys appart
            enemy1.arrange = 100;
            enemy2.arrange = 200;
            enemy3.arrange = 300;
            enemy4.arrange = 350;
            enemy5.arrange = 300;
            enemy6.arrange = 250;

            //objects
            Game.reloadPos = new Vector2(0, 0);
            Game.gunPos = new Vector2(0, 0);
            Game.backgroundPos = new Vector2(0, 0);
            Game.backgroundPos2 = new Vector2(0, 0);
            Game.doublePos = new Vector2(0, 0);
            Game.point = new Vector2(Game.gunPos.X, Game.gunPos.Y);
            Game.shieldPos = new Vector2(0, 600);
            Game.heartPos = new Vector2(0, 0);
            Game.deathPos = new Vector2(0, 0);
            Game.healthbarPos = new Vector2(0, 0);
            Game.startSelect = new Vector2(370, 170);
            dogPos = new Vector2(320, 320);
            Game.bloodDripPos = new Vector2(0, -480);
        }
        protected override void Initialize()
        {
            base.Initialize();
        }
        protected override void LoadContent()
        {
            ZombieGame = new SpriteBatch(GraphicsDevice);

            Game.gun = Content.Load<Texture2D>("gun");
            Game.background1 = Content.Load<Texture2D>("background1");
            Game.background2 = Content.Load<Texture2D>("background2");

            //objects
            Game.dog_shield = Content.Load<Texture2D>("dogShield");
            Game.heart = Content.Load<Texture2D>("health_pack");
            Game.bloodScreen = Content.Load<Texture2D>("Blood");
            Game.gunFire = Content.Load<Texture2D>("gunFire");
            Game.death = Content.Load<Texture2D>("death_pack");
            Game.healthbar = Content.Load<Texture2D>("healthbar");
            Game.healthbar2 = Content.Load<Texture2D>("healthbar2");
            Game.Mask = Content.Load<Texture2D>("mask");
            Game.block = Content.Load<Texture2D>("block");
            Game.double_pack = Content.Load<Texture2D>("double_pack");
            Game.bloodDrip = Content.Load<Texture2D>("BloodDrip");

            //Sounds
            Game.Shot = Content.Load<SoundEffect>("shot");
            Game.blowUp = Content.Load<SoundEffect>("blowUp");
            Game.background = Content.Load<SoundEffect>("backround");
            Game.DoublePoints = Content.Load<SoundEffect>("Double Points");
            Game.Heal = Content.Load<SoundEffect>("heal");
            Game.GetPoint = Content.Load<SoundEffect>("point");
            Game.GameOver = Content.Load<SoundEffect>("gameOver");
            Game.Electric = Content.Load<SoundEffect>("electric2");
            Game.wolf = Content.Load<SoundEffect>("wolf");

            //fonts
            display = Content.Load<SpriteFont>("info");
            startFont = Content.Load<SpriteFont>("start");
            description = Content.Load<SpriteFont>("description");

            //sprite sheets
            Game.dog1 = Content.Load<Texture2D>("dog1");
            Game.dog2 = Content.Load<Texture2D>("dog2");
            Game.dog3 = Content.Load<Texture2D>("dog3");
            Game.dog4 = Content.Load<Texture2D>("dog4");
            Game.dog5 = Content.Load<Texture2D>("dog5");
            Game.dog6 = Content.Load<Texture2D>("dog6");
            Game.walk1 = Content.Load<Texture2D>("walk1");
            Game.walk2 = Content.Load<Texture2D>("walk2");
            Game.walk3 = Content.Load<Texture2D>("walk3");
            Game.walk4 = Content.Load<Texture2D>("walk4");
            Game.walk5 = Content.Load<Texture2D>("walk5");
            Game.walk6 = Content.Load<Texture2D>("walk6");
            Game.fire1 = Content.Load<Texture2D>("fire1");
            Game.fire2 = Content.Load<Texture2D>("fire2");
            Game.fire3 = Content.Load<Texture2D>("fire3");
            Game.fire4 = Content.Load<Texture2D>("fire4");
            Game.cloud1 = Content.Load<Texture2D>("cloud1");
            Game.cloud2 = Content.Load<Texture2D>("cloud2");
            Game.cloud3 = Content.Load<Texture2D>("cloud3");
            Game.cloud4 = Content.Load<Texture2D>("cloud4");
            Game.cloud5 = Content.Load<Texture2D>("cloud5");
            Game.cloud6 = Content.Load<Texture2D>("cloud6");
            Game.shock1 = Content.Load<Texture2D>("shock1");
            Game.shock2 = Content.Load<Texture2D>("shock2");
            Game.shock3 = Content.Load<Texture2D>("shock3");
            Game.shield = Content.Load<Texture2D>("shield");
            Game.shield1 = Content.Load<Texture2D>("shield1");
            Game.shield2 = Content.Load<Texture2D>("shield2");
            Game.shield3 = Content.Load<Texture2D>("shield3");
            Game.shield4 = Content.Load<Texture2D>("shield4");
            Game.shield5 = Content.Load<Texture2D>("shield5");
            Game.avatar1 = Content.Load<Texture2D>("avatar1");
            Game.avatar2 = Content.Load<Texture2D>("avatar2");
            Game.avatar3 = Content.Load<Texture2D>("avatar3");
            Game.avatar4 = Content.Load<Texture2D>("avatar4");
            Game.avatar5 = Content.Load<Texture2D>("avatar5");
            Game.avatar6 = Content.Load<Texture2D>("avatar6");
            Game.electric1 = Content.Load<Texture2D>("electric1");
            Game.electric2 = Content.Load<Texture2D>("electric8");
            Game.electric3 = Content.Load<Texture2D>("electric3");
            Game.electric4 = Content.Load<Texture2D>("electric4");
            Game.electric5 = Content.Load<Texture2D>("electric5");
            Game.electric6 = Content.Load<Texture2D>("electric6");
            Game.electric7 = Content.Load<Texture2D>("electric7");
            Game.electric8 = Content.Load<Texture2D>("electric8");
            Game.avatar_blow1 = Content.Load<Texture2D>("avatar_blow1");
            Game.avatar_blow2 = Content.Load<Texture2D>("avatar_blow2");
            Game.avatar_blow3 = Content.Load<Texture2D>("avatar_blow3");
            Game.avatar_blow4 = Content.Load<Texture2D>("avatar_blow4");
            Game.avatar_blow5 = Content.Load<Texture2D>("avatar_blow5");
            Game.avatar_blow6 = Content.Load<Texture2D>("avatar_blow6");
            Game.avatar_blow7 = Content.Load<Texture2D>("avatar_blow7");



            // build arrays
            Game.walkArr[0] = Game.walk1;
            Game.walkArr[1] = Game.walk2;
            Game.walkArr[2] = Game.walk3;
            Game.walkArr[3] = Game.walk4;
            Game.walkArr[4] = Game.walk5;
            Game.walkArr[5] = Game.walk6;
            Game.blastArr[0] = Game.fire1;
            Game.blastArr[1] = Game.fire2;
            Game.blastArr[2] = Game.fire3;
            Game.blastArr[3] = Game.fire4;
            Game.shockArr[0] = Game.shock1;
            Game.shockArr[1] = Game.shock1;
            Game.shockArr[2] = Game.shock2;
            Game.cloudArr[0] = Game.cloud1;
            Game.cloudArr[1] = Game.cloud2;
            Game.cloudArr[2] = Game.cloud3;
            Game.cloudArr[3] = Game.cloud4;
            Game.cloudArr[4] = Game.cloud5;
            Game.cloudArr[5] = Game.cloud6;
            Game.dogStateArr[0] = Game.dog1;
            Game.dogStateArr[1] = Game.dog2;
            Game.dogStateArr[2] = Game.dog3;
            Game.dogStateArr[3] = Game.dog4;
            Game.dogStateArr[4] = Game.dog5;
            Game.dogStateArr[5] = Game.dog6;
            Game.shieldArr[0] = Game.shield;
            Game.shieldArr[1] = Game.shield1;
            Game.shieldArr[2] = Game.shield2;
            Game.shieldArr[3] = Game.shield3;
            Game.shieldArr[4] = Game.shield4;
            Game.shieldArr[5] = Game.shield5;
            Game.avatarArr[0] = Game.avatar1;
            Game.avatarArr[1] = Game.avatar2;
            Game.avatarArr[2] = Game.avatar3;
            Game.avatarArr[3] = Game.avatar4;
            Game.avatarArr[4] = Game.avatar5;
            Game.avatarArr[5] = Game.avatar6;
            Game.ElectricArr[0] = Game.electric1;
            Game.ElectricArr[1] = Game.electric2;
            Game.ElectricArr[2] = Game.electric3;
            Game.ElectricArr[3] = Game.electric4;
            Game.ElectricArr[4] = Game.electric5;
            Game.ElectricArr[5] = Game.electric6;
            Game.ElectricArr[6] = Game.electric7;
            Game.ElectricArr[7] = Game.electric8;
            Game.avatar_blowArr[0] = Game.avatar_blow1;
            Game.avatar_blowArr[1] = Game.avatar_blow2;
            Game.avatar_blowArr[2] = Game.avatar_blow3;
            Game.avatar_blowArr[3] = Game.avatar_blow4;
            Game.avatar_blowArr[4] = Game.avatar_blow5;
            Game.avatar_blowArr[5] = Game.avatar_blow6;
            Game.avatar_blowArr[6] = Game.avatar_blow7;
        }
        protected override void UnloadContent()
        {
        }
        protected override void Update(GameTime gameTime)
        {
            KeyboardState keystate = Keyboard.GetState();
            MouseState mouseState = Mouse.GetState();

            refreash(true);

            if (Game.background.IsDisposed == true) { Game.background.Play(); }

            Game.shootPoint = new Rectangle((int)Game.point.X, (int)Game.point.Y, Game.pointWidth, Game.pointHeight);


            if (Game.EndGame == true) { GameOverMenu(keystate); }

            if (Game.startMenu == true) { startMenu(keystate); }

            if (Game.showenemy == true) { moveEnemy(); }

            if (Game.blowup == true) { blowUp(); }

            if (Game.lighteningAttack == true)
            {
                dog.lightCounter++;
                if (dog.lightCounter == 10) { dog.lightNUM++; dog.lightCounter = 0; }
                if (dog.lightNUM == 7) { dog.lightNUM = 1; }
            }
            else if (Game.ShieldDown == true && Game.EndGame == false && Game.startMenu == false && player1.Ammo != 0 && player1.doublePoint == true && player1.doublePoint == false)
            {
                Game.clickableShield = true;
                Game.gunControl = true;
                Game.clickable = true;
                Game.clickableShield = false;

            }

            //pause game
            if (keystate.IsKeyDown(Keys.P) && Game.startMenu == false) { Game.gamePos = 1; Game.startMenu = true; }


            //displaying information
            Game.DisplayInfo2 = "Kills: " + player1.killCount;
            Game.DisplayInfo3 = player1.Ammo.ToString();
            Game.reloadPos.X = Game.gunPos.X + 600;
            Game.reloadPos.Y = Game.gunPos.Y + 250;


            // Special packs
            if (Game.heartAlive == true)
            {
                Game.heartPos.Y -= 0.5f;
                if (Game.heartPos.Y <= 280) { Game.heartOpacity -= 0.05f; }
                if (Game.heartOpacity <= 0f) { Game.heartAlive = false; Game.heartOpacity = 1f; }
            }
            if (Game.deathAlive == true)
            {
                Game.deathPos.Y -= 0.5f;
                if (Game.deathPos.Y <= 280) { Game.deathOpacity = Game.deathOpacity - 0.05f; }
                if (Game.deathOpacity <= 0f) { Game.deathAlive = false; Game.deathOpacity = 1f; }
            }
            if (Game.doubleAlive == true)
            {
                Game.doublePos.Y -= 0.5f;
                if (Game.doublePos.Y <= 280) { Game.doubleOpacity -= 0.05f; }
                if (Game.deathOpacity <= 0f) { Game.doubleAlive = false; Game.doubleOpacity = 1f; }
            }


            //shield control
            if (keystate.IsKeyDown(Keys.Space) && Game.clickableShield == true)
            {
                Game.action = true;
                Game.clickableShield = false;
            }
            if (Game.action == true)
            {
                Game.clickableShield = false;
                shieldAnimation(Game.ShieldDown);
            }


            //incease health bar when not gettting hit
            bool found = false;
            for (int i = 0; i <= zombies.Length - 1; i++)
            {
                if (zombies[i].shooting == true) { found = true; }
            }
            if (found == false || Game.ShieldDown == false)
            {
                Game.healCount++;
                if (Game.healCount == 50) { player1.HealthBar += 2; Game.healCount = 0; }
            }
            else { found = false; }
            if (player1.HealthBar >= 0) { player1.HealthBar = 0; }

            //background conntrol
            if (Game.backgroundPos2.X == 0) { Game.screenDir = true; }
            else if (Game.backgroundPos2.X == -1000) { Game.screenDir = false; }


            //gun control
            if (mouseState.X >= 0 && mouseState.X <= 1000 && mouseState.Y >= 300 && mouseState.Y <= 490 && Game.gunControl == true) {
                Game.gunPos.X = mouseState.X - 495;
                Game.gunPos.Y = mouseState.Y - 295;
                Game.point.Y = mouseState.Y;
                Game.point.X = mouseState.X;
            }


            //mouse click and RELOAD ammo
            if (mouseState.LeftButton == ButtonState.Pressed && Game.clickable == true && mouseState.Y >= 300 && mouseState.Y <= 490)
            {
                clickAnimation(true);
                if (Game.shootOneBullet == false)
                {
                    Game.Shot.Play();
                    player1.Ammo--;
                    checkEnemy();
                    Game.shootOneBullet = true;
                    if (player1.doublePoint == true) { Game.blast = true; }
                }
            }
            else
            {
                clickAnimation(false);
                Game.shootOneBullet = false;
            }
            if (keystate.IsKeyDown(Keys.R) && Game.gunControl == true && player1.Ammo <= 0)
            {
                player1.Ammo = 10;
                Game.reload = "";
                clickAnimation(true);
                if (Game.ShieldDown == true) { Game.clickable = true; }
            }
            if (player1.Ammo <= 0) { Game.reload = "reload(R)"; Game.clickable = false; player1.Ammo = 0; }

            base.Update(gameTime);
        }
        public void shieldAnimation(bool shieldISDown)
        {
            if (shieldISDown == true)
            {
                Game.clickable = false;
                Game.shieldPos.Y = Game.shieldPos.Y - 20;
                if (Game.shieldPos.Y <= 0) { Game.action = false; Game.clickableShield = true; Game.ShieldDown = false; }
            }
            else
            {
                Game.shieldPos.Y = Game.shieldPos.Y + 20;
                if (Game.shieldPos.Y == 600) { Game.action = false; Game.clickableShield = true; Game.ShieldDown = true; Game.clickable = true; }
            }
        }
        public void clickAnimation(bool mouseISdown)
        {
            if (mouseISdown)
            {
                Game.gunPos.Y = Game.gunPos.Y + 20;
                Game.pointWidth = 15;
                Game.pointHeight = 15;
                Game.point.X = Game.point.X - 2;
                Game.point.Y = Game.point.Y + 8;
            }
            else { Game.pointWidth = 10; Game.pointHeight = 10; }
        }
        public void moveEnemy()
        {
            if (Game.screenDir == true)
            {
                positions[0].X--;
                positions[1].X--;
                positions[2].X--;
                positions[3].X--;
                positions[4].X--;
                positions[5].X--;
                Game.heartPos.X--;
                dogPos.X--;
                Game.deathPos.X--;
                Game.doublePos.X--;
                Game.backgroundPos.X -= 0.5f;
                Game.backgroundPos2.X--;
            }
            else
            {
                positions[0].X++;
                positions[1].X++;
                positions[2].X++;
                positions[3].X++;
                positions[4].X++;
                positions[5].X++;
                Game.heartPos.X++;
                dogPos.X++;
                Game.doublePos.X++;
                Game.deathPos.X++;
                Game.backgroundPos.X += 0.5f;
                Game.backgroundPos2.X++;
            }

            for (int i = 0; i <= zombies.Length - 1; i++)
            {
                if (zombies[i].alive == true)
                {
                    if (positions[i].X < player1.leftSideScreen) { zombies[i].position = 1; }
                    if (positions[i].X >= player1.centerScreen - zombies[i].arrange && positions[i].X <= player1.centerScreen + zombies[i].arrange) { zombies[i].shooting = true; zombies[i].position = 2; }
                    if (positions[i].X > player1.rightSideScreen) { zombies[i].position = 3; }
                }
            }

            for (int i = 0; i <= zombies.Length - 1; i++)
            {
                if (zombies[i].position == 1) { Animate("right", i); }
                else if (zombies[i].position == 3) { Animate("left", i); }
                else { fire(i); }
            }

            //control dog
            if (dog.alive == false)
            {
                if (player1.killCount >= dog.repeatAT)
                {
                    dog.alive = true;
                    dog.repeatAT += 20;

                }
            }
            else { moveDog(); }

            if (Game.blast == true)
            {
                Game.fireCount++;
                if (Game.fireCount == 5) { player1.blastNum++; }
                else if (Game.fireCount >= 11) { Game.fireCount = 0; }

                if (player1.blastNum == 5)
                {
                    Game.blast = false;
                    player1.blastNum = 0;
                }
            }

            if (player1.doublePoint == true)
            {
                Game.DisplayInfo = "DOUBLE DAMAGE!!!";
                player1.doubleCount++;
                if (player1.doubleCount >= 600)
                {
                    player1.doublePoint = false;
                    player1.doubleCount = 0;
                    Game.GunColour = Color.White;
                    Game.DisplayInfo = "";
                }
            }

            refreash(false);
        }
        public void moveDog()
        {
            if (dog.shooting == true)
            {
                dog.shieldOn = false;
                dog.count2++;
                if (dog.count2 == 22) { Game.wolf.Play(); Game.Electric.Play(); }
                if (dog.count2 <= 15) { dog.bodyState = 3; }
                else if (dog.count2 <= 22) { dog.bodyState = 4; }
                else
                {
                    dog.bodyState = 5;

                    //player abilities disabled
                    Game.clickableShield = false;
                    Game.lighteningAttack = true;
                    Game.gunControl = false;
                    Game.clickable = false;
                    Game.Damage = 4;

                    dog.count6++;
                    if (dog.count6 <= 10) { dog.electricState = 1; }
                    else if (dog.count6 <= 20) { dog.electricState = 2; }
                    else if (dog.count6 <= 30) { dog.electricState = 3; }
                    else { dog.count6 = 0; }

                }
                if (dog.count2 >= 300)
                {

                    dog.shooting = false;
                    dog.blast2 = true;
                    dog.exit = true;

                    //player abilities enabled
                    Game.Damage = 1;
                    dog.electricState = 0;
                    Game.lighteningAttack = false;
                    Game.clickableShield = true;
                    Game.gunControl = true;
                    Game.clickable = true;

                }

            } else {

                Random rnd = new Random();
                int jumps = rnd.Next(2, 6);//making random amount of jumps


                //dog blast where dog appears
                if (dog.blast == true)
                {
                    dog.shieldOn = false;
                    dog.count4++;
                    if (dog.count4 <= 10) { dog.blastState = 1; }
                    else if (dog.count4 <= 15) { dog.blastState = 2; }
                    else if (dog.count4 <= 20) { dog.blastState = 3; }
                    else if (dog.count4 <= 25) { dog.blastState = 4; dog.showing = true; }
                    else if (dog.count4 <= 30) { dog.blastState = 5; }
                    else if (dog.count4 <= 35) { dog.blastState = 6; }
                    else
                    {
                        dog.blastState = 0;
                        dog.count4 = 0;
                        dog.blast = false;
                    }
                }

                //showing dog section
                if (dog.showing == true)
                {

                    dog.count3++;
                    if (dog.count3 <= 30) { dog.bodyState = 1; }
                    else if (dog.count3 <= 50) { dog.bodyState = 2; }
                    else { dog.count3 = 0; dog.count5++; }

                    if (dog.count5 == 2) { dog.count5 = 0; dog.blast2 = true; }
                }
                else { dog.bodyState = 0; }

                //dog blast where dog Disappears
                if (dog.blast2 == true)
                {
                    dog.shieldOn = false;
                    dog.count4++;
                    if (dog.count4 <= 10) { dog.blastState = 1; }
                    else if (dog.count4 <= 15) { dog.blastState = 2; }
                    else if (dog.count4 <= 20) { dog.blastState = 3; }
                    else if (dog.count4 <= 25) { dog.blastState = 4; dog.showing = false; }
                    else if (dog.count4 <= 30) { dog.blastState = 5; }
                    else if (dog.count4 <= 35) { dog.blastState = 6; }
                    else
                    {
                        dog.blastState = 0;
                        dog.count4 = 0;
                        dog.blast2 = false;
                        dog.dogCounter++;
                        if (dog.exit == true) { dog.reset(); }
                    }
                }

                // if dog does not meets random amount of jumps: repeat cycle
                if (dog.dogCounter != jumps && dog.blast == false && dog.showing == false && dog.blast2 == false && dog.exit == false)
                {
                    dogPos.X = rnd.Next(100, 900);
                    dog.blast = true;
                }

                // if dog meets random amount of jumps: shooting = true
                if (dog.dogCounter >= jumps && dog.blast == false)
                {
                    dog.shooting = true;
                }

            }
        }
        public void Animate(string Dir, int x)
        {
            if (Dir == "dead")
            {
                if (Game.blowupdeath == true)
                {
                    removeTheDead(100);
                }
                else
                {
                    zombies[x].count++;
                    if (zombies[x].count < 8) { zombies[x].bodyState = 2; zombies[x].X = 30; zombies[x].Y = 20; }
                    else if (zombies[x].count < 13) { zombies[x].bodyState = 3; zombies[x].X = 30; zombies[x].Y = 5; }
                    else if (zombies[x].count < 19) { zombies[x].bodyState = 4; zombies[x].X = 30; zombies[x].Y = 25; }
                    else { zombies[x].bodyState = 5; zombies[x].X = 20; zombies[x].Y = 50; }
                    removeTheDead(x);
                }
            }
            else
            {
                if (Dir == "right")
                {
                    positions[x].X = positions[x].X + Game.EnemySpeed;
                    zombies[x].Direction = true;
                    zombies[x].shooting = false;

                    zombies[x].count++;
                    if (zombies[x].count < 15) { zombies[x].walkState = 4; }
                    else if (zombies[x].count < 25) { zombies[x].walkState = 5; }
                    else if (zombies[x].count < 40) { zombies[x].walkState = 6; }
                    else if (zombies[x].count < 55) { zombies[x].walkState = 5; }
                    else { zombies[x].walkState = 4; zombies[x].count = 0; }
                }
                else
                {
                    positions[x].X = positions[x].X - Game.EnemySpeed;
                    zombies[x].Direction = false;
                    zombies[x].shooting = false;

                    zombies[x].count++;
                    if (zombies[x].count < 15) { zombies[x].walkState = 1; }
                    else if (zombies[x].count < 25) { zombies[x].walkState = 2; }
                    else if (zombies[x].count < 40) { zombies[x].walkState = 3; }
                    else if (zombies[x].count < 55) { zombies[x].walkState = 2; }
                    else { zombies[x].walkState = 1; zombies[x].count = 0; }
                }
            }
        }
        public void refreash(bool x)
        {
            if (x == true)
            {
                zombies[0] = enemy1;
                zombies[1] = enemy2;
                zombies[2] = enemy3;
                zombies[3] = enemy4;
                zombies[4] = enemy5;
                zombies[5] = enemy6;
                positions[0] = enemyPos1;
                positions[1] = enemyPos2;
                positions[2] = enemyPos3;
                positions[3] = enemyPos4;
                positions[4] = enemyPos5;
                positions[5] = enemyPos6;
            }
            else
            {
                enemy1 = zombies[0];
                enemy2 = zombies[1];
                enemy3 = zombies[2];
                enemy4 = zombies[3];
                enemy5 = zombies[4];
                enemy6 = zombies[5];
                enemyPos1 = positions[0];
                enemyPos2 = positions[1];
                enemyPos3 = positions[2];
                enemyPos4 = positions[3];
                enemyPos5 = positions[4];
                enemyPos6 = positions[5];
            }
        }
        public void checkEnemy()//tagets hit when mouse click
        {
            int deadCounter = 0;

            for (int i = zombies.Length - 1; i >= 0; i--)
            {
                if (zombies[i].alive == true && deadCounter == 0)
                {
                    zombies[i].checkHit((int)positions[i].X, (int)positions[i].Y, (int)Game.point.X);
                    if (zombies[i].alive == false) { player1.killCount++; if (player1.doublePoint == true) { player1.killCount++; } deadCounter++; ThrowObject((int)positions[i].X, (int)positions[i].Y); }
                }
            }

            if (Game.heartAlive == true && deadCounter == 0)
            {
                for (int i = (int)Game.heartPos.X; i <= Game.heartPos.X + 50; i++)
                {
                    for (int k = (int)Game.heartPos.Y; k <= Game.heartPos.Y + 50; k++)
                    {
                        if (Game.point.X == i && Game.point.Y == k)
                        {
                            Game.Heal.Play();
                            Game.heartAlive = false;
                            player1.HealthBar = 0;
                            player1.shieldHealth = 4000;
                        }
                    }
                }
            }

            if (Game.deathAlive == true && deadCounter == 0)
            {
                for (int i = (int)Game.deathPos.X; i <= Game.deathPos.X + 50; i++)
                {
                    for (int k = (int)Game.deathPos.Y; k <= Game.deathPos.Y + 50; k++)
                    {
                        if (Game.point.X == i && Game.point.Y == k)
                        {
                            Game.blowUp.Play();
                            Game.deathAlive = false;
                            Game.blowup = true;
                        }
                    }
                }
            }

            if (Game.doubleAlive == true && deadCounter == 0)
            {
                for (int i = (int)Game.doublePos.X; i <= Game.doublePos.X + 50; i++)
                {
                    for (int k = (int)Game.doublePos.Y; k <= Game.doublePos.Y + 50; k++)
                    {
                        if (Game.point.X == i && Game.point.Y == k)
                        {
                            Game.DoublePoints.Play();
                            Game.doubleAlive = false;
                            player1.doublePoint = true;
                            Game.GunColour = Color.Gold;
                            player1.shieldHealth = 0;
                        }
                    }
                }
            }

            if (dog.alive == true)
            {
                for (int i = (int)dogPos.X; i <= dogPos.X + dog.width; i++)
                {
                    for (int k = (int)dogPos.Y; k <= dogPos.Y + dog.height; k++)
                    {
                        if (Game.point.X == i && Game.point.Y == k && dog.shooting == false) { dog.shieldOn = true; }
                    }
                }
            }

            deadCounter = 0;
        }
        public void fire(int x)
        {
            zombies[x].OpenFire++;
            if (zombies[x].OpenFire >= 5) { zombies[x].showingFire = 1f; healthHit(); }
            if (zombies[x].OpenFire == 10) { zombies[x].showingFire = 0f; zombies[x].OpenFire = 0; }
        }
        public void healthHit()
        {

            if (Game.ShieldDown == false)
            {
                player1.shieldHealth--;
                if (player1.shieldHealth >= 3500) { player1.shieldStatus = 0; }
                else if (player1.shieldHealth >= 3000) { player1.shieldStatus = 1; }
                else if (player1.shieldHealth >= 2500) { player1.shieldStatus = 2; }
                else if (player1.shieldHealth >= 2000) { player1.shieldStatus = 3; }
                else if (player1.shieldHealth >= 1500) { player1.shieldStatus = 4; }
                else { player1.shieldStatus = 5; }
            }
            else
            {
                Game.HitHealth++;
                if (Game.HitHealth >= 20) { player1.HealthBar -= Game.Damage; Game.HitHealth = 0; }

                //display health Bar
                if (player1.HealthBar < -300) { Game.bloodScreenOpacity = 1f; }
                else if (player1.HealthBar < -250) { Game.bloodScreenOpacity = 0.7f; }
                else if (player1.HealthBar < -220) { Game.bloodScreenOpacity = 0.5f; }
                else if (player1.HealthBar < -200) { Game.bloodScreenOpacity = 0.2f; }
                else { Game.bloodScreenOpacity = 0f; }

                //changing health bar colours
                if (player1.HealthBar <= -280) { Game.HealthColor = Color.Red; }
                else if (player1.HealthBar <= -250) { Game.HealthColor = Color.DarkOrange; }
                else if (player1.HealthBar <= -200) { Game.HealthColor = Color.DarkGreen; }
                else { Game.HealthColor = Color.LightGreen; }

            }

            if (player1.HealthBar <= -330 && Game.EndGame == false) { player1.HealthBar = -330; Game.GameOver.Play(); Game.EndGame = true; SoundEffect.MasterVolume = 0; }
            
            if (player1.shieldHealth <= 0) { player1.shieldHealth = 0; Game.ShieldDown = false; Game.action = true; }
        }
        public void removeTheDead(int enemy)
        {
            if (enemy == 100)
            {
                Game.gameoverCount++;
                if (Game.gameoverCount >= 200)
                {
                    Game.gameoverCount = 0;
                    Game.blowupdeath = false;
                    for(int i =0; i< zombies.Length; i++)
                    {
                        zombies[i].alive = true;
                    }
                    positions[0].X = 1000;
                    positions[1].X = 1300;
                    positions[2].X = -400;
                    positions[3].X = -800;
                    positions[4].X = -3000;
                    positions[5].X = 3000;
                }
            }
            else
            {
                zombies[enemy].Respawn++;
                if (zombies[enemy].Respawn >= 100)
                {
                    zombies[enemy].reset();
                    positions[enemy].X = zombies[enemy].ChangePlace();
                    zombies[enemy].Respawn = 0;
                    Game.blowupdeath = false;
                }
            }
            refreash(false);
        }
        public void ThrowObject(int X, int Y)
        {
            if (player1.killCount >= Game.pack)
            {
                Game.heartAlive = true;
                Game.heartPos.X = X + 140;
                Game.heartPos.Y = Y + 190;
                Game.pack += 20;
            }

            if (player1.killCount >= Game.pack2)
            {
                Game.deathAlive = true;
                Game.deathPos.X = X + 140;
                Game.deathPos.Y = Y + 190;
                Game.pack2 += 30;
            }

            if (player1.killCount >= Game.pack3)
            {
                Game.doubleAlive = true;
                Game.doublePos.X = X + 140;
                Game.doublePos.Y = Y + 190;
                Game.pack3 += 35;
            }
        }
        public void blowUp()
        {
            player1.blow++;
            if (player1.blow <= 10)
            {
                player1.blowUpState = 1;
                Game.showenemy = false;
                Game.blowupdeath = true;
                zombies[0].alive = false;
                zombies[1].alive = false;
                zombies[2].alive = false;
                zombies[3].alive = false;
                zombies[4].alive = false;
                zombies[5].alive = false;
                if (player1.blow == 1)
                {
                    Game.wolf.Dispose();
                    Game.Electric.Dispose();
                    Game.Heal.Dispose();
                    Game.DoublePoints.Dispose();
                }
                dog.alive = false;
            }
            else if (player1.blow <= 20) { player1.blowUpState = 2; }
            else if (player1.blow <= 30) { player1.blowUpState = 3; }
            else if (player1.blow <= 40) { player1.blowUpState = 4; }
            else if (player1.blow <= 50) { player1.blowUpState = 5; }
            else if (player1.blow <= 60) { player1.blowUpState = 6; }
            else if (player1.blow <= 70) { player1.blowUpState = 7; }
            else
            {
                player1.blowUpState = 0;
                player1.blow = 0;
                player1.killCount += 6;
                Game.blowup = false;
                Game.showenemy = true;
                Game.background.Play();
            }
        }
        public void GameOverMenu(KeyboardState x)
        {
            Game.clickable = false;
            Game.gunControl = false;
            Game.showenemy = false;
            Game.clickableShield = false;

            foreach (Keys key in x.GetPressedKeys())
            {
                if (key != Keys.Enter && Game.keyisup == true && player1.name.Length <= 2)
                {
                    for (int i = 0; i <= 25; i++)
                    {
                        if (key.ToString() == Game.LETTERS[i])
                        {
                            player1.name += key.ToString();
                            Game.keyisup = false;
                        }
                    }
                }
                if (key == Keys.Enter && player1.name.Length == 3 && Game.keyisup == true)
                {
                    Game.keyisup = false;
                    Game.nameCount++;
                    if (Game.nameCount == 1)
                    {
                        Game.GetPoint.Play();
                        Game.col1Names = "";
                        Game.col2Names = "";

                        for (int k = 0; k <= Game.col2.Length - 1; k++)
                        {
                            if (player1.killCount > Game.col2[k] && Game.added == false)
                            {
                                Game.col1Names += player1.name + "\n";
                                Game.col2Names += player1.killCount + "\n";
                                Game.added = true;
                            }
                            Game.col1Names += Game.col1[k] + "\n";
                            Game.col2Names += Game.col2[k] + "\n";
                        }
                        if (Game.added != true)
                        {
                            Game.col1Names += player1.name + "\n";
                            Game.col2Names += player1.killCount + "\n";
                        }
                        Game.bottomMenu = Game.bottomMenu + 25;
                    }
                    if (Game.nameCount == 2)
                    {
                        Game.gameStartAnimation = true;
                    }
                }
            }
            if (x.GetPressedKeys().Length == 0)
            {
                Game.keyisup = true;
            }

            if (Game.gameStartAnimation == true)
            {
                Game.gameoverCount++;
                if (Game.gameoverCount <= 50) { Game.disapear = Game.disapear - 0.05f; Game.disapearGame = Game.disapearGame + 0.05f; }
                else if (Game.gameoverCount > 50) { Game.gameoverCount = 0; }

                if (Game.disapear <= -5) { Exit(); }
            }
        }
        public void startMenu(KeyboardState x)
        {
            Game.clickable = false;
            Game.gunControl = false;
            Game.showenemy = false;
            

            if (x.IsKeyDown(Keys.Down) && Game.keyisup == true && Game.gamePos <= 4)
            {
                Game.startSelect.Y += 75;
                Game.gamePos++;
                Game.keyisup = false;
            }
            else if (x.IsKeyDown(Keys.Up) && Game.keyisup == true && Game.gamePos >= 2)
            {
                Game.startSelect.Y -= 75;
                Game.gamePos--;
                Game.keyisup = false;
            }

            if (x.IsKeyDown(Keys.Enter))
            {
                if (Game.gamePos == 1)
                {
                    if (Game.pause == true) { Game.GetPoint.Play(); Game.gameStartAnimation = true; }
                    else
                    {
                        Game.clickable = true;
                        Game.gunControl = true;
                        Game.showenemy = true;
                        Game.startMenu = false;
                        Game.gameStartAnimation = false;
                        Game.pause = false;
                        Game.disapearGame = 0.7f;
                        Game.disapear = 1f;
                        Game.gameoverCount = 0;
                    }
                }
                else if (Game.gamePos == 2) { Game.howTOplay = true; Game.start = false; }
                else if (Game.gamePos == 3) { Game.About = true; Game.howTOplay = false; Game.start = false; }
                else if (Game.gamePos == 4) { Game.help = true; Game.About = false; Game.howTOplay = false; Game.start = false; }
                else { Exit(); }
            }

            if (x.IsKeyDown(Keys.Back) && Game.start == false)
            {
                Game.start = true;
                Game.help = false;
                Game.About = false;
                Game.howTOplay = false;
            }

            if (Game.gameStartAnimation == true)
            {
                Game.gameoverCount++;
                if (Game.gameoverCount == 10)
                {
                    if (Game.gameover2 == true) { Game.disapear = Game.disapear - 0.5f; }
                    else { Game.disapearGame = Game.disapearGame - 0.05f; }
                }
                else if (Game.gameoverCount > 10) { Game.gameoverCount = 0; }


                if (Game.disapear <= -4.5)
                {
                    Game.gameover2 = false;
                    Game.gunControl = true;
                }
                if (Game.disapearGame <= 0.5)
                {
                    Game.clickable = true;
                    Game.showenemy = true;
                    Game.startMenu = false;
                    Game.background.Play();
                    Game.gameStartAnimation = false;
                    Game.pause = false;
                    Game.disapearGame = 0.7f;
                    Game.disapear = 1f;
                    Game.gameoverCount = 0;
                }
            }

            int y = x.GetPressedKeys().Length;
            if (y == 0) { Game.keyisup = true; }
        }
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            ZombieGame.Begin();
            ZombieGame.Draw(Game.background1, new Rectangle((int)Game.backgroundPos.X, (int)Game.backgroundPos.Y, 2000, 600), Color.White);
            ZombieGame.Draw(Game.background2, new Rectangle((int)Game.backgroundPos2.X, (int)Game.backgroundPos.Y, 2000, 600), Color.White);

            //health pack
            if (Game.heartAlive == true) { ZombieGame.Draw(Game.heart, new Rectangle((int)Game.heartPos.X, (int)Game.heartPos.Y, 50, 50), Color.White * Game.heartOpacity); }
            if (Game.deathAlive == true) { ZombieGame.Draw(Game.death, new Rectangle((int)Game.deathPos.X, (int)Game.deathPos.Y, 50, 50), Color.White * Game.deathOpacity); }
            if (Game.doubleAlive == true) { ZombieGame.Draw(Game.double_pack, new Rectangle((int)Game.doublePos.X, (int)Game.doublePos.Y, 50, 50), Color.White * Game.doubleOpacity); }

            //the blow up animation from browUp()
            if (player1.blowUpState != 0)
            {
                ZombieGame.Draw((Texture2D)Game.avatar_blowArr[player1.blowUpState - 1], positions[0], Color.White);
                ZombieGame.Draw((Texture2D)Game.avatar_blowArr[player1.blowUpState - 1], positions[1], Color.White);
                ZombieGame.Draw((Texture2D)Game.avatar_blowArr[player1.blowUpState - 1], positions[2], Color.White);
                ZombieGame.Draw((Texture2D)Game.avatar_blowArr[player1.blowUpState - 1], positions[3], Color.White);
                ZombieGame.Draw((Texture2D)Game.avatar_blowArr[player1.blowUpState - 1], positions[4], Color.White);
                ZombieGame.Draw((Texture2D)Game.avatar_blowArr[player1.blowUpState - 1], positions[5], Color.White);
                ZombieGame.Draw((Texture2D)Game.avatar_blowArr[player1.blowUpState - 1], dogPos, Color.White);
            }

            if (Game.showenemy == true || Game.startMenu == true)
            {

                //death animation and making dead bodies fall behind
                if (Game.blowupdeath == false)
                {
                    if (zombies[0].alive == false) { Animate("dead", 0); ZombieGame.Draw((Texture2D)Game.avatarArr[zombies[0].bodyState - 1], new Vector2(positions[0].X + zombies[0].X, positions[0].Y + zombies[0].Y), Color.White); }
                    if (zombies[1].alive == false) { Animate("dead", 1); ZombieGame.Draw((Texture2D)Game.avatarArr[zombies[1].bodyState - 1], new Vector2(positions[1].X + zombies[1].X, positions[1].Y + zombies[1].Y), Color.White); }
                    if (zombies[2].alive == false) { Animate("dead", 2); ZombieGame.Draw((Texture2D)Game.avatarArr[zombies[2].bodyState - 1], new Vector2(positions[2].X + zombies[2].X, positions[2].Y + zombies[2].Y), Color.White); }
                    if (zombies[3].alive == false) { Animate("dead", 3); ZombieGame.Draw((Texture2D)Game.avatarArr[zombies[3].bodyState - 1], new Vector2(positions[3].X + zombies[3].X, positions[3].Y + zombies[3].Y), Color.White); }
                    if (zombies[4].alive == false) { Animate("dead", 4); ZombieGame.Draw((Texture2D)Game.avatarArr[zombies[4].bodyState - 1], new Vector2(positions[4].X + zombies[4].X, positions[4].Y + zombies[4].Y), Color.White); }
                    if (zombies[5].alive == false) { Animate("dead", 5); ZombieGame.Draw((Texture2D)Game.avatarArr[zombies[5].bodyState - 1], new Vector2(positions[5].X + zombies[5].X, positions[5].Y + zombies[5].Y), Color.White); }
                }

          
                //removing the dead
                for (int i = 0; i <= zombies.Length-1; i++) { if (zombies[i].alive == false) { removeTheDead(i); } }

                //Zombie 1
                if (zombies[0].alive == true)
                {
                    if (zombies[0].shooting == false)
                    {
                        ZombieGame.Draw((Texture2D)Game.walkArr[zombies[0].walkState - 1], positions[0], Color.White);

                    } else {
                        ZombieGame.Draw(Game.avatar1, positions[0], Color.White);
                        ZombieGame.Draw(Game.gunFire, new Rectangle((int)positions[0].X + 40, (int)positions[0].Y + 70, 120, 120), Color.White * zombies[0].showingFire);
                    }
                }

                // Zombie 2
                if (zombies[1].alive == true)
                {
                    if (zombies[1].shooting == false)
                    {
                        ZombieGame.Draw((Texture2D)Game.walkArr[zombies[1].walkState - 1], positions[1], Color.White);

                    } else {
                        ZombieGame.Draw(Game.avatar1, positions[1], Color.White);
                        ZombieGame.Draw(Game.gunFire, new Rectangle((int)positions[1].X + 40, (int)positions[1].Y + 70, 120, 120), Color.White * zombies[1].showingFire);
                    }
                }

                // Zombie 3
                if (zombies[2].alive == true)
                {
                    if (zombies[2].shooting == false)
                    {
                        ZombieGame.Draw((Texture2D)Game.walkArr[zombies[2].walkState - 1], positions[2], Color.White);
                    }
                    else
                    {
                        ZombieGame.Draw(Game.avatar1, positions[2], Color.White);
                        ZombieGame.Draw(Game.gunFire, new Rectangle((int)positions[2].X + 40, (int)positions[2].Y + 70, 120, 120), Color.White * zombies[2].showingFire);
                    }
                }

                //Zombie 4
                if (zombies[3].alive == true)
                {
                    if (zombies[3].shooting == false)
                    {
                        ZombieGame.Draw((Texture2D)Game.walkArr[zombies[3].walkState - 1], positions[3], Color.White);
                    }
                    else
                    {
                        ZombieGame.Draw(Game.avatar1, positions[3], Color.White);
                        ZombieGame.Draw(Game.gunFire, new Rectangle((int)positions[3].X + 40, (int)positions[3].Y + 70, 120, 120), Color.White * zombies[3].showingFire);
                    }
                }

                //Zombie 5
                if (zombies[4].alive == true)
                {
                    if (zombies[4].shooting == false)
                    {
                        ZombieGame.Draw((Texture2D)Game.walkArr[zombies[4].walkState - 1], positions[4], Color.White);
                    }
                    else
                    {
                        ZombieGame.Draw(Game.avatar1, positions[4], Color.White);
                        ZombieGame.Draw(Game.gunFire, new Rectangle((int)positions[4].X + 40, (int)positions[4].Y + 70, 120, 120), Color.White * zombies[4].showingFire);
                    }
                }

                //Zombie 6
                if (zombies[5].alive == true)
                {
                    if (zombies[5].shooting == false)
                    {
                        ZombieGame.Draw((Texture2D)Game.walkArr[zombies[5].walkState - 1], positions[5], Color.White);
                    }
                    else
                    {
                        ZombieGame.Draw(Game.avatar1, positions[5], Color.White);
                        ZombieGame.Draw(Game.gunFire, new Rectangle((int)positions[5].X + 40, (int)positions[5].Y + 70, 120, 120), Color.White * zombies[5].showingFire);
                    }
                }

                //three headed dog
                if (dog.alive == true)
                {
                    if (dog.bodyState != 0) { ZombieGame.Draw((Texture2D)Game.dogStateArr[dog.bodyState - 1], new Rectangle((int)dogPos.X, (int)dogPos.Y, dog.width, dog.height), Color.White); }
                    if (dog.blastState != 0) { ZombieGame.Draw((Texture2D)Game.cloudArr[dog.blastState - 1], new Rectangle((int)dogPos.X, (int)dogPos.Y, dog.width, dog.height), Color.White); }
                    if (dog.electricState != 0) { ZombieGame.Draw((Texture2D)Game.shockArr[dog.electricState - 1], new Rectangle((int)dogPos.X, (int)dogPos.Y, dog.width, dog.height), Color.White); }
                    if (dog.shieldOn == true) { ZombieGame.Draw(Game.dog_shield, new Rectangle((int)dogPos.X, (int)dogPos.Y, dog.width, dog.height), Color.White); }
                    if (Game.lighteningAttack == true) { ZombieGame.Draw((Texture2D)Game.ElectricArr[dog.lightNUM - 1], new Rectangle(0, 0, 1000, 600), Color.White); }
                }
            }

            //shield
            ZombieGame.Draw((Texture2D)Game.shieldArr[player1.shieldStatus], Game.shieldPos, Color.White);

            //flame from gun
            if (player1.blastNum != 0) { ZombieGame.Draw((Texture2D)Game.blastArr[player1.blastNum - 1], new Vector2((int)Game.gunPos.X + 100, (int)Game.gunPos.Y + 210), Color.White); }
            
            ZombieGame.Draw(Game.gun, new Rectangle((int)Game.gunPos.X, (int)Game.gunPos.Y, 1000, 600), Game.GunColour);
            ZombieGame.FillRectangle(Game.shootPoint, Color.Red);
            ZombieGame.DrawString(display, Game.DisplayInfo3, new Vector2(Game.gunPos.X + 480, Game.gunPos.Y + 515), Color.Gray);
            ZombieGame.Draw(Game.Mask, new Rectangle(0, 0, 1000, 600), Game.GunColour * 0.85f);

            //display information
            ZombieGame.Draw(Game.bloodScreen, new Rectangle(0, 0, 1000, 600), Color.White * Game.bloodScreenOpacity);
            ZombieGame.Draw(Game.healthbar2, new Rectangle(player1.HealthBar, -40, 450, 240), Game.HealthColor);
            ZombieGame.Draw(Game.healthbar, new Rectangle(0, -40, 450, 240), Color.White);
            ZombieGame.DrawString(display, Game.DisplayInfo, Game.displayPos, Color.Red);
            ZombieGame.DrawString(display, Game.DisplayInfo2, Game.DisplayInfo2Pos, Color.White);
            ZombieGame.DrawString(display, Game.reload, Game.reloadPos, Color.Gray);

            //game over menu
            if (Game.EndGame == true)
            {
                ZombieGame.Draw(Game.block, new Rectangle(0, 0, 1000, 600), Color.Black * (Game.disapearGame - 0.3f));
                ZombieGame.DrawString(display, "Game Over", new Vector2(290, 90), Color.DarkGray);

                ZombieGame.Draw(Game.block, new Rectangle(290, 120, 400, 50), Color.DarkSlateGray * Game.disapear);
                ZombieGame.DrawString(display, "Enter Name: " + player1.name, new Vector2(300, 130), Color.DarkGray * Game.disapear);

                ZombieGame.Draw(Game.block, new Rectangle(290, 180, 400, Game.bottomMenu), Color.DarkSlateGray * (Game.disapear - 0.3f));
                ZombieGame.DrawString(display, Game.col1Names, new Vector2(300, 190), Color.DarkGray * Game.disapear);
                ZombieGame.DrawString(display, Game.col2Names, new Vector2(615, 190), Color.DarkGray * Game.disapear);
            }

            //start up menu
            if (Game.startMenu == true)
            {
                Game.bloodDripPos.Y += 0.3f;
                if(Game.bloodDripPos.Y >= -80) { Game.bloodDripPos.Y = -80f; }
                ZombieGame.Draw(Game.block, new Rectangle(0, 0, 1000, 600), Color.Black * Game.disapearGame);
                ZombieGame.Draw(Game.bloodDrip, new Rectangle((int)Game.bloodDripPos.X, (int)Game.bloodDripPos.Y, 1000, 600), Color.DarkRed * Game.disapear);
                
                if (Game.start == true)
                {
                    string displaying;
                    if(Game.pause == false) { displaying = "   Resume\n\nHow To Play\n\n    About\n\n     Help"; }
                    else { displaying = "    Start\n\nHow To Play\n\n    About\n\n     Help"; }

                    ZombieGame.DrawString(display, "Ready Player One", new Vector2(370, 108), Color.DarkGray * Game.disapear);
                    ZombieGame.Draw(Game.block, new Rectangle(370, 140, 260, 320), Color.DarkSlateGray * (Game.disapear - 0.3f));
                    ZombieGame.Draw(Game.block, new Rectangle(370, (int)Game.startSelect.Y, 260, 65), Color.Gray * (Game.disapear - 0.3f));
                    ZombieGame.DrawString(startFont, displaying, new Vector2(395, 190), Color.DarkGray * Game.disapear);
                    ZombieGame.DrawString(startFont, "Exit", new Vector2(470, 490), Color.DarkGray * Game.disapear);
                }
                else if (Game.howTOplay == true)
                {
                    string displaying  ="(MOUSE):\nControls gun movement with right click \nfireing bullets\n\n(SPACE):\nBrings riot shield in defence of \ncombate\n\n(R):\nReloads the gun when out of ammo\n\n(P):\nPause for game menu"+
                    "\n\n                                            Return(back)";
                    ZombieGame.DrawString(display, "How to play()", new Vector2(370, 110), Color.DarkGray * Game.disapear);
                    ZombieGame.Draw(Game.block, new Rectangle(370, 140, 260, 215), Color.DarkSlateGray * (Game.disapear - 0.3f));
                    ZombieGame.DrawString(description, displaying, new Vector2(375, 150), Color.DarkGray * Game.disapear);
                }
                else if (Game.About == true)
                {
                    string displaying =
                    "Copy Right:                          2017/12/12\n" +
                    "Using:                           XNA MonoGame\n" +
                    "Title:                          Zombie Smasher!\n" +
                    "Game Edition:                                    iii\n" +
                    "Public domain:                        Available\n" +
                    "Game version:                               3.4.1\n" +
                    "Language used:                               C#\n" +
                    "Game Size:                                 123GB\n\n\n" +
                    "by:Simon Gebremichael\n\n" +
                    "                                           Return(back)";
                    ZombieGame.DrawString(display, "About()", new Vector2(370, 108), Color.DarkGray * Game.disapear);
                    ZombieGame.Draw(Game.block, new Rectangle(370, 140, 260, 175), Color.DarkSlateGray * (Game.disapear - 0.3f));
                    ZombieGame.DrawString(description, displaying, new Vector2(375, 145), Color.White * (Game.disapear - 0.4f));
                }
                else if (Game.help == true)
                {
                    string displaying = 
                    "(Zombies)\nthey can not be killed while walking but\ncan when shooting.\n\n"+
                    "(Dog)\nThe dog cant be killed but using the riot\nshield will help.\n\n"+
                    "(Player)\nusing the mouse the control the gun \nand left click to shoot the player comes \nwith a riot shield as well health bar will \nincrease if the player is not getting shot \nat.\n\n"+
                    "(Items)\nThroughout the game a health pack or \na death pack will appear in combate.\n\n"+
                    "                                           Return(back)";

                    ZombieGame.DrawString(display, "Help()", new Vector2(370, 110), Color.DarkGray * Game.disapear);
                    ZombieGame.Draw(Game.block, new Rectangle(370, 140, 260, 280), Color.DarkSlateGray * (Game.disapear - 0.3f));
                    ZombieGame.DrawString(description, displaying, new Vector2(375, 145), Color.DarkGray * Game.disapear);
                }
            }

            ZombieGame.End();
            base.Draw(gameTime);

        }
    }
}