using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using SimpleEditExtraHandler;
using SimpleEditPluginInterface;
using Xware.xRegistry;

namespace SimpleEdit
{
    public partial class Main : Form
    {
        public xRegistry controllerRegistry = new xRegistry("SimpleEdit");

        bool richDocument = false;

        string AppName = "SimpleEdit - " + Assembly.GetCallingAssembly().GetName().Version.ToString();

        public Main()
        {
            InitializeComponent();
            LoadSettings();
            LoadPlugins();

            this.Text = AppName;

            toolBar.Visible = false;
        }

        private void NewDocument()
        {
            NewDocument(richDocument);
        }

        private void NewDocument( bool rich )
        {
            richDocument = rich;

            textBoxSimple.Text = "";
            textBoxRich.Rtf = "";
            textBoxRich.Text = "";

            if ( rich )
            {
                this.Text = "Untitled Rich Document - " + AppName;
                textBoxRich.Visible = true;
                textBoxSimple.Visible = false;
                toolBar.Visible = true;
            }
            else
            {
                this.Text = "Untitled Text Document - " + AppName;
                textBoxRich.Visible = false;
                textBoxSimple.Visible = true;
                toolBar.Visible = false;
            }
        }

        private void LoadPlugins()
        {
            Global.Plugins.FindPlugins(Environment.CurrentDirectory + "\\plugins\\extras\\");

            foreach ( AvailablePlugin p in Global.Plugins.AvailablePlugins )
            {
                if ( p.Instance is SimpleEditExtraHandler.SEExtra )
                {
                    AddExtra((SimpleEditExtraHandler.SEExtra)p.Instance);
                }
            }
        }

        private void AddExtra( SimpleEditExtraHandler.SEExtra p )
        {
            ToolStripMenuItem i = new ToolStripMenuItem(p.PluginName);
            i.DisplayStyle = ToolStripItemDisplayStyle.Text;
            i.Click += new EventHandler(i_Click);
            i.ToolTipText = p.Description + "\n\n" +
                "Author: " + p.Author + "\n" +
                "Version: " + p.Version + "\n" +
                "Website: " + p.Website + "\n";

            menuEditExtras.DropDownItems.Add(i);
        }

        void i_Click( object sender, EventArgs e )
        {
            ToolStripMenuItem i = (ToolStripMenuItem)sender;
            SEExtra p = (SEExtra)Global.Plugins.AvailablePlugins.Find(i.Text).Instance;

            if ( richDocument )
            {
                textBoxRich.SelectedText = p.Do(textBoxRich.SelectedText);
            }
            else
            {
                textBoxSimple.SelectedText = p.Do(textBoxSimple.SelectedText);
            }
        }

        private void LoadSettings()
        {
            FontFamily[] fontFamilies;
            InstalledFontCollection installedFontCollection = new InstalledFontCollection();
            fontFamilies = installedFontCollection.Families;

            foreach ( FontFamily b in fontFamilies )
            {
                toolFontList.Items.Add(b.Name);
            }

            if ( controllerRegistry.GetBool("WordWrap") == true )
            {
                menuOptionsWordWrap.Checked = true;
                textBoxRich.WordWrap = true;
                textBoxSimple.WordWrap = true;
            }
            else
            {
                menuOptionsWordWrap.Checked = false;
                textBoxRich.WordWrap = false;
                textBoxSimple.WordWrap = false;
            }

            for ( int i = 1; i <= 5; i++ )
            {
                AddRecentFile(controllerRegistry.GetString("RecentFile" + i.ToString()));
            }
        }

        private void AddRecentFile( string path )
        {
            if ( path.Trim() != "" )
            {
                menuOpen.DropDownItems.Add(path);
            }
        }

        // Button declarations


        private void menuSearchBar_Enter( object sender, EventArgs e )
        {
            menuSearchBar.Font = new Font(SystemFonts.MessageBoxFont, FontStyle.Regular);
            menuSearchBar.ForeColor = SystemColors.WindowText;

            if ( menuSearchBar.Text == "Search..." )
            {
                menuSearchBar.Text = "";
            }
        }

