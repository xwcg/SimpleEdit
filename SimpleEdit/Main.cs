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


        }

        private void menuPrint_Click( object sender, EventArgs e )
        {
            PrintMenu p = new PrintMenu();
            p.Show();
        }
    }
}
