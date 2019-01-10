using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicGameControls
{
    public partial class Demo : Form
    {
        bool moving = false;
        string direction = "down";
        string leftRight = "left";
        public Demo()
        {
            InitializeComponent();
            gameTimer.Enabled = true;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    {
                        direction = "up";
                        if (moving = false)
                        {
                            moving = true;
                        }
                    }
                    break;
                case Keys.A:
                    {
                        direction = "right";
                        if (moving = false)
                        {
                            moving = true;
                        }
                    }
                    break;
                case Keys.S:
                    {
                        direction = "down";
                        if (moving = false)
                        {
                            moving = true;
                        }
                    }
                    break;
                case Keys.D:
                    {
                        direction = "left";
                        if (moving = false)
                        {
                            moving = true;
                        }
                    }
                    break;
            }

        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            if (moving)
            {
                switch (direction)
                {
                    case "down":
                        break;
                    case "up":
                        break;
                    case "left":
                        break;
                    case "right":
                        break;
                }
            }
            Refresh();
        }
    }
}
