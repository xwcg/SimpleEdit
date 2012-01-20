using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace SimpleEdit
{
    public partial class PrintMenu : Form
    {
        public PrintDocument pd = new PrintDocument();

        public PrintMenu()
        {
            InitializeComponent();

            string defaultPrinter = pd.PrinterSettings.PrinterName;

            foreach ( string printer in PrinterSettings.InstalledPrinters )
            {
                comboPrinters.Items.Add(printer);
                if ( defaultPrinter == printer )
                {
                    comboPrinters.SelectedIndex = comboPrinters.Items.IndexOf(printer);
                }
            }
        }

        private void comboPrinters_SelectedIndexChanged( object sender, EventArgs e )
        {

        }
    }
}
