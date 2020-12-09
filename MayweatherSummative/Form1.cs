using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;


namespace MayweatherSummative
{
    public partial class boxingGame : Form
    {
        Random ranGen = new Random();
        int scene = 1;
        SoundPlayer player = new SoundPlayer(Properties.Resources.Air_Horn_SoundBible_com_964603082);



        public boxingGame()
        {
            InitializeComponent();
        }

        private void BoxingGame_KeyDown(object sender, KeyEventArgs e)
        {
            imageBox.BackgroundImage = Properties.Resources.hi_res_98804bd5a0de8561a0829d96e3900b1e_crop_north;

            if (e.KeyCode == Keys.R)
            {
                if (scene == 1)
                {
                    scene = 3;
                }
                else if (scene == 2)
                {
                    scene = 4;
                }
                else if (scene == 3)
                {
                    scene = 7;
                }
                else if (scene == 4)
                {
                    scene = 9;
                }
                else if (scene == 5)
                {
                    scene = 17;
                }
                else if (scene == 6)
                {
                    scene = 10;
                }
                else if (scene == 7)
                {
                    scene = 11;
                }
                else if (scene == 8)
                {
                    scene = 13;
                }
                else if (scene == 9)
                {
                    scene = 15;
                }
                else if (scene == 10)
                {
                    scene = 36;
                }
                else if (scene == 11)
                {
                        int value = ranGen.Next(1, 101);
                        if (value > 80)
                        {
                            scene = 36;
                        }
                        else
                        {
                            scene = 19;
                        }
                }
                else if (scene == 12)
                {
                    scene = 33;
                }
                else if (scene == 13)
                {
                    scene = 20;
                }
                else if (scene == 14)
                {
                    Application.Exit();
                }
                else if (scene == 15)
                {
                    Application.Exit();
                }
                else if (scene == 16)
                {
                    scene = 22;
                }
                else if (scene == 17)
                {
                    scene = 24;
                }
                else if (scene == 18)
                {
                    scene = 27;
                }
                else if (scene == 19)
                {
                    scene = 29;
                }
                else if (scene == 20)
                {
                    scene = 36;
                }
                else if (scene == 21)
                {
                    int value = ranGen.Next(1, 101);
                    if (value < 50)
                    {
                        scene = 33;
                    }
                    else
                    {
                        scene = 36;
                    }
                }

                else if (scene == 22)
                {
                    scene = 36;
                }
                else if (scene == 23)
                {
                    scene = 33;
                }
                else if (scene == 24)
                {
                    scene = 36;
                }
                else if (scene == 25)
                {
                    scene = 33;
                }
                else if (scene == 26)
                {
                    scene = 30;
                }
                else if (scene == 27)
                {
                    scene = 36;
                }
                else if (scene == 28)
                {
                    scene = 33;
                }
                else if (scene == 29)
                {
                    scene = 36;
                }
                else if (scene == 30)
                {
                    scene = 36;
                }
                else if (scene == 31)
                {
                    scene = 33;
                }
                else if (scene == 32)
                {
                    Application.Exit();
                }
                else if (scene == 33)
                {
                    Application.Exit();
                }
                else if (scene == 34)
                {
                    Application.Exit();
                }
                else if (scene == 35)
                {
                    Application.Exit();
                }
                else if (scene == 36)
                {
                    Application.Exit();
                }
                else if (scene == 37)
                {
                    Application.Exit();
                }
                else if (scene == 38)
                {
                    Application.Exit();
                }
                else if (scene == 39)
                {
                    Application.Exit();
                }
                else if (scene == 40)
                {
                    Application.Exit();
                }
                else if (scene == 41)
                {
                    Application.Exit();
                }
                else if (scene == 42)
                {
                    Application.Exit();
                }
            }

            if (e.KeyCode == Keys.B)
            {
                if (scene == 1)
                {
                    scene = 2;
                }
                else if (scene == 2)
                {
                    scene = 5;
                }
                else if (scene == 3)
                {
                    scene = 6;
                }
                else if (scene == 4)
                {
                    scene = 8;
                }
                else if (scene == 5)
                {
                    scene = 16;
                }
                else if (scene == 6)
                {
                    scene = 18;
                }
                else if (scene == 7)
                {
                    scene = 19;
                }
                else if (scene == 8)
                {
                    scene = 12;
                }
                else if (scene == 9)
                {
                    scene = 14;
                }
                else if (scene == 10)
                {
                    scene = 35;
                }
                else if (scene == 11)
                {
                    scene = 35;
                }
                else if (scene == 12)
                {
                    scene = 32;
                }
                else if (scene == 13)
                {
                    scene = 21;
                }
                else if (scene == 14)
                {
                    scene = 1;
                }
                else if (scene == 15)
                {
                    scene = 1;
                }
                else if (scene == 16)
                {
                    scene = 23;
                }
                else if (scene == 17)
                {
                    scene = 25;
                }
                else if (scene == 18)
                {
                    scene = 26;
                }
                else if (scene == 19)
                {
                        int value = ranGen.Next(1, 101);
                        if (value < 80)
                        {
                            scene = 35;
                        }
                        else
                        {
                            scene = 28;
                        }
                }
                else if (scene == 20)
                {
                    scene = 35;
                }
                else if (scene == 21)
                {
                    Random ranGen = new Random();
                    int value = ranGen.Next (1, 101);

                    if (value < 50)
                    {
                        scene = 32;
                    }
                    else
                    {
                        scene = 35;
                    }
                }
                else if (scene == 24)
                {
                    scene = 35;
                }
                else if (scene == 25)
                {
                    scene = 32;
                }
                else if (scene == 26)
                {
                    scene = 31;
                }
                else if (scene == 27)
                {
                    scene = 35;
                }
                else if (scene == 28)
                {
                    scene = 32;
                }
                else if (scene == 29)
                {
                    scene = 35;
                }
                else if (scene == 30)
                {
                    scene = 35;
                }
                else if (scene == 31)
                {
                    scene = 32;
                }
                else if (scene == 32)
                {
                    scene = 1;
                }
                else if (scene == 33)
                {
                    scene = 1;
                }
                else if (scene == 34)
                {
                    scene = 1;
                }
                else if (scene == 35)
                {
                    scene = 1;
                }
                else if (scene == 36)
                {
                    scene = 1;
                }
                else if (scene == 37)
                {
                    scene = 1;
                }
                else if (scene == 38)
                {
                    scene = 1;

                }
                else if (scene == 39)
                {
                    scene = 1;
                }
                else if (scene == 40)
                {
                    scene = 1;
                }
                else if (scene == 41)
                {
                    scene = 1;
                }
                else if (scene == 42)
                {
                    scene = 1;
                }
            }

            if (e.KeyCode == Keys.G)
            {
                if (scene == 34)
                {
                    scene = 1;
                }
                else if (scene == 37)
                {
                    scene = 1;
                }
                if (scene == 21)
                {
                    int value = ranGen.Next(1, 101);
                    if (value < 50)
                    {
                        scene = 33;
                    }
                    else
                    {
                        scene = 36;
                    }
                }
            }

            switch (scene)
            {                
                case 1:                    
                    questionOutput.Text = "The ghallenger steps into the ring!, challenging Mayweather himself. The ref pulls you both to the center of the ring to touch gloves, do you touch gloves with Mayweather?";
                    blueOutput.Text = "Yes";
                    redOutput.Text = "No";
                    greenOutput.Text = "";
                    break;
                case 2:
                    questionOutput.Text = "You tap Mayweathers glove and go back to your corner. Coah asks whether your feeling agressive or if you want to play passivly.";
                    blueOutput.Text = "Go on the attack";
                    redOutput.Text = "Study your opponent slowly";
                    greenOutput.Text = "";
                    break;

                case 3:
                    player.Play();
                    questionOutput.Text = "You decide not to touch gloves. Mayweather gets pissed off. Your chances of winning just went down 40%. The fight starts and he comes after you fast with a right hook.";
                    blueOutput.Text = "Dodge Left";
                    redOutput.Text = "Dodge Right";
                    greenOutput.Text = "";
                    break;

                case 4:
                    player.Play();
                    questionOutput.Text = "You decide to play this passivley. Coach yells into the ring, giving you some advice. Your chances of winning just went up 30%. You square up to throw a punch.";
                    blueOutput.Text = "Uppercut";
                    redOutput.Text = "Hook";
                    greenOutput.Text = "";
                    break;

                case 5:
                    questionOutput.Text = "You go on the attack, he dodges your first punch and lands a good body shot.";
                    blueOutput.Text = "Attack";
                    redOutput.Text = "Retreat";
                    greenOutput.Text = "";
                    break;

                case 6:
                    questionOutput.Text = "You jump to the left just dodging the punch. Hold on, it's a combo. A flurry of punches are coming your way.";
                    blueOutput.Text = "Try to last until the end of the round";
                    redOutput.Text = "Jump out of the ring and forfeit the fight";
                    greenOutput.Text = "";
                    break;

                case 7:
                    questionOutput.Text = "You duck to the right in an attempt to escape. He lands an absolute bomb. Your chances of winning just went down 90%. He starts to close in knowing that you'rwe hurt. You can't see straight. He goes for an uppercut.";
                    blueOutput.Text = "Continue";
                    redOutput.Text = "";
                    greenOutput.Text = "";
                    break;

                case 8:
                    questionOutput.Text = "The uppercut lands on the chin. You hear the warning for 10 seconds left in the round";
                    blueOutput.Text = "Attack More";
                    redOutput.Text = "Stay Back";
                    greenOutput.Text = "";
                    break;

                case 9:
                    questionOutput.Text = "He ducked out of the way and countered with a hook to the body";
                    blueOutput.Text = "Dodge Left";
                    redOutput.Text = "Dodge Right";
                    greenOutput.Text = "";
                    break;

                case 10:
                    imageBox.BackgroundImage = Properties.Resources.professional_male_reporter_holding_microphone_isolated_white_background_30247218;
                    player.Play();
                    questionOutput.Text = "You jump out of the ring and forfeit the fight.\n\n\nReporter: How do you think the fight went today?";
                    blueOutput.Text = "Floyd is the best fighter in the world, everyone knows it and he proved it today";
                    redOutput.Text = "I think 99 times out of 100 I'd beat him. This was just that one lucky time for him";
                    greenOutput.Text = "I think this was the right outcome. Mayweather just has more skill in the ring";
                    break;

                case 11:
                    imageBox.BackgroundImage = Properties.Resources.hi_res_98804bd5a0de8561a0829d96e3900b1e_crop_north;
                    player.Play();
                    questionOutput.Text = "You didn't dodge the punch in time. You've been put in a coma for 3 weeks\n\n\nReporter: How do you think the fight went today?";
                    blueOutput.Text = "Floyd is the best fighter in the world, everyone knows it and he proved it today";
                    redOutput.Text = "I think 99 times out of 100 I'd beat him. This was just that one lucky time for him";
                    greenOutput.Text = "I think this was the right outcome. Mayweather just has more skill in the ring";
                    break;

                case 12:
                    imageBox.BackgroundImage = Properties.Resources.hi_res_98804bd5a0de8561a0829d96e3900b1e_crop_north;
                    player.Play();
                    questionOutput.Text = "You go after him before the end of the round putting him on the defensive. You land three good shots and on the fourth, Mayweather goes down hard. You knocked Floyd out.\n\n\nReporter: How do you think the fight went today?";
                    blueOutput.Text = "Honestly I think this was a fluke, I didn't expect this to happen and it shouldn't have happened at all";
                    redOutput.Text = "I think this was one of the easiest fights of my life. I had more trouble with Timmy in the 4th grade";
                    greenOutput.Text = "I think it went well Mayweather is a good fighter and I respect him";
                    break;

                case 13:
                    questionOutput.Text = "You decided to stay back and bought enouhg time for the round to end. Round 2 begins and Mayweather rushes you with his guard down, leaving a huge hook chance do you take it?";
                    blueOutput.Text = "Yes";
                    redOutput.Text = "No";
                    greenOutput.Text = "";
                    break;

                case 14:
                    imageBox.BackgroundImage = Properties.Resources.file_20200618_41200_1rtbime;
                    questionOutput.Text = "You dodge left and he throws a jab to your solar plexis, you feel a sharp pain and go down hard. You were rushed to the hospital and later die of internal bleeding. \n\n\n Would you like to play again?";
                    blueOutput.Text = "Yes";
                    redOutput.Text = "No";
                    greenOutput.Text = "";
                    break;

                case 15:
                    imageBox.BackgroundImage = Properties.Resources.file_20200618_41200_1rtbime;
                    questionOutput.Text = "You dodge right but he throws a right hook straight to your liver and you are rushed to the hospital and die of internal bleeding \n\n\n Would you like to play again?";
                    blueOutput.Text = "Yes";
                    redOutput.Text = "No";
                    greenOutput.Text = "";
                    break;

                case 16:
                    player.Play();
                    questionOutput.Text = "You attack him and land a jab right above the eye, cutting him badly just before the round ends. Coach is telling you that it would be a good idea to target his badly wounded eye when round 2 starts";
                    blueOutput.Text = "Go for the eye and try to get a T.K.O";
                    redOutput.Text = "Ignore coahes advice";
                    greenOutput.Text = "";
                    break;

                case 17:
                    questionOutput.Text = "You bought enough time while running away from Floyd to get to the 2nd round but it only mad him anrgy and he comes at you with everything hes got";
                    blueOutput.Text = "You fight back and catch him lacking and put him to sleep with an overhand haymaker. You've knocked him out";
                    redOutput.Text = "You scream for help and Floyd hits you with a huge left hook. You've been knocked out.";
                    greenOutput.Text = "";
                    break;

                case 18:
                    questionOutput.Text = "You last till the bell but are seriously hurt, everywhere. Coach asks you if you want him to throw in the towel?";
                    blueOutput.Text = "You don't want to waste the time and effort youve put in and continue";
                    redOutput.Text = "Get coach to forfeit the match";
                    greenOutput.Text = "";
                    break;

                case 19:
                    questionOutput.Text = "You dodge the punch but fall over in the process. The ref stands you up and Floyd wastes no time getting back at it.";
                    blueOutput.Text = "Duck";
                    redOutput.Text = "Weave";
                    greenOutput.Text = "";
                    break;

                case 20:
                    questionOutput.Text = "You don't throw the punch but Mayweather does. You've been knocked out. \n\n\n Would you like to play again?";
                    blueOutput.Text = "Yes";
                    redOutput.Text = "No";
                    greenOutput.Text = "";
                    break;

                case 21:
                    Random ranGen = new Random();
                    int value = ranGen.Next(1, 101);

                    if (value < 50)
                    {
                        imageBox.BackgroundImage = Properties.Resources.professional_male_reporter_holding_microphone_isolated_white_background_30247218;
                        player.Play();
                        questionOutput.Text = "You went for the punch and niled him perfectly!\n you win!\n\n\nReporter: How do you think the fight went?";
                        blueOutput.Text = "Floyd is the best fighter in the world, everyone knows it and he proved it today";
                        redOutput.Text = "I think 99 times out of 100 I'd beat him. This was just that one lucky time for him";
                        greenOutput.Text = "I think this was the right outcome. Mayweather just has more skill in the ring";
                    }
                    else
                    {
                        imageBox.BackgroundImage = Properties.Resources.professional_male_reporter_holding_microphone_isolated_white_background_30247218;
                        player.Play();
                        questionOutput.Text = "You went for the punch but in the process left yourself vunerable and Floyd countered you. \n You lose \n\n\nReporter: How do you think the fight went?";
                        blueOutput.Text = "Floyd is the best fighter in the world, everyone knows it and he proved it today";
                        redOutput.Text = "I think 99 times out of 100 I'd beat him. This was just that one lucky time for him";
                        greenOutput.Text = "I think this was the right outcome. Mayweather just has more skill in the ring";
                    }                     
                    break;

                case 22:
                    imageBox.BackgroundImage = Properties.Resources.professional_male_reporter_holding_microphone_isolated_white_background_30247218;
                    player.Play();
                    questionOutput.Text = "You don't attack the eye doing more damage to Floyds body but you left your head open. He takes advantage and knocks you out.\n\n\nReporter: How do you think the fight went today?";
                    blueOutput.Text = "Floyd is the best fighter in the world, everyone knows it and he proved it today";
                    redOutput.Text = "I think 99 times out of 100 I'd beat him. This was just that one lucky time for him";
                    greenOutput.Text = "I think this was the right outcome. Mayweather just has more skill in the ring";
                    break;

                case 23:
                    imageBox.BackgroundImage = Properties.Resources.professional_male_reporter_holding_microphone_isolated_white_background_30247218;
                    player.Play();
                    questionOutput.Text = "You keep attacking the cut and eventually the ref stops the fight due to the bleeding.\n You win \n\n\nReporter: How do you think the fight went today?";
                    blueOutput.Text = "Honestly I think this was a fluke, I didn't expect this to happen and it shouldn't have happened at all";
                    redOutput.Text = "I think this was one of the easiest fights of my life. I had more trouble with Timmy in the 4th grade";
                    greenOutput.Text = "I think it went well Mayweather is a good fighter and I respect him";
                    break;

                case 24:
                    imageBox.BackgroundImage = Properties.Resources.professional_male_reporter_holding_microphone_isolated_white_background_30247218;
                    player.Play();
                    questionOutput.Text = "You scream for help and Floyd hits you with a huge left hook.\n You've been knocked out.\n\n\nReporter: How do you think the fight went today?";
                    blueOutput.Text = "Floyd is the best fighter in the world, everyone knows it and he proved it today";
                    redOutput.Text = "I think 99 times out of 100 I'd beat him. This was just that one lucky time for him";
                    greenOutput.Text = "I think this was the right outcome. Mayweather just has more skill in the ring";
                    break;

                case 25:
                    imageBox.BackgroundImage = Properties.Resources.professional_male_reporter_holding_microphone_isolated_white_background_30247218;
                    player.Play();
                    questionOutput.Text = "You fight back and catch him lacking and put him to sleep with an overhand haymaker. You've knocked him out\n\n\n Reporter: How do you think the fight went today?";
                    blueOutput.Text = "Honestly I think this was a fluke, I didn't expect this to happen and it shouldn't have happened at all";
                    redOutput.Text = "I think this was one of the easiest fights of my life. I had more trouble with Timmy in the 4th grade";
                    greenOutput.Text = "I think it went well Mayweather is a good fighter and I respect him";
                    break;

                case 26:
                    questionOutput.Text = "You get back in the ring on your ninth life but Floyd sees that your hurt and comes charging, dodge quick!";
                    blueOutput.Text = "Left";
                    redOutput.Text = "Right";
                    greenOutput.Text = "";
                    break;

                case 27:
                    imageBox.BackgroundImage = Properties.Resources.professional_male_reporter_holding_microphone_isolated_white_background_30247218;
                    player.Play();
                    questionOutput.Text = "Coach throws in the towel for you.\nYou forfeit the fight. \n\n\nReporter: How do you think the fight went today?";
                    blueOutput.Text = "Floyd is the best fighter in the world, everyone knows it and he proved it today";
                    redOutput.Text = "I think 99 times out of 100 I'd beat him. This was just that one lucky time for him";
                    greenOutput.Text = "I think this was the right outcome. Mayweather just has more skill in the ring";
                    break;

                case 28:
                    imageBox.BackgroundImage = Properties.Resources.professional_male_reporter_holding_microphone_isolated_white_background_30247218;
                    player.Play();
                    questionOutput.Text = "You weaved but he throws an uppercut that still lands on your shoulder, tearing it apart. But you come back with a massive left hook. Knocking him out\n\n\nReporter: How do you think the fight went today?";
                    blueOutput.Text = "Honestly I think this was a fluke, I didn't expect this to happen and it shouldn't have happened at all";
                    redOutput.Text = "I think this was one of the easiest fights of my life. I had more trouble with Timmy in the 4th grade";
                    greenOutput.Text = "I think it went well Mayweather is a good fighter and I respect him";
                    break;

                case 29:
                    imageBox.BackgroundImage = Properties.Resources.professional_male_reporter_holding_microphone_isolated_white_background_30247218;
                    player.Play();
                    questionOutput.Text = "You ducked and he threw an uppercut straight into your face. You've been knocked out cold.\n\n\nReporter: How do you think the fight went today?";
                    blueOutput.Text = "Floyd is the best fighter in the world, everyone knows it and he proved it today";
                    redOutput.Text = "I think 99 times out of 100 I'd beat him. This was just that one lucky time for him";
                    greenOutput.Text = "I think this was the right outcome. Mayweather just has more skill in the ring";
                    break;

                case 30:
                    imageBox.BackgroundImage = Properties.Resources.professional_male_reporter_holding_microphone_isolated_white_background_30247218;
                    player.Play();
                    questionOutput.Text = "You dodge right and Floyd misses then he comes back with the left and his knuckles meet your temple. you've been knocked out \n\n\nReporter: How do you think the fight went today?";
                    blueOutput.Text = "Floyd is the best fighter in the world, everyone knows it and he proved it today";
                    redOutput.Text = "I think 99 times out of 100 I'd beat him. This was just that one lucky time for him";
                    greenOutput.Text = "I think this was the right outcome. Mayweather just has more skill in the ring";
                    break;

                case 31:
                    imageBox.BackgroundImage = Properties.Resources.professional_male_reporter_holding_microphone_isolated_white_background_30247218;
                    player.Play();
                    questionOutput.Text = "You dodge left but he reads it and you get hit hard. But you also hit him, knocking him out. You win!\n\n\nReporter: How do you think the fight went today?";
                    blueOutput.Text = "Honestly I think this was a fluke, I didn't expect this to happen and it shouldn't have happened at all";
                    redOutput.Text = "I think this was one of the easiest fights of my life. I had more trouble with Timmy in the 4th grade";
                    greenOutput.Text = "I think it went well Mayweather is a good fighter and I respect him";
                    break;

                case 32:
                    imageBox.BackgroundImage = Properties.Resources.The_Earth_seen_from_Apollo_17;
                    player.Play();
                    questionOutput.Text = "The world considers you one of the best fighters in the world and you're now respected by the boxing world\n\n\n Would you like to play again?";
                    blueOutput.Text = "Yes";
                    redOutput.Text = "No";
                    greenOutput.Text = "";
                    break;

                case 33:
                    imageBox.BackgroundImage = Properties.Resources.The_Earth_seen_from_Apollo_17;
                    player.Play();
                    questionOutput.Text = "The world considers you a loudmouth and doesn't like or respect you as a fighter or as a man/woman\n\n\n Would you like to play again";
                    blueOutput.Text = "Yes";
                    redOutput.Text = "No";
                    greenOutput.Text = "";
                    break;

                case 34:
                    imageBox.BackgroundImage = Properties.Resources.The_Earth_seen_from_Apollo_17;
                    player.Play();
                    questionOutput.Text = "The world considers you a one and done and doesn't respect you too much because you're a softy\n\n\nwould you like to play again?";
                    blueOutput.Text = "Yes";
                    redOutput.Text = "No";
                    greenOutput.Text = "";
                    break;

                case 35:
                    imageBox.BackgroundImage = Properties.Resources.The_Earth_seen_from_Apollo_17;
                    player.Play();
                    questionOutput.Text = "The world considers you one of the best fighters in the world and you're now respected by the boxing world\n\n\n Would you like to play again?";
                    blueOutput.Text = "Yes";
                    redOutput.Text = "No";
                    greenOutput.Text = "";
                    break;

                case 36:
                    imageBox.BackgroundImage = Properties.Resources.The_Earth_seen_from_Apollo_17;
                    player.Play();
                    questionOutput.Text = "The world considers you a loudmouth and doesn't like or respect you as a fighter or as a man/woman\n\n\n Would you like to play again";
                    blueOutput.Text = "Yes";
                    redOutput.Text = "No";
                    greenOutput.Text = "";
                    break;

                case 37:
                    imageBox.BackgroundImage = Properties.Resources.The_Earth_seen_from_Apollo_17;
                    player.Play();
                    questionOutput.Text = "The world considers you a one and done and doesn't respect you too much because you're a softy\n\n\nwould you like to play again?";
                    blueOutput.Text = "Yes";
                    redOutput.Text = "No";
                    greenOutput.Text = "";
                    break;
            }
        }
    }
}

