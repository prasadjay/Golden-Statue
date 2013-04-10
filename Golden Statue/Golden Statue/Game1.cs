using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace Golden_Statue
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;



        bool welcome = false;
        bool x = false;
        bool lvl2 = false;

        bool leftArrowPressed = false;
        bool end = false;

        bool ifLevel1;
        bool ifLevel2;
        bool ifLevel3;

        Texture2D level2End;
        Vector2 level2EndPos = new Vector2(31900, 568);

        #region marks_Saves_Tries

        int marks = 500;

        int saveCount = 0;
        int saveTry = 0;
        int tryCount = 0;

        public bool isPaused = false;

        public Vector2 pausedPoint = Vector2.Zero;
        Vector2 saveHero = new Vector2(1300, 400);

        int powerUsageCount = 800;

        //bool powerup1 = false;
        //bool powerup2 = false;
        //bool powerup3 = false;

        #endregion


        #region logs


        Texture2D log;
        public float logSpeed = 0.5f;


        //level 1

        public Vector2 logPos1 = new Vector2(2000, 500);
        public Vector2 logPos2 = new Vector2(3900, 500);
        public Vector2 logPos3 = new Vector2(6100, 500);
        public Vector2 logPos4 = new Vector2(6950, 500);
        public Vector2 logPos5 = new Vector2(8900, 500);

        //level 2

        public Vector2 logPos6 = new Vector2(15100, 500);
        public Vector2 logPos7 = new Vector2(17500, 500);
        public Vector2 logPos8 = new Vector2(20900, 500);
        public Vector2 logPos9 = new Vector2(23100, 500);
        public Vector2 logPos10 = new Vector2(29500, 500);
        public Vector2 logPos11 = new Vector2(31450, 500);

        //public Vector2 logPos12 = new Vector2(2500000, 500);



        //public Vector2 logPos13 = new Vector2(25000000, 500);
        //public Vector2 logPos14 = new Vector2(25000000, 500);
        //public Vector2 logPos15 = new Vector2(25000000, 500);
        //public Vector2 logPos16 = new Vector2(25000000, 500);
        //public Vector2 logPos17 = new Vector2(25000000, 500);
        //public Vector2 logPos18 = new Vector2(19000, 500);
        //public Vector2 logPos19 = new Vector2(20000, 500);
        //public Vector2 logPos20 = new Vector2(21000, 500);
        //public Vector2 logPos21 = new Vector2(22000, 500);
        //public Vector2 logPos22 = new Vector2(23000, 500);
        //public Vector2 logPos23 = new Vector2(24000, 500);
        //public Vector2 logPos24 = new Vector2(25100, 500);





        #endregion


        #region water

        Texture2D water;

        public Vector2 waterPos1 = new Vector2(1950, 670);
        public Vector2 waterPos2 = new Vector2(3500, 670);
        public Vector2 waterPos3 = new Vector2(7000, 670);
        public Vector2 waterPos4 = new Vector2(9500, 670);
        public Vector2 waterPos5 = new Vector2(12050, 670);

        public Vector2 waterPos6 = new Vector2(14000, 670);
        public Vector2 waterPos7 = new Vector2(16000, 670);
        public Vector2 waterPos8 = new Vector2(18000, 670);
        public Vector2 waterPos9 = new Vector2(20000, 670);
        public Vector2 waterPos10 = new Vector2(23000, 670);

        Point waterFrameSize = new Point(250, 40);
        Point waterCurrentFrame = new Point(0, 0);
        Point waterSheetSize = new Point(2, 2);

        int water_timeSinceLastFrame = 0;
        int water_timePerFrame = 150;


        #endregion


        #region markBanner
        Texture2D markBanner;

        public Vector2 bannerPos1 = new Vector2(740, 0);
        public Vector2 bannerPos2 = new Vector2(2020, 0);
        public Vector2 bannerPos3 = new Vector2(3300, 0);
        public Vector2 bannerPos4 = new Vector2(4580, 0);
        public Vector2 bannerPos5 = new Vector2(5860, 0);
        public Vector2 bannerPos6 = new Vector2(7140, 0);
        public Vector2 bannerPos7 = new Vector2(8420, 0);
        public Vector2 bannerPos8 = new Vector2(9700, 0);
        public Vector2 bannerPos9 = new Vector2(10980, 0);
        public Vector2 bannerPos10 = new Vector2(12260, 0);
        public Vector2 bannerPos11 = new Vector2(13540, 0);
        public Vector2 bannerPos12 = new Vector2(14820, 0);
        public Vector2 bannerPos13 = new Vector2(16100, 0);
        public Vector2 bannerPos14 = new Vector2(17380, 0);
        public Vector2 bannerPos15 = new Vector2(18660, 0);
        public Vector2 bannerPos16 = new Vector2(19940, 0);
        public Vector2 bannerPos17 = new Vector2(21220, 0);
        public Vector2 bannerPos18 = new Vector2(22500, 0);
        public Vector2 bannerPos19 = new Vector2(23780, 0);
        public Vector2 bannerPos20 = new Vector2(25060, 0);

        public Vector2 bannerPos21 = new Vector2(25060, 0);
        public Vector2 bannerPos22 = new Vector2(26340, 0);
        public Vector2 bannerPos23 = new Vector2(27620, 0);
        public Vector2 bannerPos24 = new Vector2(28900, 0);
        public Vector2 bannerPos25 = new Vector2(30180, 0);
        public Vector2 bannerPos26 = new Vector2(31460, 0);
        public Vector2 bannerPos27 = new Vector2(34000, 0);
        public Vector2 bannerPos28 = new Vector2(35280, 0);
        public Vector2 bannerPos29 = new Vector2(36560, 0);
        public Vector2 bannerPos30 = new Vector2(37840, 0);
        public Vector2 bannerPos31 = new Vector2(39120, 0);

        public Vector2 bannerPos32 = new Vector2(40400, 0);
        public Vector2 bannerPos33 = new Vector2(41680, 0);
        public Vector2 bannerPos34 = new Vector2(42960, 0);
        public Vector2 bannerPos35 = new Vector2(44240, 0);
        public Vector2 bannerPos36 = new Vector2(45520, 0);
        public Vector2 bannerPos37 = new Vector2(46800, 0);
        public Vector2 bannerPos38 = new Vector2(48080, 0);
        public Vector2 bannerPos39 = new Vector2(49360, 0);
        public Vector2 bannerPos40 = new Vector2(50640, 0);
        public Vector2 bannerPos41 = new Vector2(51920, 0);
        public Vector2 bannerPos42 = new Vector2(53200, 0);


        #endregion



        #region hero

        //Character info



        bool playerDied = false;



        Texture2D hero;
        Texture2D heroBlocked;
        Texture2D heroReverse;
        public Rectangle heroRect;
        public Vector2 heroPosition = Vector2.Zero;
        public float heroSpeed = 8;

        Point heroFrameSize = new Point(100, 250);
        Point heroCurrentFrame = new Point(0, 0);
        Point heroSheetSize = new Point(2, 4);

        Point heroReverseFrameSize = new Point(100, 250);
        Point heroReverseCurrentFrame = new Point(0, 0);
        Point heroReverseSheetSize = new Point(2, 4);

        int hero_timeSinceLastFrame = 0;
        int hero_timePerFrame = 350;

        // Position of the character
        float velocityX = 5.0f, velocityY;     // Velocity of the character
        float gravity = 5f;


        // invisible blocks for player

        Texture2D levelBlock1_1;
        Vector2 BlockPos1_1 = new Vector2(1280, 20);
        Vector2 BlockPos1_2 = new Vector2(10240, 20);
        Vector2 BlockPos2_1 = new Vector2(12512, 20);
        Vector2 BlockPos2_2 = new Vector2(31968, 20);
        Vector2 BlockPos3_1 = new Vector2(34512, 20);
        Vector2 BlockPosB1 = new Vector2(-2468, 20);
        Vector2 BlockPosB2 = new Vector2(-932, 20);



        #endregion



        #region enemy

        Texture2D enemy;

        public float enemySpeed2 = 8;
        public float enemyReversed = 1;

        Point enemyFrameSize = new Point(300, 300);
        Point enemyCurrentFrame = new Point(0, 0);
        Point enemySheetSize = new Point(2, 2);

        int enemy_timeSinceLastFrame = 0;
        int enemy_timePerFrame = 50;
        int enemyOffset = 50;


        //level 1
        Vector2 enemyPos1 = new Vector2(3000, 50);
        Vector2 enemyPos2 = new Vector2(4400, 50);
        Vector2 enemyPos3 = new Vector2(5000, 50);
        Vector2 enemyPos4 = new Vector2(8300, 50);
        Vector2 enemyPos5 = new Vector2(9400, 50);

        //level 2

        Vector2 enemyPos6 = new Vector2(13100, 50);
        Vector2 enemyPos7 = new Vector2(13800, 100);
        Vector2 enemyPos8 = new Vector2(14600, 100);
        Vector2 enemyPos9 = new Vector2(16800, 50);
        Vector2 enemyPos10 = new Vector2(19500, 300);
        Vector2 enemyPos11 = new Vector2(20392, 50);
        Vector2 enemyPos12 = new Vector2(21500, 50);
        Vector2 enemyPos13 = new Vector2(21900, 150);
        Vector2 enemyPos14 = new Vector2(23700, 50);
        Vector2 enemyPos15 = new Vector2(24700, 50);
        Vector2 enemyPos16 = new Vector2(26500, 100);
        Vector2 enemyPos17 = new Vector2(28500, 300);
        Vector2 enemyPos18 = new Vector2(28900, 50);
        Vector2 enemyPos19 = new Vector2(30700, 50);
        Vector2 enemyPos20 = new Vector2(213000, 10);

        //level 3


        Vector2 enemyPos21 = new Vector2(35800, 50);
        Vector2 enemyPos22 = new Vector2(36300, 50);
        Vector2 enemyPos23 = new Vector2(37900, 300);
        Vector2 enemyPos24 = new Vector2(39400, 50);
        Vector2 enemyPos25 = new Vector2(42600, 100);
        Vector2 enemyPos26 = new Vector2(46400, 50);
        Vector2 enemyPos27 = new Vector2(49200, 100);
        Vector2 enemyPos28 = new Vector2(50450, 50);
        Vector2 enemyPos29 = new Vector2(50900, 300);
        Vector2 enemyPos30 = new Vector2(53700, 50);






        #endregion

        #region diamonds

        public int diamondCount = 0;

        Texture2D diamond;

        Point diamondFrameSize = new Point(50, 50);
        Point diamondCurrentFrame = new Point(0, 0);
        Point diamondSheetSize = new Point(2, 2);
        int diamond_timeSinceLastFrame = 0;
        int diamond_timePerFrame = 150;

        // TEXTURES

        //level 1

        public Vector2 diamondPos1 = new Vector2(1400, 500);
        public Vector2 diamondPos2 = new Vector2(2200, 100);
        public Vector2 diamondPos3 = new Vector2(2250, 100);
        public Vector2 diamondPos4 = new Vector2(3400, 150);
        public Vector2 diamondPos5 = new Vector2(4800, 150);
        public Vector2 diamondPos6 = new Vector2(5300, 150);
        public Vector2 diamondPos7 = new Vector2(6200, 150);
        public Vector2 diamondPos8 = new Vector2(9100, 100);
        public Vector2 diamondPos9 = new Vector2(9150, 200);
        public Vector2 diamondPos10 = new Vector2(9900, 250);

        //level 2


        public Vector2 diamondPos11 = new Vector2(12700, 300);
        public Vector2 diamondPos12 = new Vector2(13500, 200);
        public Vector2 diamondPos13 = new Vector2(14400, 100);
        public Vector2 diamondPos14 = new Vector2(14500, 100);
        public Vector2 diamondPos15 = new Vector2(14450, 150);
        public Vector2 diamondPos16 = new Vector2(15200, 150);
        public Vector2 diamondPos17 = new Vector2(16800, 150);
        public Vector2 diamondPos18 = new Vector2(17800, 150);
        public Vector2 diamondPos19 = new Vector2(17900, 250);
        public Vector2 diamondPos20 = new Vector2(19500, 300);
        public Vector2 diamondPos21 = new Vector2(19550, 500);
        public Vector2 diamondPos22 = new Vector2(21200, 100);
        public Vector2 diamondPos23 = new Vector2(21600, 100);
        public Vector2 diamondPos24 = new Vector2(21650, 150);
        public Vector2 diamondPos25 = new Vector2(21700, 150);
        public Vector2 diamondPos26 = new Vector2(25500, 150);
        public Vector2 diamondPos27 = new Vector2(25700, 150);
        public Vector2 diamondPos28 = new Vector2(25900, 100);
        public Vector2 diamondPos29 = new Vector2(26800, 200);
        public Vector2 diamondPos30 = new Vector2(27700, 250);
        public Vector2 diamondPos31 = new Vector2(27800, 100);
        public Vector2 diamondPos32 = new Vector2(28600, 200);
        public Vector2 diamondPos33 = new Vector2(30000, 100);
        public Vector2 diamondPos34 = new Vector2(30800, 150);

        //extra stuff

        public Vector2 diamondPos35 = new Vector2(250000, 150);
        public Vector2 diamondPos36 = new Vector2(161000, 150);
        public Vector2 diamondPos37 = new Vector2(168000, 150);
        public Vector2 diamondPos38 = new Vector2(173000, 150);
        public Vector2 diamondPos39 = new Vector2(180500, 250);
        public Vector2 diamondPos40 = new Vector2(141500, 300);



        //VISIBILITY

        //level 1

        bool visibility1 = true;
        bool visibility2 = true;
        bool visibility3 = true;
        bool visibility4 = true;
        bool visibility5 = true;
        bool visibility6 = true;
        bool visibility7 = true;
        bool visibility8 = true;
        bool visibility9 = true;
        bool visibility10 = true;
        bool visibility11 = true;
        bool visibility12 = true;
        bool visibility13 = true;
        bool visibility14 = true;
        bool visibility15 = true;
        bool visibility16 = true;
        bool visibility17 = true;
        bool visibility18 = true;
        bool visibility19 = true;
        bool visibility20 = true;


        //level 2

        bool visibility21 = true;
        bool visibility22 = true;
        bool visibility23 = true;
        bool visibility24 = true;
        bool visibility25 = true;
        bool visibility26 = true;
        bool visibility27 = true;
        bool visibility28 = true;
        bool visibility29 = true;
        bool visibility30 = true;
        bool visibility31 = true;
        bool visibility32 = true;
        bool visibility33 = true;
        bool visibility34 = true;
        bool visibility35 = true;
        bool visibility36 = true;
        bool visibility37 = true;
        bool visibility38 = true;
        bool visibility39 = true;
        bool visibility40 = true;

        #endregion


        #region gems

        public int gemCount = 0;

        Texture2D gem;

        Point gemFrameSize = new Point(50, 50);
        Point gemCurrentFrame = new Point(0, 0);
        Point gemSheetSize = new Point(2, 2);
        int gem_timeSinceLastFrame = 0;
        int gem_timePerFrame = 150;

        // TEXTURES

        // bonus level

        public Vector2 gemPos1 = new Vector2(180000, 500);
        public Vector2 gemPos2 = new Vector2(270000, 100);
        public Vector2 gemPos3 = new Vector2(285000, 100);
        public Vector2 gemPos4 = new Vector2(370000, 150);
        public Vector2 gemPos5 = new Vector2(480000, 150);
        public Vector2 gemPos6 = new Vector2(540000, 150);
        public Vector2 gemPos7 = new Vector2(545000, 150);
        public Vector2 gemPos8 = new Vector2(540025, 100);
        public Vector2 gemPos9 = new Vector2(700000, 200);
        public Vector2 gemPos10 = new Vector2(800000, 250);
        public Vector2 gemPos11 = new Vector2(810000, 100);
        public Vector2 gemPos12 = new Vector2(880000, 200);
        public Vector2 gemPos13 = new Vector2(950000, 100);
        public Vector2 gemPos14 = new Vector2(940050, 150);
        public Vector2 gemPos15 = new Vector2(1000200, 50);
        public Vector2 gemPos16 = new Vector2(1080000, 150);
        public Vector2 gemPos17 = new Vector2(1150000, 150);
        public Vector2 gemPos18 = new Vector2(1155000, 150);
        public Vector2 gemPos19 = new Vector2(1250000, 250);
        public Vector2 gemPos20 = new Vector2(1270000, 300);




        public Vector2 gemPos21 = new Vector2(1290000, 500);
        public Vector2 gemPos22 = new Vector2(1350000, 100);
        public Vector2 gemPos23 = new Vector2(1355000, 100);
        public Vector2 gemPos24 = new Vector2(1410000, 150);
        public Vector2 gemPos25 = new Vector2(1400800, 150);
        public Vector2 gemPos26 = new Vector2(10500500, 150);
        public Vector2 gemPos27 = new Vector2(1500550, 150);
        public Vector2 gemPos28 = new Vector2(1800025, 100);
        public Vector2 gemPos29 = new Vector2(1850000, 200);
        public Vector2 gemPos30 = new Vector2(193000, 250);
        public Vector2 gemPos31 = new Vector2(220000, 100);
        public Vector2 gemPos32 = new Vector2(2300000, 200);
        public Vector2 gemPos33 = new Vector2(230500, 100);
        public Vector2 gemPos34 = new Vector2(235500, 150);
        public Vector2 gemPos35 = new Vector2(250000, 150);
        public Vector2 gemPos36 = new Vector2(161000, 150);
        public Vector2 gemPos37 = new Vector2(168000, 150);
        public Vector2 gemPos38 = new Vector2(173000, 150);
        public Vector2 gemPos39 = new Vector2(180500, 250);
        public Vector2 gemPos40 = new Vector2(141500, 300);


        //gems for final 3rd level


        public Vector2 gemPos41 = new Vector2(35400, 50);
        public Vector2 gemPos42 = new Vector2(38000, 150);
        public Vector2 gemPos43 = new Vector2(38800, 100);
        public Vector2 gemPos44 = new Vector2(39800, 50);
        public Vector2 gemPos45 = new Vector2(41200, 50);
        public Vector2 gemPos46 = new Vector2(41400, 150);
        public Vector2 gemPos47 = new Vector2(43700, 50);
        public Vector2 gemPos48 = new Vector2(44000, 100);
        public Vector2 gemPos49 = new Vector2(44500, 50);
        public Vector2 gemPos50 = new Vector2(45800, 150);
        public Vector2 gemPos51 = new Vector2(46800, 150);
        public Vector2 gemPos52 = new Vector2(47900, 50);
        public Vector2 gemPos53 = new Vector2(48500, 150);
        public Vector2 gemPos54 = new Vector2(48550, 150);
        public Vector2 gemPos55 = new Vector2(49800, 150);
        public Vector2 gemPos56 = new Vector2(49900, 150);
        public Vector2 gemPos57 = new Vector2(49850, 100);
        public Vector2 gemPos58 = new Vector2(49400, 200);
        public Vector2 gemPos59 = new Vector2(51800, 50);
        public Vector2 gemPos60 = new Vector2(51900, 50);



        //VISIBILITY

        //bonus level

        bool visib1 = true;
        bool visib2 = true;
        bool visib3 = true;
        bool visib4 = true;
        bool visib5 = true;
        bool visib6 = true;
        bool visib7 = true;
        bool visib8 = true;
        bool visib9 = true;
        bool visib10 = true;
        bool visib11 = true;
        bool visib12 = true;
        bool visib13 = true;
        bool visib14 = true;
        bool visib15 = true;
        bool visib16 = true;
        bool visib17 = true;
        bool visib18 = true;
        bool visib19 = true;
        bool visib20 = true;

        bool visib21 = true;
        bool visib22 = true;
        bool visib23 = true;
        bool visib24 = true;
        bool visib25 = true;
        bool visib26 = true;
        bool visib27 = true;
        bool visib28 = true;
        bool visib29 = true;
        bool visib30 = true;
        bool visib31 = true;
        bool visib32 = true;
        bool visib33 = true;
        bool visib34 = true;
        bool visib35 = true;
        bool visib36 = true;
        bool visib37 = true;
        bool visib38 = true;
        bool visib39 = true;
        bool visib40 = true;


        //final / 3rd levels

        bool visib41 = true;
        bool visib42 = true;
        bool visib43 = true;
        bool visib44 = true;
        bool visib45 = true;
        bool visib46 = true;
        bool visib47 = true;
        bool visib48 = true;
        bool visib49 = true;
        bool visib50 = true;
        bool visib51 = true;
        bool visib52 = true;
        bool visib53 = true;
        bool visib54 = true;
        bool visib55 = true;
        bool visib56 = true;
        bool visib57 = true;
        bool visib58 = true;
        bool visib59 = true;
        bool visib60 = true;


        #endregion

        #region redBonus

        public int redBonusCount = 0;

        Texture2D redBonus;

        Point redBonusFrameSize = new Point(50, 50);
        Point redBonusCurrentFrame = new Point(0, 0);
        Point redBonusSheetSize = new Point(2, 2);
        int redBonus_timeSinceLastFrame = 0;
        int redBonus_timePerFrame = 150;

        // TEXTURES

        // bonus level

        public Vector2 redBonusPos1 = new Vector2(-2388, 100);
        public Vector2 redBonusPos2 = new Vector2(-2284, 100);
        public Vector2 redBonusPos3 = new Vector2(-2224, 100);
        public Vector2 redBonusPos4 = new Vector2(-2164, 100);
        public Vector2 redBonusPos5 = new Vector2(-2114, 100);
        public Vector2 redBonusPos6 = new Vector2(-2064, 100);
        public Vector2 redBonusPos7 = new Vector2(-2014, 100);
        public Vector2 redBonusPos8 = new Vector2(-1964, 100);
        public Vector2 redBonusPos9 = new Vector2(-1914, 100);
        public Vector2 redBonusPos10 = new Vector2(-1864, 100);
        public Vector2 redBonusPos11 = new Vector2(-1764, 100);
        public Vector2 redBonusPos12 = new Vector2(-1714, 100);
        public Vector2 redBonusPos13 = new Vector2(-1664, 100);
        public Vector2 redBonusPos14 = new Vector2(-1614, 100);
        public Vector2 redBonusPos15 = new Vector2(-1564, 100);
        public Vector2 redBonusPos16 = new Vector2(-1514, 100);
        public Vector2 redBonusPos17 = new Vector2(-1464, 100);
        public Vector2 redBonusPos18 = new Vector2(-1414, 100);
        public Vector2 redBonusPos19 = new Vector2(-1364, 100);
        public Vector2 redBonusPos20 = new Vector2(-1314, 100);

        public Vector2 redBonusPos21 = new Vector2(-2100, 600);
        public Vector2 redBonusPos22 = new Vector2(-2004, 600);
        public Vector2 redBonusPos23 = new Vector2(-1964, 600);
        public Vector2 redBonusPos24 = new Vector2(-1814, 600);
        public Vector2 redBonusPos25 = new Vector2(-1564, 600);
        public Vector2 redBonusPos26 = new Vector2(-1314, 600);


        bool visibRed1 = true;
        bool visibRed2 = true;
        bool visibRed3 = true;
        bool visibRed4 = true;
        bool visibRed5 = true;
        bool visibRed6 = true;
        bool visibRed7 = true;
        bool visibRed8 = true;
        bool visibRed9 = true;
        bool visibRed10 = true;
        bool visibRed11 = true;
        bool visibRed12 = true;
        bool visibRed13 = true;
        bool visibRed14 = true;
        bool visibRed15 = true;
        bool visibRed16 = true;
        bool visibRed17 = true;
        bool visibRed18 = true;
        bool visibRed19 = true;
        bool visibRed20 = true;
        bool visibRed21 = true;
        bool visibRed22 = true;
        bool visibRed23 = true;
        bool visibRed24 = true;
        bool visibRed25 = true;
        bool visibRed26 = true;


        #endregion

        #region backgrounds

        Texture2D titleScreen;
        Texture2D level2start;
        Texture2D level3start;
        Texture2D failScreen;
        Texture2D winScreen;
        Texture2D gamePauseScreen;
        Texture2D tutorial;
        Texture2D controllers;
        Texture2D quests;
        Texture2D exitToMenu;
        Texture2D bonusScreen1;
        Texture2D bonusScreen2;
        Texture2D bonusScreen3;


        //level 1


        Texture2D back1_1;
        Texture2D back1_2;
        Texture2D back1_3;
        Texture2D back1_4;
        Texture2D back1_5;
        Texture2D back1_6;
        Texture2D back1_7;
        Texture2D back1_8;
        Texture2D back1_9;
        Texture2D back1_10;

        //level 2

        Texture2D back2_1;
        Texture2D back2_2;
        Texture2D back2_3;
        Texture2D back2_4;
        Texture2D back2_5;
        Texture2D back2_6;
        Texture2D back2_7;
        Texture2D back2_8;
        Texture2D back2_9;
        Texture2D back2_10;
        Texture2D back2_11;
        Texture2D back2_12;
        Texture2D back2_13;
        Texture2D back2_14;
        Texture2D back2_15;
        Texture2D back2_16;
        Texture2D back2_17;
        Texture2D back2_18;
        Texture2D back2_19;
        Texture2D back2_20;

        //level 3

        Texture2D back3_1;
        Texture2D back3_2;
        Texture2D back3_3;
        Texture2D back3_4;
        Texture2D back3_5;
        Texture2D back3_6;
        Texture2D back3_7;
        Texture2D back3_8;
        Texture2D back3_9;
        Texture2D back3_10;
        Texture2D back3_11;
        Texture2D back3_12;
        Texture2D back3_13;
        Texture2D back3_14;
        Texture2D back3_15;
        Texture2D back3_16;
        Texture2D back3_17;
        Texture2D back3_18;
        Texture2D back3_19;
        Texture2D back3_20;



        #endregion

        #region ground

        Texture2D groundBlock;
        public Vector2 groundBlockPos1 = new Vector2(1300, 688);
        public Vector2 groundBlockPos2 = new Vector2(5300, 688);
        public Vector2 groundBlockPos3 = new Vector2(9300, 688);
        public Vector2 groundBlockPos4 = new Vector2(13300, 688);
        public Vector2 groundBlockPos5 = new Vector2(17300, 688);
        public Vector2 groundBlockPos6 = new Vector2(21300, 688);
        public Vector2 groundBlockPos7 = new Vector2(25300, 688);
        public Vector2 groundBlockPos8 = new Vector2(29300, 688);
        public Vector2 groundBlockPos9 = new Vector2(33300, 688);
        public Vector2 groundBlockPos10 = new Vector2(37300, 688);
        public Vector2 groundBlockPos11 = new Vector2(41300, 688);
        public Vector2 groundBlockPos12 = new Vector2(45300, 688);
        public Vector2 groundBlockPos13 = new Vector2(49300, 688);
        public Vector2 groundBlockPos14 = new Vector2(53300, 688);
        public Vector2 groundBlockPos15 = new Vector2(57300, 688);
        public Vector2 groundBlockPos16 = new Vector2(61300, 688);
        public Vector2 groundBlockPos17 = new Vector2(65300, 688);
        public Vector2 groundBlockPos18 = new Vector2(69300, 688);
        public Vector2 groundBlockPos19 = new Vector2(73300, 688);
        public Vector2 groundBlockPos20 = new Vector2(-4952, 668);


        Texture2D ground;
        public Vector2 groundPos = new Vector2(740, 668);
        public Vector2 groundPos1 = new Vector2(3640, 668);
        public Vector2 groundPos2 = new Vector2(6540, 668);
        public Vector2 groundPos3 = new Vector2(9440, 668);
        public Vector2 groundPos4 = new Vector2(12340, 668);
        public Vector2 groundPos5 = new Vector2(15240, 668);
        public Vector2 groundPos6 = new Vector2(18140, 668);
        public Vector2 groundPos7 = new Vector2(21040, 668);
        public Vector2 groundPos8 = new Vector2(23940, 668);
        public Vector2 groundPos9 = new Vector2(26840, 668);
        public Vector2 groundPos10 = new Vector2(29740, 668);
        public Vector2 groundPos11 = new Vector2(32640, 668);



        #endregion


        #region tower

        Texture2D tower;

        #endregion

        #region cloud

        Texture2D cloud;
        public int cloudSpeed = 3;
        public Vector2 cloudPos1 = new Vector2(-2488, 500);
        public Vector2 cloudPos2 = new Vector2(-1464, 500);
        public Vector2 cloudPos3 = new Vector2(-1976, 500);
        public Vector2 cloudPos4 = new Vector2(-2000, 200);

        #endregion



        #region ironFence


        Texture2D ironFence;

        //level 1

        public Vector2 fencePos1 = new Vector2(1720, 620);
        public Vector2 fencePos2 = new Vector2(2300, 620);
        public Vector2 fencePos3 = new Vector2(4200, 620);
        public Vector2 fencePos4 = new Vector2(7300, 620);
        public Vector2 fencePos5 = new Vector2(8500, 620);

        //level 2

        public Vector2 fencePos6 = new Vector2(13100, 620);
        public Vector2 fencePos7 = new Vector2(15700, 620);
        public Vector2 fencePos8 = new Vector2(17700, 620);
        public Vector2 fencePos9 = new Vector2(20600, 620);
        public Vector2 fencePos10 = new Vector2(26500, 620);
        public Vector2 fencePos17 = new Vector2(30000, 620);
        public Vector2 fencePos18 = new Vector2(31500, 620);

        //level 3

        public Vector2 fencePos11 = new Vector2(35900, 600);
        public Vector2 fencePos12 = new Vector2(38900, 600);
        public Vector2 fencePos13 = new Vector2(40200, 600);
        public Vector2 fencePos14 = new Vector2(41900, 600);
        public Vector2 fencePos15 = new Vector2(45400, 600);
        public Vector2 fencePos16 = new Vector2(48950, 600);



        #endregion

        #region rockie

        Texture2D rockie;
        public Vector2 rockiePos1 = new Vector2(740, 200);
        public Vector2 rockiePos2 = new Vector2(10240, 200);
        public Vector2 rockiePos3 = new Vector2(12000, 200);
        public Vector2 rockiePos4 = new Vector2(31968, 200);

        #endregion


        #region Trees_Vala

        Texture2D tree1;

        #endregion

        #region Special_Texures

        Texture2D lv1;
        Texture2D lion;

        #endregion


        #region deer

        Texture2D deerFront;
        Texture2D deerReverse;
        float deerSpeed = 2.0f;

        Point deerFrameSize = new Point(300, 200);
        Point deerCurrentFrame = new Point(0, 0);
        Point deerSheetSize = new Point(2, 2);

        int deer_timeSinceLastFrame = 0;
        int deer_timePerFrame = 50;


        public Vector2 deerPos1 = new Vector2(3600, 468);
        public Vector2 deerPos2 = new Vector2(7000, 468);
        public Vector2 deerPos3 = new Vector2(7800, 468);

        public Vector2 deerPos4 = new Vector2(14100, 468);
        public Vector2 deerPos5 = new Vector2(24000, 468);
        public Vector2 deerPos6 = new Vector2(25000, 468);
        public Vector2 deerPos7 = new Vector2(28000, 468);
        public Vector2 deerPos8 = new Vector2(30500, 468);

        // extra 

        public Vector2 deerPos9 = new Vector2(4444440, 0);
        public Vector2 deerPos10 = new Vector2(444444, 0);

        #endregion

        #region bird

        Texture2D birdFront;
        Texture2D birdReverse;
        float birdSpeed = 3.0f;

        Point birdFrameSize = new Point(100, 100);
        Point birdCurrentFrame = new Point(0, 0);
        Point birdSheetSize = new Point(2, 2);

        int bird_timeSinceLastFrame = 0;
        int bird_timePerFrame = 50;


        public Vector2 birdPos1 = new Vector2(1800, 100);
        public Vector2 birdPos2 = new Vector2(5500, 100);
        public Vector2 birdPos3 = new Vector2(10500, 100);
        public Vector2 birdPos4 = new Vector2(19000, 100);
        public Vector2 birdPos5 = new Vector2(23300, 100);
        public Vector2 birdPos6 = new Vector2(25000, 100);


        #endregion

        #region snake

        Texture2D snakeFront;
        Texture2D snakeReverse;

        Texture2D snakeDarkFro;
        Texture2D snakeDarkRev;

        float snakeSpeed = 1.5f;

        Point snakeFrameSize = new Point(200, 100);
        Point snakeCurrentFrame = new Point(0, 0);
        Point snakeSheetSize = new Point(2, 2);

        int snake_timeSinceLastFrame = 0;
        int snake_timePerFrame = 50;

        //level 3

        public Vector2 snakePos1 = new Vector2(39200, 590);
        public Vector2 snakePos2 = new Vector2(42500, 590);
        public Vector2 snakePos3 = new Vector2(46000, 590);
        public Vector2 snakePos4 = new Vector2(50500, 590);


        // level 2
        public Vector2 snakePos5 = new Vector2(14500, 600);
        public Vector2 snakePos6 = new Vector2(17300, 600);
        public Vector2 snakePos7 = new Vector2(23300, 600);
        public Vector2 snakePos8 = new Vector2(27300, 600);



        //level 3


        #endregion

        #region mushroom

        Texture2D mushroom;
        Texture2D redMushroom;

        public Vector2 redMushroomPos = new Vector2(19200, 608);

        //level 1

        public Vector2 mushPos1 = new Vector2(3400, 630);
        public Vector2 mushPos2 = new Vector2(6400, 630);
        public Vector2 mushPos3 = new Vector2(9700, 630);

        //level 2 
        public Vector2 mushPos4 = new Vector2(15200, 630);
        public Vector2 mushPos5 = new Vector2(18700, 630);
        public Vector2 mushPos6 = new Vector2(25500, 630);



        #endregion

        #region vine

        Texture2D vine;
        Texture2D vineEntrance1;
        Texture2D vineEntrance2;
        public Vector2 vineEntrancePos1 = new Vector2(0, 0);
        public Vector2 vineEntrancePos2 = new Vector2(0, 0);

        public Vector2 vinePos1 = new Vector2(0, 0);
        public Vector2 vinePos2 = new Vector2(0, 0);
        public Vector2 vinePos3 = new Vector2(0, 0);
        public Vector2 vinePos4 = new Vector2(0, 0);



        #endregion

        #region fire

        //fire tourches

        Texture2D fireTourch;

        Point fireTourchFrameSize = new Point(80, 150);
        Point fireTourchCurrentFrame = new Point(0, 0);
        Point fireTourchSheetSize = new Point(2, 2);

        int fireTourch_timeSinceLastFrame = 0;
        int fireTourch_timePerFrame = 250;

        public Vector2 fireTouchPos1 = new Vector2(34150, 50);
        public Vector2 fireTouchPos2 = new Vector2(35000, 50);
        public Vector2 fireTouchPos3 = new Vector2(37500, 50);
        public Vector2 fireTouchPos4 = new Vector2(38900, 50);
        public Vector2 fireTouchPos5 = new Vector2(40500, 100);
        public Vector2 fireTouchPos6 = new Vector2(42200, 100);
        public Vector2 fireTouchPos7 = new Vector2(45280, 100);
        public Vector2 fireTouchPos8 = new Vector2(47400, 100);
        public Vector2 fireTouchPos9 = new Vector2(49600, 100);
        public Vector2 fireTouchPos10 = new Vector2(51300, 100);


        // fire fire fire

        Texture2D fireMedium;

        Point fireMediumFrameSize = new Point(200, 200);
        Point fireMediumCurrentFrame = new Point(0, 0);
        Point fireMediumSheetSize = new Point(2, 4);

        int fireMedium_timeSinceLastFrame = 0;
        int fireMedium_timePerFrame = 150;

        public Vector2 fireMediumPos1 = new Vector2(36900, 600);
        public Vector2 fireMediumPos2 = new Vector2(39750, 468);
        public Vector2 fireMediumPos3 = new Vector2(40900, 468);
        public Vector2 fireMediumPos4 = new Vector2(41100, 468);
        public Vector2 fireMediumPos5 = new Vector2(41300, 468);
        public Vector2 fireMediumPos6 = new Vector2(41500, 468);
        public Vector2 fireMediumPos7 = new Vector2(44300, 468);
        public Vector2 fireMediumPos8 = new Vector2(41700, 468);

        public Vector2 fireMediumPos9 = new Vector2(38400, 668);
        public Vector2 fireMediumPos10 = new Vector2(42700, 668);
        public Vector2 fireMediumPos11 = new Vector2(46600, 668);
        public Vector2 fireMediumPos12 = new Vector2(49350, 668);
        public Vector2 fireMediumPos13 = new Vector2(51500, 668);
        public Vector2 fireMediumPos14 = new Vector2(51900, 668);

        public Vector2 fireMediumPos15 = new Vector2(47750, 568);
        public Vector2 fireMediumPos16 = new Vector2(47950, 568);
        public Vector2 fireMediumPos17 = new Vector2(48150, 568);
        public Vector2 fireMediumPos18 = new Vector2(48350, 568);

        public Vector2 fireMediumPos19 = new Vector2(44100, 568);
        public Vector2 fireMediumPos20 = new Vector2(43900, 568);

        //large fire

        Texture2D fireLarge;

        Point fireLargeFrameSize = new Point(350, 500);
        Point fireLargeCurrentFrame = new Point(0, 0);
        Point fireLargeSheetSize = new Point(2, 4);

        int fireLarge_timeSinceLastFrame = 0;
        int fireLarge_timePerFrame = 150;


        public Vector2 fireLargePos1 = new Vector2(53618, 268);
        public Vector2 fireLargePos2 = new Vector2(53950, 268);




        #endregion

        #region smallBlock

        Texture2D smallBlock;

        public Vector2 smallBlockPos1 = new Vector2(35100, 570); //L
        public Vector2 smallBlockPos2 = new Vector2(35200, 470); //L
        public Vector2 smallBlockPos3 = new Vector2(35398, 470); //R
        public Vector2 smallBlockPos4 = new Vector2(35498, 570); //R

        public Vector2 smallBlockPos5 = new Vector2(36100, 570); //L
        public Vector2 smallBlockPos6 = new Vector2(36300, 470); //L
        public Vector2 smallBlockPos7 = new Vector2(36400, 370); //L
        public Vector2 smallBlockPos8 = new Vector2(36598, 370); //R
        public Vector2 smallBlockPos9 = new Vector2(36698, 470); //R
        public Vector2 smallBlockPos10 = new Vector2(36898, 570); //R

        public Vector2 smallBlockPos11 = new Vector2(37800, 570); //L
        public Vector2 smallBlockPos12 = new Vector2(37998, 570); //R

        public Vector2 smallBlockPos13 = new Vector2(38600, 470); //L
        public Vector2 smallBlockPos14 = new Vector2(38798, 470); //R

        public Vector2 smallBlockPos15 = new Vector2(39300, 570); //L
        public Vector2 smallBlockPos16 = new Vector2(39500, 470); //L
        public Vector2 smallBlockPos17 = new Vector2(39700, 370); //L
        public Vector2 smallBlockPos18 = new Vector2(40098, 570); //R

        public Vector2 smallBlockPos19 = new Vector2(40400, 570); //L
        public Vector2 smallBlockPos20 = new Vector2(40700, 470); //L
        public Vector2 smallBlockPos21 = new Vector2(41200, 370); //L

        public Vector2 smallBlockPos22 = new Vector2(43300, 570); //L
        public Vector2 smallBlockPos23 = new Vector2(43700, 470); //L
        public Vector2 smallBlockPos24 = new Vector2(43500, 370); //L
        public Vector2 smallBlockPos25 = new Vector2(43698, 370); //R
        public Vector2 smallBlockPos26 = new Vector2(43798, 470); //R
        public Vector2 smallBlockPos27 = new Vector2(43898, 570); //R

        public Vector2 smallBlockPos28 = new Vector2(44600, 570); //L
        public Vector2 smallBlockPos29 = new Vector2(44800, 470); //L
        public Vector2 smallBlockPos30 = new Vector2(44998, 470); //R
        public Vector2 smallBlockPos31 = new Vector2(45198, 570); //R

        public Vector2 smallBlockPos32 = new Vector2(47500, 570); //L
        public Vector2 smallBlockPos33 = new Vector2(47700, 470); //L
        public Vector2 smallBlockPos34 = new Vector2(47698, 570); //R
        public Vector2 smallBlockPos35 = new Vector2(47898, 470); //R

        public Vector2 smallBlockPos36 = new Vector2(48700, 470); //L
        public Vector2 smallBlockPos37 = new Vector2(48898, 470); //R
        public Vector2 smallBlockPos38 = new Vector2(48900, 570); //L
        public Vector2 smallBlockPos39 = new Vector2(49098, 570); //R

        public Vector2 smallBlockPos40 = new Vector2(50100, 570); //L
        public Vector2 smallBlockPos41 = new Vector2(50298, 570); //R

        public Vector2 smallBlockPos42 = new Vector2(51500, 470); //L
        public Vector2 smallBlockPos43 = new Vector2(51698, 570); //R

        public Vector2 smallBlockPos44 = new Vector2(51900, 570); //L
        public Vector2 smallBlockPos45 = new Vector2(52098, 570); //R

        // for moving level 3 blocks

        public Vector2 smallBlockPos46 = new Vector2(43700, 368);
        public Vector2 smallBlockPos47 = new Vector2(44500, 368);

        public Vector2 smallBlockPos48 = new Vector2(47880, 368);
        public Vector2 smallBlockPos49 = new Vector2(48520, 358);

        //cloud


        public Vector2 smallBlockPos50 = new Vector2(-2400, 200);
        public Vector2 smallBlockPos51 = new Vector2(-932, 200);



        #endregion

        #region tiger

        Texture2D tigerFro;
        Texture2D tigerRev;

        Texture2D tigerDarkFro;
        Texture2D tigerDarkRev;

        public int tigerSpeed = 2;

        Point tigerFrameSize = new Point(300, 200);
        Point tigerCurrentFrame = new Point(0, 0);
        Point tigerSheetSize = new Point(2, 2);

        int tiger_timeSinceLastFrame = 0;
        int tiger_timePerFrame = 50;

        //level 2

        public Vector2 tigerPos1 = new Vector2(18300, 570);


        //level 3

        public Vector2 tigerPos2 = new Vector2(52500, 468);
        public Vector2 tigerPos3 = new Vector2(52700, 468);
        public Vector2 tigerPos4 = new Vector2(52900, 458);




        #endregion

        #region level3_stones

        Texture2D lvl3ground;
        Texture2D lvl3block;
        public int lvl3blockSpeed = 5;

        public Vector2 lvl3groundPos1 = new Vector2(34000, 668);
        public Vector2 lvl3groundPos2 = new Vector2(36900, 668);
        public Vector2 lvl3groundPos3 = new Vector2(39800, 668);
        public Vector2 lvl3groundPos4 = new Vector2(42700, 668);
        public Vector2 lvl3groundPos5 = new Vector2(45600, 668);
        public Vector2 lvl3groundPos6 = new Vector2(48500, 668);
        public Vector2 lvl3groundPos7 = new Vector2(51400, 668);

        public Vector2 lvl3blockPos1 = new Vector2(35100, 568);
        public Vector2 lvl3blockPos2 = new Vector2(35300, 568);
        public Vector2 lvl3blockPos3 = new Vector2(35200, 468);

        public Vector2 lvl3blockPos4 = new Vector2(36100, 568);
        public Vector2 lvl3blockPos5 = new Vector2(36700, 568);
        public Vector2 lvl3blockPos6 = new Vector2(36300, 468);
        public Vector2 lvl3blockPos7 = new Vector2(36500, 468);
        public Vector2 lvl3blockPos8 = new Vector2(36400, 368);

        public Vector2 lvl3blockPos9 = new Vector2(37800, 568);

        public Vector2 lvl3blockPos10 = new Vector2(38600, 468);

        public Vector2 lvl3blockPos11 = new Vector2(39300, 568);
        public Vector2 lvl3blockPos12 = new Vector2(39500, 468);
        public Vector2 lvl3blockPos13 = new Vector2(39700, 368);
        public Vector2 lvl3blockPos14 = new Vector2(40000, 568);

        public Vector2 lvl3blockPos15 = new Vector2(40400, 568);
        public Vector2 lvl3blockPos16 = new Vector2(40700, 468);
        public Vector2 lvl3blockPos17 = new Vector2(41000, 368);
        public Vector2 lvl3blockPos18 = new Vector2(41200, 368);
        public Vector2 lvl3blockPos19 = new Vector2(41400, 368);
        public Vector2 lvl3blockPos20 = new Vector2(41600, 368);

        public Vector2 lvl3blockPos21 = new Vector2(43300, 568);
        public Vector2 lvl3blockPos22 = new Vector2(43500, 568);
        public Vector2 lvl3blockPos23 = new Vector2(43700, 568);
        public Vector2 lvl3blockPos24 = new Vector2(43400, 468);
        public Vector2 lvl3blockPos25 = new Vector2(43600, 468);
        public Vector2 lvl3blockPos26 = new Vector2(43500, 368);

        public Vector2 lvl3blockPos27 = new Vector2(44600, 568);
        public Vector2 lvl3blockPos28 = new Vector2(45000, 568);
        public Vector2 lvl3blockPos29 = new Vector2(44800, 468);
        public Vector2 lvl3blockPos30 = new Vector2(43720, 368);

        public Vector2 lvl3blockPos31 = new Vector2(47500, 568);
        public Vector2 lvl3blockPos32 = new Vector2(47700, 468);
        public Vector2 lvl3blockPos33 = new Vector2(47900, 368);

        public Vector2 lvl3blockPos34 = new Vector2(48700, 468);
        public Vector2 lvl3blockPos35 = new Vector2(48900, 568);
        public Vector2 lvl3blockPos36 = new Vector2(50100, 568);

        public Vector2 lvl3blockPos37 = new Vector2(51500, 468);
        public Vector2 lvl3blockPos38 = new Vector2(51900, 468);





        #endregion

        #region Sound_Audio

        Song backgroundMusic;
        SoundEffect jump;
        //SoundEffect run;
        SoundEffect fail;
        SoundEffect win;

        #endregion

        #region FONT_Config

        SpriteFont gameFont;
        SpriteFont gameFont2;
        public Vector2 fontPos = new Vector2(1100, 10);

        #endregion


        #region NOT_USED

        //float timer;
        //SoundEffect running;

        #endregion




        //Secondary Classes.................


        Camera camera;

      




        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";

            graphics.PreferredBackBufferWidth = 1024;
            graphics.PreferredBackBufferHeight = 768;
            graphics.IsFullScreen = true;
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            camera = new Camera(GraphicsDevice.Viewport);


            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.


            spriteBatch = new SpriteBatch(GraphicsDevice);

            gameFont = Content.Load<SpriteFont>(@"fonts/SFont");
            gameFont2 = Content.Load<SpriteFont>(@"fonts/SFont2");



            //hero = Content.Load<Texture2D>(@"images/heroFro");
            //heroBlocked = Content.Load<Texture2D>(@"images/heroBlocked");
            //heroReverse = Content.Load<Texture2D>(@"images/heroRev2");
            hero = Content.Load<Texture2D>(@"images/heroTest");
            heroBlocked = Content.Load<Texture2D>(@"images/heroStill");
            heroReverse = Content.Load<Texture2D>(@"images/heroTest2");
            enemy = Content.Load<Texture2D>(@"images/spirit3");
            diamond = Content.Load<Texture2D>(@"images/flowerAni");
            gem = Content.Load<Texture2D>(@"images/diamondNew");
            ground = Content.Load<Texture2D>(@"images/newPdr");
            groundBlock = Content.Load<Texture2D>(@"images/groundBlockNew");
            tower = Content.Load<Texture2D>(@"images/tower1");
            ironFence = Content.Load<Texture2D>(@"images/ironFence2");
            lv1 = Content.Load<Texture2D>(@"images/scroll");
            log = Content.Load<Texture2D>(@"images/loggNew");
            markBanner = Content.Load<Texture2D>(@"images/markBanner");
            water = Content.Load<Texture2D>(@"images/waterNew");
            rockie = Content.Load<Texture2D>(@"images/rockkNew");
            lion = Content.Load<Texture2D>(@"images/buddha");
            tree1 = Content.Load<Texture2D>(@"images/tree1");
            levelBlock1_1 = Content.Load<Texture2D>(@"images/tower1");
            tree1 = Content.Load<Texture2D>(@"images/tree1");
            mushroom = Content.Load<Texture2D>(@"images/mushroomNew");
            redMushroom = Content.Load<Texture2D>(@"images/redMushroom");
            vine = Content.Load<Texture2D>(@"images/vine");
            vineEntrance1 = Content.Load<Texture2D>(@"images/vineBlock");
            vineEntrance2 = Content.Load<Texture2D>(@"images/vineBlock");
            lvl3ground = Content.Load<Texture2D>(@"images/level3Ground");
            lvl3block = Content.Load<Texture2D>(@"images/stoneBlock");
            cloud = Content.Load<Texture2D>(@"images/cloud_bar");
            redBonus = Content.Load<Texture2D>(@"images/diamondBonus");
            level2End = Content.Load<Texture2D>(@"images/level2End");

            fireTourch = Content.Load<Texture2D>(@"images/fireTourch");
            fireMedium = Content.Load<Texture2D>(@"images/fireMedium");
            fireLarge = Content.Load<Texture2D>(@"images/fireLarge");

            smallBlock = Content.Load<Texture2D>(@"images/smallBlock");

            //other animals
            deerFront = Content.Load<Texture2D>(@"images/deerFro2");
            deerReverse = Content.Load<Texture2D>(@"images/deerRev2");
            birdFront = Content.Load<Texture2D>(@"images/bird1Fro");
            birdReverse = Content.Load<Texture2D>(@"images/bird1Rev");
            snakeFront = Content.Load<Texture2D>(@"images/snakeFro2");
            snakeReverse = Content.Load<Texture2D>(@"images/snakeRev2");
            tigerFro = Content.Load<Texture2D>(@"images/tigerFro");
            tigerRev = Content.Load<Texture2D>(@"images/tigerRev");
            snakeDarkFro = Content.Load<Texture2D>(@"images/snakeDarkFro");
            snakeDarkRev = Content.Load<Texture2D>(@"images/snakeDarkRev");
            tigerDarkFro = Content.Load<Texture2D>(@"images/tigerBlackFro");
            tigerDarkRev = Content.Load<Texture2D>(@"images/tigerBlackRev");






            #region backgrounds_ContentLoad

            titleScreen = Content.Load<Texture2D>(@"images/TitleScreenNew");
            failScreen = Content.Load<Texture2D>(@"images/fail");
            winScreen = Content.Load<Texture2D>(@"images/win");
            level2start = Content.Load<Texture2D>(@"images/level2");
            level3start = Content.Load<Texture2D>(@"images/level3");
            gamePauseScreen = Content.Load<Texture2D>(@"images/paused");
            tutorial = Content.Load<Texture2D>(@"images/tute");
            controllers = Content.Load<Texture2D>(@"images/controllers");
            quests = Content.Load<Texture2D>(@"images/quests");
            exitToMenu = Content.Load<Texture2D>(@"images/exitToMenu");
            bonusScreen1 = Content.Load<Texture2D>(@"images/bonusLevel1");
            bonusScreen2 = Content.Load<Texture2D>(@"images/bonusLevel2");
            bonusScreen3 = Content.Load<Texture2D>(@"images/bonusLevel1");

            //level 1
            back1_1 = Content.Load<Texture2D>(@"images/12");
            back1_2 = Content.Load<Texture2D>(@"images/14");
            back1_3 = Content.Load<Texture2D>(@"images/13");
            back1_4 = Content.Load<Texture2D>(@"images/15");
            back1_5 = Content.Load<Texture2D>(@"images/16");
            back1_6 = Content.Load<Texture2D>(@"images/18");
            back1_7 = Content.Load<Texture2D>(@"images/19");
            back1_8 = Content.Load<Texture2D>(@"images/6");
            back1_9 = Content.Load<Texture2D>(@"images/7");
            back1_10 = Content.Load<Texture2D>(@"images/8");

            //level 2

            back2_1 = Content.Load<Texture2D>(@"images/12");
            back2_2 = Content.Load<Texture2D>(@"images/12");
            back2_3 = Content.Load<Texture2D>(@"images/14");
            back2_4 = Content.Load<Texture2D>(@"images/13");
            back2_5 = Content.Load<Texture2D>(@"images/15");
            back2_6 = Content.Load<Texture2D>(@"images/16");
            back2_7 = Content.Load<Texture2D>(@"images/18");
            back2_8 = Content.Load<Texture2D>(@"images/19");
            back2_9 = Content.Load<Texture2D>(@"images/17");
            back2_10 = Content.Load<Texture2D>(@"images/26");
            back2_11 = Content.Load<Texture2D>(@"images/27");
            back2_12 = Content.Load<Texture2D>(@"images/4");
            back2_13 = Content.Load<Texture2D>(@"images/8");
            back2_14 = Content.Load<Texture2D>(@"images/10");
            back2_15 = Content.Load<Texture2D>(@"images/20");
            back2_16 = Content.Load<Texture2D>(@"images/7");
            back2_17 = Content.Load<Texture2D>(@"images/8");
            back2_18 = Content.Load<Texture2D>(@"images/12");
            back2_19 = Content.Load<Texture2D>(@"images/14");
            back2_20 = Content.Load<Texture2D>(@"images/13");

            //level 3

            back3_1 = Content.Load<Texture2D>(@"images/dark");
            back3_2 = Content.Load<Texture2D>(@"images/dark");
            back3_3 = Content.Load<Texture2D>(@"images/dark");
            back3_4 = Content.Load<Texture2D>(@"images/dark");
            back3_5 = Content.Load<Texture2D>(@"images/dark");
            back3_6 = Content.Load<Texture2D>(@"images/dark");
            back3_7 = Content.Load<Texture2D>(@"images/dark");
            back3_8 = Content.Load<Texture2D>(@"images/dark");
            back3_9 = Content.Load<Texture2D>(@"images/dark");
            back3_10 = Content.Load<Texture2D>(@"images/dark");
            back3_11 = Content.Load<Texture2D>(@"images/dark");
            back3_12 = Content.Load<Texture2D>(@"images/dark");
            back3_13 = Content.Load<Texture2D>(@"images/dark");
            back3_14 = Content.Load<Texture2D>(@"images/dark");
            back3_15 = Content.Load<Texture2D>(@"images/dark");
            back3_16 = Content.Load<Texture2D>(@"images/dark");
            back3_17 = Content.Load<Texture2D>(@"images/dark");
            back3_18 = Content.Load<Texture2D>(@"images/dark");
            back3_19 = Content.Load<Texture2D>(@"images/dark");
            back3_20 = Content.Load<Texture2D>(@"images/dark");


            #endregion

            if (!welcome)
            {
                backgroundMusic = Content.Load<Song>(@"audio/rain2");
                MediaPlayer.Play(backgroundMusic);
                MediaPlayer.IsRepeating = true;
            }




            jump = Content.Load<SoundEffect>(@"audio/jump");



            fail = Content.Load<SoundEffect>(@"audio/fail");

            win = Content.Load<SoundEffect>(@"audio/final");

            
            

            

        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

            // TODO: Add your update logic here

            if (heroPosition.X > 1000 && heroPosition.X < 10300)
            {
                ifLevel1 = true;
                ifLevel2 = false;
                ifLevel3 = false;
            }

            if (heroPosition.X > 12000 && heroPosition.X < 32000)
            {
                ifLevel1 = false;
                ifLevel2 = true;
                ifLevel3 = false;
            }

            if (heroPosition.X > 34000 && heroPosition.X < 54000)
            {
                ifLevel1 = false;
                ifLevel2 = false;
                ifLevel3 = true;
            }



            heroRect = new Rectangle((int)heroPosition.X, (int)heroPosition.Y, (int)hero.Width, (int)hero.Height);

            float time = (float)gameTime.ElapsedGameTime.Seconds;

            float timer = (float)gameTime.ElapsedGameTime.Seconds;




            if (isFailScreen())
            {
                fail.Play();
            }


            if (playerHitsFinalLevel()/*isGameEndScreen() heroPosition.X >= 58412 && heroPosition.X <= 58200*/)
            {
                MediaPlayer.Stop();
                win.Play();
            }



            #region trial

            //if ((heroPosition == new Vector2(45540, 0)) || (heroPosition == new Vector2(43540, 0)) || heroPosition == new Vector2(41540, 0))
            //    {

            //        menuItem.Play();

            //    }




            #endregion





            playerHitsLog();
            playerHitsLevel3Block();
            playerHitsFire();

            playerHitsIronFence();
            playerHitsSnake();
            playerHitsTiger();

            if (playerHitsMushroom())
            {
                heroPosition.X = heroPosition.X - 2000;
            }

            if (playerHitsRedMushroom())
            {
                heroPosition = new Vector2(-2488, 0);
            }

            if (playerHitsLastCloud())
            {
                //redirect to place where vine is started 
                heroPosition = new Vector2(23700, 50);
            }

            if (playerHitsWater())
            {
                heroSpeed = 0;
            }

            #region keyboard_inputs

            KeyboardState ks = Keyboard.GetState();

            if (ks.IsKeyUp(Keys.Space) && (x))
            {
                if (playerHitsGround() || playerHitsLevel3Block())
                    heroPosition.Y += 0;
                else
                {
                    if (playerHitsLog())
                        heroPosition.Y -= 0;
                    else
                        heroPosition.Y += 5;
                }
            }

            if (ks.IsKeyDown(Keys.Right) && !(islevle2winScreen()) && !playerHitsSmallBlocksLEFT() && !(isExitScreen()) && !(isQuestScreen()) && !(isControolerScreen()) && !(isTuteScreen()) && !(isPausingScreen()) && !(isGameEndScreen()) && !(isLevel2Screen()) && !(isFailScreen()) && (x) && (!(playerHitsBlocks(levelBlock1_1, BlockPos1_2, hero, heroPosition)) && !(playerHitsBlocks(levelBlock1_1, BlockPos2_1, hero, heroPosition)) && !(playerHitsBlocks(levelBlock1_1, BlockPosB2, hero, heroPosition))))
            {
                //if ((playerHitsGround()))
                //    run.Play();
                heroPosition.X += heroSpeed;
                leftArrowPressed = false;
                fontPos.X += heroSpeed;
            }

            if (ks.IsKeyDown(Keys.Left) && !(islevle2winScreen()) && !playerHitsSmallBlocksRight() && !(isExitScreen()) && !(isQuestScreen()) && !(isControolerScreen()) && !(isTuteScreen()) && !(isPausingScreen()) && !(isGameEndScreen()) && !(isLevel2Screen()) && !(isFailScreen()) && (x) && (!(playerHitsBlocks(levelBlock1_1, BlockPos1_1, hero, heroPosition)) && !(playerHitsBlocks(levelBlock1_1, BlockPos2_1, hero, heroPosition)) && !(playerHitsBlocks(levelBlock1_1, BlockPos3_1, hero, heroPosition)) && !(playerHitsBlocks(levelBlock1_1, BlockPosB1, hero, heroPosition))))
            {
                //if ((playerHitsGround()))
                //    run.Play();
                heroPosition.X -= heroSpeed;
                leftArrowPressed = true;
                fontPos.X -= heroSpeed;

            }


            if (ks.IsKeyDown(Keys.Up) && (x))
            {
                // heroPosition.Y -= heroSpeed;
            }
            if (ks.IsKeyDown(Keys.Down) && (x))
            {
                // heroPosition.Y += heroSpeed;
            }

            if (ks.IsKeyDown(Keys.Space) && (playerHitsGround() || playerHitsLog() || playerHitsCloud() || playerHitsLevel3Block()))
            {


                if (heroSpeed == 0)
                    heroSpeed += 8;


                velocityY += gravity * time;
                heroPosition.X += velocityX * time;
                heroPosition.Y += velocityY * time;
                heroPosition.Y -= 220;
                jump.Play();


            }

            if (ks.IsKeyDown(Keys.Space) && !(playerHitsGround()) && !(playerHitsLog()))
            {
                heroPosition.Y += 5;
            }

            //cheats

            if ((end) && ks.IsKeyDown(Keys.T) && (x))
            {
                heroPosition = new Vector2(12600, 0);
            }

            if ((end) && ks.IsKeyDown(Keys.Y) && (x))
            {
                heroPosition = new Vector2(34700, 420);
                //heroPosition = new Vector2(53456, 420);
            }

            if ((end) && ks.IsKeyDown(Keys.K) && (x))
                heroPosition = new Vector2(-2488, 0);

            //cheats ends here

            if (ks.IsKeyDown(Keys.Enter) && !(x))
            {
                x = true;
                heroPosition = new Vector2(1300, 418);
                //heroPosition = new Vector2(27070, 0);
                welcome = false;
                //heroPosition = new Vector2(13540, 0);

            }

            if (saveCount < 5 && ks.IsKeyDown(Keys.F3))
            {
                saveHero = heroPosition;
                saveCount = +1;
            }
            else
            {
                //nothing happens
            }

            if (ks.IsKeyDown(Keys.F4) && saveTry < 3)
            {

                heroPosition = saveHero;
                fontPos.X = saveHero.X;
                saveTry += 1;


            }

            //if (ks.IsKeyDown(Keys.F2))
            //{
            //    heroPosition = new Vector2(1300, 0);
            //    tryCount += 1;
            //    //write other reset codes
            //}


            if (ks.IsKeyDown(Keys.F2) && tryCount < 3)
            {
                tryCount += 1;
                //heroPosition = new Vector2(1300, 400);
                //if(lvl2==false)
                //    heroPosition = new Vector2(1300, 400);
                //if(lvl2==true)
                //    heroPosition = new Vector2(13540, 400);

                //marks = 0;

                //if (lvl2 == true)
                //    powerUsageCount = 1200;
                //if (lvl2 == false)
                //    powerUsageCount = 800;

                if (ifLevel1)
                {
                    heroPosition = new Vector2(1300, 400);
                    powerUsageCount = 800;
                }

                if (ifLevel2)
                {
                    heroPosition = new Vector2(12600, 400);
                    powerUsageCount = 1200;
                }

                if (ifLevel3)
                {
                    heroPosition = new Vector2(34700, 400);
                    powerUsageCount = 1800;
                }




                fontPos.X = heroPosition.X;



                // making diamonds reappear

                visibility1 = true;
                visibility2 = true;
                visibility3 = true;
                visibility4 = true;
                visibility5 = true;
                visibility6 = true;
                visibility7 = true;
                visibility8 = true;
                visibility9 = true;
                visibility10 = true;
                visibility11 = true;
                visibility12 = true;
                visibility13 = true;
                visibility14 = true;
                visibility15 = true;
                visibility16 = true;
                visibility17 = true;
                visibility18 = true;
                visibility19 = true;
                visibility20 = true;

                visibility21 = true;
                visibility22 = true;
                visibility23 = true;
                visibility24 = true;
                visibility25 = true;
                visibility26 = true;
                visibility27 = true;
                visibility28 = true;
                visibility29 = true;
                visibility30 = true;
                visibility31 = true;
                visibility32 = true;
                visibility33 = true;
                visibility34 = true;
                visibility35 = true;
                visibility36 = true;
                visibility37 = true;
                visibility38 = true;
                visibility39 = true;
                visibility40 = true;

                //gems


                visib1 = true;
                visib2 = true;
                visib3 = true;
                visib4 = true;
                visib5 = true;
                visib6 = true;
                visib7 = true;
                visib8 = true;
                visib9 = true;
                visib10 = true;
                visib11 = true;
                visib12 = true;
                visib13 = true;
                visib14 = true;
                visib15 = true;
                visib16 = true;
                visib17 = true;
                visib18 = true;
                visib19 = true;
                visib20 = true;

                visib21 = true;
                visib22 = true;
                visib23 = true;
                visib24 = true;
                visib25 = true;
                visib26 = true;
                visib27 = true;
                visib28 = true;
                visib29 = true;
                visib30 = true;
                visib31 = true;
                visib32 = true;
                visib33 = true;
                visib34 = true;
                visib35 = true;
                visib36 = true;
                visib37 = true;
                visib38 = true;
                visib39 = true;
                visib40 = true;


                //final / 3rd levels

                visib41 = true;
                visib42 = true;
                visib43 = true;
                visib44 = true;
                visib45 = true;
                visib46 = true;
                visib47 = true;
                visib48 = true;
                visib49 = true;
                visib50 = true;
                visib51 = true;
                visib52 = true;
                visib53 = true;
                visib54 = true;
                visib55 = true;
                visib56 = true;
                visib57 = true;
                visib58 = true;
                visib59 = true;
                visib60 = true;


            }



            if (ks.IsKeyDown(Keys.F1))
            {
                tryCount = 0;
                playerDied = false;
                heroPosition = new Vector2(1300, 400);
                marks = 0;
                saveCount = 0;
                saveHero = new Vector2(1300, 400);
                saveTry = 0;

                powerUsageCount = 800;

                fontPos = new Vector2(1100, 0);





                // making diamonds reappear

                visibility1 = true;
                visibility2 = true;
                visibility3 = true;
                visibility4 = true;
                visibility5 = true;
                visibility6 = true;
                visibility7 = true;
                visibility8 = true;
                visibility9 = true;
                visibility10 = true;
                visibility11 = true;
                visibility12 = true;
                visibility13 = true;
                visibility14 = true;
                visibility15 = true;
                visibility16 = true;
                visibility17 = true;
                visibility18 = true;
                visibility19 = true;
                visibility20 = true;

                visibility21 = true;
                visibility22 = true;
                visibility23 = true;
                visibility24 = true;
                visibility25 = true;
                visibility26 = true;
                visibility27 = true;
                visibility28 = true;
                visibility29 = true;
                visibility30 = true;
                visibility31 = true;
                visibility32 = true;
                visibility33 = true;
                visibility34 = true;
                visibility35 = true;
                visibility36 = true;
                visibility37 = true;
                visibility38 = true;
                visibility39 = true;
                visibility40 = true;

                //gems

                visib1 = true;
                visib2 = true;
                visib3 = true;
                visib4 = true;
                visib5 = true;
                visib6 = true;
                visib7 = true;
                visib8 = true;
                visib9 = true;
                visib10 = true;
                visib11 = true;
                visib12 = true;
                visib13 = true;
                visib14 = true;
                visib15 = true;
                visib16 = true;
                visib17 = true;
                visib18 = true;
                visib19 = true;
                visib20 = true;

                visib21 = true;
                visib22 = true;
                visib23 = true;
                visib24 = true;
                visib25 = true;
                visib26 = true;
                visib27 = true;
                visib28 = true;
                visib29 = true;
                visib30 = true;
                visib31 = true;
                visib32 = true;
                visib33 = true;
                visib34 = true;
                visib35 = true;
                visib36 = true;
                visib37 = true;
                visib38 = true;
                visib39 = true;
                visib40 = true;


                //final / 3rd levels

                visib41 = true;
                visib42 = true;
                visib43 = true;
                visib44 = true;
                visib45 = true;
                visib46 = true;
                visib47 = true;
                visib48 = true;
                visib49 = true;
                visib50 = true;
                visib51 = true;
                visib52 = true;
                visib53 = true;
                visib54 = true;
                visib55 = true;
                visib56 = true;
                visib57 = true;
                visib58 = true;
                visib59 = true;
                visib60 = true;

                //bonus red gems

                visibRed1 = true;
                visibRed2 = true;
                visibRed3 = true;
                visibRed4 = true;
                visibRed5 = true;
                visibRed6 = true;
                visibRed7 = true;
                visibRed8 = true;
                visibRed9 = true;
                visibRed10 = true;
                visibRed11 = true;
                visibRed12 = true;
                visibRed13 = true;
                visibRed14 = true;
                visibRed15 = true;
                visibRed16 = true;
                visibRed17 = true;
                visibRed18 = true;
                visibRed19 = true;
                visibRed20 = true;
                visibRed21 = true;
                visibRed22 = true;
                visibRed23 = true;
                visibRed24 = true;
                visibRed25 = true;
                visibRed26 = true;

                //write game Full restart logic here
            }

            //if ((playerDied) && tryCount < 3)
            //{
            //    //write continue to next try logic
            //}

            if ((playerDied) && tryCount == 2)
            {
                heroPosition = new Vector2(39440, 0);
                //End of the game logic
            }



            // level limitations

            if (isLevel2Screen() && ks.IsKeyDown(Keys.Enter))
            {
                //begin next level

                heroPosition = new Vector2(12900, 400);
                fontPos.X = heroPosition.X;
            }


            if (heroPosition.X == 72412 && ks.IsKeyDown(Keys.Enter))
            {
                //begin last level

                heroPosition = new Vector2(34700, 420);
            }

            // pausing and continuing

            if (ks.IsKeyDown(Keys.F5) && (x) && !(isPaused))
            {
                pausedPoint = heroPosition;
                isPaused = true;
                pausedPoint = heroPosition;
                heroPosition = new Vector2(68412, 0);
            }

            if (ks.IsKeyDown(Keys.F6) && (x) && (isPaused))
            {

                heroPosition = pausedPoint;
                isPaused = false;

            }

            if (ks.IsKeyDown(Keys.F8) && !(x))
            {
                heroPosition = new Vector2(66412, 0);
            }

            if (ks.IsKeyDown(Keys.F9) && !(x))
            {
                heroPosition = new Vector2(64412, 0);
            }

            if (ks.IsKeyDown(Keys.F10) && !(x))
            {
                heroPosition = new Vector2(62412, 0);
            }


            //game exit logic

            if (ks.IsKeyDown(Keys.Escape) && !(x))
                this.Exit();

            // game to welcome screen logic

            if (ks.IsKeyDown(Keys.F12) && (x) && !(isPaused))
            {
                pausedPoint = heroPosition;
                isPaused = true;
                //pausedPoint = heroPosition;
                heroPosition = new Vector2(70412, 0);
            }

            if (ks.IsKeyDown(Keys.Escape) && (x) && (isPaused))
            {

                heroPosition = pausedPoint;
                isPaused = false;
            }

            if (ks.IsKeyDown(Keys.Enter) && (x) && (isPaused))
            {
                heroPosition = new Vector2(0, 0);
                x = false;
                welcome = true;
            }


            if (ks.IsKeyDown(Keys.Z) && (x) && ks.IsKeyUp(Keys.A))
                powerUsageCount -= 1;

            #endregion





            #region enemy_movement

            //enemyPos.X += enemySpeed1;
            //enemyPos1.X += enemySpeed1;
            //enemyPos2.X += enemySpeed1;
            //enemyPos3.X += enemySpeed1;

            #endregion



            //enemyHitsBlocks(tower, new Vector2(1000,20), new Vector2(1500, 20), enemy, enemyPos );
            playerHitsEnemy();

            #region enemyies

            if (!(isPaused))
            {

                //level 1 stuff

                if (heroPosition.X > 2560)
                {
                    enemyChase(ref enemyPos1);

                }

                if (heroPosition.X > 3584)
                {
                    enemyChase(ref enemyPos2);

                }

                if (heroPosition.X > 4800)
                {
                    enemyChase(ref enemyPos3);

                }

                if (heroPosition.X > 7680)
                {
                    enemyChase(ref enemyPos4);

                }

                if (heroPosition.X > 8500)
                {
                    enemyChase(ref enemyPos5);

                }


                // level 2 stuff


                if (heroPosition.X > 13000)
                {
                    enemyChase(ref enemyPos6);

                }

                if (heroPosition.X > 13000)
                {
                    enemyChase(ref enemyPos7);

                }

                if (heroPosition.X > 14000)
                {
                    enemyChase(ref enemyPos8);

                }
                if (heroPosition.X > 15800)
                {
                    enemyChase(ref enemyPos9);

                }


                if (heroPosition.X > 19000)
                {
                    enemyChase(ref enemyPos10);
                    enemyChase(ref enemyPos11);
                }

                if (heroPosition.X > 21000)
                {
                    enemyChase(ref enemyPos12);
                    enemyChase(ref enemyPos13);
                }
                if (heroPosition.X > 23000)
                {
                    enemyChase(ref enemyPos14);
                    enemyChase(ref enemyPos15);
                }

                if (heroPosition.X > 26000)
                {
                    enemyChase(ref enemyPos16);
                    enemyChase(ref enemyPos17);
                }

                if (heroPosition.X > 28000)
                {
                    enemyChase(ref enemyPos18);

                }
                if (heroPosition.X > 30000)
                {
                    enemyChase(ref enemyPos19);

                }

                //level 3 stuff

                if (heroPosition.X > 35024)
                {
                    enemyChase(ref enemyPos21);

                }

                if (heroPosition.X > 36048)
                {
                    enemyChase(ref enemyPos22);

                }

                if (heroPosition.X > 37072)
                {
                    enemyChase(ref enemyPos23);

                }

                if (heroPosition.X > 39120)
                {
                    enemyChase(ref enemyPos24);

                }

                if (heroPosition.X > 42196)
                {
                    enemyChase(ref enemyPos25);

                }

                if (heroPosition.X > 46286)
                {
                    enemyChase(ref enemyPos26);

                }

                if (heroPosition.X > 48336)
                {
                    enemyChase(ref enemyPos27);

                }

                if (heroPosition.X > 50384)
                {
                    enemyChase(ref enemyPos28);

                }

                if (heroPosition.X > 50384)
                {
                    enemyChase(ref enemyPos29);

                }

                if (heroPosition.X > 53456)
                {
                    enemyChase(ref enemyPos30);

                }











            }

            #endregion




            #region Functions_PlayerHits_DIAMONDS (using Flowers)

            //level 1

            playerHitsDiamond(ref visibility1, diamondPos1);
            playerHitsDiamond(ref visibility2, diamondPos2);
            playerHitsDiamond(ref visibility3, diamondPos3);
            playerHitsDiamond(ref visibility4, diamondPos4);
            playerHitsDiamond(ref visibility5, diamondPos5);
            playerHitsDiamond(ref visibility6, diamondPos6);
            playerHitsDiamond(ref visibility7, diamondPos7);
            playerHitsDiamond(ref visibility8, diamondPos8);
            playerHitsDiamond(ref visibility9, diamondPos9);
            playerHitsDiamond(ref visibility10, diamondPos10);
            playerHitsDiamond(ref visibility11, diamondPos11);
            playerHitsDiamond(ref visibility12, diamondPos12);
            playerHitsDiamond(ref visibility13, diamondPos13);
            playerHitsDiamond(ref visibility14, diamondPos14);
            playerHitsDiamond(ref visibility15, diamondPos15);
            playerHitsDiamond(ref visibility16, diamondPos16);
            playerHitsDiamond(ref visibility17, diamondPos17);
            playerHitsDiamond(ref visibility18, diamondPos18);
            playerHitsDiamond(ref visibility19, diamondPos19);
            playerHitsDiamond(ref visibility20, diamondPos20);


            //level 2

            playerHitsDiamond(ref visibility21, diamondPos21);
            playerHitsDiamond(ref visibility22, diamondPos22);
            playerHitsDiamond(ref visibility23, diamondPos23);
            playerHitsDiamond(ref visibility24, diamondPos24);
            playerHitsDiamond(ref visibility25, diamondPos25);
            playerHitsDiamond(ref visibility26, diamondPos26);
            playerHitsDiamond(ref visibility27, diamondPos27);
            playerHitsDiamond(ref visibility28, diamondPos28);
            playerHitsDiamond(ref visibility29, diamondPos29);
            playerHitsDiamond(ref visibility30, diamondPos30);
            playerHitsDiamond(ref visibility31, diamondPos31);
            playerHitsDiamond(ref visibility32, diamondPos32);
            playerHitsDiamond(ref visibility33, diamondPos33);
            playerHitsDiamond(ref visibility34, diamondPos34);
            playerHitsDiamond(ref visibility35, diamondPos35);
            playerHitsDiamond(ref visibility36, diamondPos36);
            playerHitsDiamond(ref visibility37, diamondPos37);
            playerHitsDiamond(ref visibility38, diamondPos38);
            playerHitsDiamond(ref visibility39, diamondPos39);
            playerHitsDiamond(ref visibility40, diamondPos40);

            #endregion

            #region Functions_PlayerHits_DIAMONDS (using gems)

            // bonus levels

            playerHitsDiamond(ref visib1, gemPos1);
            playerHitsDiamond(ref visib2, gemPos2);
            playerHitsDiamond(ref visib3, gemPos3);
            playerHitsDiamond(ref visib4, gemPos4);
            playerHitsDiamond(ref visib5, gemPos5);
            playerHitsDiamond(ref visib6, gemPos6);
            playerHitsDiamond(ref visib7, gemPos7);
            playerHitsDiamond(ref visib8, gemPos8);
            playerHitsDiamond(ref visib9, gemPos9);
            playerHitsDiamond(ref visib10, gemPos10);
            playerHitsDiamond(ref visib11, gemPos11);
            playerHitsDiamond(ref visib12, gemPos12);
            playerHitsDiamond(ref visib13, gemPos13);
            playerHitsDiamond(ref visib14, gemPos14);
            playerHitsDiamond(ref visib15, gemPos15);
            playerHitsDiamond(ref visib16, gemPos16);
            playerHitsDiamond(ref visib17, gemPos17);
            playerHitsDiamond(ref visib18, gemPos18);
            playerHitsDiamond(ref visib19, gemPos19);
            playerHitsDiamond(ref visib20, gemPos20);


            playerHitsDiamond(ref visib21, gemPos21);
            playerHitsDiamond(ref visib22, gemPos22);
            playerHitsDiamond(ref visib23, gemPos23);
            playerHitsDiamond(ref visib24, gemPos24);
            playerHitsDiamond(ref visib25, gemPos25);
            playerHitsDiamond(ref visib26, gemPos26);
            playerHitsDiamond(ref visib27, gemPos27);
            playerHitsDiamond(ref visib28, gemPos28);
            playerHitsDiamond(ref visib29, gemPos29);
            playerHitsDiamond(ref visib30, gemPos30);
            playerHitsDiamond(ref visib31, gemPos31);
            playerHitsDiamond(ref visib32, gemPos32);
            playerHitsDiamond(ref visib33, gemPos33);
            playerHitsDiamond(ref visib34, gemPos34);
            playerHitsDiamond(ref visib35, gemPos35);
            playerHitsDiamond(ref visib36, gemPos36);
            playerHitsDiamond(ref visib37, gemPos37);
            playerHitsDiamond(ref visib38, gemPos38);
            playerHitsDiamond(ref visib39, gemPos39);
            playerHitsDiamond(ref visib40, gemPos40);


            // final / 3rd level

            playerHitsDiamond(ref visib41, gemPos41);
            playerHitsDiamond(ref visib42, gemPos42);
            playerHitsDiamond(ref visib43, gemPos43);
            playerHitsDiamond(ref visib44, gemPos44);
            playerHitsDiamond(ref visib45, gemPos45);
            playerHitsDiamond(ref visib46, gemPos46);
            playerHitsDiamond(ref visib47, gemPos47);
            playerHitsDiamond(ref visib48, gemPos48);
            playerHitsDiamond(ref visib49, gemPos49);
            playerHitsDiamond(ref visib50, gemPos50);
            playerHitsDiamond(ref visib51, gemPos51);
            playerHitsDiamond(ref visib52, gemPos52);
            playerHitsDiamond(ref visib53, gemPos53);
            playerHitsDiamond(ref visib54, gemPos54);
            playerHitsDiamond(ref visib55, gemPos55);
            playerHitsDiamond(ref visib56, gemPos56);
            playerHitsDiamond(ref visib57, gemPos57);
            playerHitsDiamond(ref visib58, gemPos58);
            playerHitsDiamond(ref visib59, gemPos59);
            playerHitsDiamond(ref visib60, gemPos60);


            #endregion

            #region Functions_PlayerHits_BonusREDS

            playerHitsDiamond(ref visibRed1, redBonusPos1);
            playerHitsDiamond(ref visibRed2, redBonusPos2);
            playerHitsDiamond(ref visibRed3, redBonusPos3);
            playerHitsDiamond(ref visibRed4, redBonusPos4);
            playerHitsDiamond(ref visibRed5, redBonusPos5);
            playerHitsDiamond(ref visibRed6, redBonusPos6);
            playerHitsDiamond(ref visibRed7, redBonusPos7);
            playerHitsDiamond(ref visibRed8, redBonusPos8);
            playerHitsDiamond(ref visibRed9, redBonusPos9);
            playerHitsDiamond(ref visibRed10, redBonusPos10);
            playerHitsDiamond(ref visibRed11, redBonusPos11);
            playerHitsDiamond(ref visibRed12, redBonusPos12);
            playerHitsDiamond(ref visibRed13, redBonusPos13);
            playerHitsDiamond(ref visibRed14, redBonusPos14);
            playerHitsDiamond(ref visibRed15, redBonusPos15);
            playerHitsDiamond(ref visibRed16, redBonusPos16);
            playerHitsDiamond(ref visibRed17, redBonusPos17);
            playerHitsDiamond(ref visibRed18, redBonusPos18);
            playerHitsDiamond(ref visibRed19, redBonusPos19);
            playerHitsDiamond(ref visibRed20, redBonusPos20);
            playerHitsDiamond(ref visibRed21, redBonusPos21);
            playerHitsDiamond(ref visibRed22, redBonusPos22);
            playerHitsDiamond(ref visibRed23, redBonusPos23);
            playerHitsDiamond(ref visibRed24, redBonusPos24);
            playerHitsDiamond(ref visibRed25, redBonusPos25);
            playerHitsDiamond(ref visibRed26, redBonusPos26);

            #endregion


            if ((playerHitsNextLevel()))
            {
                lvl2 = true;
                powerUsageCount = 1200;
                heroPosition = new Vector2(56412, 400);

            }

            if ((playerHitsFinalLevel()))
            {
                heroPosition.X = 58412;
            }


            if ((playerHitsSecondLevel()))
            {
                heroPosition.X = 72412;
            }






            #region playerHitsBlock  Effects

            if (playerHitsBlocks(levelBlock1_1, BlockPos1_1, hero, heroPosition))
            {
                heroPosition = new Vector2(heroPosition.X + 2, heroPosition.Y);
            }

            if (playerHitsBlocks(levelBlock1_1, BlockPos1_2, hero, heroPosition))
            {
                heroPosition = new Vector2(heroPosition.X - 2, heroPosition.Y);
            }

            if (playerHitsBlocks(levelBlock1_1, BlockPos2_1, hero, heroPosition))
            {
                heroPosition = new Vector2(heroPosition.X + 2, heroPosition.Y);
            }

            if (playerHitsBlocks(levelBlock1_1, BlockPos2_2, hero, heroPosition))
            {
                heroPosition = new Vector2(heroPosition.X - 12, heroPosition.Y);
            }

            #endregion



            // Sprite Animation STARTS

            #region hero_animation

            if (ks.IsKeyDown(Keys.Right) && (!playerHitsLog() || !playerHitsGround()))
            {

                hero_timeSinceLastFrame += gameTime.ElapsedGameTime.Milliseconds;
                if (hero_timeSinceLastFrame > hero_timePerFrame)
                {
                    hero_timeSinceLastFrame -= hero_timePerFrame;

                    ++heroCurrentFrame.X;
                    if (heroCurrentFrame.X >= heroSheetSize.X)
                    {
                        heroCurrentFrame.X = 0;
                        ++heroCurrentFrame.Y;

                        if (heroCurrentFrame.Y >= heroSheetSize.Y)
                            heroCurrentFrame.Y = 0;
                    }
                }
            }

            if (ks.IsKeyDown(Keys.Left) && (!playerHitsLog() || !playerHitsGround()))
            {

                hero_timeSinceLastFrame += gameTime.ElapsedGameTime.Milliseconds;
                if (hero_timeSinceLastFrame > hero_timePerFrame)
                {
                    hero_timeSinceLastFrame -= hero_timePerFrame;

                    ++heroReverseCurrentFrame.X;
                    if (heroReverseCurrentFrame.X >= heroReverseSheetSize.X)
                    {
                        heroReverseCurrentFrame.X = 0;
                        ++heroReverseCurrentFrame.Y;

                        if (heroReverseCurrentFrame.Y >= heroReverseSheetSize.Y)
                            heroReverseCurrentFrame.Y = 0;
                    }
                }
            }


            if (ks.IsKeyDown(Keys.Right) && (playerHitsLog() || playerHitsGround()))
            {

                hero_timeSinceLastFrame += gameTime.ElapsedGameTime.Milliseconds;
                if (hero_timeSinceLastFrame > hero_timePerFrame)
                {
                    hero_timeSinceLastFrame -= hero_timePerFrame;

                    ++heroCurrentFrame.X;
                    if (heroCurrentFrame.X >= heroSheetSize.X)
                    {
                        heroCurrentFrame.X = 0;
                        ++heroCurrentFrame.Y;

                        if (heroCurrentFrame.Y >= heroSheetSize.Y)
                            heroCurrentFrame.Y = 0;
                    }
                }
            }

            if (ks.IsKeyDown(Keys.Left) && (playerHitsLog() || playerHitsGround()))
            {

                hero_timeSinceLastFrame += gameTime.ElapsedGameTime.Milliseconds;
                if (hero_timeSinceLastFrame > hero_timePerFrame)
                {
                    hero_timeSinceLastFrame -= hero_timePerFrame;

                    ++heroReverseCurrentFrame.X;
                    if (heroReverseCurrentFrame.X >= heroReverseSheetSize.X)
                    {
                        heroReverseCurrentFrame.X = 0;
                        ++heroReverseCurrentFrame.Y;

                        if (heroReverseCurrentFrame.Y >= heroReverseSheetSize.Y)
                            heroReverseCurrentFrame.Y = 0;
                    }
                }
            }


            #endregion

            #region enemy_animation



            enemy_timeSinceLastFrame += gameTime.ElapsedGameTime.Milliseconds;
            if (enemy_timeSinceLastFrame > enemy_timePerFrame)
            {
                enemy_timeSinceLastFrame -= enemy_timePerFrame;

                ++enemyCurrentFrame.X;
                if (enemyCurrentFrame.X >= enemySheetSize.X)
                {
                    enemyCurrentFrame.X = 0;
                    ++enemyCurrentFrame.Y;

                    if (enemyCurrentFrame.Y >= enemySheetSize.Y)
                        enemyCurrentFrame.Y = 0;
                }
            }

            #endregion


            #region diamond_animation

            diamond_timeSinceLastFrame += gameTime.ElapsedGameTime.Milliseconds;
            if (diamond_timeSinceLastFrame > diamond_timePerFrame)
            {
                diamond_timeSinceLastFrame -= diamond_timePerFrame;

                ++diamondCurrentFrame.X;
                if (diamondCurrentFrame.X >= diamondSheetSize.X)
                {
                    diamondCurrentFrame.X = 0;
                    ++diamondCurrentFrame.Y;

                    if (diamondCurrentFrame.Y >= diamondSheetSize.Y)
                        diamondCurrentFrame.Y = 0;
                }
            }

            #endregion

            #region gem_animation

            gem_timeSinceLastFrame += gameTime.ElapsedGameTime.Milliseconds;
            if (gem_timeSinceLastFrame > gem_timePerFrame)
            {
                gem_timeSinceLastFrame -= gem_timePerFrame;

                ++gemCurrentFrame.X;
                if (gemCurrentFrame.X >= gemSheetSize.X)
                {
                    gemCurrentFrame.X = 0;
                    ++gemCurrentFrame.Y;

                    if (gemCurrentFrame.Y >= gemSheetSize.Y)
                        gemCurrentFrame.Y = 0;
                }
            }

            #endregion

            #region bonusRed_animation

            redBonus_timeSinceLastFrame += gameTime.ElapsedGameTime.Milliseconds;
            if (redBonus_timeSinceLastFrame > redBonus_timePerFrame)
            {
                redBonus_timeSinceLastFrame -= redBonus_timePerFrame;

                ++redBonusCurrentFrame.X;
                if (redBonusCurrentFrame.X >= redBonusSheetSize.X)
                {
                    redBonusCurrentFrame.X = 0;
                    ++redBonusCurrentFrame.Y;

                    if (redBonusCurrentFrame.Y >= redBonusSheetSize.Y)
                        gemCurrentFrame.Y = 0;
                }
            }

            #endregion

            #region water_animation

            water_timeSinceLastFrame += gameTime.ElapsedGameTime.Milliseconds;
            if (water_timeSinceLastFrame > water_timePerFrame)
            {
                water_timeSinceLastFrame -= water_timePerFrame;

                ++waterCurrentFrame.X;
                if (waterCurrentFrame.X >= waterSheetSize.X)
                {
                    waterCurrentFrame.X = 0;
                    ++waterCurrentFrame.Y;

                    if (waterCurrentFrame.Y >= waterSheetSize.Y)
                        waterCurrentFrame.Y = 0;
                }
            }

            #endregion

            #region deer_Animation

            deer_timeSinceLastFrame += gameTime.ElapsedGameTime.Milliseconds;
            if (deer_timeSinceLastFrame > deer_timePerFrame)
            {
                deer_timeSinceLastFrame -= deer_timePerFrame;

                ++deerCurrentFrame.X;
                if (deerCurrentFrame.X >= deerSheetSize.X)
                {
                    deerCurrentFrame.X = 0;
                    ++deerCurrentFrame.Y;

                    if (deerCurrentFrame.Y >= deerSheetSize.Y)
                        deerCurrentFrame.Y = 0;
                }
            }


            #endregion

            #region bird_Animation

            bird_timeSinceLastFrame += gameTime.ElapsedGameTime.Milliseconds;
            if (bird_timeSinceLastFrame > bird_timePerFrame)
            {
                bird_timeSinceLastFrame -= bird_timePerFrame;

                ++birdCurrentFrame.X;
                if (birdCurrentFrame.X >= birdSheetSize.X)
                {
                    birdCurrentFrame.X = 0;
                    ++birdCurrentFrame.Y;

                    if (birdCurrentFrame.Y >= birdSheetSize.Y)
                        birdCurrentFrame.Y = 0;
                }
            }


            #endregion

            #region fire_animation

            //fire tourch

            fireTourch_timeSinceLastFrame += gameTime.ElapsedGameTime.Milliseconds;
            if (fireTourch_timeSinceLastFrame > fireTourch_timePerFrame)
            {
                fireTourch_timeSinceLastFrame -= fireTourch_timePerFrame;

                ++fireTourchCurrentFrame.X;
                if (fireTourchCurrentFrame.X >= fireTourchSheetSize.X)
                {
                    fireTourchCurrentFrame.X = 0;
                    ++fireTourchCurrentFrame.Y;

                    if (fireTourchCurrentFrame.Y >= fireTourchSheetSize.Y)
                        fireTourchCurrentFrame.Y = 0;
                }
            }

            // meduim fire

            fireMedium_timeSinceLastFrame += gameTime.ElapsedGameTime.Milliseconds;
            if (fireMedium_timeSinceLastFrame > fireMedium_timePerFrame)
            {
                fireMedium_timeSinceLastFrame -= fireMedium_timePerFrame;

                ++fireMediumCurrentFrame.X;
                if (fireMediumCurrentFrame.X >= fireMediumSheetSize.X)
                {
                    fireMediumCurrentFrame.X = 0;
                    ++fireMediumCurrentFrame.Y;

                    if (fireMediumCurrentFrame.Y >= fireMediumSheetSize.Y)
                        fireMediumCurrentFrame.Y = 0;
                }
            }



            //fire large

            fireLarge_timeSinceLastFrame += gameTime.ElapsedGameTime.Milliseconds;
            if (fireLarge_timeSinceLastFrame > fireLarge_timePerFrame)
            {
                fireLarge_timeSinceLastFrame -= fireLarge_timePerFrame;

                ++fireLargeCurrentFrame.X;
                if (fireLargeCurrentFrame.X >= fireLargeSheetSize.X)
                {
                    fireLargeCurrentFrame.X = 0;
                    ++fireLargeCurrentFrame.Y;

                    if (fireLargeCurrentFrame.Y >= fireLargeSheetSize.Y)
                        fireLargeCurrentFrame.Y = 0;
                }
            }




            #endregion



            #region snake_Animation

            snake_timeSinceLastFrame += gameTime.ElapsedGameTime.Milliseconds;
            if (snake_timeSinceLastFrame > snake_timePerFrame)
            {
                snake_timeSinceLastFrame -= snake_timePerFrame;

                ++snakeCurrentFrame.X;
                if (snakeCurrentFrame.X >= snakeSheetSize.X)
                {
                    snakeCurrentFrame.X = 0;
                    ++snakeCurrentFrame.Y;

                    if (snakeCurrentFrame.Y >= snakeSheetSize.Y)
                        snakeCurrentFrame.Y = 0;
                }
            }


            #endregion

            #region TIGER_ANIMATION

            tiger_timeSinceLastFrame += gameTime.ElapsedGameTime.Milliseconds;
            if (tiger_timeSinceLastFrame > tiger_timePerFrame)
            {
                tiger_timeSinceLastFrame -= tiger_timePerFrame;

                ++tigerCurrentFrame.X;
                if (tigerCurrentFrame.X >= tigerSheetSize.X)
                {
                    tigerCurrentFrame.X = 0;
                    ++tigerCurrentFrame.Y;

                    if (tigerCurrentFrame.Y >= tigerSheetSize.Y)
                        tigerCurrentFrame.Y = 0;
                }
            }

            #endregion
            // Sprite Animation ENDS


            #region logMoving

            if (!(isPaused))
                logMoves();

            //level 1

            logPos1.Y += logSpeed;
            logPos2.Y += logSpeed;
            logPos3.Y += logSpeed;
            logPos4.Y += logSpeed;
            logPos5.Y += logSpeed;

            //level 2
            logPos6.Y += logSpeed;
            logPos7.Y += logSpeed;
            logPos8.Y += logSpeed;
            logPos9.Y += logSpeed;
            logPos10.Y += logSpeed;
            logPos11.Y += logSpeed;

            //logPos12.Y += logSpeed;




            //logPos13.Y += logSpeed;
            //logPos14.Y += logSpeed;
            //logPos15.Y += logSpeed;
            //logPos16.Y += logSpeed;
            //logPos17.Y += logSpeed;
            //logPos18.Y += logSpeed;
            //logPos19.Y += logSpeed;
            //logPos20.Y += logSpeed;
            //logPos21.Y += logSpeed;
            //logPos22.Y += logSpeed;
            //logPos23.Y += logSpeed;
            //logPos24.Y += logSpeed;





            #endregion

            #region deermoving

            //level 1

            if (heroPosition.X > 2560 && heroPosition.X < 4560)
                deerPos1.X -= deerSpeed;
            if (heroPosition.X > 5632 && heroPosition.X < 7632)
                deerPos2.X -= deerSpeed;
            if (heroPosition.X > 7580 && heroPosition.X < 9580)
                deerPos3.X += deerSpeed;

            //level 2


            if (heroPosition.X > 13024 && heroPosition.X < 15024)
                deerPos4.X -= deerSpeed;
            if (heroPosition.X > 23000 && heroPosition.X < 25000)
                deerPos5.X -= deerSpeed;
            if (heroPosition.X > 24500 && heroPosition.X < 32000)
                deerPos6.X += deerSpeed;
            if (heroPosition.X > 27400 && heroPosition.X < 32000)
                deerPos7.X += deerSpeed;
            if (heroPosition.X > 29000 && heroPosition.X < 32000)
                deerPos8.X += deerSpeed;




            #endregion

            #region TigerMoving

            if (heroPosition.X > 17120)
                tigerPos1.X -= tigerSpeed;
            if (heroPosition.X > 51300)
                tigerPos2.X -= tigerSpeed;
            if (heroPosition.X > 51500)
                tigerPos3.X -= tigerSpeed;
            if (heroPosition.X > 51700)
                tigerPos4.X -= tigerSpeed;


            #endregion

            #region birdmoving

            if (heroPosition.X > 1036)
                birdPos1.X -= birdSpeed;
            if (heroPosition.X > 3500)
                birdPos2.X -= birdSpeed;
            if (heroPosition.X > 9728)
                birdPos3.X -= birdSpeed;
            if (heroPosition.X > 17500)
                birdPos4.X -= birdSpeed;
            if (heroPosition.X > 21900)
                birdPos5.X -= birdSpeed;
            if (heroPosition.X > 23700)
                birdPos6.X -= birdSpeed;



            #endregion

            #region snakemoving

            if (heroPosition.X > 37096)
                snakePos1.X -= snakeSpeed;
            if (heroPosition.X > 41196)
                snakePos2.X -= snakeSpeed;
            if (heroPosition.X > 44264)
                snakePos3.X -= snakeSpeed;
            if (heroPosition.X > 48360)
                snakePos4.X -= snakeSpeed;

            if (heroPosition.X > 13100)
                snakePos5.X -= snakeSpeed;
            if (heroPosition.X > 15000)
                snakePos6.X -= snakeSpeed;
            if (heroPosition.X > 20000)
                snakePos7.X -= snakeSpeed;
            if (heroPosition.X > 25300)
                snakePos8.X -= snakeSpeed;



            #endregion

            #region player_hits_SkyCLOUDS

            if (playerHitsSky())
                heroPosition = new Vector2(60412, 0);

            if (playerHitsCloud())
                heroPosition.Y -= 0;

            #endregion


            #region cloudMoving

            cloudPos4.X += cloudSpeed;

            //if (playerHitsBlocks(levelBlock1_1, BlockPosB2, hero, heroPosition) || playerHitsBlocks(levelBlock1_1, BlockPosB1, hero, heroPosition))

            if (cloudHitsBlock())
                cloudSpeed *= -1;



            #endregion

            #region lvl3tile_mover

            lvl3blockPos30.X += lvl3blockSpeed;
            lvl3blockPos33.X += lvl3blockSpeed;

            if (movingBlockhitsBlock())
                lvl3blockSpeed *= -1;


            #endregion

            camera.update(gameTime, this);


            base.Update(gameTime);

            if (playerHitsNextLevel())
            {
                heroPosition = new Vector2(8000, 0);
                nextLevel();
            }


            //  if(playerHitsBlocks(, , ))



          
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here

            spriteBatch.Begin(SpriteSortMode.FrontToBack, BlendState.AlphaBlend, null, null, null, null, camera.transform);

            #region ground_draw
            spriteBatch.Draw(ground, groundPos, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(ground, groundPos1, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(ground, groundPos2, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(ground, groundPos3, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(ground, groundPos4, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(ground, groundPos5, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(ground, groundPos6, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(ground, groundPos7, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(ground, groundPos8, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(ground, groundPos9, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(ground, groundPos10, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            //spriteBatch.Draw(ground, groundPos11, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);


            #endregion

            #region tower_draw

            spriteBatch.Draw(levelBlock1_1, BlockPos1_1, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(levelBlock1_1, BlockPos1_2, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(levelBlock1_1, BlockPos2_1, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(levelBlock1_1, BlockPos2_2, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(levelBlock1_1, BlockPos3_1, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(levelBlock1_1, BlockPosB1, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(levelBlock1_1, BlockPosB2, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            //spriteBatch.Draw(tower, new Vector2(1000, 20), null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 0);
            //spriteBatch.Draw(tower, new Vector2(1500, 20), null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 0);
            //spriteBatch.Draw(tower, new Vector2(1800, 20), null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 0);
            //spriteBatch.Draw(tower, new Vector2(2300, 20), null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 0);

            //spriteBatch.Draw(tower, new Vector2(4500, 20), null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 0);
            //spriteBatch.Draw(tower, new Vector2(5000, 20), null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 0);
            //spriteBatch.Draw(tower, new Vector2(6500, 20), null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 0);
            //spriteBatch.Draw(tower, new Vector2(7000, 20), null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 0);
            #endregion


            #region enemy_draw
            // if ((enemyReversed == 1))
            // {
            spriteBatch.Draw(enemy, enemyPos1, new Rectangle(enemyCurrentFrame.X * enemyFrameSize.X, enemyCurrentFrame.Y * enemyFrameSize.Y, enemyFrameSize.X, enemyFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(enemy, enemyPos2, new Rectangle(enemyCurrentFrame.X * enemyFrameSize.X, enemyCurrentFrame.Y * enemyFrameSize.Y, enemyFrameSize.X, enemyFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(enemy, enemyPos3, new Rectangle(enemyCurrentFrame.X * enemyFrameSize.X, enemyCurrentFrame.Y * enemyFrameSize.Y, enemyFrameSize.X, enemyFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(enemy, enemyPos4, new Rectangle(enemyCurrentFrame.X * enemyFrameSize.X, enemyCurrentFrame.Y * enemyFrameSize.Y, enemyFrameSize.X, enemyFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(enemy, enemyPos5, new Rectangle(enemyCurrentFrame.X * enemyFrameSize.X, enemyCurrentFrame.Y * enemyFrameSize.Y, enemyFrameSize.X, enemyFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(enemy, enemyPos6, new Rectangle(enemyCurrentFrame.X * enemyFrameSize.X, enemyCurrentFrame.Y * enemyFrameSize.Y, enemyFrameSize.X, enemyFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(enemy, enemyPos7, new Rectangle(enemyCurrentFrame.X * enemyFrameSize.X, enemyCurrentFrame.Y * enemyFrameSize.Y, enemyFrameSize.X, enemyFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(enemy, enemyPos8, new Rectangle(enemyCurrentFrame.X * enemyFrameSize.X, enemyCurrentFrame.Y * enemyFrameSize.Y, enemyFrameSize.X, enemyFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(enemy, enemyPos9, new Rectangle(enemyCurrentFrame.X * enemyFrameSize.X, enemyCurrentFrame.Y * enemyFrameSize.Y, enemyFrameSize.X, enemyFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(enemy, enemyPos10, new Rectangle(enemyCurrentFrame.X * enemyFrameSize.X, enemyCurrentFrame.Y * enemyFrameSize.Y, enemyFrameSize.X, enemyFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(enemy, enemyPos11, new Rectangle(enemyCurrentFrame.X * enemyFrameSize.X, enemyCurrentFrame.Y * enemyFrameSize.Y, enemyFrameSize.X, enemyFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(enemy, enemyPos12, new Rectangle(enemyCurrentFrame.X * enemyFrameSize.X, enemyCurrentFrame.Y * enemyFrameSize.Y, enemyFrameSize.X, enemyFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(enemy, enemyPos13, new Rectangle(enemyCurrentFrame.X * enemyFrameSize.X, enemyCurrentFrame.Y * enemyFrameSize.Y, enemyFrameSize.X, enemyFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(enemy, enemyPos14, new Rectangle(enemyCurrentFrame.X * enemyFrameSize.X, enemyCurrentFrame.Y * enemyFrameSize.Y, enemyFrameSize.X, enemyFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(enemy, enemyPos15, new Rectangle(enemyCurrentFrame.X * enemyFrameSize.X, enemyCurrentFrame.Y * enemyFrameSize.Y, enemyFrameSize.X, enemyFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(enemy, enemyPos16, new Rectangle(enemyCurrentFrame.X * enemyFrameSize.X, enemyCurrentFrame.Y * enemyFrameSize.Y, enemyFrameSize.X, enemyFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(enemy, enemyPos17, new Rectangle(enemyCurrentFrame.X * enemyFrameSize.X, enemyCurrentFrame.Y * enemyFrameSize.Y, enemyFrameSize.X, enemyFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(enemy, enemyPos18, new Rectangle(enemyCurrentFrame.X * enemyFrameSize.X, enemyCurrentFrame.Y * enemyFrameSize.Y, enemyFrameSize.X, enemyFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(enemy, enemyPos19, new Rectangle(enemyCurrentFrame.X * enemyFrameSize.X, enemyCurrentFrame.Y * enemyFrameSize.Y, enemyFrameSize.X, enemyFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(enemy, enemyPos20, new Rectangle(enemyCurrentFrame.X * enemyFrameSize.X, enemyCurrentFrame.Y * enemyFrameSize.Y, enemyFrameSize.X, enemyFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(enemy, enemyPos21, new Rectangle(enemyCurrentFrame.X * enemyFrameSize.X, enemyCurrentFrame.Y * enemyFrameSize.Y, enemyFrameSize.X, enemyFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(enemy, enemyPos22, new Rectangle(enemyCurrentFrame.X * enemyFrameSize.X, enemyCurrentFrame.Y * enemyFrameSize.Y, enemyFrameSize.X, enemyFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(enemy, enemyPos23, new Rectangle(enemyCurrentFrame.X * enemyFrameSize.X, enemyCurrentFrame.Y * enemyFrameSize.Y, enemyFrameSize.X, enemyFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(enemy, enemyPos24, new Rectangle(enemyCurrentFrame.X * enemyFrameSize.X, enemyCurrentFrame.Y * enemyFrameSize.Y, enemyFrameSize.X, enemyFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(enemy, enemyPos25, new Rectangle(enemyCurrentFrame.X * enemyFrameSize.X, enemyCurrentFrame.Y * enemyFrameSize.Y, enemyFrameSize.X, enemyFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(enemy, enemyPos26, new Rectangle(enemyCurrentFrame.X * enemyFrameSize.X, enemyCurrentFrame.Y * enemyFrameSize.Y, enemyFrameSize.X, enemyFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(enemy, enemyPos27, new Rectangle(enemyCurrentFrame.X * enemyFrameSize.X, enemyCurrentFrame.Y * enemyFrameSize.Y, enemyFrameSize.X, enemyFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(enemy, enemyPos28, new Rectangle(enemyCurrentFrame.X * enemyFrameSize.X, enemyCurrentFrame.Y * enemyFrameSize.Y, enemyFrameSize.X, enemyFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(enemy, enemyPos29, new Rectangle(enemyCurrentFrame.X * enemyFrameSize.X, enemyCurrentFrame.Y * enemyFrameSize.Y, enemyFrameSize.X, enemyFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(enemy, enemyPos30, new Rectangle(enemyCurrentFrame.X * enemyFrameSize.X, enemyCurrentFrame.Y * enemyFrameSize.Y, enemyFrameSize.X, enemyFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);


            //}
            //if((enemyReversed == -1))
            //{
            //    spriteBatch.Draw(enemyReverse, enemyPos, new Rectangle(enemyCurrentFrame.X * enemyFrameSize.X, enemyCurrentFrame.Y * enemyFrameSize.Y, enemyFrameSize.X, enemyFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            //    spriteBatch.Draw(enemyReverse, enemyPos1, new Rectangle(enemyCurrentFrame.X * enemyFrameSize.X, enemyCurrentFrame.Y * enemyFrameSize.Y, enemyFrameSize.X, enemyFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            //    spriteBatch.Draw(enemyReverse, enemyPos2, new Rectangle(enemyCurrentFrame.X * enemyFrameSize.X, enemyCurrentFrame.Y * enemyFrameSize.Y, enemyFrameSize.X, enemyFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            //    spriteBatch.Draw(enemyReverse, enemyPos3, new Rectangle(enemyCurrentFrame.X * enemyFrameSize.X, enemyCurrentFrame.Y * enemyFrameSize.Y, enemyFrameSize.X, enemyFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            //}

            #endregion

            #region background_draw


            spriteBatch.Draw(titleScreen, new Vector2(-412, 0), null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1f);

            //level 1

            spriteBatch.Draw(back1_1, new Vector2(512, 0), null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 0.0f);
            spriteBatch.Draw(back1_2, new Vector2(1536, 0), null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 0.0f);
            spriteBatch.Draw(back1_3, new Vector2(2560, 0), null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 0.0f);
            spriteBatch.Draw(back1_4, new Vector2(3584, 0), null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 0.0f);
            spriteBatch.Draw(back1_5, new Vector2(4608, 0), null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 0.0f);
            spriteBatch.Draw(back1_6, new Vector2(5632, 0), null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 0.0f);
            spriteBatch.Draw(back1_7, new Vector2(6656, 0), null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 0.0f);
            spriteBatch.Draw(back1_8, new Vector2(7680, 0), null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 0.0f);
            spriteBatch.Draw(back1_9, new Vector2(8704, 0), null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 0.0f);
            spriteBatch.Draw(back1_10, new Vector2(9728, 0), null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 0.0f);

            //level 2

            spriteBatch.Draw(back2_1, new Vector2(12000, 0), null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 0.0f);
            spriteBatch.Draw(back2_2, new Vector2(13024, 0), null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 0.0f);
            spriteBatch.Draw(back2_3, new Vector2(14048, 0), null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 0.0f);
            spriteBatch.Draw(back2_4, new Vector2(15072, 0), null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 0.0f);
            spriteBatch.Draw(back2_5, new Vector2(16096, 0), null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 0.0f);
            spriteBatch.Draw(back2_6, new Vector2(17120, 0), null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 0.0f);
            spriteBatch.Draw(back2_7, new Vector2(18144, 0), null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 0.0f);
            spriteBatch.Draw(back2_8, new Vector2(19168, 0), null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 0.0f);
            spriteBatch.Draw(back2_9, new Vector2(20192, 0), null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 0.0f);
            spriteBatch.Draw(back2_10, new Vector2(21216, 0), null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 0.0f);
            spriteBatch.Draw(back2_11, new Vector2(22240, 0), null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 0.0f);
            spriteBatch.Draw(back2_12, new Vector2(23264, 0), null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 0.0f);
            spriteBatch.Draw(back2_13, new Vector2(24288, 0), null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 0.0f);
            spriteBatch.Draw(back2_14, new Vector2(25312, 0), null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 0.0f);
            spriteBatch.Draw(back2_15, new Vector2(26336, 0), null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 0.0f);
            spriteBatch.Draw(back2_16, new Vector2(27360, 0), null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 0.0f);
            spriteBatch.Draw(back2_17, new Vector2(28384, 0), null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 0.0f);
            spriteBatch.Draw(back2_18, new Vector2(29408, 0), null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 0.0f);
            spriteBatch.Draw(back2_19, new Vector2(30432, 0), null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 0.0f);
            spriteBatch.Draw(back2_20, new Vector2(31456, 0), null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 0.0f);

            //level 3

            spriteBatch.Draw(back3_1, new Vector2(34000, 0), null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 0.0f);
            spriteBatch.Draw(back3_2, new Vector2(35024, 0), null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 0.0f);
            spriteBatch.Draw(back3_3, new Vector2(36048, 0), null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 0.0f);
            spriteBatch.Draw(back3_4, new Vector2(37072, 0), null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 0.0f);
            spriteBatch.Draw(back3_5, new Vector2(38096, 0), null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 0.0f);
            spriteBatch.Draw(back3_6, new Vector2(39120, 0), null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 0.0f);
            spriteBatch.Draw(back3_7, new Vector2(40144, 0), null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 0.0f);
            spriteBatch.Draw(back3_8, new Vector2(41168, 0), null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 0.0f);
            spriteBatch.Draw(back3_9, new Vector2(42192, 0), null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 0.0f);
            spriteBatch.Draw(back3_10, new Vector2(43216, 0), null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 0.0f);
            spriteBatch.Draw(back3_11, new Vector2(44240, 0), null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 0.0f);
            spriteBatch.Draw(back3_12, new Vector2(45264, 0), null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 0.0f);
            spriteBatch.Draw(back3_13, new Vector2(46288, 0), null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 0.0f);
            spriteBatch.Draw(back3_14, new Vector2(47312, 0), null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 0.0f);
            spriteBatch.Draw(back3_15, new Vector2(48336, 0), null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 0.0f);
            spriteBatch.Draw(back3_16, new Vector2(49360, 0), null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 0.0f);
            spriteBatch.Draw(back3_17, new Vector2(50384, 0), null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 0.0f);
            spriteBatch.Draw(back3_18, new Vector2(51408, 0), null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 0.0f);
            spriteBatch.Draw(back3_19, new Vector2(52432, 0), null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 0.0f);
            spriteBatch.Draw(back3_20, new Vector2(53456, 0), null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 0.0f);

            //menu screens

            spriteBatch.Draw(level2start, new Vector2(56000, 0), null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(level3start, new Vector2(72000, 0), null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(winScreen, new Vector2(58000, 0), null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 0.9f);
            spriteBatch.Draw(failScreen, new Vector2(60000, 0), null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(quests, new Vector2(62000, 0), null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1f);
            spriteBatch.Draw(tutorial, new Vector2(64000, 0), null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1f);
            spriteBatch.Draw(controllers, new Vector2(66000, 0), null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1f);
            spriteBatch.Draw(gamePauseScreen, new Vector2(68000, 0), null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1f);
            spriteBatch.Draw(exitToMenu, new Vector2(70000, 0), null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(bonusScreen1, new Vector2(-3000, 0), null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 0.0f);
            spriteBatch.Draw(bonusScreen2, new Vector2(-1976, 0), null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 0.0f);
            spriteBatch.Draw(bonusScreen3, new Vector2(-952, 0), null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 0.0f);




            #endregion


            #region hero_draw
            //  spriteBatch.Draw(hero, heroPosition, new Rectangle(heroCurrentFrame.X * heroFrameSize.X, heroCurrentFrame.Y* heroFrameSize.Y, heroFrameSize.X, heroFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            #endregion

            #region diamond_draw

            // level 1


            if (visibility1)
                spriteBatch.Draw(diamond, diamondPos1, new Rectangle(diamondCurrentFrame.X * diamondFrameSize.X, diamondCurrentFrame.Y * diamondFrameSize.Y, diamondFrameSize.X, diamondFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visibility2)
                spriteBatch.Draw(diamond, diamondPos2, new Rectangle(diamondCurrentFrame.X * diamondFrameSize.X, diamondCurrentFrame.Y * diamondFrameSize.Y, diamondFrameSize.X, diamondFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visibility3)
                spriteBatch.Draw(diamond, diamondPos3, new Rectangle(diamondCurrentFrame.X * diamondFrameSize.X, diamondCurrentFrame.Y * diamondFrameSize.Y, diamondFrameSize.X, diamondFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visibility4)
                spriteBatch.Draw(diamond, diamondPos4, new Rectangle(diamondCurrentFrame.X * diamondFrameSize.X, diamondCurrentFrame.Y * diamondFrameSize.Y, diamondFrameSize.X, diamondFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visibility5)
                spriteBatch.Draw(diamond, diamondPos5, new Rectangle(diamondCurrentFrame.X * diamondFrameSize.X, diamondCurrentFrame.Y * diamondFrameSize.Y, diamondFrameSize.X, diamondFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visibility6)
                spriteBatch.Draw(diamond, diamondPos6, new Rectangle(diamondCurrentFrame.X * diamondFrameSize.X, diamondCurrentFrame.Y * diamondFrameSize.Y, diamondFrameSize.X, diamondFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visibility7)
                spriteBatch.Draw(diamond, diamondPos7, new Rectangle(diamondCurrentFrame.X * diamondFrameSize.X, diamondCurrentFrame.Y * diamondFrameSize.Y, diamondFrameSize.X, diamondFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visibility8)
                spriteBatch.Draw(diamond, diamondPos8, new Rectangle(diamondCurrentFrame.X * diamondFrameSize.X, diamondCurrentFrame.Y * diamondFrameSize.Y, diamondFrameSize.X, diamondFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visibility9)
                spriteBatch.Draw(diamond, diamondPos9, new Rectangle(diamondCurrentFrame.X * diamondFrameSize.X, diamondCurrentFrame.Y * diamondFrameSize.Y, diamondFrameSize.X, diamondFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visibility10)
                spriteBatch.Draw(diamond, diamondPos10, new Rectangle(diamondCurrentFrame.X * diamondFrameSize.X, diamondCurrentFrame.Y * diamondFrameSize.Y, diamondFrameSize.X, diamondFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            //level 2


            if (visibility11)
                spriteBatch.Draw(diamond, diamondPos11, new Rectangle(diamondCurrentFrame.X * diamondFrameSize.X, diamondCurrentFrame.Y * diamondFrameSize.Y, diamondFrameSize.X, diamondFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visibility12)
                spriteBatch.Draw(diamond, diamondPos12, new Rectangle(diamondCurrentFrame.X * diamondFrameSize.X, diamondCurrentFrame.Y * diamondFrameSize.Y, diamondFrameSize.X, diamondFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visibility13)
                spriteBatch.Draw(diamond, diamondPos13, new Rectangle(diamondCurrentFrame.X * diamondFrameSize.X, diamondCurrentFrame.Y * diamondFrameSize.Y, diamondFrameSize.X, diamondFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visibility14)
                spriteBatch.Draw(diamond, diamondPos14, new Rectangle(diamondCurrentFrame.X * diamondFrameSize.X, diamondCurrentFrame.Y * diamondFrameSize.Y, diamondFrameSize.X, diamondFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visibility15)
                spriteBatch.Draw(diamond, diamondPos15, new Rectangle(diamondCurrentFrame.X * diamondFrameSize.X, diamondCurrentFrame.Y * diamondFrameSize.Y, diamondFrameSize.X, diamondFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visibility16)
                spriteBatch.Draw(diamond, diamondPos16, new Rectangle(diamondCurrentFrame.X * diamondFrameSize.X, diamondCurrentFrame.Y * diamondFrameSize.Y, diamondFrameSize.X, diamondFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visibility17)
                spriteBatch.Draw(diamond, diamondPos17, new Rectangle(diamondCurrentFrame.X * diamondFrameSize.X, diamondCurrentFrame.Y * diamondFrameSize.Y, diamondFrameSize.X, diamondFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visibility18)
                spriteBatch.Draw(diamond, diamondPos18, new Rectangle(diamondCurrentFrame.X * diamondFrameSize.X, diamondCurrentFrame.Y * diamondFrameSize.Y, diamondFrameSize.X, diamondFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visibility19)
                spriteBatch.Draw(diamond, diamondPos19, new Rectangle(diamondCurrentFrame.X * diamondFrameSize.X, diamondCurrentFrame.Y * diamondFrameSize.Y, diamondFrameSize.X, diamondFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visibility20)
                spriteBatch.Draw(diamond, diamondPos20, new Rectangle(diamondCurrentFrame.X * diamondFrameSize.X, diamondCurrentFrame.Y * diamondFrameSize.Y, diamondFrameSize.X, diamondFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);


            if (visibility21)
                spriteBatch.Draw(diamond, diamondPos21, new Rectangle(diamondCurrentFrame.X * diamondFrameSize.X, diamondCurrentFrame.Y * diamondFrameSize.Y, diamondFrameSize.X, diamondFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visibility22)
                spriteBatch.Draw(diamond, diamondPos22, new Rectangle(diamondCurrentFrame.X * diamondFrameSize.X, diamondCurrentFrame.Y * diamondFrameSize.Y, diamondFrameSize.X, diamondFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visibility23)
                spriteBatch.Draw(diamond, diamondPos23, new Rectangle(diamondCurrentFrame.X * diamondFrameSize.X, diamondCurrentFrame.Y * diamondFrameSize.Y, diamondFrameSize.X, diamondFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visibility24)
                spriteBatch.Draw(diamond, diamondPos24, new Rectangle(diamondCurrentFrame.X * diamondFrameSize.X, diamondCurrentFrame.Y * diamondFrameSize.Y, diamondFrameSize.X, diamondFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visibility25)
                spriteBatch.Draw(diamond, diamondPos25, new Rectangle(diamondCurrentFrame.X * diamondFrameSize.X, diamondCurrentFrame.Y * diamondFrameSize.Y, diamondFrameSize.X, diamondFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visibility26)
                spriteBatch.Draw(diamond, diamondPos26, new Rectangle(diamondCurrentFrame.X * diamondFrameSize.X, diamondCurrentFrame.Y * diamondFrameSize.Y, diamondFrameSize.X, diamondFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visibility27)
                spriteBatch.Draw(diamond, diamondPos27, new Rectangle(diamondCurrentFrame.X * diamondFrameSize.X, diamondCurrentFrame.Y * diamondFrameSize.Y, diamondFrameSize.X, diamondFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visibility28)
                spriteBatch.Draw(diamond, diamondPos28, new Rectangle(diamondCurrentFrame.X * diamondFrameSize.X, diamondCurrentFrame.Y * diamondFrameSize.Y, diamondFrameSize.X, diamondFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visibility29)
                spriteBatch.Draw(diamond, diamondPos29, new Rectangle(diamondCurrentFrame.X * diamondFrameSize.X, diamondCurrentFrame.Y * diamondFrameSize.Y, diamondFrameSize.X, diamondFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visibility30)
                spriteBatch.Draw(diamond, diamondPos30, new Rectangle(diamondCurrentFrame.X * diamondFrameSize.X, diamondCurrentFrame.Y * diamondFrameSize.Y, diamondFrameSize.X, diamondFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visibility31)
                spriteBatch.Draw(diamond, diamondPos31, new Rectangle(diamondCurrentFrame.X * diamondFrameSize.X, diamondCurrentFrame.Y * diamondFrameSize.Y, diamondFrameSize.X, diamondFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visibility32)
                spriteBatch.Draw(diamond, diamondPos32, new Rectangle(diamondCurrentFrame.X * diamondFrameSize.X, diamondCurrentFrame.Y * diamondFrameSize.Y, diamondFrameSize.X, diamondFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visibility33)
                spriteBatch.Draw(diamond, diamondPos33, new Rectangle(diamondCurrentFrame.X * diamondFrameSize.X, diamondCurrentFrame.Y * diamondFrameSize.Y, diamondFrameSize.X, diamondFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visibility34)
                spriteBatch.Draw(diamond, diamondPos34, new Rectangle(diamondCurrentFrame.X * diamondFrameSize.X, diamondCurrentFrame.Y * diamondFrameSize.Y, diamondFrameSize.X, diamondFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            /*
             
            if (visibility35)
                spriteBatch.Draw(diamond, diamondPos35, new Rectangle(diamondCurrentFrame.X * diamondFrameSize.X, diamondCurrentFrame.Y * diamondFrameSize.Y, diamondFrameSize.X, diamondFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visibility36)
                spriteBatch.Draw(diamond, diamondPos36, new Rectangle(diamondCurrentFrame.X * diamondFrameSize.X, diamondCurrentFrame.Y * diamondFrameSize.Y, diamondFrameSize.X, diamondFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visibility37)
                spriteBatch.Draw(diamond, diamondPos37, new Rectangle(diamondCurrentFrame.X * diamondFrameSize.X, diamondCurrentFrame.Y * diamondFrameSize.Y, diamondFrameSize.X, diamondFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visibility38)
                spriteBatch.Draw(diamond, diamondPos38, new Rectangle(diamondCurrentFrame.X * diamondFrameSize.X, diamondCurrentFrame.Y * diamondFrameSize.Y, diamondFrameSize.X, diamondFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visibility39)
                spriteBatch.Draw(diamond, diamondPos39, new Rectangle(diamondCurrentFrame.X * diamondFrameSize.X, diamondCurrentFrame.Y * diamondFrameSize.Y, diamondFrameSize.X, diamondFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visibility40)
                spriteBatch.Draw(diamond, diamondPos40, new Rectangle(diamondCurrentFrame.X * diamondFrameSize.X, diamondCurrentFrame.Y * diamondFrameSize.Y, diamondFrameSize.X, diamondFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

             */

            #endregion


            #region gem_draw

            // bonus levels
            /*

            if (visib1)
                spriteBatch.Draw(gem, gemPos1, new Rectangle(gemCurrentFrame.X * gemFrameSize.X, gemCurrentFrame.Y * gemFrameSize.Y, gemFrameSize.X, gemFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visib2)
                spriteBatch.Draw(gem, gemPos2, new Rectangle(gemCurrentFrame.X * gemFrameSize.X, gemCurrentFrame.Y * gemFrameSize.Y, gemFrameSize.X, gemFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visib3)
                spriteBatch.Draw(gem, gemPos3, new Rectangle(gemCurrentFrame.X * gemFrameSize.X, gemCurrentFrame.Y * gemFrameSize.Y, gemFrameSize.X, gemFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visib4)
                spriteBatch.Draw(gem, gemPos4, new Rectangle(gemCurrentFrame.X * gemFrameSize.X, gemCurrentFrame.Y * gemFrameSize.Y, gemFrameSize.X, gemFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visib5)
                spriteBatch.Draw(gem, gemPos5, new Rectangle(gemCurrentFrame.X * gemFrameSize.X, gemCurrentFrame.Y * gemFrameSize.Y, gemFrameSize.X, gemFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visib6)
                spriteBatch.Draw(gem, gemPos6, new Rectangle(gemCurrentFrame.X * gemFrameSize.X, gemCurrentFrame.Y * gemFrameSize.Y, gemFrameSize.X, gemFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visib7)
                spriteBatch.Draw(gem, gemPos7, new Rectangle(gemCurrentFrame.X * gemFrameSize.X, gemCurrentFrame.Y * gemFrameSize.Y, gemFrameSize.X, gemFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visib8)
                spriteBatch.Draw(gem, gemPos8, new Rectangle(gemCurrentFrame.X * gemFrameSize.X, gemCurrentFrame.Y * gemFrameSize.Y, gemFrameSize.X, gemFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visib9)
                spriteBatch.Draw(gem, gemPos9, new Rectangle(gemCurrentFrame.X * gemFrameSize.X, gemCurrentFrame.Y * gemFrameSize.Y, gemFrameSize.X, gemFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visib10)
                spriteBatch.Draw(gem, gemPos10, new Rectangle(gemCurrentFrame.X * gemFrameSize.X, gemCurrentFrame.Y * gemFrameSize.Y, gemFrameSize.X, gemFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visib11)
                spriteBatch.Draw(gem, gemPos11, new Rectangle(gemCurrentFrame.X * gemFrameSize.X, gemCurrentFrame.Y * gemFrameSize.Y, gemFrameSize.X, gemFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visib12)
                spriteBatch.Draw(gem, gemPos12, new Rectangle(gemCurrentFrame.X * gemFrameSize.X, gemCurrentFrame.Y * gemFrameSize.Y, gemFrameSize.X, gemFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visib13)
                spriteBatch.Draw(gem, gemPos13, new Rectangle(gemCurrentFrame.X * gemFrameSize.X, gemCurrentFrame.Y * gemFrameSize.Y, gemFrameSize.X, gemFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visib14)
                spriteBatch.Draw(gem, gemPos14, new Rectangle(gemCurrentFrame.X * gemFrameSize.X, gemCurrentFrame.Y * gemFrameSize.Y, gemFrameSize.X, gemFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visib15)
                spriteBatch.Draw(gem, gemPos15, new Rectangle(gemCurrentFrame.X * gemFrameSize.X, gemCurrentFrame.Y * gemFrameSize.Y, gemFrameSize.X, gemFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visib16)
                spriteBatch.Draw(gem, gemPos16, new Rectangle(gemCurrentFrame.X * gemFrameSize.X, gemCurrentFrame.Y * gemFrameSize.Y, gemFrameSize.X, gemFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visib17)
                spriteBatch.Draw(gem, gemPos17, new Rectangle(gemCurrentFrame.X * gemFrameSize.X, gemCurrentFrame.Y * gemFrameSize.Y, gemFrameSize.X, gemFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visib18)
                spriteBatch.Draw(gem, gemPos18, new Rectangle(gemCurrentFrame.X * gemFrameSize.X, gemCurrentFrame.Y * gemFrameSize.Y, gemFrameSize.X, gemFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visib19)
                spriteBatch.Draw(gem, gemPos19, new Rectangle(gemCurrentFrame.X * gemFrameSize.X, gemCurrentFrame.Y * gemFrameSize.Y, gemFrameSize.X, gemFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visib20)
                spriteBatch.Draw(gem, gemPos20, new Rectangle(gemCurrentFrame.X * gemFrameSize.X, gemCurrentFrame.Y * gemFrameSize.Y, gemFrameSize.X, gemFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);


            if (visib21)
                spriteBatch.Draw(gem, gemPos21, new Rectangle(gemCurrentFrame.X * gemFrameSize.X, gemCurrentFrame.Y * gemFrameSize.Y, gemFrameSize.X, gemFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visib22)
                spriteBatch.Draw(gem, gemPos22, new Rectangle(gemCurrentFrame.X * gemFrameSize.X, gemCurrentFrame.Y * gemFrameSize.Y, gemFrameSize.X, gemFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visib23)
                spriteBatch.Draw(gem, gemPos23, new Rectangle(gemCurrentFrame.X * gemFrameSize.X, gemCurrentFrame.Y * gemFrameSize.Y, gemFrameSize.X, gemFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visib24)
                spriteBatch.Draw(gem, gemPos24, new Rectangle(gemCurrentFrame.X * gemFrameSize.X, gemCurrentFrame.Y * gemFrameSize.Y, gemFrameSize.X, gemFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visib25)
                spriteBatch.Draw(gem, gemPos25, new Rectangle(gemCurrentFrame.X * gemFrameSize.X, gemCurrentFrame.Y * gemFrameSize.Y, gemFrameSize.X, gemFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visib26)
                spriteBatch.Draw(gem, gemPos26, new Rectangle(gemCurrentFrame.X * gemFrameSize.X, gemCurrentFrame.Y * gemFrameSize.Y, gemFrameSize.X, gemFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visib27)
                spriteBatch.Draw(gem, gemPos27, new Rectangle(gemCurrentFrame.X * gemFrameSize.X, gemCurrentFrame.Y * gemFrameSize.Y, gemFrameSize.X, gemFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visib28)
                spriteBatch.Draw(gem, gemPos28, new Rectangle(gemCurrentFrame.X * gemFrameSize.X, gemCurrentFrame.Y * gemFrameSize.Y, gemFrameSize.X, gemFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visib29)
                spriteBatch.Draw(gem, gemPos29, new Rectangle(gemCurrentFrame.X * gemFrameSize.X, gemCurrentFrame.Y * gemFrameSize.Y, gemFrameSize.X, gemFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visib30)
                spriteBatch.Draw(gem, gemPos30, new Rectangle(gemCurrentFrame.X * gemFrameSize.X, gemCurrentFrame.Y * gemFrameSize.Y, gemFrameSize.X, gemFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visib31)
                spriteBatch.Draw(gem, gemPos31, new Rectangle(gemCurrentFrame.X * gemFrameSize.X, gemCurrentFrame.Y * gemFrameSize.Y, gemFrameSize.X, gemFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visib32)
                spriteBatch.Draw(gem, gemPos32, new Rectangle(gemCurrentFrame.X * gemFrameSize.X, gemCurrentFrame.Y * gemFrameSize.Y, gemFrameSize.X, gemFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visib33)
                spriteBatch.Draw(gem, gemPos33, new Rectangle(gemCurrentFrame.X * gemFrameSize.X, gemCurrentFrame.Y * gemFrameSize.Y, gemFrameSize.X, gemFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visib34)
                spriteBatch.Draw(gem, gemPos34, new Rectangle(gemCurrentFrame.X * gemFrameSize.X, gemCurrentFrame.Y * gemFrameSize.Y, gemFrameSize.X, gemFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visib35)
                spriteBatch.Draw(gem, gemPos35, new Rectangle(gemCurrentFrame.X * gemFrameSize.X, gemCurrentFrame.Y * gemFrameSize.Y, gemFrameSize.X, gemFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visib36)
                spriteBatch.Draw(gem, gemPos36, new Rectangle(gemCurrentFrame.X * gemFrameSize.X, gemCurrentFrame.Y * gemFrameSize.Y, gemFrameSize.X, gemFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visib37)
                spriteBatch.Draw(gem, gemPos37, new Rectangle(gemCurrentFrame.X * gemFrameSize.X, gemCurrentFrame.Y * gemFrameSize.Y, gemFrameSize.X, gemFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visib38)
                spriteBatch.Draw(gem, gemPos38, new Rectangle(gemCurrentFrame.X * gemFrameSize.X, gemCurrentFrame.Y * gemFrameSize.Y, gemFrameSize.X, gemFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visib39)
                spriteBatch.Draw(gem, gemPos39, new Rectangle(gemCurrentFrame.X * gemFrameSize.X, gemCurrentFrame.Y * gemFrameSize.Y, gemFrameSize.X, gemFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visib40)
                spriteBatch.Draw(gem, gemPos40, new Rectangle(gemCurrentFrame.X * gemFrameSize.X, gemCurrentFrame.Y * gemFrameSize.Y, gemFrameSize.X, gemFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

           */
            // final / 3rd level

            if (visib41)
                spriteBatch.Draw(gem, gemPos41, new Rectangle(gemCurrentFrame.X * gemFrameSize.X, gemCurrentFrame.Y * gemFrameSize.Y, gemFrameSize.X, gemFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visib42)
                spriteBatch.Draw(gem, gemPos42, new Rectangle(gemCurrentFrame.X * gemFrameSize.X, gemCurrentFrame.Y * gemFrameSize.Y, gemFrameSize.X, gemFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visib43)
                spriteBatch.Draw(gem, gemPos43, new Rectangle(gemCurrentFrame.X * gemFrameSize.X, gemCurrentFrame.Y * gemFrameSize.Y, gemFrameSize.X, gemFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visib44)
                spriteBatch.Draw(gem, gemPos44, new Rectangle(gemCurrentFrame.X * gemFrameSize.X, gemCurrentFrame.Y * gemFrameSize.Y, gemFrameSize.X, gemFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visib45)
                spriteBatch.Draw(gem, gemPos45, new Rectangle(gemCurrentFrame.X * gemFrameSize.X, gemCurrentFrame.Y * gemFrameSize.Y, gemFrameSize.X, gemFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visib46)
                spriteBatch.Draw(gem, gemPos46, new Rectangle(gemCurrentFrame.X * gemFrameSize.X, gemCurrentFrame.Y * gemFrameSize.Y, gemFrameSize.X, gemFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visib47)
                spriteBatch.Draw(gem, gemPos47, new Rectangle(gemCurrentFrame.X * gemFrameSize.X, gemCurrentFrame.Y * gemFrameSize.Y, gemFrameSize.X, gemFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visib48)
                spriteBatch.Draw(gem, gemPos48, new Rectangle(gemCurrentFrame.X * gemFrameSize.X, gemCurrentFrame.Y * gemFrameSize.Y, gemFrameSize.X, gemFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visib49)
                spriteBatch.Draw(gem, gemPos49, new Rectangle(gemCurrentFrame.X * gemFrameSize.X, gemCurrentFrame.Y * gemFrameSize.Y, gemFrameSize.X, gemFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visib50)
                spriteBatch.Draw(gem, gemPos50, new Rectangle(gemCurrentFrame.X * gemFrameSize.X, gemCurrentFrame.Y * gemFrameSize.Y, gemFrameSize.X, gemFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visib51)
                spriteBatch.Draw(gem, gemPos51, new Rectangle(gemCurrentFrame.X * gemFrameSize.X, gemCurrentFrame.Y * gemFrameSize.Y, gemFrameSize.X, gemFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visib52)
                spriteBatch.Draw(gem, gemPos52, new Rectangle(gemCurrentFrame.X * gemFrameSize.X, gemCurrentFrame.Y * gemFrameSize.Y, gemFrameSize.X, gemFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visib53)
                spriteBatch.Draw(gem, gemPos53, new Rectangle(gemCurrentFrame.X * gemFrameSize.X, gemCurrentFrame.Y * gemFrameSize.Y, gemFrameSize.X, gemFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visib54)
                spriteBatch.Draw(gem, gemPos54, new Rectangle(gemCurrentFrame.X * gemFrameSize.X, gemCurrentFrame.Y * gemFrameSize.Y, gemFrameSize.X, gemFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visib55)
                spriteBatch.Draw(gem, gemPos55, new Rectangle(gemCurrentFrame.X * gemFrameSize.X, gemCurrentFrame.Y * gemFrameSize.Y, gemFrameSize.X, gemFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visib56)
                spriteBatch.Draw(gem, gemPos56, new Rectangle(gemCurrentFrame.X * gemFrameSize.X, gemCurrentFrame.Y * gemFrameSize.Y, gemFrameSize.X, gemFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visib57)
                spriteBatch.Draw(gem, gemPos57, new Rectangle(gemCurrentFrame.X * gemFrameSize.X, gemCurrentFrame.Y * gemFrameSize.Y, gemFrameSize.X, gemFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visib58)
                spriteBatch.Draw(gem, gemPos58, new Rectangle(gemCurrentFrame.X * gemFrameSize.X, gemCurrentFrame.Y * gemFrameSize.Y, gemFrameSize.X, gemFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visib59)
                spriteBatch.Draw(gem, gemPos59, new Rectangle(gemCurrentFrame.X * gemFrameSize.X, gemCurrentFrame.Y * gemFrameSize.Y, gemFrameSize.X, gemFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visib60)
                spriteBatch.Draw(gem, gemPos60, new Rectangle(gemCurrentFrame.X * gemFrameSize.X, gemCurrentFrame.Y * gemFrameSize.Y, gemFrameSize.X, gemFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);


            #endregion

            #region redBonus_draw

            if (visibRed1)
                spriteBatch.Draw(redBonus, redBonusPos1, new Rectangle(gemCurrentFrame.X * gemFrameSize.X, gemCurrentFrame.Y * gemFrameSize.Y, gemFrameSize.X, gemFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visibRed2)
                spriteBatch.Draw(redBonus, redBonusPos2, new Rectangle(gemCurrentFrame.X * gemFrameSize.X, gemCurrentFrame.Y * gemFrameSize.Y, gemFrameSize.X, gemFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visibRed3)
                spriteBatch.Draw(redBonus, redBonusPos3, new Rectangle(gemCurrentFrame.X * gemFrameSize.X, gemCurrentFrame.Y * gemFrameSize.Y, gemFrameSize.X, gemFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visibRed4)
                spriteBatch.Draw(redBonus, redBonusPos4, new Rectangle(gemCurrentFrame.X * gemFrameSize.X, gemCurrentFrame.Y * gemFrameSize.Y, gemFrameSize.X, gemFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visibRed5)
                spriteBatch.Draw(redBonus, redBonusPos5, new Rectangle(gemCurrentFrame.X * gemFrameSize.X, gemCurrentFrame.Y * gemFrameSize.Y, gemFrameSize.X, gemFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visibRed6)
                spriteBatch.Draw(redBonus, redBonusPos6, new Rectangle(gemCurrentFrame.X * gemFrameSize.X, gemCurrentFrame.Y * gemFrameSize.Y, gemFrameSize.X, gemFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visibRed7)
                spriteBatch.Draw(redBonus, redBonusPos7, new Rectangle(gemCurrentFrame.X * gemFrameSize.X, gemCurrentFrame.Y * gemFrameSize.Y, gemFrameSize.X, gemFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visibRed8)
                spriteBatch.Draw(redBonus, redBonusPos8, new Rectangle(gemCurrentFrame.X * gemFrameSize.X, gemCurrentFrame.Y * gemFrameSize.Y, gemFrameSize.X, gemFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visibRed9)
                spriteBatch.Draw(redBonus, redBonusPos9, new Rectangle(gemCurrentFrame.X * gemFrameSize.X, gemCurrentFrame.Y * gemFrameSize.Y, gemFrameSize.X, gemFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visibRed10)
                spriteBatch.Draw(redBonus, redBonusPos10, new Rectangle(gemCurrentFrame.X * gemFrameSize.X, gemCurrentFrame.Y * gemFrameSize.Y, gemFrameSize.X, gemFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visibRed11)
                spriteBatch.Draw(redBonus, redBonusPos11, new Rectangle(gemCurrentFrame.X * gemFrameSize.X, gemCurrentFrame.Y * gemFrameSize.Y, gemFrameSize.X, gemFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visibRed12)
                spriteBatch.Draw(redBonus, redBonusPos12, new Rectangle(gemCurrentFrame.X * gemFrameSize.X, gemCurrentFrame.Y * gemFrameSize.Y, gemFrameSize.X, gemFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visibRed13)
                spriteBatch.Draw(redBonus, redBonusPos13, new Rectangle(gemCurrentFrame.X * gemFrameSize.X, gemCurrentFrame.Y * gemFrameSize.Y, gemFrameSize.X, gemFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visibRed14)
                spriteBatch.Draw(redBonus, redBonusPos14, new Rectangle(gemCurrentFrame.X * gemFrameSize.X, gemCurrentFrame.Y * gemFrameSize.Y, gemFrameSize.X, gemFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visibRed15)
                spriteBatch.Draw(redBonus, redBonusPos15, new Rectangle(gemCurrentFrame.X * gemFrameSize.X, gemCurrentFrame.Y * gemFrameSize.Y, gemFrameSize.X, gemFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visibRed16)
                spriteBatch.Draw(redBonus, redBonusPos16, new Rectangle(gemCurrentFrame.X * gemFrameSize.X, gemCurrentFrame.Y * gemFrameSize.Y, gemFrameSize.X, gemFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visibRed17)
                spriteBatch.Draw(redBonus, redBonusPos17, new Rectangle(gemCurrentFrame.X * gemFrameSize.X, gemCurrentFrame.Y * gemFrameSize.Y, gemFrameSize.X, gemFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visibRed18)
                spriteBatch.Draw(redBonus, redBonusPos18, new Rectangle(gemCurrentFrame.X * gemFrameSize.X, gemCurrentFrame.Y * gemFrameSize.Y, gemFrameSize.X, gemFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visibRed19)
                spriteBatch.Draw(redBonus, redBonusPos19, new Rectangle(gemCurrentFrame.X * gemFrameSize.X, gemCurrentFrame.Y * gemFrameSize.Y, gemFrameSize.X, gemFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visibRed20)
                spriteBatch.Draw(redBonus, redBonusPos20, new Rectangle(gemCurrentFrame.X * gemFrameSize.X, gemCurrentFrame.Y * gemFrameSize.Y, gemFrameSize.X, gemFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visibRed21)
                spriteBatch.Draw(redBonus, redBonusPos21, new Rectangle(gemCurrentFrame.X * gemFrameSize.X, gemCurrentFrame.Y * gemFrameSize.Y, gemFrameSize.X, gemFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visibRed22)
                spriteBatch.Draw(redBonus, redBonusPos22, new Rectangle(gemCurrentFrame.X * gemFrameSize.X, gemCurrentFrame.Y * gemFrameSize.Y, gemFrameSize.X, gemFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visibRed23)
                spriteBatch.Draw(redBonus, redBonusPos23, new Rectangle(gemCurrentFrame.X * gemFrameSize.X, gemCurrentFrame.Y * gemFrameSize.Y, gemFrameSize.X, gemFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visibRed24)
                spriteBatch.Draw(redBonus, redBonusPos24, new Rectangle(gemCurrentFrame.X * gemFrameSize.X, gemCurrentFrame.Y * gemFrameSize.Y, gemFrameSize.X, gemFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visibRed25)
                spriteBatch.Draw(redBonus, redBonusPos25, new Rectangle(gemCurrentFrame.X * gemFrameSize.X, gemCurrentFrame.Y * gemFrameSize.Y, gemFrameSize.X, gemFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (visibRed26)
                spriteBatch.Draw(redBonus, redBonusPos26, new Rectangle(gemCurrentFrame.X * gemFrameSize.X, gemCurrentFrame.Y * gemFrameSize.Y, gemFrameSize.X, gemFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);



            #endregion

            #region playerHitsBlock draw

            KeyboardState lk = Keyboard.GetState();


            //if (playerHitsBlocks(levelBlock1_1, BlockPos1_1, hero, heroPosition) || playerHitsBlocks(levelBlock1_1, BlockPos1_2, hero, heroPosition) || playerHitsBlocks(levelBlock1_1, BlockPos2_1, hero, heroPosition) || playerHitsBlocks(levelBlock1_1, BlockPos2_2, hero, heroPosition))
            //    spriteBatch.Draw(heroBlocked, heroPosition, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            if (lk.IsKeyDown(Keys.Left) && lk.IsKeyUp(Keys.Right) && !(playerHitsBlocks(levelBlock1_1, BlockPos1_1, hero, heroPosition) || playerHitsBlocks(levelBlock1_1, BlockPos1_2, hero, heroPosition) || playerHitsBlocks(levelBlock1_1, BlockPos2_1, hero, heroPosition) || playerHitsBlocks(levelBlock1_1, BlockPos2_2, hero, heroPosition)))
                spriteBatch.Draw(heroReverse, heroPosition, new Rectangle(heroReverseCurrentFrame.X * heroReverseFrameSize.X, heroReverseCurrentFrame.Y * heroReverseFrameSize.Y, heroReverseFrameSize.X, heroReverseFrameSize.Y), Color.White, 0, Vector2.Zero, 1f, SpriteEffects.None, 0.5f);
            if (lk.IsKeyDown(Keys.Right) && lk.IsKeyUp(Keys.Left) && !(playerHitsBlocks(levelBlock1_1, BlockPos1_1, hero, heroPosition) || playerHitsBlocks(levelBlock1_1, BlockPos1_2, hero, heroPosition) || playerHitsBlocks(levelBlock1_1, BlockPos2_1, hero, heroPosition) || playerHitsBlocks(levelBlock1_1, BlockPos2_2, hero, heroPosition)))
                spriteBatch.Draw(hero, heroPosition, new Rectangle(heroCurrentFrame.X * heroFrameSize.X, heroCurrentFrame.Y * heroFrameSize.Y, heroFrameSize.X, heroFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 0.5f);
            if ((lk.IsKeyUp(Keys.Right) && lk.IsKeyUp(Keys.Left)))
                spriteBatch.Draw(heroBlocked, heroPosition, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 0.5f);


            //else
            //{
            //    if (!(leftArrowPressed))
            //        spriteBatch.Draw(hero, heroPosition, new Rectangle(heroCurrentFrame.X * heroFrameSize.X, heroCurrentFrame.Y * heroFrameSize.Y, heroFrameSize.X, heroFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 0.5f);
            //    if ((leftArrowPressed))
            //        spriteBatch.Draw(heroReverse, heroPosition, new Rectangle(heroReverseCurrentFrame.X * heroReverseFrameSize.X, heroReverseCurrentFrame.Y * heroReverseFrameSize.Y, heroReverseFrameSize.X, heroReverseFrameSize.Y), Color.White, 0, Vector2.Zero, 0.5f, SpriteEffects.None, 0.5f);

            //}

            #endregion

            #region ironFence

            //level 1

            spriteBatch.Draw(ironFence, fencePos1, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 0.5f);
            spriteBatch.Draw(ironFence, fencePos2, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 0.5f);
            spriteBatch.Draw(ironFence, fencePos3, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 0.5f);
            spriteBatch.Draw(ironFence, fencePos4, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 0.5f);
            spriteBatch.Draw(ironFence, fencePos5, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 0.5f);

            //level 2

            spriteBatch.Draw(ironFence, fencePos6, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 0.5f);
            spriteBatch.Draw(ironFence, fencePos7, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 0.5f);
            spriteBatch.Draw(ironFence, fencePos8, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 0.5f);
            spriteBatch.Draw(ironFence, fencePos9, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 0.5f);
            spriteBatch.Draw(ironFence, fencePos10, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 0.5f);
            spriteBatch.Draw(ironFence, fencePos17, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 0.5f);
            spriteBatch.Draw(ironFence, fencePos18, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 0.5f);

            //level 3

            spriteBatch.Draw(ironFence, fencePos11, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 0.5f);
            spriteBatch.Draw(ironFence, fencePos12, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 0.5f);
            spriteBatch.Draw(ironFence, fencePos13, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 0.5f);
            spriteBatch.Draw(ironFence, fencePos14, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 0.5f);
            spriteBatch.Draw(ironFence, fencePos15, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 0.5f);
            spriteBatch.Draw(ironFence, fencePos16, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 0.5f);


            #endregion

            #region water

            spriteBatch.Draw(water, waterPos1, new Rectangle(waterCurrentFrame.X * waterFrameSize.X, waterCurrentFrame.Y * waterFrameSize.Y, waterFrameSize.X, waterFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(water, waterPos2, new Rectangle(waterCurrentFrame.X * waterFrameSize.X, waterCurrentFrame.Y * waterFrameSize.Y, waterFrameSize.X, waterFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(water, waterPos3, new Rectangle(waterCurrentFrame.X * waterFrameSize.X, waterCurrentFrame.Y * waterFrameSize.Y, waterFrameSize.X, waterFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(water, waterPos4, new Rectangle(waterCurrentFrame.X * waterFrameSize.X, waterCurrentFrame.Y * waterFrameSize.Y, waterFrameSize.X, waterFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(water, waterPos5, new Rectangle(waterCurrentFrame.X * waterFrameSize.X, waterCurrentFrame.Y * waterFrameSize.Y, waterFrameSize.X, waterFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            spriteBatch.Draw(water, waterPos6, new Rectangle(waterCurrentFrame.X * waterFrameSize.X, waterCurrentFrame.Y * waterFrameSize.Y, waterFrameSize.X, waterFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(water, waterPos7, new Rectangle(waterCurrentFrame.X * waterFrameSize.X, waterCurrentFrame.Y * waterFrameSize.Y, waterFrameSize.X, waterFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(water, waterPos8, new Rectangle(waterCurrentFrame.X * waterFrameSize.X, waterCurrentFrame.Y * waterFrameSize.Y, waterFrameSize.X, waterFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(water, waterPos9, new Rectangle(waterCurrentFrame.X * waterFrameSize.X, waterCurrentFrame.Y * waterFrameSize.Y, waterFrameSize.X, waterFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(water, waterPos10, new Rectangle(waterCurrentFrame.X * waterFrameSize.X, waterCurrentFrame.Y * waterFrameSize.Y, waterFrameSize.X, waterFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);


            #endregion


            #region rockie

            spriteBatch.Draw(rockie, rockiePos1, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(rockie, rockiePos2, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(rockie, rockiePos3, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(rockie, rockiePos4, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);


            #endregion

            #region groundBlock

            spriteBatch.Draw(groundBlock, groundBlockPos1, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(groundBlock, groundBlockPos2, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(groundBlock, groundBlockPos3, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(groundBlock, groundBlockPos4, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(groundBlock, groundBlockPos5, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(groundBlock, groundBlockPos6, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(groundBlock, groundBlockPos7, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(groundBlock, groundBlockPos8, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(groundBlock, groundBlockPos9, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(groundBlock, groundBlockPos10, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(groundBlock, groundBlockPos11, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(groundBlock, groundBlockPos12, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(groundBlock, groundBlockPos13, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(groundBlock, groundBlockPos14, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(groundBlock, groundBlockPos15, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(groundBlock, groundBlockPos16, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(groundBlock, groundBlockPos17, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(groundBlock, groundBlockPos18, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(groundBlock, groundBlockPos19, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(groundBlock, groundBlockPos20, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);



            #endregion


            #region extra_Trees

            spriteBatch.Draw(tree1, new Vector2(3100, 200), null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(tree1, new Vector2(5100, 200), null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(tree1, new Vector2(8100, 200), null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(tree1, new Vector2(11100, 200), null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(tree1, new Vector2(15300, 200), null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(tree1, new Vector2(17300, 200), null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(tree1, new Vector2(20100, 200), null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(tree1, new Vector2(23100, 200), null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);


            #endregion



            #region Logs
            spriteBatch.Draw(log, logPos1, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(log, logPos2, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(log, logPos3, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(log, logPos4, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(log, logPos5, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(log, logPos6, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(log, logPos7, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(log, logPos8, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(log, logPos9, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            // spriteBatch.Draw(log, logPos10, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(log, logPos11, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            // spriteBatch.Draw(log, logPos12, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            //spriteBatch.Draw(log, logPos13, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            //spriteBatch.Draw(log, logPos14, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            //spriteBatch.Draw(log, logPos15, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            //spriteBatch.Draw(log, logPos16, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            //spriteBatch.Draw(log, logPos17, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            //spriteBatch.Draw(log, logPos18, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            //spriteBatch.Draw(log, logPos19, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            //spriteBatch.Draw(log, logPos20, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            //spriteBatch.Draw(log, logPos21, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            //spriteBatch.Draw(log, logPos22, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            //spriteBatch.Draw(log, logPos23, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            //spriteBatch.Draw(log, logPos24, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);



            #endregion


            #region deer



            spriteBatch.Draw(deerReverse, deerPos1, new Rectangle(deerCurrentFrame.X * deerFrameSize.X, deerCurrentFrame.Y * deerFrameSize.Y, deerFrameSize.X, deerFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(deerReverse, deerPos2, new Rectangle(deerCurrentFrame.X * deerFrameSize.X, deerCurrentFrame.Y * deerFrameSize.Y, deerFrameSize.X, deerFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(deerFront, deerPos3, new Rectangle(deerCurrentFrame.X * deerFrameSize.X, deerCurrentFrame.Y * deerFrameSize.Y, deerFrameSize.X, deerFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(deerReverse, deerPos4, new Rectangle(deerCurrentFrame.X * deerFrameSize.X, deerCurrentFrame.Y * deerFrameSize.Y, deerFrameSize.X, deerFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(deerReverse, deerPos5, new Rectangle(deerCurrentFrame.X * deerFrameSize.X, deerCurrentFrame.Y * deerFrameSize.Y, deerFrameSize.X, deerFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            spriteBatch.Draw(deerFront, deerPos6, new Rectangle(deerCurrentFrame.X * deerFrameSize.X, deerCurrentFrame.Y * deerFrameSize.Y, deerFrameSize.X, deerFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(deerFront, deerPos7, new Rectangle(deerCurrentFrame.X * deerFrameSize.X, deerCurrentFrame.Y * deerFrameSize.Y, deerFrameSize.X, deerFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(deerFront, deerPos8, new Rectangle(deerCurrentFrame.X * deerFrameSize.X, deerCurrentFrame.Y * deerFrameSize.Y, deerFrameSize.X, deerFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            //spriteBatch.Draw(deerReverse, deerPos9, new Rectangle(deerCurrentFrame.X * deerFrameSize.X, deerCurrentFrame.Y * deerFrameSize.Y, deerFrameSize.X, deerFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            //spriteBatch.Draw(deerReverse, deerPos10, new Rectangle(deerCurrentFrame.X * deerFrameSize.X, deerCurrentFrame.Y * deerFrameSize.Y, deerFrameSize.X, deerFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);





            #endregion


            #region bird



            spriteBatch.Draw(birdReverse, birdPos1, new Rectangle(birdCurrentFrame.X * birdFrameSize.X, birdCurrentFrame.Y * birdFrameSize.Y, birdFrameSize.X, birdFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(birdReverse, birdPos2, new Rectangle(birdCurrentFrame.X * birdFrameSize.X, birdCurrentFrame.Y * birdFrameSize.Y, birdFrameSize.X, birdFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(birdReverse, birdPos3, new Rectangle(birdCurrentFrame.X * birdFrameSize.X, birdCurrentFrame.Y * birdFrameSize.Y, birdFrameSize.X, birdFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            spriteBatch.Draw(birdReverse, birdPos4, new Rectangle(birdCurrentFrame.X * birdFrameSize.X, birdCurrentFrame.Y * birdFrameSize.Y, birdFrameSize.X, birdFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(birdReverse, birdPos5, new Rectangle(birdCurrentFrame.X * birdFrameSize.X, birdCurrentFrame.Y * birdFrameSize.Y, birdFrameSize.X, birdFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(birdReverse, birdPos6, new Rectangle(birdCurrentFrame.X * birdFrameSize.X, birdCurrentFrame.Y * birdFrameSize.Y, birdFrameSize.X, birdFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            //spriteBatch.Draw(birdReverse, birdPos7, new Rectangle(birdCurrentFrame.X * birdFrameSize.X, birdCurrentFrame.Y * birdFrameSize.Y, birdFrameSize.X, birdFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            //spriteBatch.Draw(birdReverse, birdPos8, new Rectangle(birdCurrentFrame.X * birdFrameSize.X, birdCurrentFrame.Y * birdFrameSize.Y, birdFrameSize.X, birdFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            //spriteBatch.Draw(birdReverse, birdPos9, new Rectangle(birdCurrentFrame.X * birdFrameSize.X, birdCurrentFrame.Y * birdFrameSize.Y, birdFrameSize.X, birdFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            //spriteBatch.Draw(birdReverse, birdPos10, new Rectangle(birdCurrentFrame.X * birdFrameSize.X, birdCurrentFrame.Y * birdFrameSize.Y, birdFrameSize.X, birdFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);





            #endregion

            #region snake



            spriteBatch.Draw(snakeDarkRev, snakePos1, new Rectangle(snakeCurrentFrame.X * snakeFrameSize.X, snakeCurrentFrame.Y * snakeFrameSize.Y, snakeFrameSize.X, snakeFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(snakeDarkRev, snakePos2, new Rectangle(snakeCurrentFrame.X * snakeFrameSize.X, snakeCurrentFrame.Y * snakeFrameSize.Y, snakeFrameSize.X, snakeFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(snakeDarkRev, snakePos3, new Rectangle(snakeCurrentFrame.X * snakeFrameSize.X, snakeCurrentFrame.Y * snakeFrameSize.Y, snakeFrameSize.X, snakeFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(snakeDarkRev, snakePos4, new Rectangle(snakeCurrentFrame.X * snakeFrameSize.X, snakeCurrentFrame.Y * snakeFrameSize.Y, snakeFrameSize.X, snakeFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            spriteBatch.Draw(snakeReverse, snakePos5, new Rectangle(snakeCurrentFrame.X * snakeFrameSize.X, snakeCurrentFrame.Y * snakeFrameSize.Y, snakeFrameSize.X, snakeFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(snakeReverse, snakePos6, new Rectangle(snakeCurrentFrame.X * snakeFrameSize.X, snakeCurrentFrame.Y * snakeFrameSize.Y, snakeFrameSize.X, snakeFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(snakeReverse, snakePos7, new Rectangle(snakeCurrentFrame.X * snakeFrameSize.X, snakeCurrentFrame.Y * snakeFrameSize.Y, snakeFrameSize.X, snakeFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(snakeReverse, snakePos8, new Rectangle(snakeCurrentFrame.X * snakeFrameSize.X, snakeCurrentFrame.Y * snakeFrameSize.Y, snakeFrameSize.X, snakeFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            //spriteBatch.Draw(snakeReverse, snakePos9, new Rectangle(snakeCurrentFrame.X * snakeFrameSize.X, snakeCurrentFrame.Y * snakeFrameSize.Y, snakeFrameSize.X, snakeFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            //spriteBatch.Draw(snakeReverse, snakePos10, new Rectangle(snakeCurrentFrame.X * snakeFrameSize.X, snakeCurrentFrame.Y * snakeFrameSize.Y, snakeFrameSize.X, snakeFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);





            #endregion

            #region markBanners


            spriteBatch.Draw(markBanner, bannerPos1, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1f);
            spriteBatch.Draw(markBanner, bannerPos2, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1f);
            spriteBatch.Draw(markBanner, bannerPos3, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(markBanner, bannerPos4, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(markBanner, bannerPos5, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(markBanner, bannerPos6, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(markBanner, bannerPos7, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(markBanner, bannerPos8, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(markBanner, bannerPos9, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(markBanner, bannerPos10, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(markBanner, bannerPos11, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(markBanner, bannerPos12, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(markBanner, bannerPos13, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(markBanner, bannerPos14, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(markBanner, bannerPos15, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(markBanner, bannerPos16, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(markBanner, bannerPos17, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(markBanner, bannerPos18, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(markBanner, bannerPos19, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(markBanner, bannerPos20, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            spriteBatch.Draw(markBanner, bannerPos21, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1f);
            spriteBatch.Draw(markBanner, bannerPos22, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1f);
            spriteBatch.Draw(markBanner, bannerPos23, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(markBanner, bannerPos24, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(markBanner, bannerPos25, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(markBanner, bannerPos26, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(markBanner, bannerPos27, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(markBanner, bannerPos28, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(markBanner, bannerPos29, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(markBanner, bannerPos30, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(markBanner, bannerPos31, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(markBanner, bannerPos32, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(markBanner, bannerPos33, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(markBanner, bannerPos34, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(markBanner, bannerPos35, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(markBanner, bannerPos36, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(markBanner, bannerPos37, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(markBanner, bannerPos38, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(markBanner, bannerPos39, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(markBanner, bannerPos40, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(markBanner, bannerPos41, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(markBanner, bannerPos42, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);



            #endregion

            #region mushrooms

            spriteBatch.Draw(mushroom, mushPos1, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(mushroom, mushPos2, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(mushroom, mushPos3, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(mushroom, mushPos4, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(mushroom, mushPos5, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(mushroom, mushPos6, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(redMushroom, redMushroomPos, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);





            #endregion

            #region vine_Entrance

            //spriteBatch.Draw(vineEntrance1, vineEntrancePos1,null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            //spriteBatch.Draw(vineEntrance2, vineEntrancePos2, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);


            #endregion

            #region lvl3ground

            spriteBatch.Draw(lvl3ground, lvl3groundPos1, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(lvl3ground, lvl3groundPos2, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(lvl3ground, lvl3groundPos3, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(lvl3ground, lvl3groundPos4, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(lvl3ground, lvl3groundPos5, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(lvl3ground, lvl3groundPos6, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(lvl3ground, lvl3groundPos7, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);


            #endregion

            #region level3Block

            spriteBatch.Draw(lvl3block, lvl3blockPos1, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(lvl3block, lvl3blockPos2, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(lvl3block, lvl3blockPos3, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(lvl3block, lvl3blockPos4, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(lvl3block, lvl3blockPos5, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(lvl3block, lvl3blockPos6, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(lvl3block, lvl3blockPos7, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(lvl3block, lvl3blockPos8, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(lvl3block, lvl3blockPos9, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(lvl3block, lvl3blockPos10, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(lvl3block, lvl3blockPos11, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(lvl3block, lvl3blockPos12, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(lvl3block, lvl3blockPos13, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(lvl3block, lvl3blockPos14, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(lvl3block, lvl3blockPos15, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(lvl3block, lvl3blockPos16, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(lvl3block, lvl3blockPos17, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(lvl3block, lvl3blockPos18, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(lvl3block, lvl3blockPos19, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(lvl3block, lvl3blockPos20, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(lvl3block, lvl3blockPos21, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(lvl3block, lvl3blockPos22, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(lvl3block, lvl3blockPos23, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(lvl3block, lvl3blockPos24, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(lvl3block, lvl3blockPos25, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(lvl3block, lvl3blockPos26, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(lvl3block, lvl3blockPos27, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(lvl3block, lvl3blockPos28, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(lvl3block, lvl3blockPos29, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(lvl3block, lvl3blockPos30, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(lvl3block, lvl3blockPos31, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(lvl3block, lvl3blockPos32, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(lvl3block, lvl3blockPos33, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(lvl3block, lvl3blockPos34, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(lvl3block, lvl3blockPos35, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(lvl3block, lvl3blockPos36, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(lvl3block, lvl3blockPos37, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(lvl3block, lvl3blockPos38, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);




            #endregion

            #region clouds

            spriteBatch.Draw(cloud, cloudPos1, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1f);
            spriteBatch.Draw(cloud, cloudPos2, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1f);
            spriteBatch.Draw(cloud, cloudPos3, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1f);
            spriteBatch.Draw(cloud, cloudPos4, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1f);


            #endregion

            #region fire

            //tourches

            spriteBatch.Draw(fireTourch, fireTouchPos1, new Rectangle(fireTourchCurrentFrame.X * fireTourchFrameSize.X, fireTourchCurrentFrame.Y * fireTourchFrameSize.Y, fireTourchFrameSize.X, fireTourchFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(fireTourch, fireTouchPos2, new Rectangle(fireTourchCurrentFrame.X * fireTourchFrameSize.X, fireTourchCurrentFrame.Y * fireTourchFrameSize.Y, fireTourchFrameSize.X, fireTourchFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(fireTourch, fireTouchPos3, new Rectangle(fireTourchCurrentFrame.X * fireTourchFrameSize.X, fireTourchCurrentFrame.Y * fireTourchFrameSize.Y, fireTourchFrameSize.X, fireTourchFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(fireTourch, fireTouchPos4, new Rectangle(fireTourchCurrentFrame.X * fireTourchFrameSize.X, fireTourchCurrentFrame.Y * fireTourchFrameSize.Y, fireTourchFrameSize.X, fireTourchFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(fireTourch, fireTouchPos5, new Rectangle(fireTourchCurrentFrame.X * fireTourchFrameSize.X, fireTourchCurrentFrame.Y * fireTourchFrameSize.Y, fireTourchFrameSize.X, fireTourchFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(fireTourch, fireTouchPos6, new Rectangle(fireTourchCurrentFrame.X * fireTourchFrameSize.X, fireTourchCurrentFrame.Y * fireTourchFrameSize.Y, fireTourchFrameSize.X, fireTourchFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(fireTourch, fireTouchPos7, new Rectangle(fireTourchCurrentFrame.X * fireTourchFrameSize.X, fireTourchCurrentFrame.Y * fireTourchFrameSize.Y, fireTourchFrameSize.X, fireTourchFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(fireTourch, fireTouchPos8, new Rectangle(fireTourchCurrentFrame.X * fireTourchFrameSize.X, fireTourchCurrentFrame.Y * fireTourchFrameSize.Y, fireTourchFrameSize.X, fireTourchFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(fireTourch, fireTouchPos9, new Rectangle(fireTourchCurrentFrame.X * fireTourchFrameSize.X, fireTourchCurrentFrame.Y * fireTourchFrameSize.Y, fireTourchFrameSize.X, fireTourchFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(fireTourch, fireTouchPos10, new Rectangle(fireTourchCurrentFrame.X * fireTourchFrameSize.X, fireTourchCurrentFrame.Y * fireTourchFrameSize.Y, fireTourchFrameSize.X, fireTourchFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);


            //medium fire

            spriteBatch.Draw(fireMedium, fireMediumPos1, new Rectangle(fireMediumCurrentFrame.X * fireMediumFrameSize.X, fireMediumCurrentFrame.Y * fireMediumFrameSize.Y, fireMediumFrameSize.X, fireMediumFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(fireMedium, fireMediumPos2, new Rectangle(fireMediumCurrentFrame.X * fireMediumFrameSize.X, fireMediumCurrentFrame.Y * fireMediumFrameSize.Y, fireMediumFrameSize.X, fireMediumFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(fireMedium, fireMediumPos3, new Rectangle(fireMediumCurrentFrame.X * fireMediumFrameSize.X, fireMediumCurrentFrame.Y * fireMediumFrameSize.Y, fireMediumFrameSize.X, fireMediumFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(fireMedium, fireMediumPos4, new Rectangle(fireMediumCurrentFrame.X * fireMediumFrameSize.X, fireMediumCurrentFrame.Y * fireMediumFrameSize.Y, fireMediumFrameSize.X, fireMediumFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(fireMedium, fireMediumPos5, new Rectangle(fireMediumCurrentFrame.X * fireMediumFrameSize.X, fireMediumCurrentFrame.Y * fireMediumFrameSize.Y, fireMediumFrameSize.X, fireMediumFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(fireMedium, fireMediumPos6, new Rectangle(fireMediumCurrentFrame.X * fireMediumFrameSize.X, fireMediumCurrentFrame.Y * fireMediumFrameSize.Y, fireMediumFrameSize.X, fireMediumFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(fireMedium, fireMediumPos7, new Rectangle(fireMediumCurrentFrame.X * fireMediumFrameSize.X, fireMediumCurrentFrame.Y * fireMediumFrameSize.Y, fireMediumFrameSize.X, fireMediumFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(fireMedium, fireMediumPos8, new Rectangle(fireMediumCurrentFrame.X * fireMediumFrameSize.X, fireMediumCurrentFrame.Y * fireMediumFrameSize.Y, fireMediumFrameSize.X, fireMediumFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(fireMedium, fireMediumPos9, new Rectangle(fireMediumCurrentFrame.X * fireMediumFrameSize.X, fireMediumCurrentFrame.Y * fireMediumFrameSize.Y, fireMediumFrameSize.X, fireMediumFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(fireMedium, fireMediumPos10, new Rectangle(fireMediumCurrentFrame.X * fireMediumFrameSize.X, fireMediumCurrentFrame.Y * fireMediumFrameSize.Y, fireMediumFrameSize.X, fireMediumFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(fireMedium, fireMediumPos11, new Rectangle(fireMediumCurrentFrame.X * fireMediumFrameSize.X, fireMediumCurrentFrame.Y * fireMediumFrameSize.Y, fireMediumFrameSize.X, fireMediumFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(fireMedium, fireMediumPos12, new Rectangle(fireMediumCurrentFrame.X * fireMediumFrameSize.X, fireMediumCurrentFrame.Y * fireMediumFrameSize.Y, fireMediumFrameSize.X, fireMediumFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(fireMedium, fireMediumPos13, new Rectangle(fireMediumCurrentFrame.X * fireMediumFrameSize.X, fireMediumCurrentFrame.Y * fireMediumFrameSize.Y, fireMediumFrameSize.X, fireMediumFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(fireMedium, fireMediumPos14, new Rectangle(fireMediumCurrentFrame.X * fireMediumFrameSize.X, fireMediumCurrentFrame.Y * fireMediumFrameSize.Y, fireMediumFrameSize.X, fireMediumFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(fireMedium, fireMediumPos15, new Rectangle(fireMediumCurrentFrame.X * fireMediumFrameSize.X, fireMediumCurrentFrame.Y * fireMediumFrameSize.Y, fireMediumFrameSize.X, fireMediumFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(fireMedium, fireMediumPos16, new Rectangle(fireMediumCurrentFrame.X * fireMediumFrameSize.X, fireMediumCurrentFrame.Y * fireMediumFrameSize.Y, fireMediumFrameSize.X, fireMediumFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(fireMedium, fireMediumPos17, new Rectangle(fireMediumCurrentFrame.X * fireMediumFrameSize.X, fireMediumCurrentFrame.Y * fireMediumFrameSize.Y, fireMediumFrameSize.X, fireMediumFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(fireMedium, fireMediumPos18, new Rectangle(fireMediumCurrentFrame.X * fireMediumFrameSize.X, fireMediumCurrentFrame.Y * fireMediumFrameSize.Y, fireMediumFrameSize.X, fireMediumFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(fireMedium, fireMediumPos19, new Rectangle(fireMediumCurrentFrame.X * fireMediumFrameSize.X, fireMediumCurrentFrame.Y * fireMediumFrameSize.Y, fireMediumFrameSize.X, fireMediumFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(fireMedium, fireMediumPos20, new Rectangle(fireMediumCurrentFrame.X * fireMediumFrameSize.X, fireMediumCurrentFrame.Y * fireMediumFrameSize.Y, fireMediumFrameSize.X, fireMediumFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);


            //large fire

            spriteBatch.Draw(fireLarge, fireLargePos1, new Rectangle(fireLargeCurrentFrame.X * fireLargeFrameSize.X, fireLargeCurrentFrame.Y * fireLargeFrameSize.Y, fireLargeFrameSize.X, fireLargeFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(fireLarge, fireLargePos2, new Rectangle(fireLargeCurrentFrame.X * fireLargeFrameSize.X, fireLargeCurrentFrame.Y * fireLargeFrameSize.Y, fireLargeFrameSize.X, fireLargeFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);


            #endregion

            #region tiger

            spriteBatch.Draw(tigerRev, tigerPos1, new Rectangle(tigerCurrentFrame.X * tigerFrameSize.X, tigerCurrentFrame.Y * tigerFrameSize.Y, tigerFrameSize.X, tigerFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(tigerDarkRev, tigerPos2, new Rectangle(tigerCurrentFrame.X * tigerFrameSize.X, tigerCurrentFrame.Y * tigerFrameSize.Y, tigerFrameSize.X, tigerFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(tigerDarkRev, tigerPos3, new Rectangle(tigerCurrentFrame.X * tigerFrameSize.X, tigerCurrentFrame.Y * tigerFrameSize.Y, tigerFrameSize.X, tigerFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(tigerDarkRev, tigerPos4, new Rectangle(tigerCurrentFrame.X * tigerFrameSize.X, tigerCurrentFrame.Y * tigerFrameSize.Y, tigerFrameSize.X, tigerFrameSize.Y), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);


            #endregion


            #region smallBlocks

            spriteBatch.Draw(smallBlock, smallBlockPos46, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(smallBlock, smallBlockPos47, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(smallBlock, smallBlockPos48, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(smallBlock, smallBlockPos49, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            spriteBatch.Draw(smallBlock, smallBlockPos50, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.Draw(smallBlock, smallBlockPos51, null, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);


            #endregion

            spriteBatch.Draw(lv1, new Vector2(10140, 500), Color.White);

            spriteBatch.Draw(lion, new Vector2(53200, 500), Color.White);

            spriteBatch.Draw(level2End, level2EndPos, Color.White);

            spriteBatch.DrawString(gameFont, "Points : " + marks.ToString() + "  Remaining Magic  : " + powerUsageCount.ToString() + "  Saves :" + saveCount.ToString(), new Vector2(heroPosition.X - 180, 5) /*fontPos*/, Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);
            spriteBatch.DrawString(gameFont2, marks.ToString(), new Vector2(58280, 445), Color.White, 0, Vector2.Zero, 1, SpriteEffects.None, 1);

            spriteBatch.End();

            base.Draw(gameTime);

        }


        #region functionals


        protected bool playerHitsNextLevel()
        {
            Rectangle RS = new Rectangle((int)10140, (int)500, lv1.Width, lv1.Height);
            Rectangle rs = new Rectangle((int)heroPosition.X, (int)heroPosition.Y, hero.Width / 2, hero.Height / 4);

            KeyboardState ty = Keyboard.GetState();
            if (rs.Intersects(RS)/* && diamondCount>15*/)
            {
                lvl2 = true;
                marks += 5000;
                return true;
            }
            else
            {
                return false;
            }
        }

        protected bool playerHitsFinalLevel()
        {
            Rectangle RS = new Rectangle((int)53200, (int)500, lion.Width, lion.Height);
            Rectangle rs = new Rectangle((int)heroPosition.X, (int)heroPosition.Y, hero.Width / 2, hero.Height / 4);

            KeyboardState ty = Keyboard.GetState();
            if (rs.Intersects(RS)/* && diamondCount > 35*/)
            {
                lvl2 = false;
                marks += 10000;
                return true;
            }
            else
            {
                return false;
            }
        }

        protected bool playerHitsSecondLevel()
        {
            Rectangle RS = new Rectangle((int)level2EndPos.X, (int)level2EndPos.Y, level2End.Width, level2End.Height);
            Rectangle rs = new Rectangle((int)heroPosition.X, (int)heroPosition.Y, hero.Width / 2, hero.Height / 4);

            KeyboardState ty = Keyboard.GetState();
            if (rs.Intersects(RS)/* && diamondCount > 35*/)
            {
                lvl2 = false;
                marks += 10000;
                return true;
            }
            else
            {
                return false;
            }
        }

        protected bool playerHitsGround()
        {
            Rectangle RS1 = new Rectangle((int)groundBlockPos1.X, (int)groundBlockPos1.Y, groundBlock.Width, groundBlock.Height);
            Rectangle RS2 = new Rectangle((int)groundBlockPos2.X, (int)groundBlockPos2.Y, groundBlock.Width, groundBlock.Height);
            Rectangle RS3 = new Rectangle((int)groundBlockPos3.X, (int)groundBlockPos3.Y, groundBlock.Width, groundBlock.Height);
            Rectangle RS4 = new Rectangle((int)groundBlockPos4.X, (int)groundBlockPos4.Y, groundBlock.Width, groundBlock.Height);
            Rectangle RS5 = new Rectangle((int)groundBlockPos5.X, (int)groundBlockPos5.Y, groundBlock.Width, groundBlock.Height);
            Rectangle RS6 = new Rectangle((int)groundBlockPos6.X, (int)groundBlockPos6.Y, groundBlock.Width, groundBlock.Height);
            Rectangle RS7 = new Rectangle((int)groundBlockPos7.X, (int)groundBlockPos7.Y, groundBlock.Width, groundBlock.Height);
            Rectangle RS8 = new Rectangle((int)groundBlockPos8.X, (int)groundBlockPos8.Y, groundBlock.Width, groundBlock.Height);
            Rectangle RS9 = new Rectangle((int)groundBlockPos9.X, (int)groundBlockPos9.Y, groundBlock.Width, groundBlock.Height);
            Rectangle RS10 = new Rectangle((int)groundBlockPos10.X, (int)groundBlockPos10.Y, groundBlock.Width, groundBlock.Height);
            Rectangle RS11 = new Rectangle((int)groundBlockPos11.X, (int)groundBlockPos11.Y, groundBlock.Width, groundBlock.Height);
            Rectangle RS12 = new Rectangle((int)groundBlockPos12.X, (int)groundBlockPos12.Y, groundBlock.Width, groundBlock.Height);
            Rectangle RS13 = new Rectangle((int)groundBlockPos13.X, (int)groundBlockPos13.Y, groundBlock.Width, groundBlock.Height);
            Rectangle RS14 = new Rectangle((int)groundBlockPos14.X, (int)groundBlockPos14.Y, groundBlock.Width, groundBlock.Height);
            Rectangle RS15 = new Rectangle((int)groundBlockPos15.X, (int)groundBlockPos15.Y, groundBlock.Width, groundBlock.Height);
            Rectangle RS16 = new Rectangle((int)groundBlockPos16.X, (int)groundBlockPos16.Y, groundBlock.Width, groundBlock.Height);
            Rectangle RS17 = new Rectangle((int)groundBlockPos17.X, (int)groundBlockPos17.Y, groundBlock.Width, groundBlock.Height);
            Rectangle RS18 = new Rectangle((int)groundBlockPos18.X, (int)groundBlockPos18.Y, groundBlock.Width, groundBlock.Height);
            Rectangle RS19 = new Rectangle((int)groundBlockPos19.X, (int)groundBlockPos19.Y, groundBlock.Width, groundBlock.Height);


            Rectangle rs = new Rectangle((int)heroPosition.X, (int)heroPosition.Y, hero.Width / 2, hero.Height / 4);

            KeyboardState ty = Keyboard.GetState();
            if (rs.Intersects(RS1) || rs.Intersects(RS2) || rs.Intersects(RS3) || rs.Intersects(RS4) || rs.Intersects(RS5) || rs.Intersects(RS6) || rs.Intersects(RS7) || rs.Intersects(RS8) || rs.Intersects(RS9) || rs.Intersects(RS10) || rs.Intersects(RS11) || rs.Intersects(RS12) || rs.Intersects(RS13) || rs.Intersects(RS14) || rs.Intersects(RS15) || rs.Intersects(RS16) || rs.Intersects(RS17) || rs.Intersects(RS18) || rs.Intersects(RS19))
            {
                end = true;
                //heroSpeed *= +1;
                return true;
            }
            else
            {
                return false;
            }
        }



        protected void enemyHitsBlocks(Texture2D t, Vector2 tp1, Vector2 tp2, Texture2D enemy, Vector2 enemyPos)
        {
            Rectangle rs1 = new Rectangle((int)tp1.X, (int)tp1.Y, t.Width, t.Height);
            Rectangle rs2 = new Rectangle((int)tp2.X, (int)tp2.Y, t.Width, t.Height);
            Rectangle enemy1 = new Rectangle((int)enemyPos.X, (int)enemyPos.Y, enemy.Width / 2, enemy.Height / 2);


            if (enemy1.Intersects(rs1) || enemy1.Intersects(rs2))
            {
                //enemySpeed1 *= -1;
                //enemyReversed *= -1;
            }
        }

        protected bool playerHitsBlocks(Texture2D block, Vector2 vec, Texture2D player, Vector2 playerPos)
        {
            Rectangle tower = new Rectangle((int)vec.X, (int)vec.Y, block.Width, block.Height);
            Rectangle play = new Rectangle((int)playerPos.X, (int)playerPos.Y, player.Width / 2, player.Height / 4);


            if (play.Intersects(tower))
                return true;
            else
                return false;

        }

        protected void playerHitsDiamond(ref bool visible, Vector2 diamondPos)
        {
            Rectangle RS = new Rectangle((int)diamondPos.X, (int)diamondPos.Y, diamond.Width, diamond.Height);
            Rectangle rs = new Rectangle((int)heroPosition.X, (int)heroPosition.Y, hero.Width / 2, hero.Height / 4);

            KeyboardState ty = Keyboard.GetState();

            if (rs.Intersects(RS) && ty.IsKeyDown(Keys.C) && (visible))
            {
                visible = false;

                if (heroPosition.X >= -2880 && heroPosition.X <= -1000)
                    marks += 200;
                if (lvl2 == false)
                    marks += 100;
                if (lvl2 == true)
                    marks += 200;
                if (heroPosition.X >= -2488 && heroPosition.X <= -952)
                    marks += 500;

                diamondCount += 1;
            }
        }

        protected void playerHitsEnemy()
        {
            Rectangle h = new Rectangle((int)heroPosition.X, (int)heroPosition.Y, hero.Width / 2, hero.Height / 4);
            Rectangle p1 = new Rectangle((int)enemyPos1.X + enemyOffset, (int)enemyPos1.Y + enemyOffset, enemy.Width / 2 - (enemyOffset * 2), enemy.Height / 2 - (enemyOffset * 2));
            Rectangle p2 = new Rectangle((int)enemyPos2.X + enemyOffset, (int)enemyPos2.Y + enemyOffset, enemy.Width / 2 - (enemyOffset * 2), enemy.Height / 2 - (enemyOffset * 2));
            Rectangle p3 = new Rectangle((int)enemyPos3.X + enemyOffset, (int)enemyPos3.Y + enemyOffset, enemy.Width / 2 - (enemyOffset * 2), enemy.Height / 2 - (enemyOffset * 2));
            Rectangle p4 = new Rectangle((int)enemyPos4.X + enemyOffset, (int)enemyPos4.Y + enemyOffset, enemy.Width / 2 - (enemyOffset * 2), enemy.Height / 2 - (enemyOffset * 2));
            Rectangle p5 = new Rectangle((int)enemyPos5.X + enemyOffset, (int)enemyPos5.Y + enemyOffset, enemy.Width / 2 - (enemyOffset * 2), enemy.Height / 2 - (enemyOffset * 2));
            Rectangle p6 = new Rectangle((int)enemyPos6.X + enemyOffset, (int)enemyPos6.Y + enemyOffset, enemy.Width / 2 - (enemyOffset * 2), enemy.Height / 2 - (enemyOffset * 2));
            Rectangle p7 = new Rectangle((int)enemyPos7.X + enemyOffset, (int)enemyPos7.Y + enemyOffset, enemy.Width / 2 - (enemyOffset * 2), enemy.Height / 2 - (enemyOffset * 2));
            Rectangle p8 = new Rectangle((int)enemyPos8.X + enemyOffset, (int)enemyPos8.Y + enemyOffset, enemy.Width / 2 - (enemyOffset * 2), enemy.Height / 2 - (enemyOffset * 2));
            Rectangle p9 = new Rectangle((int)enemyPos9.X + enemyOffset, (int)enemyPos9.Y + enemyOffset, enemy.Width / 2 - (enemyOffset * 2), enemy.Height / 2 - (enemyOffset * 2));
            Rectangle p10 = new Rectangle((int)enemyPos10.X + enemyOffset, (int)enemyPos10.Y + enemyOffset, enemy.Width / 2 - (enemyOffset * 2), enemy.Height / 2 - (enemyOffset * 2));
            Rectangle p11 = new Rectangle((int)enemyPos11.X + enemyOffset, (int)enemyPos11.Y + enemyOffset, enemy.Width / 2 - (enemyOffset * 2), enemy.Height / 2 - (enemyOffset * 2));
            Rectangle p12 = new Rectangle((int)enemyPos12.X + enemyOffset, (int)enemyPos12.Y + enemyOffset, enemy.Width / 2 - (enemyOffset * 2), enemy.Height / 2 - (enemyOffset * 2));
            Rectangle p13 = new Rectangle((int)enemyPos13.X + enemyOffset, (int)enemyPos13.Y + enemyOffset, enemy.Width / 2 - (enemyOffset * 2), enemy.Height / 2 - (enemyOffset * 2));
            Rectangle p14 = new Rectangle((int)enemyPos14.X + enemyOffset, (int)enemyPos14.Y + enemyOffset, enemy.Width / 2 - (enemyOffset * 2), enemy.Height / 2 - (enemyOffset * 2));
            Rectangle p15 = new Rectangle((int)enemyPos15.X + enemyOffset, (int)enemyPos15.Y + enemyOffset, enemy.Width / 2 - (enemyOffset * 2), enemy.Height / 2 - (enemyOffset * 2));
            Rectangle p16 = new Rectangle((int)enemyPos16.X + enemyOffset, (int)enemyPos16.Y + enemyOffset, enemy.Width / 2 - (enemyOffset * 2), enemy.Height / 2 - (enemyOffset * 2));
            Rectangle p17 = new Rectangle((int)enemyPos17.X + enemyOffset, (int)enemyPos17.Y + enemyOffset, enemy.Width / 2 - (enemyOffset * 2), enemy.Height / 2 - (enemyOffset * 2));
            Rectangle p18 = new Rectangle((int)enemyPos18.X + enemyOffset, (int)enemyPos18.Y + enemyOffset, enemy.Width / 2 - (enemyOffset * 2), enemy.Height / 2 - (enemyOffset * 2));
            Rectangle p19 = new Rectangle((int)enemyPos19.X + enemyOffset, (int)enemyPos19.Y + enemyOffset, enemy.Width / 2 - (enemyOffset * 2), enemy.Height / 2 - (enemyOffset * 2));
            Rectangle p20 = new Rectangle((int)enemyPos20.X + enemyOffset, (int)enemyPos20.Y + enemyOffset, enemy.Width / 2 - (enemyOffset * 2), enemy.Height / 2 - (enemyOffset * 2));
            Rectangle p21 = new Rectangle((int)enemyPos21.X + enemyOffset, (int)enemyPos21.Y + enemyOffset, enemy.Width / 2 - (enemyOffset * 2), enemy.Height / 2 - (enemyOffset * 2));
            Rectangle p22 = new Rectangle((int)enemyPos22.X + enemyOffset, (int)enemyPos22.Y + enemyOffset, enemy.Width / 2 - (enemyOffset * 2), enemy.Height / 2 - (enemyOffset * 2));
            Rectangle p23 = new Rectangle((int)enemyPos23.X + enemyOffset, (int)enemyPos23.Y + enemyOffset, enemy.Width / 2 - (enemyOffset * 2), enemy.Height / 2 - (enemyOffset * 2));
            Rectangle p24 = new Rectangle((int)enemyPos24.X + enemyOffset, (int)enemyPos24.Y + enemyOffset, enemy.Width / 2 - (enemyOffset * 2), enemy.Height / 2 - (enemyOffset * 2));
            Rectangle p25 = new Rectangle((int)enemyPos25.X + enemyOffset, (int)enemyPos25.Y + enemyOffset, enemy.Width / 2 - (enemyOffset * 2), enemy.Height / 2 - (enemyOffset * 2));
            Rectangle p26 = new Rectangle((int)enemyPos26.X + enemyOffset, (int)enemyPos26.Y + enemyOffset, enemy.Width / 2 - (enemyOffset * 2), enemy.Height / 2 - (enemyOffset * 2));
            Rectangle p27 = new Rectangle((int)enemyPos23.X + enemyOffset, (int)enemyPos23.Y + enemyOffset, enemy.Width / 2 - (enemyOffset * 2), enemy.Height / 2 - (enemyOffset * 2));
            Rectangle p28 = new Rectangle((int)enemyPos24.X + enemyOffset, (int)enemyPos24.Y + enemyOffset, enemy.Width / 2 - (enemyOffset * 2), enemy.Height / 2 - (enemyOffset * 2));
            Rectangle p29 = new Rectangle((int)enemyPos25.X + enemyOffset, (int)enemyPos25.Y + enemyOffset, enemy.Width / 2 - (enemyOffset * 2), enemy.Height / 2 - (enemyOffset * 2));
            Rectangle p30 = new Rectangle((int)enemyPos26.X + enemyOffset, (int)enemyPos26.Y + enemyOffset, enemy.Width / 2 - (enemyOffset * 2), enemy.Height / 2 - (enemyOffset * 2));



            KeyboardState pp = Keyboard.GetState();

            //if (pp.IsKeyDown(Keys.X) && (pp.IsKeyDown(Keys.Left) || pp.IsKeyDown(Keys.Right)) && (p1.Intersects(p2)))
            //{
            //    enemyPoss = new Vector2(50000, 0);
            //    marks += 100;
            //}

            if (((h.Intersects(p1)) || (h.Intersects(p2)) || (h.Intersects(p3)) || (h.Intersects(p4)) || (h.Intersects(p5)) || (h.Intersects(p6)) || (h.Intersects(p7)) || (h.Intersects(p8)) || (h.Intersects(p9)) || (h.Intersects(p10)) || (h.Intersects(p11)) || (h.Intersects(p12)) || (h.Intersects(p13)) || (h.Intersects(p14)) || (h.Intersects(p15)) || (h.Intersects(p16)) || (h.Intersects(p17)) || (h.Intersects(p18)) || (h.Intersects(p19)) || (h.Intersects(p20)) || (h.Intersects(p21)) || (h.Intersects(p22)) || (h.Intersects(p26)) || (h.Intersects(p27)) || (h.Intersects(p28)) || (h.Intersects(p29)) || (h.Intersects(p30)) || (h.Intersects(p23)) || (h.Intersects(p24)) || (h.Intersects(p25))) && !(pp.IsKeyDown(Keys.Z)))
            {
                playerDied = true;
                heroPosition = new Vector2(60412, 400);
            }

            if (((h.Intersects(p1)) || (h.Intersects(p2)) || (h.Intersects(p3)) || (h.Intersects(p4)) || (h.Intersects(p5)) || (h.Intersects(p6)) || (h.Intersects(p7)) || (h.Intersects(p8)) || (h.Intersects(p9)) || (h.Intersects(p10)) || (h.Intersects(p11)) || (h.Intersects(p12)) || (h.Intersects(p13)) || (h.Intersects(p14)) || (h.Intersects(p15)) || (h.Intersects(p16)) || (h.Intersects(p17)) || (h.Intersects(p18)) || (h.Intersects(p19)) || (h.Intersects(p20)) || (h.Intersects(p21)) || (h.Intersects(p22)) || (h.Intersects(p23)) || (h.Intersects(p24)) || (h.Intersects(p25)) || (h.Intersects(p25)) || (h.Intersects(p26)) || (h.Intersects(p27)) || (h.Intersects(p28)) || (h.Intersects(p29)) || (h.Intersects(p30))) && (pp.IsKeyDown(Keys.Z)) && (getPowerCount()))
            {
                powerUsageCount -= 1;
            }

            if (((h.Intersects(p1)) || (h.Intersects(p2)) || (h.Intersects(p3)) || (h.Intersects(p4)) || (h.Intersects(p5)) || (h.Intersects(p6)) || (h.Intersects(p7)) || (h.Intersects(p8)) || (h.Intersects(p9)) || (h.Intersects(p10)) || (h.Intersects(p11)) || (h.Intersects(p12)) || (h.Intersects(p13)) || (h.Intersects(p14)) || (h.Intersects(p15)) || (h.Intersects(p16)) || (h.Intersects(p17)) || (h.Intersects(p18)) || (h.Intersects(p19)) || (h.Intersects(p20)) || (h.Intersects(p21)) || (h.Intersects(p22)) || (h.Intersects(p23)) || (h.Intersects(p24)) || (h.Intersects(p25)) || (h.Intersects(p25)) || (h.Intersects(p26)) || (h.Intersects(p27)) || (h.Intersects(p28)) || (h.Intersects(p29)) || (h.Intersects(p30))) && (pp.IsKeyDown(Keys.Z)) && !(getPowerCount()))
            {
                playerDied = true;
                heroPosition = new Vector2(60412, 400);
            }





        }

        protected void enemyChase(ref Vector2 enemyPoss)
        {
            Random rnd = new Random();


            //if (lvl2 == false)
            //{
            //    if (heroPosition.X < enemyPoss.X)
            //        enemyPoss.X -= rnd.Next(-2, 4);
            //    else if (heroPosition.X > enemyPoss.X)
            //        enemyPoss.X += rnd.Next(-2, 4);
            //    if (heroPosition.Y < enemyPoss.Y)
            //        enemyPoss.Y -= rnd.Next(-2, 4);
            //    else if (heroPosition.Y > enemyPoss.Y)
            //        enemyPoss.Y += rnd.Next(-2, 4);

            //}
            //if (lvl2 == true)
            //{
            //    if (heroPosition.X < enemyPoss.X)
            //        enemyPoss.X -= rnd.Next(-2, 7);
            //    else if (heroPosition.X > enemyPoss.X)
            //        enemyPoss.X += rnd.Next(-2, 7);
            //    if (heroPosition.Y < enemyPoss.Y)
            //        enemyPoss.Y -= rnd.Next(-2, 7);
            //    else if (heroPosition.Y > enemyPoss.Y)
            //        enemyPoss.Y += rnd.Next(-2, 7);


            //}


            if ( ifLevel1 == true && ifLevel2 == false && ifLevel3 == false)
            {
                if (heroPosition.X < enemyPoss.X)
                    enemyPoss.X -= rnd.Next(-2, 4);
                else if (heroPosition.X > enemyPoss.X)
                    enemyPoss.X += rnd.Next(-2, 4);
                if (heroPosition.Y < enemyPoss.Y)
                    enemyPoss.Y -= rnd.Next(-2, 4);
                else if (heroPosition.Y > enemyPoss.Y)
                    enemyPoss.Y += rnd.Next(-2, 4);

            }

            if (ifLevel1 == false && ifLevel2 == true && ifLevel3 == false)
            {
                if (heroPosition.X < enemyPoss.X)
                    enemyPoss.X -= rnd.Next(-2, 5);
                else if (heroPosition.X > enemyPoss.X)
                    enemyPoss.X += rnd.Next(-2, 5);
                if (heroPosition.Y < enemyPoss.Y)
                    enemyPoss.Y -= rnd.Next(-2, 5);
                else if (heroPosition.Y > enemyPoss.Y)
                    enemyPoss.Y += rnd.Next(-2, 5);
            }

            if (ifLevel1 == false && ifLevel2 == false && ifLevel3 == true)
            {
                if (heroPosition.X < enemyPoss.X)
                    enemyPoss.X -= rnd.Next(-2, 7);
                else if (heroPosition.X > enemyPoss.X)
                    enemyPoss.X += rnd.Next(-2, 7);
                if (heroPosition.Y < enemyPoss.Y)
                    enemyPoss.Y -= rnd.Next(-2, 7);
                else if (heroPosition.Y > enemyPoss.Y)
                    enemyPoss.Y += rnd.Next(-2, 7);
            }





        }

        protected void playerHitsFire()
        {
            //tourches

            Rectangle p1 = new Rectangle((int)fireTouchPos1.X, (int)fireTouchPos1.Y, fireTourch.Width / 2, fireTourch.Height / 3);
            Rectangle p2 = new Rectangle((int)fireTouchPos2.X, (int)fireTouchPos2.Y, fireTourch.Width / 2, fireTourch.Height / 3);
            Rectangle p3 = new Rectangle((int)fireTouchPos3.X, (int)fireTouchPos3.Y, fireTourch.Width / 2, fireTourch.Height / 3);
            Rectangle p4 = new Rectangle((int)fireTouchPos4.X, (int)fireTouchPos4.Y, fireTourch.Width / 2, fireTourch.Height / 3);
            Rectangle p5 = new Rectangle((int)fireTouchPos5.X, (int)fireTouchPos5.Y, fireTourch.Width / 2, fireTourch.Height / 3);
            Rectangle p6 = new Rectangle((int)fireTouchPos6.X, (int)fireTouchPos6.Y, fireTourch.Width / 2, fireTourch.Height / 3);
            Rectangle p7 = new Rectangle((int)fireTouchPos7.X, (int)fireTouchPos7.Y, fireTourch.Width / 2, fireTourch.Height / 3);
            Rectangle p8 = new Rectangle((int)fireTouchPos8.X, (int)fireTouchPos8.Y, fireTourch.Width / 2, fireTourch.Height / 3);
            Rectangle p9 = new Rectangle((int)fireTouchPos9.X, (int)fireTouchPos9.Y, fireTourch.Width / 2, fireTourch.Height / 3);
            Rectangle p10 = new Rectangle((int)fireTouchPos10.X, (int)fireTouchPos10.Y, fireTourch.Width / 2, fireTourch.Height / 3);

            Rectangle p11 = new Rectangle((int)fireMediumPos1.X, (int)fireMediumPos1.Y, fireMedium.Width / 2, fireMedium.Height / 4);
            Rectangle p12 = new Rectangle((int)fireMediumPos2.X, (int)fireMediumPos2.Y, fireMedium.Width / 2, fireMedium.Height / 4);
            Rectangle p13 = new Rectangle((int)fireMediumPos3.X, (int)fireMediumPos3.Y, fireMedium.Width / 2, fireMedium.Height / 4);
            Rectangle p14 = new Rectangle((int)fireMediumPos4.X, (int)fireMediumPos4.Y, fireMedium.Width / 2, fireMedium.Height / 4);
            Rectangle p15 = new Rectangle((int)fireMediumPos5.X, (int)fireMediumPos5.Y, fireMedium.Width / 2, fireMedium.Height / 4);
            Rectangle p16 = new Rectangle((int)fireMediumPos6.X, (int)fireMediumPos6.Y, fireMedium.Width / 2, fireMedium.Height / 4);
            Rectangle p17 = new Rectangle((int)fireMediumPos7.X, (int)fireMediumPos7.Y, fireMedium.Width / 2, fireMedium.Height / 4);

            Rectangle p18 = new Rectangle((int)fireMediumPos8.X, (int)fireMediumPos8.Y, fireMedium.Width / 2, fireMedium.Height / 4);
            Rectangle p19 = new Rectangle((int)fireMediumPos9.X, (int)fireMediumPos9.Y, fireMedium.Width / 2, fireMedium.Height / 4);
            Rectangle p20 = new Rectangle((int)fireMediumPos10.X, (int)fireMediumPos10.Y, fireMedium.Width / 2, fireMedium.Height / 4);
            Rectangle p21 = new Rectangle((int)fireMediumPos11.X, (int)fireMediumPos11.Y, fireMedium.Width / 2, fireMedium.Height / 4);
            Rectangle p22 = new Rectangle((int)fireMediumPos12.X, (int)fireMediumPos12.Y, fireMedium.Width / 2, fireMedium.Height / 4);
            Rectangle p23 = new Rectangle((int)fireMediumPos13.X, (int)fireMediumPos13.Y, fireMedium.Width / 2, fireMedium.Height / 4);
            Rectangle p24 = new Rectangle((int)fireMediumPos14.X, (int)fireMediumPos14.Y, fireMedium.Width / 2, fireMedium.Height / 4);

            Rectangle p25 = new Rectangle((int)fireMediumPos15.X, (int)fireMediumPos15.Y, fireMedium.Width / 2, fireMedium.Height / 4);
            Rectangle p26 = new Rectangle((int)fireMediumPos16.X, (int)fireMediumPos16.Y, fireMedium.Width / 2, fireMedium.Height / 4);
            Rectangle p27 = new Rectangle((int)fireMediumPos17.X, (int)fireMediumPos17.Y, fireMedium.Width / 2, fireMedium.Height / 4);
            Rectangle p28 = new Rectangle((int)fireMediumPos18.X, (int)fireMediumPos18.Y, fireMedium.Width / 2, fireMedium.Height / 4);
            Rectangle p29 = new Rectangle((int)fireMediumPos19.X, (int)fireMediumPos19.Y, fireMedium.Width / 2, fireMedium.Height / 4);
            Rectangle p30 = new Rectangle((int)fireMediumPos20.X, (int)fireMediumPos20.Y, fireMedium.Width / 2, fireMedium.Height / 4);


            Rectangle h = new Rectangle((int)heroPosition.X, (int)heroPosition.Y, hero.Width / 2, hero.Height / 4);

            KeyboardState kk = Keyboard.GetState();


            if ((h.Intersects(p1) || h.Intersects(p2) || h.Intersects(p3) || h.Intersects(p4) || h.Intersects(p5) || h.Intersects(p6) || h.Intersects(p7) || h.Intersects(p8) || h.Intersects(p9) || h.Intersects(p10)) || (h.Intersects(p11) || (h.Intersects(p12) || h.Intersects(p13) || h.Intersects(p14) || h.Intersects(p15) || h.Intersects(p16) || h.Intersects(p17) || h.Intersects(p18) || h.Intersects(p19) || h.Intersects(p20) || h.Intersects(p21) || h.Intersects(p22) || h.Intersects(p23) || h.Intersects(p24) || h.Intersects(p25) || h.Intersects(p26) || h.Intersects(p27) || h.Intersects(p28) || h.Intersects(p29) || h.Intersects(p30)) && kk.IsKeyUp(Keys.A)))
            {
                playerDied = true;
                tryCount += 1;
                heroPosition = new Vector2(60412, 0);
            }
        }

        protected bool playerHitsLog()
        {
            Rectangle RS1 = new Rectangle((int)logPos1.X, (int)logPos1.Y, log.Width, log.Height);
            Rectangle RS2 = new Rectangle((int)logPos2.X, (int)logPos2.Y, log.Width, log.Height);
            Rectangle RS3 = new Rectangle((int)logPos3.X, (int)logPos3.Y, log.Width, log.Height);
            Rectangle RS4 = new Rectangle((int)logPos4.X, (int)logPos4.Y, log.Width, log.Height);
            Rectangle RS5 = new Rectangle((int)logPos5.X, (int)logPos5.Y, log.Width, log.Height);
            Rectangle RS6 = new Rectangle((int)logPos6.X, (int)logPos6.Y, log.Width, log.Height);
            Rectangle RS7 = new Rectangle((int)logPos7.X, (int)logPos7.Y, log.Width, log.Height);
            Rectangle RS8 = new Rectangle((int)logPos8.X, (int)logPos8.Y, log.Width, log.Height);
            Rectangle RS9 = new Rectangle((int)logPos9.X, (int)logPos9.Y, log.Width, log.Height);
            Rectangle RS10 = new Rectangle((int)logPos10.X, (int)logPos10.Y, log.Width, log.Height);
            Rectangle RS11 = new Rectangle((int)logPos11.X, (int)logPos11.Y, log.Width, log.Height);
            // Rectangle RS12 = new Rectangle((int)logPos12.X, (int)logPos12.Y, log.Width, log.Height);

            //Rectangle RS13 = new Rectangle((int)logPos13.X, (int)logPos13.Y, log.Width, log.Height);
            //Rectangle RS14 = new Rectangle((int)logPos14.X, (int)logPos14.Y, log.Width, log.Height);
            //Rectangle RS15 = new Rectangle((int)logPos15.X, (int)logPos15.Y, log.Width, log.Height);
            //Rectangle RS16 = new Rectangle((int)logPos16.X, (int)logPos16.Y, log.Width, log.Height);
            //Rectangle RS17 = new Rectangle((int)logPos17.X, (int)logPos17.Y, log.Width, log.Height);
            //Rectangle RS18 = new Rectangle((int)logPos18.X, (int)logPos18.Y, log.Width, log.Height);
            //Rectangle RS19 = new Rectangle((int)logPos19.X, (int)logPos19.Y, log.Width, log.Height);
            //Rectangle RS20 = new Rectangle((int)logPos20.X, (int)logPos20.Y, log.Width, log.Height);
            //Rectangle RS21 = new Rectangle((int)logPos21.X, (int)logPos21.Y, log.Width, log.Height);
            //Rectangle RS22 = new Rectangle((int)logPos22.X, (int)logPos22.Y, log.Width, log.Height);
            //Rectangle RS23 = new Rectangle((int)logPos23.X, (int)logPos23.Y, log.Width, log.Height);
            //Rectangle RS24 = new Rectangle((int)logPos24.X, (int)logPos24.Y, log.Width, log.Height);



            Rectangle rs = new Rectangle((int)heroPosition.X, (int)heroPosition.Y, hero.Width / 2, hero.Height / 4);

            KeyboardState ty = Keyboard.GetState();
            if (rs.Intersects(RS1) || rs.Intersects(RS2) || rs.Intersects(RS3) || rs.Intersects(RS4) || rs.Intersects(RS5) || rs.Intersects(RS6) || rs.Intersects(RS7) || rs.Intersects(RS8) || rs.Intersects(RS9) || rs.Intersects(RS10) || rs.Intersects(RS11)/* || rs.Intersects(RS12) || rs.Intersects(RS13) || rs.Intersects(RS14) || rs.Intersects(RS15) || rs.Intersects(RS16) || rs.Intersects(RS17) || rs.Intersects(RS18) || rs.Intersects(RS19) || rs.Intersects(RS20) || rs.Intersects(RS21) || rs.Intersects(RS22) || rs.Intersects(RS23) || rs.Intersects(RS24) */)
            {
                //end = true;
                heroSpeed = 0;
                return true;

            }
            else
            {
                return false;
            }
        }

        protected void logMoves()
        {
            Rectangle p1 = new Rectangle((int)logPos1.X, (int)logPos1.Y, log.Width, log.Height);
            Rectangle p2 = new Rectangle((int)logPos2.X, (int)logPos2.Y, log.Width, log.Height);
            Rectangle p3 = new Rectangle((int)logPos3.X, (int)logPos3.Y, log.Width, log.Height);
            Rectangle p4 = new Rectangle((int)logPos4.X, (int)logPos4.Y, log.Width, log.Height);
            Rectangle p5 = new Rectangle((int)logPos5.X, (int)logPos5.Y, log.Width, log.Height);
            Rectangle p6 = new Rectangle((int)logPos6.X, (int)logPos6.Y, log.Width, log.Height);
            Rectangle p7 = new Rectangle((int)logPos7.X, (int)logPos7.Y, log.Width, log.Height);
            Rectangle p8 = new Rectangle((int)logPos8.X, (int)logPos8.Y, log.Width, log.Height);
            Rectangle p9 = new Rectangle((int)logPos9.X, (int)logPos9.Y, log.Width, log.Height);
            Rectangle p10 = new Rectangle((int)logPos10.X, (int)logPos10.Y, log.Width, log.Height);
            Rectangle p11 = new Rectangle((int)logPos11.X, (int)logPos11.Y, log.Width, log.Height);
            //Rectangle p12 = new Rectangle((int)logPos12.X, (int)logPos12.Y, log.Width, log.Height);
            //Rectangle p13 = new Rectangle((int)logPos13.X, (int)logPos13.Y, log.Width, log.Height);
            //Rectangle p14 = new Rectangle((int)logPos14.X, (int)logPos14.Y, log.Width, log.Height);
            //Rectangle p15 = new Rectangle((int)logPos15.X, (int)logPos15.Y, log.Width, log.Height);
            //Rectangle p16 = new Rectangle((int)logPos16.X, (int)logPos16.Y, log.Width, log.Height);
            //Rectangle p17 = new Rectangle((int)logPos17.X, (int)logPos17.Y, log.Width, log.Height);
            //Rectangle p18 = new Rectangle((int)logPos18.X, (int)logPos18.Y, log.Width, log.Height);
            //Rectangle p19 = new Rectangle((int)logPos19.X, (int)logPos19.Y, log.Width, log.Height);
            //Rectangle p20 = new Rectangle((int)logPos20.X, (int)logPos20.Y, log.Width, log.Height);
            //Rectangle p21 = new Rectangle((int)logPos21.X, (int)logPos21.Y, log.Width, log.Height);
            //Rectangle p22 = new Rectangle((int)logPos22.X, (int)logPos22.Y, log.Width, log.Height);
            //Rectangle p23 = new Rectangle((int)logPos23.X, (int)logPos23.Y, log.Width, log.Height);
            //Rectangle p24 = new Rectangle((int)logPos24.X, (int)logPos24.Y, log.Width, log.Height);



            Rectangle g1 = new Rectangle((int)groundBlockPos1.X, (int)groundBlockPos1.Y, groundBlock.Width, groundBlock.Height);
            Rectangle g2 = new Rectangle((int)groundBlockPos2.X, (int)groundBlockPos2.Y, groundBlock.Width, groundBlock.Height);
            Rectangle g3 = new Rectangle((int)groundBlockPos3.X, (int)groundBlockPos3.Y, groundBlock.Width, groundBlock.Height);
            Rectangle g4 = new Rectangle((int)groundBlockPos4.X, (int)groundBlockPos4.Y, groundBlock.Width, groundBlock.Height);
            Rectangle g5 = new Rectangle((int)groundBlockPos5.X, (int)groundBlockPos5.Y, groundBlock.Width, groundBlock.Height);
            Rectangle g6 = new Rectangle((int)groundBlockPos6.X, (int)groundBlockPos6.Y, groundBlock.Width, groundBlock.Height);
            Rectangle g7 = new Rectangle((int)groundBlockPos7.X, (int)groundBlockPos7.Y, groundBlock.Width, groundBlock.Height);
            Rectangle g8 = new Rectangle((int)groundBlockPos8.X, (int)groundBlockPos8.Y, groundBlock.Width, groundBlock.Height);
            Rectangle g9 = new Rectangle((int)groundBlockPos9.X, (int)groundBlockPos9.Y, groundBlock.Width, groundBlock.Height);




            Rectangle l1 = new Rectangle((int)bannerPos1.X, (int)bannerPos1.Y, markBanner.Width, markBanner.Height);
            Rectangle l2 = new Rectangle((int)bannerPos2.X, (int)bannerPos2.Y, markBanner.Width, markBanner.Height);
            Rectangle l3 = new Rectangle((int)bannerPos3.X, (int)bannerPos3.Y, markBanner.Width, markBanner.Height);
            Rectangle l4 = new Rectangle((int)bannerPos4.X, (int)bannerPos4.Y, markBanner.Width, markBanner.Height);
            Rectangle l5 = new Rectangle((int)bannerPos5.X, (int)bannerPos5.Y, markBanner.Width, markBanner.Height);
            Rectangle l6 = new Rectangle((int)bannerPos6.X, (int)bannerPos6.Y, markBanner.Width, markBanner.Height);
            Rectangle l7 = new Rectangle((int)bannerPos7.X, (int)bannerPos7.Y, markBanner.Width, markBanner.Height);
            Rectangle l8 = new Rectangle((int)bannerPos8.X, (int)bannerPos8.Y, markBanner.Width, markBanner.Height);
            Rectangle l9 = new Rectangle((int)bannerPos9.X, (int)bannerPos9.Y, markBanner.Width, markBanner.Height);
            Rectangle l10 = new Rectangle((int)bannerPos10.X, (int)bannerPos10.Y, markBanner.Width, markBanner.Height);
            Rectangle l11 = new Rectangle((int)bannerPos11.X, (int)bannerPos11.Y, markBanner.Width, markBanner.Height);
            Rectangle l12 = new Rectangle((int)bannerPos12.X, (int)bannerPos12.Y, markBanner.Width, markBanner.Height);
            Rectangle l13 = new Rectangle((int)bannerPos13.X, (int)bannerPos13.Y, markBanner.Width, markBanner.Height);
            Rectangle l14 = new Rectangle((int)bannerPos14.X, (int)bannerPos14.Y, markBanner.Width, markBanner.Height);
            Rectangle l15 = new Rectangle((int)bannerPos15.X, (int)bannerPos15.Y, markBanner.Width, markBanner.Height);
            Rectangle l16 = new Rectangle((int)bannerPos16.X, (int)bannerPos16.Y, markBanner.Width, markBanner.Height);
            Rectangle l17 = new Rectangle((int)bannerPos17.X, (int)bannerPos17.Y, markBanner.Width, markBanner.Height);
            Rectangle l18 = new Rectangle((int)bannerPos18.X, (int)bannerPos18.Y, markBanner.Width, markBanner.Height);
            Rectangle l19 = new Rectangle((int)bannerPos19.X, (int)bannerPos19.Y, markBanner.Width, markBanner.Height);
            Rectangle l20 = new Rectangle((int)bannerPos20.X, (int)bannerPos20.Y, markBanner.Width, markBanner.Height);

            //--------------
            if (p1.Intersects(g1) || p1.Intersects(g2) || p1.Intersects(g3) || p1.Intersects(g4) || p1.Intersects(g5) || p1.Intersects(g1) || p1.Intersects(g6) || p1.Intersects(g7) || p1.Intersects(g8) || p1.Intersects(g9) || p1.Intersects(l1) || p1.Intersects(l2) || p1.Intersects(l3) || p1.Intersects(l4) || p1.Intersects(l5) || p1.Intersects(l1) || p1.Intersects(l6) || p1.Intersects(l7) || p1.Intersects(l8) || p1.Intersects(l9) || p1.Intersects(l10) || p1.Intersects(l11) || p1.Intersects(l12) || p1.Intersects(l13) || p1.Intersects(l14) || p1.Intersects(l15) || p1.Intersects(l16) || p1.Intersects(l17) || p1.Intersects(l18) || p1.Intersects(l19) || p1.Intersects(l20))
            {
                logSpeed *= -1;
            }

            if (p2.Intersects(g1) || p2.Intersects(g2) || p2.Intersects(g3) || p2.Intersects(g4) || p2.Intersects(g5) || p2.Intersects(g1) || p2.Intersects(g6) || p2.Intersects(g7) || p2.Intersects(g8) || p1.Intersects(g9) || p2.Intersects(l1) || p2.Intersects(l2) || p2.Intersects(l3) || p2.Intersects(l4) || p2.Intersects(l5) || p2.Intersects(l1) || p2.Intersects(l6) || p2.Intersects(l7) || p2.Intersects(l8) || p2.Intersects(l9) || p2.Intersects(l10) || p2.Intersects(l11) || p2.Intersects(l12) || p2.Intersects(l13) || p2.Intersects(l14) || p2.Intersects(l15) || p2.Intersects(l16) || p2.Intersects(l17) || p2.Intersects(l18) || p2.Intersects(l19) || p2.Intersects(l20))
            {
                logSpeed *= -1;
            }

            if (p3.Intersects(g1) || p3.Intersects(g2) || p3.Intersects(g3) || p3.Intersects(g4) || p3.Intersects(g5) || p3.Intersects(g1) || p3.Intersects(g6) || p3.Intersects(g7) || p3.Intersects(g8) || p1.Intersects(g9) || p3.Intersects(l1) || p3.Intersects(l2) || p3.Intersects(l3) || p3.Intersects(l4) || p3.Intersects(l5) || p3.Intersects(l1) || p3.Intersects(l6) || p3.Intersects(l7) || p3.Intersects(l8) || p3.Intersects(l9) || p3.Intersects(l10) || p3.Intersects(l11) || p3.Intersects(l12) || p3.Intersects(l13) || p3.Intersects(l14) || p3.Intersects(l15) || p3.Intersects(l16) || p3.Intersects(l17) || p3.Intersects(l18) || p3.Intersects(l19) || p3.Intersects(l20))
            {
                logSpeed *= -1;
            }

            if (p4.Intersects(g1) || p4.Intersects(g2) || p4.Intersects(g3) || p4.Intersects(g4) || p4.Intersects(g5) || p4.Intersects(g1) || p4.Intersects(g6) || p4.Intersects(g7) || p4.Intersects(g8) || p4.Intersects(l1) || p4.Intersects(l2) || p4.Intersects(l3) || p4.Intersects(l4) || p4.Intersects(l5) || p4.Intersects(l1) || p4.Intersects(l6) || p4.Intersects(l7) || p4.Intersects(l8) || p4.Intersects(l9) || p4.Intersects(l10) || p4.Intersects(l11) || p4.Intersects(l12) || p4.Intersects(l13) || p4.Intersects(l14) || p4.Intersects(l15) || p4.Intersects(l16) || p4.Intersects(l17) || p4.Intersects(l18) || p4.Intersects(l19) || p4.Intersects(l20))
            {
                logSpeed *= -1;
            }

            if (p5.Intersects(g1) || p5.Intersects(g2) || p5.Intersects(g3) || p5.Intersects(g4) || p5.Intersects(g5) || p5.Intersects(g1) || p5.Intersects(g6) || p5.Intersects(g7) || p5.Intersects(g8) || p5.Intersects(l1) || p5.Intersects(l2) || p5.Intersects(l3) || p5.Intersects(l4) || p5.Intersects(l5) || p5.Intersects(l1) || p5.Intersects(l6) || p5.Intersects(l7) || p5.Intersects(l8) || p5.Intersects(l9) || p5.Intersects(l10) || p5.Intersects(l11) || p5.Intersects(l12) || p5.Intersects(l13) || p5.Intersects(l14) || p5.Intersects(l15) || p5.Intersects(l16) || p5.Intersects(l17) || p5.Intersects(l18) || p5.Intersects(l19) || p5.Intersects(l20))
            {
                logSpeed *= -1;
            }

            //-----------

            //if (p6.Intersects(g1) || p6.Intersects(g2) || p6.Intersects(g3) || p6.Intersects(g4) || p6.Intersects(g5) || p6.Intersects(g1) || p6.Intersects(g6) || p6.Intersects(g7) || p6.Intersects(g8) || p6.Intersects(l1) || p6.Intersects(l2) || p6.Intersects(l3) || p6.Intersects(l4) || p6.Intersects(l5) || p6.Intersects(l1) || p6.Intersects(l6) || p6.Intersects(l7) || p6.Intersects(l8) || p6.Intersects(l9) || p6.Intersects(l10) || p6.Intersects(l11) || p6.Intersects(l12) || p6.Intersects(l13) || p6.Intersects(l14) || p6.Intersects(l15) || p6.Intersects(l16) || p6.Intersects(l17) || p6.Intersects(l18) || p6.Intersects(l19) || p6.Intersects(l20))
            //{
            //    logSpeed *= -1;
            //}

            //if (p7.Intersects(g1) || p7.Intersects(g2) || p7.Intersects(g3) || p7.Intersects(g4) || p7.Intersects(g5) || p7.Intersects(g1) || p7.Intersects(g6) || p7.Intersects(g7) || p7.Intersects(g8) || p7.Intersects(l1) || p7.Intersects(l2) || p7.Intersects(l3) || p7.Intersects(l4) || p7.Intersects(l5) || p7.Intersects(l1) || p7.Intersects(l6) || p7.Intersects(l7) || p7.Intersects(l8) || p7.Intersects(l9) || p7.Intersects(l10) || p7.Intersects(l11) || p7.Intersects(l12) || p7.Intersects(l13) || p7.Intersects(l14) || p7.Intersects(l15) || p7.Intersects(l16) || p7.Intersects(l17) || p7.Intersects(l18) || p7.Intersects(l19) || p7.Intersects(l20))
            //{
            //    logSpeed *= -1;
            //}

            //if (p8.Intersects(g1) || p8.Intersects(g2) || p8.Intersects(g3) || p8.Intersects(g4) || p8.Intersects(g5) || p8.Intersects(g1) || p8.Intersects(g6) || p8.Intersects(g7) || p8.Intersects(g8) || p8.Intersects(l1) || p8.Intersects(l2) || p8.Intersects(l3) || p8.Intersects(l4) || p8.Intersects(l5) || p8.Intersects(l1) || p8.Intersects(l6) || p8.Intersects(l7) || p8.Intersects(l8) || p8.Intersects(l9) || p8.Intersects(l10) || p8.Intersects(l11) || p8.Intersects(l12) || p8.Intersects(l13) || p8.Intersects(l14) || p8.Intersects(l15) || p8.Intersects(l16) || p8.Intersects(l17) || p8.Intersects(l18) || p8.Intersects(l19) || p8.Intersects(l20))
            //{
            //    logSpeed *= -1;
            //}

            //if (p9.Intersects(g1) || p9.Intersects(g2) || p9.Intersects(g3) || p9.Intersects(g4) || p9.Intersects(g5) || p9.Intersects(g1) || p9.Intersects(g6) || p9.Intersects(g7) || p9.Intersects(g8) || p9.Intersects(l1) || p9.Intersects(l2) || p9.Intersects(l3) || p9.Intersects(l4) || p9.Intersects(l5) || p9.Intersects(l1) || p9.Intersects(l6) || p9.Intersects(l7) || p9.Intersects(l8) || p9.Intersects(l9) || p9.Intersects(l10) || p9.Intersects(l11) || p9.Intersects(l12) || p9.Intersects(l13) || p9.Intersects(l14) || p9.Intersects(l15) || p9.Intersects(l16) || p9.Intersects(l17) || p9.Intersects(l18) || p9.Intersects(l19) || p9.Intersects(l20))
            //{
            //    logSpeed *= -1;
            //}

            //if (p10.Intersects(g1) || p10.Intersects(g2) || p10.Intersects(g3) || p10.Intersects(g4) || p10.Intersects(g5) || p10.Intersects(g1) || p10.Intersects(g6) || p10.Intersects(g7) || p10.Intersects(g8) || p10.Intersects(l1) || p10.Intersects(l2) || p10.Intersects(l3) || p10.Intersects(l4) || p10.Intersects(l5) || p10.Intersects(l1) || p10.Intersects(l6) || p10.Intersects(l7) || p10.Intersects(l8) || p10.Intersects(l9) || p10.Intersects(l10) || p10.Intersects(l11) || p10.Intersects(l12) || p10.Intersects(l13) || p10.Intersects(l14) || p10.Intersects(l15) || p10.Intersects(l16) || p10.Intersects(l17) || p10.Intersects(l18) || p10.Intersects(l19) || p10.Intersects(l20))
            //{
            //    logSpeed *= -1;
            //}

            ////-------

            //if (p11.Intersects(g1) || p11.Intersects(g2) || p11.Intersects(g3) || p11.Intersects(g4) || p11.Intersects(g5) || p11.Intersects(g1) || p11.Intersects(g6) || p11.Intersects(g7) || p11.Intersects(g8) || p11.Intersects(l1) || p11.Intersects(l2) || p11.Intersects(l3) || p11.Intersects(l4) || p11.Intersects(l5) || p11.Intersects(l1) || p11.Intersects(l6) || p11.Intersects(l7) || p11.Intersects(l8) || p11.Intersects(l9) || p11.Intersects(l10) || p11.Intersects(l11) || p11.Intersects(l12) || p11.Intersects(l13) || p11.Intersects(l14) || p11.Intersects(l15) || p11.Intersects(l16) || p11.Intersects(l17) || p11.Intersects(l18) || p11.Intersects(l19) || p11.Intersects(l20))
            //{
            //    logSpeed *= -1;
            //}

            //if (p12.Intersects(g1) || p12.Intersects(g2) || p12.Intersects(g3) || p12.Intersects(g4) || p12.Intersects(g5) || p12.Intersects(g1) || p12.Intersects(g6) || p12.Intersects(g7) || p12.Intersects(g8) || p12.Intersects(l1) || p12.Intersects(l2) || p12.Intersects(l3) || p12.Intersects(l4) || p12.Intersects(l5) || p12.Intersects(l1) || p12.Intersects(l6) || p12.Intersects(l7) || p12.Intersects(l8) || p12.Intersects(l9) || p12.Intersects(l10) || p12.Intersects(l11) || p12.Intersects(l12) || p12.Intersects(l13) || p12.Intersects(l14) || p12.Intersects(l15) || p12.Intersects(l16) || p12.Intersects(l17) || p12.Intersects(l18) || p12.Intersects(l19) || p12.Intersects(l20))
            //{
            //    logSpeed *= -1;
            //}

            //if (p13.Intersects(g1) || p13.Intersects(g2) || p13.Intersects(g3) || p13.Intersects(g4) || p13.Intersects(g5) || p13.Intersects(g1) || p13.Intersects(g6) || p13.Intersects(g7) || p13.Intersects(g8) || p13.Intersects(l1) || p13.Intersects(l2) || p13.Intersects(l3) || p13.Intersects(l4) || p13.Intersects(l5) || p13.Intersects(l1) || p13.Intersects(l6) || p13.Intersects(l7) || p13.Intersects(l8) || p13.Intersects(l9) || p13.Intersects(l10) || p13.Intersects(l11) || p13.Intersects(l12) || p13.Intersects(l13) || p13.Intersects(l14) || p13.Intersects(l15) || p13.Intersects(l16) || p13.Intersects(l17) || p13.Intersects(l18) || p13.Intersects(l19) || p13.Intersects(l20))
            //{
            //    logSpeed *= -1;
            //}

            //if (p14.Intersects(g1) || p14.Intersects(g2) || p14.Intersects(g3) || p14.Intersects(g4) || p14.Intersects(g5) || p14.Intersects(g1) || p14.Intersects(g6) || p14.Intersects(g7) || p14.Intersects(g8) || p14.Intersects(l1) || p14.Intersects(l2) || p14.Intersects(l3) || p14.Intersects(l4) || p14.Intersects(l5) || p14.Intersects(l1) || p14.Intersects(l6) || p14.Intersects(l7) || p14.Intersects(l8) || p14.Intersects(l9) || p14.Intersects(l10) || p14.Intersects(l11) || p14.Intersects(l12) || p14.Intersects(l13) || p14.Intersects(l14) || p14.Intersects(l15) || p14.Intersects(l16) || p14.Intersects(l17) || p14.Intersects(l18) || p14.Intersects(l19) || p14.Intersects(l20))
            //{
            //    logSpeed *= -1;
            //}

            //if (p15.Intersects(g1) || p15.Intersects(g2) || p15.Intersects(g3) || p15.Intersects(g4) || p15.Intersects(g5) || p15.Intersects(g1) || p15.Intersects(g6) || p15.Intersects(g7) || p15.Intersects(g8) || p15.Intersects(l1) || p15.Intersects(l2) || p15.Intersects(l3) || p15.Intersects(l4) || p15.Intersects(l5) || p15.Intersects(l1) || p15.Intersects(l6) || p15.Intersects(l7) || p15.Intersects(l8) || p15.Intersects(l9) || p15.Intersects(l10) || p15.Intersects(l11) || p15.Intersects(l12) || p15.Intersects(l13) || p15.Intersects(l14) || p15.Intersects(l15) || p15.Intersects(l16) || p15.Intersects(l17) || p15.Intersects(l18) || p15.Intersects(l19) || p15.Intersects(l20))
            //{
            //    logSpeed *= -1;
            //}

            ////------------

            //if (p16.Intersects(g1) || p16.Intersects(g2) || p16.Intersects(g3) || p16.Intersects(g4) || p16.Intersects(g5) || p16.Intersects(g1) || p16.Intersects(g6) || p16.Intersects(g7) || p16.Intersects(g8) || p16.Intersects(l1) || p16.Intersects(l2) || p16.Intersects(l3) || p16.Intersects(l4) || p16.Intersects(l5) || p16.Intersects(l1) || p16.Intersects(l6) || p16.Intersects(l7) || p16.Intersects(l8) || p16.Intersects(l9) || p16.Intersects(l10) || p16.Intersects(l11) || p16.Intersects(l12) || p16.Intersects(l13) || p16.Intersects(l14) || p16.Intersects(l15) || p16.Intersects(l16) || p16.Intersects(l17) || p16.Intersects(l18) || p16.Intersects(l19) || p16.Intersects(l20))
            //{
            //    logSpeed *= -1;
            //}

            //if (p17.Intersects(g1) || p17.Intersects(g2) || p17.Intersects(g3) || p17.Intersects(g4) || p17.Intersects(g5) || p17.Intersects(g1) || p17.Intersects(g6) || p17.Intersects(g7) || p17.Intersects(g8) || p17.Intersects(l1) || p17.Intersects(l2) || p17.Intersects(l3) || p17.Intersects(l4) || p17.Intersects(l5) || p17.Intersects(l1) || p17.Intersects(l6) || p17.Intersects(l7) || p17.Intersects(l8) || p17.Intersects(l9) || p17.Intersects(l10) || p17.Intersects(l11) || p17.Intersects(l12) || p17.Intersects(l13) || p17.Intersects(l14) || p17.Intersects(l15) || p17.Intersects(l16) || p17.Intersects(l17) || p17.Intersects(l18) || p17.Intersects(l19) || p17.Intersects(l20))
            //{
            //    logSpeed *= -1;
            //}

            //if (p18.Intersects(g1) || p18.Intersects(g2) || p18.Intersects(g3) || p18.Intersects(g4) || p18.Intersects(g5) || p18.Intersects(g1) || p18.Intersects(g6) || p18.Intersects(g7) || p18.Intersects(g8) || p18.Intersects(l1) || p18.Intersects(l2) || p18.Intersects(l3) || p18.Intersects(l4) || p18.Intersects(l5) || p18.Intersects(l1) || p18.Intersects(l6) || p18.Intersects(l7) || p18.Intersects(l8) || p18.Intersects(l9) || p18.Intersects(l10) || p18.Intersects(l11) || p18.Intersects(l12) || p18.Intersects(l13) || p18.Intersects(l14) || p18.Intersects(l15) || p18.Intersects(l16) || p18.Intersects(l17) || p18.Intersects(l18) || p18.Intersects(l19) || p18.Intersects(l20))
            //{
            //    logSpeed *= -1;
            //}

            //if (p19.Intersects(g1) || p19.Intersects(g2) || p19.Intersects(g3) || p19.Intersects(g4) || p19.Intersects(g5) || p19.Intersects(g1) || p19.Intersects(g6) || p19.Intersects(g7) || p19.Intersects(g8) || p19.Intersects(l1) || p19.Intersects(l2) || p19.Intersects(l3) || p19.Intersects(l4) || p19.Intersects(l5) || p19.Intersects(l1) || p19.Intersects(l6) || p19.Intersects(l7) || p19.Intersects(l8) || p19.Intersects(l9) || p19.Intersects(l10) || p19.Intersects(l11) || p19.Intersects(l12) || p19.Intersects(l13) || p19.Intersects(l14) || p19.Intersects(l15) || p19.Intersects(l16) || p19.Intersects(l17) || p19.Intersects(l18) || p19.Intersects(l19) || p19.Intersects(l20))
            //{
            //    logSpeed *= -1;
            //}

            //if (p20.Intersects(g1) || p20.Intersects(g2) || p20.Intersects(g3) || p20.Intersects(g4) || p20.Intersects(g5) || p20.Intersects(g1) || p20.Intersects(g6) || p20.Intersects(g7) || p20.Intersects(g8) || p20.Intersects(l1) || p20.Intersects(l2) || p20.Intersects(l3) || p20.Intersects(l4) || p20.Intersects(l5) || p20.Intersects(l1) || p20.Intersects(l6) || p20.Intersects(l7) || p20.Intersects(l8) || p20.Intersects(l9) || p20.Intersects(l10) || p20.Intersects(l11) || p20.Intersects(l12) || p20.Intersects(l13) || p20.Intersects(l14) || p20.Intersects(l15) || p20.Intersects(l16) || p20.Intersects(l17) || p20.Intersects(l18) || p20.Intersects(l19) || p20.Intersects(l20))
            //{
            //    logSpeed *= -1;
            //}

            //if (p21.Intersects(g1) || p21.Intersects(g2) || p21.Intersects(g3) || p21.Intersects(g4) || p21.Intersects(g5) || p21.Intersects(g1) || p21.Intersects(g6) || p21.Intersects(g7) || p21.Intersects(g8) || p21.Intersects(l1) || p21.Intersects(l2) || p21.Intersects(l3) || p21.Intersects(l4) || p21.Intersects(l5) || p21.Intersects(l1) || p21.Intersects(l6) || p21.Intersects(l7) || p21.Intersects(l8) || p21.Intersects(l9) || p21.Intersects(l10) || p21.Intersects(l11) || p21.Intersects(l12) || p21.Intersects(l13) || p21.Intersects(l14) || p21.Intersects(l15) || p21.Intersects(l16) || p21.Intersects(l17) || p21.Intersects(l18) || p21.Intersects(l19) || p21.Intersects(l20))
            //{
            //    logSpeed *= -1;
            //}

            //if (p22.Intersects(g1) || p22.Intersects(g2) || p22.Intersects(g3) || p22.Intersects(g4) || p22.Intersects(g5) || p22.Intersects(g1) || p22.Intersects(g6) || p22.Intersects(g7) || p22.Intersects(g8) || p22.Intersects(l1) || p22.Intersects(l2) || p22.Intersects(l3) || p22.Intersects(l4) || p22.Intersects(l5) || p22.Intersects(l1) || p22.Intersects(l6) || p22.Intersects(l7) || p22.Intersects(l8) || p22.Intersects(l9) || p22.Intersects(l10) || p22.Intersects(l11) || p22.Intersects(l12) || p22.Intersects(l13) || p22.Intersects(l14) || p22.Intersects(l15) || p22.Intersects(l16) || p22.Intersects(l17) || p22.Intersects(l18) || p22.Intersects(l19) || p22.Intersects(l20))
            //{
            //    logSpeed *= -1;
            //}

            //if (p23.Intersects(g1) || p23.Intersects(g2) || p23.Intersects(g3) || p23.Intersects(g4) || p23.Intersects(g5) || p23.Intersects(g1) || p23.Intersects(g6) || p23.Intersects(g7) || p23.Intersects(g8) || p23.Intersects(l1) || p23.Intersects(l2) || p23.Intersects(l3) || p23.Intersects(l4) || p23.Intersects(l5) || p23.Intersects(l1) || p23.Intersects(l6) || p23.Intersects(l7) || p23.Intersects(l8) || p23.Intersects(l9) || p23.Intersects(l10) || p23.Intersects(l11) || p23.Intersects(l12) || p23.Intersects(l13) || p23.Intersects(l14) || p23.Intersects(l15) || p23.Intersects(l16) || p23.Intersects(l17) || p23.Intersects(l18) || p23.Intersects(l19) || p23.Intersects(l20))
            //{
            //    logSpeed *= -1;
            //}

            //if (p24.Intersects(g1) || p24.Intersects(g2) || p24.Intersects(g3) || p24.Intersects(g4) || p24.Intersects(g5) || p24.Intersects(g1) || p24.Intersects(g6) || p24.Intersects(g7) || p24.Intersects(g8) || p24.Intersects(l1) || p24.Intersects(l2) || p24.Intersects(l3) || p24.Intersects(l4) || p24.Intersects(l5) || p24.Intersects(l1) || p24.Intersects(l6) || p24.Intersects(l7) || p24.Intersects(l8) || p24.Intersects(l9) || p24.Intersects(l10) || p24.Intersects(l11) || p24.Intersects(l12) || p24.Intersects(l13) || p24.Intersects(l14) || p24.Intersects(l15) || p24.Intersects(l16) || p24.Intersects(l17) || p24.Intersects(l18) || p24.Intersects(l19) || p24.Intersects(l20))
            //{
            //    logSpeed *= -1;
            //}


        }

        protected void playerHitsIronFence()
        {
            Rectangle p1 = new Rectangle((int)fencePos1.X + 10, (int)fencePos1.Y + 10, ironFence.Width - 10, ironFence.Height - 10);
            Rectangle p2 = new Rectangle((int)fencePos2.X, (int)fencePos2.Y, ironFence.Width - 10, ironFence.Height);
            Rectangle p3 = new Rectangle((int)fencePos3.X, (int)fencePos3.Y, ironFence.Width - 10, ironFence.Height);
            Rectangle p4 = new Rectangle((int)fencePos4.X, (int)fencePos4.Y, ironFence.Width - 10, ironFence.Height);
            Rectangle p5 = new Rectangle((int)fencePos5.X, (int)fencePos5.Y, ironFence.Width - 10, ironFence.Height);

            Rectangle p6 = new Rectangle((int)fencePos6.X, (int)fencePos6.Y, ironFence.Width, ironFence.Height);
            Rectangle p7 = new Rectangle((int)fencePos7.X, (int)fencePos7.Y, ironFence.Width - 10, ironFence.Height);
            Rectangle p8 = new Rectangle((int)fencePos8.X, (int)fencePos8.Y, ironFence.Width - 10, ironFence.Height);
            Rectangle p9 = new Rectangle((int)fencePos9.X, (int)fencePos9.Y, ironFence.Width - 10, ironFence.Height);
            Rectangle p10 = new Rectangle((int)fencePos10.X, (int)fencePos10.Y, ironFence.Width - 10, ironFence.Height);
            Rectangle p17 = new Rectangle((int)fencePos17.X, (int)fencePos17.Y, ironFence.Width - 10, ironFence.Height);
            Rectangle p18 = new Rectangle((int)fencePos18.X, (int)fencePos18.Y, ironFence.Width - 10, ironFence.Height);

            Rectangle p11 = new Rectangle((int)fencePos11.X, (int)fencePos11.Y, ironFence.Width - 10, ironFence.Height);
            Rectangle p12 = new Rectangle((int)fencePos12.X, (int)fencePos12.Y, ironFence.Width, ironFence.Height);
            Rectangle p13 = new Rectangle((int)fencePos13.X, (int)fencePos13.Y, ironFence.Width - 10, ironFence.Height);
            Rectangle p14 = new Rectangle((int)fencePos14.X, (int)fencePos14.Y, ironFence.Width - 10, ironFence.Height);
            Rectangle p15 = new Rectangle((int)fencePos15.X, (int)fencePos15.Y, ironFence.Width - 10, ironFence.Height);
            Rectangle p16 = new Rectangle((int)fencePos16.X, (int)fencePos16.Y, ironFence.Width - 10, ironFence.Height);

            Rectangle h = new Rectangle((int)heroPosition.X, (int)heroPosition.Y, hero.Width / 2, hero.Height / 4);

            KeyboardState kk = Keyboard.GetState();


            if ((h.Intersects(p1) || h.Intersects(p2) || h.Intersects(p11) || h.Intersects(p17) || h.Intersects(p18) || h.Intersects(p12) || h.Intersects(p13) || h.Intersects(p14) || h.Intersects(p15) || h.Intersects(p16) || h.Intersects(p3) || h.Intersects(p4) || h.Intersects(p5) || h.Intersects(p6) || h.Intersects(p7) || h.Intersects(p8) || h.Intersects(p9) || h.Intersects(p10)) && kk.IsKeyUp(Keys.A))
            {
                playerDied = true;
                tryCount += 1;
                heroPosition = new Vector2(60412, 0);
            }

        }

        protected void playerHitsSnake()
        {
            Rectangle p1 = new Rectangle((int)snakePos1.X, (int)snakePos1.Y, snakeReverse.Width / 3, snakeReverse.Height / 3);
            Rectangle p2 = new Rectangle((int)snakePos2.X, (int)snakePos2.Y, snakeReverse.Width / 3, snakeReverse.Height / 3);
            Rectangle p3 = new Rectangle((int)snakePos3.X, (int)snakePos3.Y, snakeReverse.Width / 3, snakeReverse.Height / 3);
            Rectangle p4 = new Rectangle((int)snakePos4.X, (int)snakePos4.Y, snakeReverse.Width / 3, snakeReverse.Height / 3);
            Rectangle p5 = new Rectangle((int)snakePos5.X, (int)snakePos5.Y, snakeReverse.Width / 3, snakeReverse.Height / 3);
            Rectangle p6 = new Rectangle((int)snakePos6.X, (int)snakePos6.Y, snakeReverse.Width / 3, snakeReverse.Height / 3);
            Rectangle p7 = new Rectangle((int)snakePos7.X, (int)snakePos7.Y, snakeReverse.Width / 3, snakeReverse.Height / 3);
            Rectangle p8 = new Rectangle((int)snakePos8.X, (int)snakePos8.Y, snakeReverse.Width / 3, snakeReverse.Height / 3);


            Rectangle h = new Rectangle((int)heroPosition.X, (int)heroPosition.Y, hero.Width / 2, hero.Height / 4);

            KeyboardState kk = Keyboard.GetState();


            if ((h.Intersects(p1) || h.Intersects(p2) || h.Intersects(p3) || h.Intersects(p4) || h.Intersects(p5) || h.Intersects(p6) || h.Intersects(p7) || h.Intersects(p8)) && kk.IsKeyUp(Keys.A))
            {
                playerDied = true;
                tryCount += 1;
                heroPosition = new Vector2(60412, 0);
            }

        }


        protected void playerHitsTiger()
        {
            Rectangle p1 = new Rectangle((int)tigerPos1.X, (int)tigerPos1.Y, tigerRev.Width / 2, tigerRev.Height / 2);
            Rectangle p2 = new Rectangle((int)tigerPos2.X, (int)tigerPos2.Y, tigerDarkRev.Width / 2, tigerDarkRev.Height / 2);
            Rectangle p3 = new Rectangle((int)tigerPos3.X, (int)tigerPos3.Y, tigerDarkRev.Width / 2, tigerDarkRev.Height / 2);
            Rectangle p4 = new Rectangle((int)tigerPos4.X, (int)tigerPos4.Y, tigerDarkRev.Width / 2, tigerDarkRev.Height / 2);



            Rectangle h = new Rectangle((int)heroPosition.X, (int)heroPosition.Y, hero.Width / 2, hero.Height / 4);

            KeyboardState kk = Keyboard.GetState();


            if ((h.Intersects(p1) || h.Intersects(p2) || h.Intersects(p3) || h.Intersects(p4)) && kk.IsKeyUp(Keys.A))
            {
                playerDied = true;
                tryCount += 1;
                heroPosition = new Vector2(60412, 0);
            }

        }

        protected bool playerHitsMushroom()
        {
            Rectangle p1 = new Rectangle((int)mushPos1.X, (int)mushPos1.Y, mushroom.Width, mushroom.Height);
            Rectangle p2 = new Rectangle((int)mushPos2.X, (int)mushPos2.Y, mushroom.Width, mushroom.Height);
            Rectangle p3 = new Rectangle((int)mushPos3.X, (int)mushPos3.Y, mushroom.Width, mushroom.Height);
            Rectangle p4 = new Rectangle((int)mushPos4.X, (int)mushPos4.Y, mushroom.Width, mushroom.Height);
            Rectangle p5 = new Rectangle((int)mushPos5.X, (int)mushPos5.Y, mushroom.Width, mushroom.Height);
            Rectangle p6 = new Rectangle((int)mushPos6.X, (int)mushPos6.Y, mushroom.Width, mushroom.Height);


            Rectangle h = new Rectangle((int)heroPosition.X, (int)heroPosition.Y, hero.Width / 2, hero.Height / 4);

            if (h.Intersects(p1) || h.Intersects(p2) || h.Intersects(p3) || h.Intersects(p4) || h.Intersects(p5) || h.Intersects(p6))
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        protected bool playerHitsRedMushroom()
        {
            Rectangle p1 = new Rectangle((int)redMushroomPos.X, (int)redMushroomPos.Y, redMushroom.Width, redMushroom.Height);

            Rectangle h = new Rectangle((int)heroPosition.X, (int)heroPosition.Y, hero.Width / 2, hero.Height / 4);

            if (h.Intersects(p1))
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        public bool playerHitsCloud()
        {
            Rectangle cloud1 = new Rectangle((int)cloudPos1.X, (int)cloudPos1.Y, cloud.Width, cloud.Height);
            //Rectangle cloud2 = new Rectangle((int)cloudPos2.X, (int)cloudPos2.Y, cloud.Width, cloud.Height);
            Rectangle cloud3 = new Rectangle((int)cloudPos3.X, (int)cloudPos3.Y, cloud.Width, cloud.Height);
            Rectangle cloud4 = new Rectangle((int)cloudPos4.X, (int)cloudPos4.Y, cloud.Width, cloud.Height);

            Rectangle player = new Rectangle((int)heroPosition.X, (int)heroPosition.Y, hero.Width / 2, hero.Height / 4);

            if (player.Intersects(cloud1) || /* player.Intersects(cloud2) || */ player.Intersects(cloud3) || player.Intersects(cloud4))
                return true;
            else
                return false;
        }

        public bool playerHitsLastCloud()
        {
            Rectangle cloud2 = new Rectangle((int)cloudPos2.X, (int)cloudPos2.Y, cloud.Width, cloud.Height);
            Rectangle player = new Rectangle((int)heroPosition.X, (int)heroPosition.Y, hero.Width / 2, hero.Height / 4);

            if (player.Intersects(cloud2))
                return true;
            else
                return false;
        }

        public bool cloudHitsBlock()
        {
            Rectangle cloud2 = new Rectangle((int)cloudPos4.X, (int)cloudPos4.Y, cloud.Width, cloud.Height);
            Rectangle b1 = new Rectangle((int)smallBlockPos50.X, (int)smallBlockPos50.Y, smallBlock.Width, smallBlock.Height);
            Rectangle b2 = new Rectangle((int)smallBlockPos51.X, (int)smallBlockPos51.Y, smallBlock.Width, smallBlock.Height);


            if (cloud2.Intersects(b1) || cloud2.Intersects(b2))
                return true;
            else
                return false;
        }


        protected bool movingBlockhitsBlock()
        {
            Rectangle b1 = new Rectangle((int)smallBlockPos46.X, (int)smallBlockPos46.Y, smallBlock.Width, smallBlock.Height);
            Rectangle b2 = new Rectangle((int)smallBlockPos47.X, (int)smallBlockPos47.Y, smallBlock.Width, smallBlock.Height);
            Rectangle b3 = new Rectangle((int)smallBlockPos46.X, (int)smallBlockPos46.Y, smallBlock.Width, smallBlock.Height);
            Rectangle b4 = new Rectangle((int)smallBlockPos47.X, (int)smallBlockPos47.Y, smallBlock.Width, smallBlock.Height);

            Rectangle h1 = new Rectangle((int)lvl3blockPos30.X, (int)lvl3blockPos30.Y, lvl3block.Width, lvl3block.Height);
            Rectangle h2 = new Rectangle((int)lvl3blockPos33.X, (int)lvl3blockPos33.Y, lvl3block.Width, lvl3block.Height);

            if ((h1.Intersects(b1) || h1.Intersects(b2)) || (h2.Intersects(b3) || h2.Intersects(b4)))
                return true;
            else
                return false;



        }

        protected bool playerHitsWater()
        {
            Rectangle p1 = new Rectangle((int)waterPos1.X, (int)waterPos1.Y, water.Width / 2, water.Height / 2);
            Rectangle p2 = new Rectangle((int)waterPos2.X, (int)waterPos2.Y, water.Width / 2, water.Height / 2);
            Rectangle p3 = new Rectangle((int)waterPos3.X, (int)waterPos3.Y, water.Width / 2, water.Height / 2);
            Rectangle p4 = new Rectangle((int)waterPos4.X, (int)waterPos4.Y, water.Width / 2, water.Height / 2);
            Rectangle p5 = new Rectangle((int)waterPos5.X, (int)waterPos5.Y, water.Width / 2, water.Height / 2);

            Rectangle p6 = new Rectangle((int)waterPos6.X, (int)waterPos6.Y, water.Width / 2, water.Height / 2);
            Rectangle p7 = new Rectangle((int)waterPos7.X, (int)waterPos7.Y, water.Width / 2, water.Height / 2);
            Rectangle p8 = new Rectangle((int)waterPos8.X, (int)waterPos8.Y, water.Width / 2, water.Height / 2);
            Rectangle p9 = new Rectangle((int)waterPos9.X, (int)waterPos9.Y, water.Width / 2, water.Height / 2);
            Rectangle p10 = new Rectangle((int)waterPos10.X, (int)waterPos10.Y, water.Width / 2, water.Height / 2);

            Rectangle h = new Rectangle((int)heroPosition.X, (int)heroPosition.Y, hero.Width / 2, hero.Height / 4);


            if (h.Intersects(p1) || h.Intersects(p2) || h.Intersects(p3) || h.Intersects(p4) || h.Intersects(p5) || h.Intersects(p6) || h.Intersects(p7) || h.Intersects(p8) || h.Intersects(p9) || h.Intersects(p10))
            {

                return true;
            }
            else
                return false;
        }

        protected bool playerHitsLevel3Block()
        {
            Rectangle RS1 = new Rectangle((int)lvl3blockPos1.X, (int)lvl3blockPos1.Y, lvl3block.Width, lvl3block.Height);
            Rectangle RS2 = new Rectangle((int)lvl3blockPos2.X, (int)lvl3blockPos2.Y, lvl3block.Width, lvl3block.Height);
            Rectangle RS3 = new Rectangle((int)lvl3blockPos3.X, (int)lvl3blockPos3.Y, lvl3block.Width, lvl3block.Height);
            Rectangle RS4 = new Rectangle((int)lvl3blockPos4.X, (int)lvl3blockPos4.Y, lvl3block.Width, lvl3block.Height);
            Rectangle RS5 = new Rectangle((int)lvl3blockPos5.X, (int)lvl3blockPos5.Y, lvl3block.Width, lvl3block.Height);
            Rectangle RS6 = new Rectangle((int)lvl3blockPos6.X, (int)lvl3blockPos6.Y, lvl3block.Width, lvl3block.Height);
            Rectangle RS7 = new Rectangle((int)lvl3blockPos7.X, (int)lvl3blockPos7.Y, lvl3block.Width, lvl3block.Height);
            Rectangle RS8 = new Rectangle((int)lvl3blockPos8.X, (int)lvl3blockPos8.Y, lvl3block.Width, lvl3block.Height);
            Rectangle RS9 = new Rectangle((int)lvl3blockPos9.X, (int)lvl3blockPos9.Y, lvl3block.Width, lvl3block.Height);
            Rectangle RS10 = new Rectangle((int)lvl3blockPos10.X, (int)lvl3blockPos10.Y, lvl3block.Width, lvl3block.Height);
            Rectangle RS11 = new Rectangle((int)lvl3blockPos11.X, (int)lvl3blockPos12.Y, lvl3block.Width, lvl3block.Height);
            Rectangle RS12 = new Rectangle((int)lvl3blockPos12.X, (int)lvl3blockPos12.Y, lvl3block.Width, lvl3block.Height);
            Rectangle RS13 = new Rectangle((int)lvl3blockPos13.X, (int)lvl3blockPos13.Y, lvl3block.Width, lvl3block.Height);
            Rectangle RS14 = new Rectangle((int)lvl3blockPos14.X, (int)lvl3blockPos14.Y, lvl3block.Width, lvl3block.Height);
            Rectangle RS15 = new Rectangle((int)lvl3blockPos15.X, (int)lvl3blockPos15.Y, lvl3block.Width, lvl3block.Height);
            Rectangle RS16 = new Rectangle((int)lvl3blockPos16.X, (int)lvl3blockPos16.Y, lvl3block.Width, lvl3block.Height);
            Rectangle RS17 = new Rectangle((int)lvl3blockPos17.X, (int)lvl3blockPos17.Y, lvl3block.Width, lvl3block.Height);
            Rectangle RS18 = new Rectangle((int)lvl3blockPos18.X, (int)lvl3blockPos18.Y, lvl3block.Width, lvl3block.Height);
            Rectangle RS19 = new Rectangle((int)lvl3blockPos19.X, (int)lvl3blockPos19.Y, lvl3block.Width, lvl3block.Height);
            Rectangle RS20 = new Rectangle((int)lvl3blockPos20.X, (int)lvl3blockPos20.Y, lvl3block.Width, lvl3block.Height);
            Rectangle RS21 = new Rectangle((int)lvl3blockPos21.X, (int)lvl3blockPos21.Y, lvl3block.Width, lvl3block.Height);
            Rectangle RS22 = new Rectangle((int)lvl3blockPos22.X, (int)lvl3blockPos22.Y, lvl3block.Width, lvl3block.Height);
            Rectangle RS23 = new Rectangle((int)lvl3blockPos23.X, (int)lvl3blockPos23.Y, lvl3block.Width, lvl3block.Height);
            Rectangle RS24 = new Rectangle((int)lvl3blockPos24.X, (int)lvl3blockPos24.Y, lvl3block.Width, lvl3block.Height);
            Rectangle RS25 = new Rectangle((int)lvl3blockPos25.X, (int)lvl3blockPos25.Y, lvl3block.Width, lvl3block.Height);
            Rectangle RS26 = new Rectangle((int)lvl3blockPos26.X, (int)lvl3blockPos26.Y, lvl3block.Width, lvl3block.Height);
            Rectangle RS27 = new Rectangle((int)lvl3blockPos27.X, (int)lvl3blockPos27.Y, lvl3block.Width, lvl3block.Height);
            Rectangle RS28 = new Rectangle((int)lvl3blockPos28.X, (int)lvl3blockPos28.Y, lvl3block.Width, lvl3block.Height);
            Rectangle RS29 = new Rectangle((int)lvl3blockPos29.X, (int)lvl3blockPos29.Y, lvl3block.Width, lvl3block.Height);
            Rectangle RS30 = new Rectangle((int)lvl3blockPos30.X, (int)lvl3blockPos30.Y, lvl3block.Width, lvl3block.Height);
            Rectangle RS31 = new Rectangle((int)lvl3blockPos31.X, (int)lvl3blockPos31.Y, lvl3block.Width, lvl3block.Height);
            Rectangle RS32 = new Rectangle((int)lvl3blockPos32.X, (int)lvl3blockPos32.Y, lvl3block.Width, lvl3block.Height);
            Rectangle RS33 = new Rectangle((int)lvl3blockPos33.X, (int)lvl3blockPos33.Y, lvl3block.Width, lvl3block.Height);
            Rectangle RS34 = new Rectangle((int)lvl3blockPos34.X, (int)lvl3blockPos34.Y, lvl3block.Width, lvl3block.Height);
            Rectangle RS35 = new Rectangle((int)lvl3blockPos35.X, (int)lvl3blockPos35.Y, lvl3block.Width, lvl3block.Height);
            Rectangle RS36 = new Rectangle((int)lvl3blockPos36.X, (int)lvl3blockPos36.Y, lvl3block.Width, lvl3block.Height);
            Rectangle RS37 = new Rectangle((int)lvl3blockPos37.X, (int)lvl3blockPos37.Y, lvl3block.Width, lvl3block.Height);
            Rectangle RS38 = new Rectangle((int)lvl3blockPos38.X, (int)lvl3blockPos38.Y, lvl3block.Width, lvl3block.Height);


            Rectangle rs = new Rectangle((int)heroPosition.X, (int)heroPosition.Y, hero.Width / 2, hero.Height / 4);

            KeyboardState ty = Keyboard.GetState();
            if (rs.Intersects(RS1) || rs.Intersects(RS2) || rs.Intersects(RS3) || rs.Intersects(RS4) || rs.Intersects(RS5) || rs.Intersects(RS6) || rs.Intersects(RS7) || rs.Intersects(RS8) || rs.Intersects(RS9) || rs.Intersects(RS10) || rs.Intersects(RS11) || rs.Intersects(RS12) || rs.Intersects(RS13) || rs.Intersects(RS14) || rs.Intersects(RS15) || rs.Intersects(RS16) || rs.Intersects(RS17) || rs.Intersects(RS18) || rs.Intersects(RS19) || rs.Intersects(RS20) || rs.Intersects(RS21) || rs.Intersects(RS22) || rs.Intersects(RS23) || rs.Intersects(RS24) || rs.Intersects(RS25) || rs.Intersects(RS26) || rs.Intersects(RS27) || rs.Intersects(RS28) || rs.Intersects(RS29) || rs.Intersects(RS30) || rs.Intersects(RS31) || rs.Intersects(RS32) || rs.Intersects(RS33) || rs.Intersects(RS34) || rs.Intersects(RS35) || rs.Intersects(RS36) || rs.Intersects(RS37) || rs.Intersects(RS38))
                return true;
            else
                return false;
        }

        protected bool playerHitsSmallBlocksLEFT()
        {
            Rectangle RS1 = new Rectangle((int)smallBlockPos1.X, (int)smallBlockPos1.Y, smallBlock.Width, smallBlock.Height);
            Rectangle RS2 = new Rectangle((int)smallBlockPos2.X, (int)smallBlockPos2.Y, smallBlock.Width, smallBlock.Height);
            Rectangle RS3 = new Rectangle((int)smallBlockPos5.X, (int)smallBlockPos5.Y, smallBlock.Width, smallBlock.Height);
            Rectangle RS4 = new Rectangle((int)smallBlockPos6.X, (int)smallBlockPos6.Y, smallBlock.Width, smallBlock.Height);
            Rectangle RS5 = new Rectangle((int)smallBlockPos7.X, (int)smallBlockPos7.Y, smallBlock.Width, smallBlock.Height);
            Rectangle RS6 = new Rectangle((int)smallBlockPos11.X, (int)smallBlockPos11.Y, smallBlock.Width, smallBlock.Height);
            Rectangle RS7 = new Rectangle((int)smallBlockPos13.X, (int)smallBlockPos13.Y, smallBlock.Width, smallBlock.Height);
            Rectangle RS8 = new Rectangle((int)smallBlockPos15.X, (int)smallBlockPos15.Y, smallBlock.Width, smallBlock.Height);
            Rectangle RS9 = new Rectangle((int)smallBlockPos16.X, (int)smallBlockPos16.Y, smallBlock.Width, smallBlock.Height);
            Rectangle RS10 = new Rectangle((int)smallBlockPos17.X, (int)smallBlockPos17.Y, smallBlock.Width, smallBlock.Height);
            Rectangle RS11 = new Rectangle((int)smallBlockPos19.X, (int)smallBlockPos19.Y, smallBlock.Width, smallBlock.Height);
            Rectangle RS12 = new Rectangle((int)smallBlockPos20.X, (int)smallBlockPos20.Y, smallBlock.Width, smallBlock.Height);
            Rectangle RS13 = new Rectangle((int)smallBlockPos21.X, (int)smallBlockPos21.Y, smallBlock.Width, smallBlock.Height);
            Rectangle RS14 = new Rectangle((int)smallBlockPos22.X, (int)smallBlockPos22.Y, smallBlock.Width, smallBlock.Height);
            Rectangle RS15 = new Rectangle((int)smallBlockPos23.X, (int)smallBlockPos23.Y, smallBlock.Width, smallBlock.Height);
            Rectangle RS16 = new Rectangle((int)smallBlockPos24.X, (int)smallBlockPos24.Y, smallBlock.Width, smallBlock.Height);
            Rectangle RS17 = new Rectangle((int)smallBlockPos28.X, (int)smallBlockPos29.Y, smallBlock.Width, smallBlock.Height);
            Rectangle RS18 = new Rectangle((int)smallBlockPos29.X, (int)smallBlockPos29.Y, smallBlock.Width, smallBlock.Height);
            Rectangle RS19 = new Rectangle((int)smallBlockPos32.X, (int)smallBlockPos32.Y, smallBlock.Width, smallBlock.Height);
            Rectangle RS20 = new Rectangle((int)smallBlockPos33.X, (int)smallBlockPos33.Y, smallBlock.Width, smallBlock.Height);
            Rectangle RS21 = new Rectangle((int)smallBlockPos36.X, (int)smallBlockPos36.Y, smallBlock.Width, smallBlock.Height);
            Rectangle RS22 = new Rectangle((int)smallBlockPos38.X, (int)smallBlockPos38.Y, smallBlock.Width, smallBlock.Height);
            Rectangle RS23 = new Rectangle((int)smallBlockPos40.X, (int)smallBlockPos40.Y, smallBlock.Width, smallBlock.Height);
            Rectangle RS24 = new Rectangle((int)smallBlockPos42.X, (int)smallBlockPos42.Y, smallBlock.Width, smallBlock.Height);
            Rectangle RS25 = new Rectangle((int)smallBlockPos44.X, (int)smallBlockPos44.Y, smallBlock.Width, smallBlock.Height);



            Rectangle rs = new Rectangle((int)heroPosition.X, (int)heroPosition.Y, hero.Width / 2, hero.Height / 4);

            KeyboardState ty = Keyboard.GetState();
            if (rs.Intersects(RS1) || rs.Intersects(RS2) || rs.Intersects(RS3) || rs.Intersects(RS4) || rs.Intersects(RS5) || rs.Intersects(RS6) || rs.Intersects(RS7) || rs.Intersects(RS8) || rs.Intersects(RS9) || rs.Intersects(RS10) || rs.Intersects(RS11) || rs.Intersects(RS12) || rs.Intersects(RS13) || rs.Intersects(RS14) || rs.Intersects(RS15) || rs.Intersects(RS16) || rs.Intersects(RS17) || rs.Intersects(RS18) || rs.Intersects(RS19) || rs.Intersects(RS20) || rs.Intersects(RS21) || rs.Intersects(RS22) || rs.Intersects(RS23) || rs.Intersects(RS24) || rs.Intersects(RS25))
                return true;
            else
                return false;
        }

        protected bool playerHitsSmallBlocksRight()
        {
            Rectangle RS1 = new Rectangle((int)smallBlockPos3.X, (int)smallBlockPos3.Y, smallBlock.Width, smallBlock.Height);
            Rectangle RS2 = new Rectangle((int)smallBlockPos4.X, (int)smallBlockPos4.Y, smallBlock.Width, smallBlock.Height);
            Rectangle RS3 = new Rectangle((int)smallBlockPos8.X, (int)smallBlockPos8.Y, smallBlock.Width, smallBlock.Height);
            Rectangle RS4 = new Rectangle((int)smallBlockPos9.X, (int)smallBlockPos9.Y, smallBlock.Width, smallBlock.Height);
            Rectangle RS5 = new Rectangle((int)smallBlockPos10.X, (int)smallBlockPos10.Y, smallBlock.Width, smallBlock.Height);
            Rectangle RS6 = new Rectangle((int)smallBlockPos12.X, (int)smallBlockPos12.Y, smallBlock.Width, smallBlock.Height);
            Rectangle RS7 = new Rectangle((int)smallBlockPos14.X, (int)smallBlockPos14.Y, smallBlock.Width, smallBlock.Height);
            Rectangle RS8 = new Rectangle((int)smallBlockPos18.X, (int)smallBlockPos18.Y, smallBlock.Width, smallBlock.Height);
            Rectangle RS9 = new Rectangle((int)smallBlockPos25.X, (int)smallBlockPos25.Y, smallBlock.Width, smallBlock.Height);
            Rectangle RS10 = new Rectangle((int)smallBlockPos26.X, (int)smallBlockPos26.Y, smallBlock.Width, smallBlock.Height);
            Rectangle RS11 = new Rectangle((int)smallBlockPos27.X, (int)smallBlockPos27.Y, smallBlock.Width, smallBlock.Height);
            Rectangle RS12 = new Rectangle((int)smallBlockPos30.X, (int)smallBlockPos30.Y, smallBlock.Width, smallBlock.Height);
            Rectangle RS13 = new Rectangle((int)smallBlockPos31.X, (int)smallBlockPos31.Y, smallBlock.Width, smallBlock.Height);
            Rectangle RS14 = new Rectangle((int)smallBlockPos34.X, (int)smallBlockPos34.Y, smallBlock.Width, smallBlock.Height);
            Rectangle RS15 = new Rectangle((int)smallBlockPos35.X, (int)smallBlockPos35.Y, smallBlock.Width, smallBlock.Height);
            Rectangle RS16 = new Rectangle((int)smallBlockPos37.X, (int)smallBlockPos37.Y, smallBlock.Width, smallBlock.Height);
            Rectangle RS17 = new Rectangle((int)smallBlockPos39.X, (int)smallBlockPos39.Y, smallBlock.Width, smallBlock.Height);
            Rectangle RS18 = new Rectangle((int)smallBlockPos41.X, (int)smallBlockPos41.Y, smallBlock.Width, smallBlock.Height);
            Rectangle RS19 = new Rectangle((int)smallBlockPos43.X, (int)smallBlockPos43.Y, smallBlock.Width, smallBlock.Height);
            Rectangle RS20 = new Rectangle((int)smallBlockPos45.X, (int)smallBlockPos45.Y, smallBlock.Width, smallBlock.Height);


            Rectangle rs = new Rectangle((int)heroPosition.X, (int)heroPosition.Y, hero.Width / 2, hero.Height / 4);

            KeyboardState ty = Keyboard.GetState();
            if (rs.Intersects(RS1) || rs.Intersects(RS2) || rs.Intersects(RS3) || rs.Intersects(RS4) || rs.Intersects(RS5) || rs.Intersects(RS6) || rs.Intersects(RS7) || rs.Intersects(RS8) || rs.Intersects(RS9) || rs.Intersects(RS10) || rs.Intersects(RS11) || rs.Intersects(RS12) || rs.Intersects(RS13) || rs.Intersects(RS14) || rs.Intersects(RS15) || rs.Intersects(RS16) || rs.Intersects(RS17) || rs.Intersects(RS18) || rs.Intersects(RS19) || rs.Intersects(RS20))
                return true;
            else
                return false;
        }

        public bool getPowerCount()
        {
            if (powerUsageCount > 0)
                return true;
            else
                return false;
        }

        public bool isFailScreen()
        {
            if (heroPosition.X == 60412)
                return true;
            else
                return false;
        }

        public bool isLevel2Screen()
        {
            if (heroPosition.X == 56412)
            {
                powerUsageCount = 1200;
                return true;
            }
            else
                return false;
        }

        public bool isGameEndScreen()
        {
            if (heroPosition.X == 58412)
                return true;
            else
                return false;
        }

        public bool playerHitsSky()
        {
            Rectangle ground = new Rectangle((int)groundBlockPos20.X, (int)groundBlockPos20.Y, groundBlock.Width, groundBlock.Height);
            Rectangle player = new Rectangle((int)heroPosition.X, (int)heroPosition.Y, hero.Width / 2, hero.Height / 4);

            if (player.Intersects(ground))
                return true;
            else
                return false;
        }

        public bool isQuestScreen()
        {
            if (heroPosition.X == 62412)
                return true;
            else
                return false;
        }

        public bool isControolerScreen()
        {
            if (heroPosition.X == 66412)
                return true;
            else
                return false;
        }

        public bool isPausingScreen()
        {
            if (heroPosition.X == 68412)
                return true;
            else
                return false;
        }

        public bool isTuteScreen()
        {
            if (heroPosition.X == 64412)
                return true;
            else
                return false;
        }

        public bool isExitScreen()
        {
            if (heroPosition.X == 70412)
                return true;
            else
                return false;
        }

        public void nextLevel()
        {
            end = true;
        }


        public bool islevle2winScreen()
        {
            if (heroPosition.X == 72412)
                return true;
            else
                return false;
        }


        #endregion


    }
}
