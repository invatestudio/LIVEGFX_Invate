using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INV_LiveGFX
{
    public partial class LiveGFX : Form
    {
        public LiveGFX()
        {
            InitializeComponent();

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btn_maximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_live1_Click(object sender, EventArgs e)
        {
            toggle(sender);
            BMD_Controller.Visible = true;
            liveEvent1.BringToFront();
        }

        void toggle(object sender)
        {
            btn_live1.selected = false;
            btn_live2.selected = false;
            btn_team.selected = false;
            btn_event.selected = false;
            btn_table.selected = false;
            btn_options.selected = false;

            ((Bunifu.Framework.UI.BunifuFlatButton)sender).selected = true;
        }

        private void btn_live2_Click(object sender, EventArgs e)
        {
            toggle(sender);
            BMD_Controller.Visible = true;
            inGame1.BringToFront();
        }

        private void btn_team_Click(object sender, EventArgs e)
        {
            toggle(sender);
            BMD_Controller.Visible = false;
            teamDatabase1.BringToFront();
        }

        private void btn_event_Click(object sender, EventArgs e)
        {
            toggle(sender);
            BMD_Controller.Visible = false;
            eventInfo1.BringToFront();
        }

        private void btn_table_Click(object sender, EventArgs e)
        {
            toggle(sender);
            BMD_Controller.Visible = false;
            table1.BringToFront();
        }

        private void btn_options_Click(object sender, EventArgs e)
        {
            toggle(sender);
            BMD_Controller.Visible = false;
            options1.BringToFront();
        }

        private void liveEvent1_Load(object sender, EventArgs e)
        {
            
        }

        private void bar_title_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }
    }
}
