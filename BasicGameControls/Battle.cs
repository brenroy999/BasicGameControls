using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicGameControls
{
    public partial class Battle : Form
    {

        string menuLoc = "FIGHT";

        public Battle()
        {
            InitializeComponent();
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
                            ;
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
                case Keys.Enter:
                    {

                    }
                    break;
            }
        }

        private void Battle_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(Properties.Resources.battle_main_menu, 240, 48, 0, 112);
            e.Graphics.DrawImage(Properties.Resources.grass, 240, 112, 0, 0);
            Pen menuSele = new Pen(Color.Red);
            switch (menuLoc)
            {
                case "FIGHT":
                    {
                        e.Graphics.DrawRectangle(menuSele ,142, 120, 34, 15);
                    }
                    break;
                case "BAG":
                    {

                    }
                    break;
                case "PKMN":
                    {

                    }
                    break;
                case "RUN":
                    {

                    }
                    break;
            }
        }
    }
}
