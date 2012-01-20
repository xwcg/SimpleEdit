namespace SimpleEdit
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.textBoxSimple = new System.Windows.Forms.TextBox();
            this.textBoxRich = new System.Windows.Forms.RichTextBox();
            this.menuStrip = new System.Windows.Forms.ToolStrip();
            this.menuSearchBar = new System.Windows.Forms.ToolStripTextBox();
            this.menuNew = new System.Windows.Forms.ToolStripDropDownButton();
            this.menuNewText = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNewRich = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOpen = new System.Windows.Forms.ToolStripSplitButton();
            this.menuPrint = new System.Windows.Forms.ToolStripSplitButton();
            this.menuPrintSelection = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.menuOptions = new System.Windows.Forms.ToolStripDropDownButton();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.statusStrip.Location = new System.Drawing.Point(0, 480);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.statusStrip.Size = new System.Drawing.Size(808, 22);
            this.statusStrip.TabIndex = 0;
            this.statusStrip.Text = "statusStrip1";
            // 
            // textBoxSimple
            // 
            this.textBoxSimple.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSimple.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxSimple.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.textBoxSimple.Location = new System.Drawing.Point(0, 25);
            this.textBoxSimple.Margin = new System.Windows.Forms.Padding(10);
            this.textBoxSimple.MaxLength = 2147483647;
            this.textBoxSimple.Multiline = true;
            this.textBoxSimple.Name = "textBoxSimple";
            this.textBoxSimple.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxSimple.Size = new System.Drawing.Size(808, 455);
            this.textBoxSimple.TabIndex = 2;
            // 
            // textBoxRich
            // 
            this.textBoxRich.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRich.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxRich.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.textBoxRich.Location = new System.Drawing.Point(0, 25);
            this.textBoxRich.Name = "textBoxRich";
            this.textBoxRich.Size = new System.Drawing.Size(808, 455);
            this.textBoxRich.TabIndex = 3;
            this.textBoxRich.Text = "";
            this.textBoxRich.Visible = false;
            // 
            // menuStrip
            // 
            this.menuStrip.AllowMerge = false;
            this.menuStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNew,
            this.menuOpen,
            this.menuPrint,
            this.toolStripButton1,
            this.menuSearchBar,
            this.menuOptions});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(808, 25);
            this.menuStrip.TabIndex = 4;
            this.menuStrip.Text = "toolStrip1";
            // 
            // menuSearchBar
            // 
            this.menuSearchBar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.menuSearchBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.menuSearchBar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.menuSearchBar.ForeColor = System.Drawing.SystemColors.GrayText;
            this.menuSearchBar.Name = "menuSearchBar";
            this.menuSearchBar.Size = new System.Drawing.Size(100, 25);
            this.menuSearchBar.Text = "Search...";
            this.menuSearchBar.ToolTipText = "Enter search terms here";
            // 
            // menuNew
            // 
            this.menuNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuNew.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNewText,
            this.menuNewRich});
            this.menuNew.Image = ( (System.Drawing.Image)( resources.GetObject("menuNew.Image") ) );
            this.menuNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuNew.Name = "menuNew";
            this.menuNew.Size = new System.Drawing.Size(44, 22);
            this.menuNew.Text = "&New";
            this.menuNew.ToolTipText = "Make a new file";
            // 
            // menuNewText
            // 
            this.menuNewText.Name = "menuNewText";
            this.menuNewText.Size = new System.Drawing.Size(143, 22);
            this.menuNewText.Text = "&Text File";
            this.menuNewText.ToolTipText = "A text document with no text formatting. Like a .txt file.";
            // 
            // menuNewRich
            // 
            this.menuNewRich.Name = "menuNewRich";
            this.menuNewRich.Size = new System.Drawing.Size(143, 22);
            this.menuNewRich.Text = "&Rich Text File";
            this.menuNewRich.ToolTipText = "A rich text file with formatting. Like a word document.";
            // 
            // menuOpen
            // 
            this.menuOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuOpen.Image = ( (System.Drawing.Image)( resources.GetObject("menuOpen.Image") ) );
            this.menuOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuOpen.Name = "menuOpen";
            this.menuOpen.Size = new System.Drawing.Size(52, 22);
            this.menuOpen.Text = "&Open";
            this.menuOpen.ToolTipText = "Open an existing file";
            // 
            // menuPrint
            // 
            this.menuPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuPrint.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPrintSelection});
            this.menuPrint.Image = ( (System.Drawing.Image)( resources.GetObject("menuPrint.Image") ) );
            this.menuPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuPrint.Name = "menuPrint";
            this.menuPrint.Size = new System.Drawing.Size(48, 22);
            this.menuPrint.Text = "&Print";
            this.menuPrint.ToolTipText = "Print the whole document";
            // 
            // menuPrintSelection
            // 
            this.menuPrintSelection.Name = "menuPrintSelection";
            this.menuPrintSelection.Size = new System.Drawing.Size(193, 22);
            this.menuPrintSelection.Text = "Print only &selected text";
            this.menuPrintSelection.ToolTipText = "Prints only your current seletion";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::SimpleEdit.Properties.Resources.ZoomHS;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // menuOptions
            // 
            this.menuOptions.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.menuOptions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuOptions.Image = ( (System.Drawing.Image)( resources.GetObject("menuOptions.Image") ) );
            this.menuOptions.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuOptions.Name = "menuOptions";
            this.menuOptions.Size = new System.Drawing.Size(62, 22);
            this.menuOptions.Text = "&Options";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 502);
            this.Controls.Add(this.textBoxSimple);
            this.Controls.Add(this.textBoxRich);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ( (System.Drawing.Icon)( resources.GetObject("$this.Icon") ) );
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SimpleEdit";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.TextBox textBoxSimple;
        private System.Windows.Forms.RichTextBox textBoxRich;
        private System.Windows.Forms.ToolStrip menuStrip;
        private System.Windows.Forms.ToolStripDropDownButton menuNew;
        private System.Windows.Forms.ToolStripMenuItem menuNewText;
        private System.Windows.Forms.ToolStripMenuItem menuNewRich;
        private System.Windows.Forms.ToolStripSplitButton menuOpen;
        private System.Windows.Forms.ToolStripSplitButton menuPrint;
        private System.Windows.Forms.ToolStripMenuItem menuPrintSelection;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripTextBox menuSearchBar;
        private System.Windows.Forms.ToolStripDropDownButton menuOptions;
    }
}