        private void menuSearchBar_Leave( object sender, EventArgs e )
        {
            menuSearchBar.Font = new Font(SystemFonts.MessageBoxFont, FontStyle.Italic);
            menuSearchBar.ForeColor = SystemColors.GrayText;

            if ( menuSearchBar.Text.Trim() == "" )
            {
                menuSearchBar.Text = "Search...";
            }
        }

        private void menuPrint_Click( object sender, EventArgs e )
        {
            PrintMenu p = new PrintMenu();
            p.Show();
        }

        private void menuOptionsWordWrap_Click( object sender, EventArgs e )
        {
            if ( controllerRegistry.GetBool("WordWrap") == true )
            {
                menuOptionsWordWrap.Checked = false;
                textBoxRich.WordWrap = false;
                textBoxSimple.WordWrap = false;
                controllerRegistry.SetValue("WordWrap", false);
            }
            else
            {
                menuOptionsWordWrap.Checked = true;
                textBoxRich.WordWrap = true;
                textBoxSimple.WordWrap = true;
                controllerRegistry.SetValue("WordWrap", true);
            }

        }

        private void menuNewText_Click( object sender, EventArgs e )
        {
            NewDocument(false);
        }

        private void menuNewRich_Click( object sender, EventArgs e )
        {
            NewDocument(true);
        }

        private void toolBold_Click( object sender, EventArgs e )
        {
            textBoxRich.SelectionFont = new Font(textBoxRich.SelectionFont, textBoxRich.SelectionFont.Style ^ FontStyle.Bold);
        }

        private void toolItalic_Click( object sender, EventArgs e )
        {
            textBoxRich.SelectionFont = new Font(textBoxRich.SelectionFont, textBoxRich.SelectionFont.Style ^ FontStyle.Italic);
        }

        private void toolUnderline_Click( object sender, EventArgs e )
        {
            textBoxRich.SelectionFont = new Font(textBoxRich.SelectionFont, textBoxRich.SelectionFont.Style ^ FontStyle.Underline);
        }

        private void toolStrike_Click( object sender, EventArgs e )
        {
            textBoxRich.SelectionFont = new Font(textBoxRich.SelectionFont, textBoxRich.SelectionFont.Style ^ FontStyle.Strikeout);
        }

        private void textBoxRich_SelectionChanged( object sender, EventArgs e )
        {
            try
            {
                toolBold.Checked = textBoxRich.SelectionFont.Bold;
                toolItalic.Checked = textBoxRich.SelectionFont.Italic;
                toolUnderline.Checked = textBoxRich.SelectionFont.Underline;
                toolStrike.Checked = textBoxRich.SelectionFont.Strikeout;
                toolFontList.SelectedIndex = toolFontList.Items.IndexOf(textBoxRich.SelectionFont.Name);
                toolFontSize.Text = textBoxRich.SelectionFont.SizeInPoints.ToString();
            }
            catch
            {
                toolBold.Checked = false;
                toolItalic.Checked = false;
                toolUnderline.Checked = false;
                toolStrike.Checked = false;
                toolFontList.Text = "";                ;
                toolFontSize.Text = "";
            }
        }

        private void toolFontList_SelectedIndexChanged( object sender, EventArgs e )
        {
            try
            {
                textBoxRich.SelectionFont = new Font(toolFontList.Text, textBoxRich.SelectionFont.Size, textBoxRich.SelectionFont.Style, textBoxRich.SelectionFont.Unit);
            }
            catch
            {
            }
        }

        private void toolFontSize_SelectedIndexChanged( object sender, EventArgs e )
        {
            try
            {
                float f = Convert.ToSingle(toolFontSize.Text);
                textBoxRich.SelectionFont = new Font(textBoxRich.SelectionFont.Name, f, textBoxRich.SelectionFont.Style, GraphicsUnit.Point);
            }
            catch
            {
            }
        }


    }
}
