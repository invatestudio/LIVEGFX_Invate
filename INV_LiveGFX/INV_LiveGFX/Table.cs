using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INV_LiveGFX
{
    public partial class Table : UserControl
    {
        public Table()
        {
            InitializeComponent();
        }

        private void metroComboBox32_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (metroComboBox32.SelectedIndex.ToString() == "0")
            {
                tournament1.BringToFront();
                s_team1.Enabled = false;
                s_team2.Enabled = false;
                s_team3.Enabled = false;
                s_team4.Enabled = false;
                s_team5.Enabled = false;
                s_team6.Enabled = false;
                s_team7.Enabled = false;
                s_team8.Enabled = false;
                s_team9.Enabled = false;
                s_team10.Enabled = false;
                s_team11.Enabled = false;
                s_team12.Enabled = false;
                s_team13.Enabled = false;
                s_team14.Enabled = false;
                s_team15.Enabled = false;
                s_team16.Enabled = false;
            }
            else if (metroComboBox32.SelectedIndex.ToString() == "1")
            {
                tournament2.BringToFront();
                d_team1.Enabled = false;
                d_team2.Enabled = false;
                d_team3.Enabled = false;
                d_team4.Enabled = false;
                d_team5.Enabled = false;
                d_team6.Enabled = false;
                d_team7.Enabled = false;
                d_team8.Enabled = false;
                d_team9.Enabled = false;
                d_team10.Enabled = false;
                d_team11.Enabled = false;
                d_team12.Enabled = false;
                d_team13.Enabled = false;
                d_team14.Enabled = false;
                d_team15.Enabled = false;
                d_team16.Enabled = false;

                d_team_l1.Enabled = false;
                d_team_l2.Enabled = false;
                d_team_l3.Enabled = false;
                d_team_l4.Enabled = false;
                d_team_l5.Enabled = false;
                d_team_l6.Enabled = false;
                d_team_l7.Enabled = false;
                d_team_l8.Enabled = false;
            }
            else if (metroComboBox32.SelectedIndex.ToString() == "2")
            {
                tournament1.BringToFront();
                s_team1.Enabled = true;
                s_team2.Enabled = true;
                s_team3.Enabled = true;
                s_team4.Enabled = true;
                s_team5.Enabled = true;
                s_team6.Enabled = true;
                s_team7.Enabled = true;
                s_team8.Enabled = true;
                s_team9.Enabled = true;
                s_team10.Enabled = true;
                s_team11.Enabled = true;
                s_team12.Enabled = true;
                s_team13.Enabled = true;
                s_team14.Enabled = true;
                s_team15.Enabled = true;
                s_team16.Enabled = true;
            }
            else if (metroComboBox32.SelectedIndex.ToString() == "3")
            {
                tournament2.BringToFront();
                d_team1.Enabled = true;
                d_team2.Enabled = true;
                d_team3.Enabled = true;
                d_team4.Enabled = true;
                d_team5.Enabled = true;
                d_team6.Enabled = true;
                d_team7.Enabled = true;
                d_team8.Enabled = true;
                d_team9.Enabled = true;
                d_team10.Enabled = true;
                d_team11.Enabled = true;
                d_team12.Enabled = true;
                d_team13.Enabled = true;
                d_team14.Enabled = true;
                d_team15.Enabled = true;
                d_team16.Enabled = true;

                d_team_l1.Enabled = true;
                d_team_l2.Enabled = true;
                d_team_l3.Enabled = true;
                d_team_l4.Enabled = true;
                d_team_l5.Enabled = true;
                d_team_l6.Enabled = true;
                d_team_l7.Enabled = true;
                d_team_l8.Enabled = true;
            }
        }
    }
}
