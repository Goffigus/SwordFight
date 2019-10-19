using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwordFight
{
    public partial class Form1 : Form
    {
        string yName;
        int opHP = 50;
        int yHP = 50;
        Random r = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            you.Text = yourName.Text + " " + yHP.ToString() + " HP"; ;
            yName = yourName.Text;
            opponent.Text = "Opponent " + opHP.ToString() + " HP";

            fastAttack.Visible = true;
            strongAttack.Visible = true;
            Block.Visible = true;
            you.Visible = true;
            opponent.Visible = true;
            yAction.Visible = true;
            oAction.Visible = true;

            Start.Visible = false;
            yourName.Visible = false;
        }

        private void fastAttack_Click(object sender, EventArgs e)
        {
            
            int attack = r.Next(1, 10);
            int opAttack;

            if (opHP < 30)
            {
                opAttack = r.Next(1, 15);
            }
            else
            {
                opAttack = r.Next(1, 25);
            }

            yAction.Text = String.Format("{0} attacks for {1} damage!", yName, attack);
            opHP = opHP - attack;

            oAction.Text = String.Format("Opponnet attacks you for {0} damage!", opAttack);
            yHP = yHP - opAttack;

            you.Text = yourName.Text + " " + yHP.ToString() + " HP"; ;
            opponent.Text = "Opponent " + opHP.ToString() + " HP";


            if (opHP < 1)
            {
                yAction.Text = yName + " Wins!";
                oAction.Text = "ARhaggrr...";
            }
            else if (yHP < 1)
            {
                yAction.Text = yName + " Loses!";
                oAction.Text = "HA HA HA HA!!!";
            }
           
            
        }

        private void strongAttack_Click(object sender, EventArgs e)
        {
            int hit = r.Next(1, 10);
            int attack = r.Next(8, 25);
            int opAttack;

            if (opHP < 30)
            {
                opAttack = r.Next(1, 15);
            }
            else
            {
                opAttack = r.Next(1, 25);
            }

            if (hit > 2)
            {
                yAction.Text = String.Format("{0} attacks for {1} damage!", yName, attack);
                opHP = opHP - attack;
            }
            else
            {
                yAction.Text = yName + " misses...";
            }

            oAction.Text = String.Format("Opponnet attacks you for {0} damage!", opAttack);
            yHP = yHP - opAttack;

            you.Text = yourName.Text + " " + yHP.ToString() + " HP"; ;
            opponent.Text = "Opponent " + opHP.ToString() + " HP";


            if (opHP < 1)
            {
                yAction.Text = yName + " Wins!";
                oAction.Text = "ARhaggrr...";
            }
            else if (yHP < 1)
            {
                yAction.Text = yName + " Loses!";
                oAction.Text = "HA HA HA HA!!!";
            }
            
        }

        private void Block_Click(object sender, EventArgs e)
        {
            int opAttack;
            int attack = r.Next(5,15);

            if (opHP < 30)
            {
                opAttack = r.Next(1, 15);
            }
            else
            {
                opAttack = r.Next(1, 25);
            }

            if (opAttack < 5)
            {
                oAction.Text = String.Format("Opponnet attacks you for {0} damage!", opAttack);
                yHP = yHP - opAttack;
                yAction.Text = yName + " Fails to Block...";
            }
            else if (opAttack < 15)
            {
                oAction.Text = "Opponent is parried!";
                yAction.Text = yName + " Blocks the strike!";
            }
            else
            {
                oAction.Text = "Opponent is parried!";
                yAction.Text = String.Format("{0} Counters for {1} damage!", yName, attack);
                opHP = opHP - attack;
            }


            you.Text = yourName.Text + " " + yHP.ToString() + " HP"; ;
            opponent.Text = "Opponent " + opHP.ToString() + " HP";


            if (opHP < 1)
            {
                yAction.Text = yName + " Wins!";
                oAction.Text = "ARhaggrr...";
            }
            else if (yHP < 1)
            {
                yAction.Text = yName + " Loses!";
                oAction.Text = "HA HA HA HA!!!";
            }

        }
    }
}
