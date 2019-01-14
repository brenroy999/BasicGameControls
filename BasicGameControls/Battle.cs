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
                case Keys.Enter:
                    {

                    }
                    break;
            }
        }

        private void Battle_Paint(object sender, PaintEventArgs e)
        {
            switch (menuLoc)
            {
                case "FIGHT":
                    {

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
