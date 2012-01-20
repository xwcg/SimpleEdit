using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Xware.xRegistry;

namespace SimpleEdit
{
    public partial class Main : Form
    {
        public xRegistry controllerRegistry = new xRegistry("SimpleEdit");

        public Main()
        {
            InitializeComponent();

            LoadSettings();
        }

        private void LoadSettings()
        {
            if ( controllerRegistry.GetBool("WordWrap") == true )
            {
                //menuOptionsWordWrap.Checked = true;
                textBoxRich.WordWrap = true;
                textBoxSimple.WordWrap = true;
            }
            else
            {
                //menuOptionsWordWrap.Checked = false;
                textBoxRich.WordWrap = false;
                textBoxSimple.WordWrap = false;
            }
        }

        // Button declarations

        private void menuPrint_Click( object sender, EventArgs e )
        {
            PrintMenu p = new PrintMenu();
            p.Show();
        }

        //private void menuSearchBar_Enter( object sender, EventArgs e )
        //{
        //    menuSearchBar.Font = new Font(SystemFonts.MessageBoxFont, FontStyle.Regular);
        //    menuSearchBar.ForeColor = SystemColors.WindowText;

        //    if ( menuSearchBar.Text == "Search..." )
        //    {
        //        menuSearchBar.Text = "";
        //    }
        //}

        //private void menuSearchBar_Leave( object sender, EventArgs e )
        //{
        //    menuSearchBar.Font = new Font(SystemFonts.MessageBoxFont, FontStyle.Italic);
        //    menuSearchBar.ForeColor = SystemColors.GrayText;

        //    if ( menuSearchBar.Text.Trim() == "" )
        //    {
        //        menuSearchBar.Text = "Search...";
        //    }
        //}
    }
}
