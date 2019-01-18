using System;
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
        private void Initfont()
        {
            PrivateFontCollection fontCollect = new PrivateFontCollection();
            int fontLength = Properties.Resources.pokemon_emerald_pro.Length;
            byte[] fontData = Properties.Resources.pokemon_emerald_pro;
            System.IntPtr data = Marshal.AllocCoTaskMem(fontLength);
            Marshal.Copy(fontData, 0, data, fontLength);
            fontCollect.AddMemoryFont(data, fontLength);
        }

        string menuLoc = "FIGHT";
        string menuState = "Intro";

        bool buttonA = false;

        public Battle()
        {
            InitializeComponent();
            Initfont();
//            Font pep = new Font(fontCollect.Families[0]);
        }

        private void Battle_KeyDown(object sender, KeyEventArgs e)
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


        private void gameTimer_Tick(object sender, EventArgs e)
        {

        }

        private void Battle_Paint(object sender, PaintEventArgs e)
        {
            //            e.Graphics.DrawImage(Properties.Resources.grass, 240, 112, 0, 0);
            Pen menuSele = new Pen(Color.Red);


            switch (menuState)
            {
                case "Intro":
                    e.Graphics.DrawImage(Properties.Resources.trainer_bird, 146, 4, 64, 64);
                    e.Graphics.DrawImage(Properties.Resources.back1, 0, 48, 64, 64);
                    e.Graphics.DrawImage(Properties.Resources.battle_intro, 0, 112, 240, 48);
                    break;
                case "PokemonOut":

                    break;
                case "Main":

                    break;
                case "FIGHT":
                    break;
            }


            if (menuState == "FIGHT")
            {
                e.Graphics.DrawImage(Properties.Resources.battle_main_menu, 0, 112, 240, 48);
                switch (menuLoc)
                {
                    case "FIGHT":
                        {
                            e.Graphics.DrawRectangle(menuSele, 142, 120, 46, 16);
                        }
                        break;
                    case "BAG":
                        {
                            e.Graphics.DrawRectangle(menuSele, 188, 120, 46, 16);
                        }
                        break;
                    case "PKMN":
                        {
                            e.Graphics.DrawRectangle(menuSele, 142, 136, 46, 16);
                        }
                        break;
                    case "RUN":
                        {
                            e.Graphics.DrawRectangle(menuSele, 188, 136, 46, 16);
                        }
                        break;
                }
                Refresh();
            }
        }
    }
}

