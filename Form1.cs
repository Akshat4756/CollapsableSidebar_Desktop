using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MordernSlidingSidebar
{
    public partial class Form1 : Form
    {
        bool _sidebarExpanded;
        bool homeCollapsed;
        public Form1()
        {
            InitializeComponent();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            //set time interval to lowest to make it smooth
            HomeTimer.Start();
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            //set the minimum size and maximum size of sidebar panel 
            if (_sidebarExpanded)
            {
                //if sidebar is expanded , minimize the width of sidebar
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    _sidebarExpanded = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if(sidebar.Width== sidebar.MaximumSize.Width)
                {
                    _sidebarExpanded = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            //set time interval to lowest to make it smooth
            sidebarTimer.Start();
        }

        private void HomeTimer_Tick(object sender, EventArgs e)
        {
            if (homeCollapsed)
            {
                HomePanel.Height += 10;
                if (HomePanel.Height == HomePanel.MaximumSize.Height)
                {
                    homeCollapsed = false;
                    HomeTimer.Stop();
                }
            }
            else
            {
                HomePanel.Height -= 10;
                if (HomePanel.Height == HomePanel.MinimumSize.Height)
                {
                    homeCollapsed = true;
                    HomeTimer.Stop();

                }
            }
        }
    }
}
