﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicGameControls
{
    public partial class Battle : Form
    {

        string menuLoc = "FIGHT";
        string menuState = "Intro";
        string redArrow = "Up";
        string battleJason = "Trainer JASON would like to battle!";

        string heroMon = "RALTS";
        int heroLevel = 9;
        int heroHP = 80;
        string foeMon = "EEVEE";
        int foeLevel = 8;
        int foeHP = 72;

        int throwFrame = 1;
        int throwX = 16;
        int descLocX = 12;
        int descLocY = 122;

        bool buttonA = false;
        bool animation = false;

        public Battle()
        {
            InitializeComponent();
            //            Font pep = new Font(fontCollect.Families[0]);
        }

        private void Battle_KeyDown(object sender, KeyEventArgs e)
        {
            if (!animation)
            {
                switch (e.KeyCode)
                {
                    case Keys.W:
                        {
                            if (menuLoc == "PKMN")
                            {
                                menuLoc = "FIGHT";
                            }
                            if (menuLoc == "RUN")
                            {
                                menuLoc = "BAG";
                            }
                            else
                            {
                            }
                        }
                        break;
                    case Keys.A:
                        {
                            if (menuLoc == "BAG")
                            {
                                menuLoc = "FIGHT";
                            }
                            if (menuLoc == "RUN")
                            {
                                menuLoc = "PKMN";
                            }
                            else
                            {

                            }
                        }
                        break;
                    case Keys.S:
                        {
                            if (menuLoc == "FIGHT")
                            {
                                menuLoc = "PKMN";
                            }
                            if (menuLoc == "BAG")
                            {
                                menuLoc = "RUN";
                            }
                            else
                            {

                            }
                        }
                        break;
                    case Keys.D:
                        {
                            if (menuLoc == "FIGHT")
                            {
                                menuLoc = "BAG";
                            }
                            if (menuLoc == "PKMN")
                            {
                                menuLoc = "RUN";
                            }
                            else
                            {

                            }
                        }
                        break;
                    case Keys.Enter:
                        {
                            buttonA = true;
                        }
                        break;
                }
            }
            else
            {
                buttonA = false;
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            if (menuState == "Intro")
            {
                //Arrow movement
                if (redArrow == "Down")
                {
                    redArrow = "Up";
                }

                else
                {
                    redArrow = "Down";
                }

                if (buttonA == true)
                {
                    menuState = "PokemonOut";
                }

            }

            if (menuState == "PokemonOut")
            {
                for (int a = 0; a < 80; a++)
                {
                    if (a > 20)
                    {
                        throwFrame = 2;
                    }
                    if (a > 40)
                    {
                        throwFrame = 3;
                    }
                    if (a > 60)
                    {
                        throwFrame = 4;
                    }
                    throwX--;
                    Refresh();
                }
                menuState = "Main";
            }

            if (menuState == "Main")
            {
                
            }

            Refresh();
        }

        private void Battle_Paint(object sender, PaintEventArgs e)
        {
            Pen menuSele = new Pen(Color.Red);
            SolidBrush colorDesc = new SolidBrush(Color.White);
            SolidBrush indiColor = new SolidBrush(Color.FromArgb(255, 66, 66, 66));
            SolidBrush shadowDesc = new SolidBrush(Color.FromArgb(255, 107, 89, 115));
            Font menuDesc = new Font("Pokémon Emerald Pro", 12, FontStyle.Regular);
            Font uiFont = new Font("ADMUI3Sm", 7, FontStyle.Regular);

            switch (throwFrame)
            {
                case 1:
                    {
                        e.Graphics.DrawImage(Properties.Resources.back1, throwX, 48, 64, 64);
                    }
                    break;
                case 2:
                    {
                        e.Graphics.DrawImage(Properties.Resources.back2, throwX, 48, 64, 64);
                    }
                    break;
                case 3:
                    {
                        e.Graphics.DrawImage(Properties.Resources.back3, throwX, 48, 64, 64);
                    }
                    break;
                case 4:
                    {
                        e.Graphics.DrawImage(Properties.Resources.back4, throwX, 48, 64, 64);
                    }
                    break;
            }

            switch (menuState)
            {
                case "Intro":
                    {
                        gameTimer.Interval = (160);
                        e.Graphics.DrawImage(Properties.Resources.trainer_bird, 146, 4, 64, 64);
//                        e.Graphics.DrawImage(Properties.Resources.back1, 16, 48, 64, 64);
                        e.Graphics.DrawImage(Properties.Resources.battle_intro, 0, 112, 240, 48);
                        e.Graphics.DrawString(battleJason, menuDesc, shadowDesc, descLocX + 1, descLocY + 1);
                        e.Graphics.DrawString(battleJason, menuDesc, colorDesc, descLocX, descLocY);
                    }
                    break;

                case "PokemonOut":
                    {
                        e.Graphics.DrawImage(Properties.Resources.battle_intro, 0, 112, 240, 48);
                    }
                    break;

                case "Main":
                    {

                        gameTimer.Interval = (10);
                        e.Graphics.DrawImage(Properties.Resources.ralts_b, 24, 48, 64, 64);
                        e.Graphics.DrawImage(Properties.Resources.eevee_f, 142, 16, 64, 64);
                        e.Graphics.DrawImage(Properties.Resources.battle_main_menu, 0, 112, 240, 48);
 //                       e.Graphics.DrawImage(Properties.Resources.battle_main_menu, 0, 112, 240, 48);
                        e.Graphics.DrawImage(Properties.Resources.hero_ui, 128, 73, 106, 40);
                        e.Graphics.DrawImage(Properties.Resources.foe_ui, 12, 15, 100, 32);
                        e.Graphics.DrawString(heroLevel + "", uiFont, indiColor, 216, 78);
                    }
                    break;

                case "FIGHT":
                    {

                    }
                    break;
            }

            if (menuState == "Intro")
            {
                switch (redArrow)
                {
                    case "Up":
                        e.Graphics.DrawImage(Properties.Resources.arrow_red, (descLocX + battleJason.Length), descLocY, 12, 12);
                        break;
                    case "Down":
                        e.Graphics.DrawImage(Properties.Resources.arrow_red, (descLocX + battleJason.Length), descLocY + 2, 12, 12);
                        break;
                }
            }

            if (menuState == "Main")
            {
                e.Graphics.DrawImage(Properties.Resources.battle_main_menu, 0, 112, 240, 48);
                switch (menuLoc)
                {
                    case "FIGHT":
                        {
                            e.Graphics.DrawImage(Properties.Resources.arrow_grey, 126, 123, 12, 12);
                        }
                        break;
                    case "BAG":
                        {
                            e.Graphics.DrawImage(Properties.Resources.arrow_grey, 182, 123, 12, 12);
                        }
                        break;
                    case "PKMN":
                        {
                            e.Graphics.DrawImage(Properties.Resources.arrow_grey, 126, 139, 12, 12);
                        }
                        break;
                    case "RUN":
                        {
                            e.Graphics.DrawImage(Properties.Resources.arrow_grey, 182, 139, 12, 12);
                        }
                        break;
                }
                Refresh();
            }
        }
    }
}