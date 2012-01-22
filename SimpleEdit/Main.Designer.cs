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
            this.labelStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.textBoxSimple = new System.Windows.Forms.TextBox();
            this.textBoxRich = new System.Windows.Forms.RichTextBox();
            this.menuStrip = new System.Windows.Forms.ToolStrip();
            this.menuNew = new System.Windows.Forms.ToolStripDropDownButton();
            this.menuNewText = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNewRich = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOpen = new System.Windows.Forms.ToolStripSplitButton();
            this.menuPrint = new System.Windows.Forms.ToolStripSplitButton();
            this.menuPrintSelection = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSearch = new System.Windows.Forms.ToolStripButton();
            this.menuSearchBar = new System.Windows.Forms.ToolStripTextBox();
            this.menuOptions = new System.Windows.Forms.ToolStripDropDownButton();
            this.menuOptionsWordWrap = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuEdit = new System.Windows.Forms.ToolStripDropDownButton();
            this.menuEditUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuEditCut = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuEditSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditExtras = new System.Windows.Forms.ToolStripMenuItem();
            this.toolBar = new System.Windows.Forms.ToolStrip();
            this.toolBold = new System.Windows.Forms.ToolStripButton();
            this.toolItalic = new System.Windows.Forms.ToolStripButton();
            this.toolUnderline = new System.Windows.Forms.ToolStripButton();
            this.toolStrike = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolAlignLeft = new System.Windows.Forms.ToolStripButton();
            this.toolAlignCenter = new System.Windows.Forms.ToolStripButton();
            this.toolAlignRight = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolFontList = new System.Windows.Forms.ToolStripComboBox();
            this.toolFontSize = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.menuEditConvert = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.menuEditConvertRich = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditConvertText = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.toolBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelStatus});
            this.statusStrip.Location = new System.Drawing.Point(0, 480);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.statusStrip.Size = new System.Drawing.Size(808, 22);
            this.statusStrip.TabIndex = 0;
            this.statusStrip.Text = "statusStrip1";
            // 
            // labelStatus
            // 
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(39, 17);
            this.labelStatus.Text = "Status";
            // 
            // textBoxSimple
            // 
            this.textBoxSimple.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSimple.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxSimple.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.textBoxSimple.Location = new System.Drawing.Point(0, 53);
            this.textBoxSimple.Margin = new System.Windows.Forms.Padding(10);
            this.textBoxSimple.MaxLength = 2147483647;
            this.textBoxSimple.Multiline = true;
            this.textBoxSimple.Name = "textBoxSimple";
            this.textBoxSimple.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxSimple.Size = new System.Drawing.Size(808, 427);
            this.textBoxSimple.TabIndex = 2;
            // 
            // textBoxRich
            // 
            this.textBoxRich.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRich.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxRich.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.textBoxRich.Location = new System.Drawing.Point(0, 53);
            this.textBoxRich.Name = "textBoxRich";
            this.textBoxRich.Size = new System.Drawing.Size(808, 427);
            this.textBoxRich.TabIndex = 3;
            this.textBoxRich.Text = "";
            this.textBoxRich.Visible = false;
            this.textBoxRich.SelectionChanged += new System.EventHandler(this.textBoxRich_SelectionChanged);
            // 
            // menuStrip
            // 
            this.menuStrip.AllowMerge = false;
            this.menuStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNew,
            this.menuOpen,
            this.menuPrint,
            this.menuSearch,
            this.menuSearchBar,
            this.menuOptions,
            this.toolStripSeparator1,
            this.menuEdit});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(808, 25);
            this.menuStrip.TabIndex = 4;
            this.menuStrip.Text = "toolStrip1";
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
            this.menuNewText.Size = new System.Drawing.Size(152, 22);
            this.menuNewText.Text = "&Text File";
            this.menuNewText.ToolTipText = "A text document with no text formatting. Like a .txt file.";
            this.menuNewText.Click += new System.EventHandler(this.menuNewText_Click);
            // 
            // menuNewRich
            // 
            this.menuNewRich.Name = "menuNewRich";
            this.menuNewRich.Size = new System.Drawing.Size(152, 22);
            this.menuNewRich.Text = "&Rich Text File";
            this.menuNewRich.ToolTipText = "A rich text file with formatting. Like a word document.";
            this.menuNewRich.Click += new System.EventHandler(this.menuNewRich_Click);
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
            // menuSearch
            // 
            this.menuSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.menuSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.menuSearch.Image = global::SimpleEdit.Properties.Resources.ZoomHS;
            this.menuSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuSearch.Name = "menuSearch";
            this.menuSearch.Size = new System.Drawing.Size(23, 22);
            this.menuSearch.ToolTipText = "Search";
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
            this.menuSearchBar.Leave += new System.EventHandler(this.menuSearchBar_Leave);
            this.menuSearchBar.Enter += new System.EventHandler(this.menuSearchBar_Enter);
            // 
            // menuOptions
            // 
            this.menuOptions.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.menuOptions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuOptionsWordWrap});
            this.menuOptions.Image = ( (System.Drawing.Image)( resources.GetObject("menuOptions.Image") ) );
            this.menuOptions.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuOptions.Name = "menuOptions";
            this.menuOptions.Size = new System.Drawing.Size(62, 22);
            this.menuOptions.Text = "&Options";
            // 
            // menuOptionsWordWrap
            // 
            this.menuOptionsWordWrap.Name = "menuOptionsWordWrap";
            this.menuOptionsWordWrap.Size = new System.Drawing.Size(134, 22);
            this.menuOptionsWordWrap.Text = "Word Wrap";
            this.menuOptionsWordWrap.Click += new System.EventHandler(this.menuOptionsWordWrap_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // menuEdit
            // 
            this.menuEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuEditUndo,
            this.toolStripSeparator2,
            this.menuEditCut,
            this.menuEditCopy,
            this.menuEditPaste,
            this.toolStripSeparator3,
            this.menuEditSelectAll,
            this.menuEditConvert,
            this.toolStripSeparator7,
            this.menuEditExtras});
            this.menuEdit.Image = ( (System.Drawing.Image)( resources.GetObject("menuEdit.Image") ) );
            this.menuEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuEdit.Name = "menuEdit";
            this.menuEdit.Size = new System.Drawing.Size(40, 22);
            this.menuEdit.Text = "&Edit";
            // 
            // menuEditUndo
            // 
            this.menuEditUndo.Name = "menuEditUndo";
            this.menuEditUndo.ShortcutKeys = ( (System.Windows.Forms.Keys)( ( System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z ) ) );
            this.menuEditUndo.Size = new System.Drawing.Size(184, 22);
            this.menuEditUndo.Text = "&Undo";
            this.menuEditUndo.Click += new System.EventHandler(this.menuEditUndo_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(181, 6);
            // 
            // menuEditCut
            // 
            this.menuEditCut.Name = "menuEditCut";
            this.menuEditCut.ShortcutKeys = ( (System.Windows.Forms.Keys)( ( System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X ) ) );
            this.menuEditCut.Size = new System.Drawing.Size(184, 22);
            this.menuEditCut.Text = "C&ut";
            this.menuEditCut.Click += new System.EventHandler(this.menuEditCut_Click);
            // 
            // menuEditCopy
            // 
            this.menuEditCopy.Name = "menuEditCopy";
            this.menuEditCopy.ShortcutKeys = ( (System.Windows.Forms.Keys)( ( System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C ) ) );
            this.menuEditCopy.Size = new System.Drawing.Size(184, 22);
            this.menuEditCopy.Text = "&Copy";
            this.menuEditCopy.Click += new System.EventHandler(this.menuEditCopy_Click);
            // 
            // menuEditPaste
            // 
            this.menuEditPaste.Name = "menuEditPaste";
            this.menuEditPaste.ShortcutKeys = ( (System.Windows.Forms.Keys)( ( System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V ) ) );
            this.menuEditPaste.Size = new System.Drawing.Size(184, 22);
            this.menuEditPaste.Text = "&Paste";
            this.menuEditPaste.Click += new System.EventHandler(this.menuEditPaste_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(181, 6);
            // 
            // menuEditSelectAll
            // 
            this.menuEditSelectAll.Name = "menuEditSelectAll";
            this.menuEditSelectAll.ShortcutKeys = ( (System.Windows.Forms.Keys)( ( System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A ) ) );
            this.menuEditSelectAll.Size = new System.Drawing.Size(184, 22);
            this.menuEditSelectAll.Text = "Select &All";
            this.menuEditSelectAll.Click += new System.EventHandler(this.menuEditSelectAll_Click);
            // 
            // menuEditExtras
            // 
            this.menuEditExtras.Name = "menuEditExtras";
            this.menuEditExtras.Size = new System.Drawing.Size(184, 22);
            this.menuEditExtras.Text = "E&xtras...";
            // 
            // toolBar
            // 
            this.toolBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBold,
            this.toolItalic,
            this.toolUnderline,
            this.toolStrike,
            this.toolStripSeparator6,
            this.toolAlignLeft,
            this.toolAlignCenter,
            this.toolAlignRight,
            this.toolStripSeparator4,
            this.toolFontList,
            this.toolFontSize,
            this.toolStripSeparator5});
            this.toolBar.Location = new System.Drawing.Point(0, 25);
            this.toolBar.Name = "toolBar";
            this.toolBar.Padding = new System.Windows.Forms.Padding(10, 0, 1, 0);
            this.toolBar.Size = new System.Drawing.Size(808, 28);
            this.toolBar.TabIndex = 5;
            this.toolBar.Text = "Formatting Tool Bar";
            // 
            // toolBold
            // 
            this.toolBold.CheckOnClick = true;
            this.toolBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolBold.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBold.Name = "toolBold";
            this.toolBold.Padding = new System.Windows.Forms.Padding(3);
            this.toolBold.Size = new System.Drawing.Size(25, 25);
            this.toolBold.Text = "B";
            this.toolBold.ToolTipText = "Bold (Thick letters)";
            this.toolBold.Click += new System.EventHandler(this.toolBold_Click);
            // 
            // toolItalic
            // 
            this.toolItalic.CheckOnClick = true;
            this.toolItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolItalic.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.toolItalic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolItalic.Name = "toolItalic";
            this.toolItalic.Padding = new System.Windows.Forms.Padding(3);
            this.toolItalic.Size = new System.Drawing.Size(23, 25);
            this.toolItalic.Text = "I";
            this.toolItalic.ToolTipText = "Italics (Slanted letters)";
            this.toolItalic.Click += new System.EventHandler(this.toolItalic_Click);
            // 
            // toolUnderline
            // 
            this.toolUnderline.CheckOnClick = true;
            this.toolUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolUnderline.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline);
            this.toolUnderline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolUnderline.Name = "toolUnderline";
            this.toolUnderline.Padding = new System.Windows.Forms.Padding(3);
            this.toolUnderline.Size = new System.Drawing.Size(25, 25);
            this.toolUnderline.Text = "U";
            this.toolUnderline.ToolTipText = "Underlined (Line under letters)";
            this.toolUnderline.Click += new System.EventHandler(this.toolUnderline_Click);
            // 
            // toolStrike
            // 
            this.toolStrike.CheckOnClick = true;
            this.toolStrike.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStrike.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Strikeout);
            this.toolStrike.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrike.Name = "toolStrike";
            this.toolStrike.Padding = new System.Windows.Forms.Padding(3);
            this.toolStrike.Size = new System.Drawing.Size(23, 25);
            this.toolStrike.Text = "S";
            this.toolStrike.ToolTipText = "Striked (Line through letters)";
            this.toolStrike.Click += new System.EventHandler(this.toolStrike_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 28);
            // 
            // toolAlignLeft
            // 
            this.toolAlignLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolAlignLeft.Image = global::SimpleEdit.Properties.Resources.AlignTableCellMiddleLeftJustHS;
            this.toolAlignLeft.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAlignLeft.Name = "toolAlignLeft";
            this.toolAlignLeft.Size = new System.Drawing.Size(23, 25);
            this.toolAlignLeft.Text = "toolStripButton1";
            this.toolAlignLeft.Click += new System.EventHandler(this.toolAlignLeft_Click);
            // 
            // toolAlignCenter
            // 
            this.toolAlignCenter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolAlignCenter.Image = global::SimpleEdit.Properties.Resources.AlignTableCellMiddleCenterHS;
            this.toolAlignCenter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAlignCenter.Name = "toolAlignCenter";
            this.toolAlignCenter.Size = new System.Drawing.Size(23, 25);
            this.toolAlignCenter.Text = "toolStripButton2";
            this.toolAlignCenter.Click += new System.EventHandler(this.toolAlignCenter_Click);
            // 
            // toolAlignRight
            // 
            this.toolAlignRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolAlignRight.Image = global::SimpleEdit.Properties.Resources.AlignTableCellMiddleRightHS;
            this.toolAlignRight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAlignRight.Name = "toolAlignRight";
            this.toolAlignRight.Size = new System.Drawing.Size(23, 25);
            this.toolAlignRight.Text = "toolStripButton3";
            this.toolAlignRight.Click += new System.EventHandler(this.toolAlignRight_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 28);
            // 
            // toolFontList
            // 
            this.toolFontList.Name = "toolFontList";
            this.toolFontList.Size = new System.Drawing.Size(121, 28);
            this.toolFontList.SelectedIndexChanged += new System.EventHandler(this.toolFontList_SelectedIndexChanged);
            // 
            // toolFontSize
            // 
            this.toolFontSize.AutoSize = false;
            this.toolFontSize.DropDownWidth = 50;
            this.toolFontSize.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "36",
            "48",
            "72"});
            this.toolFontSize.Name = "toolFontSize";
            this.toolFontSize.Size = new System.Drawing.Size(50, 23);
            this.toolFontSize.SelectedIndexChanged += new System.EventHandler(this.toolFontSize_SelectedIndexChanged);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 28);
            // 
            // menuEditConvert
            // 
            this.menuEditConvert.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuEditConvertRich,
            this.menuEditConvertText});
            this.menuEditConvert.Name = "menuEditConvert";
            this.menuEditConvert.Size = new System.Drawing.Size(184, 22);
            this.menuEditConvert.Text = "Convert Document...";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(181, 6);
            // 
            // menuEditConvertRich
            // 
            this.menuEditConvertRich.Name = "menuEditConvertRich";
            this.menuEditConvertRich.Size = new System.Drawing.Size(152, 22);
            this.menuEditConvertRich.Text = "To Rich Text";
            this.menuEditConvertRich.Click += new System.EventHandler(this.menuEditConvertRich_Click);
            // 
            // menuEditConvertText
            // 
            this.menuEditConvertText.Name = "menuEditConvertText";
            this.menuEditConvertText.Size = new System.Drawing.Size(152, 22);
            this.menuEditConvertText.Text = "To Text";
            this.menuEditConvertText.Click += new System.EventHandler(this.menuEditConvertText_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 502);
            this.Controls.Add(this.textBoxRich);
            this.Controls.Add(this.textBoxSimple);
            this.Controls.Add(this.toolBar);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ( (System.Drawing.Icon)( resources.GetObject("$this.Icon") ) );
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SimpleEdit";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolBar.ResumeLayout(false);
            this.toolBar.PerformLayout();
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
        private System.Windows.Forms.ToolStripButton menuSearch;
        private System.Windows.Forms.ToolStripTextBox menuSearchBar;
        private System.Windows.Forms.ToolStripDropDownButton menuOptions;
        private System.Windows.Forms.ToolStripMenuItem menuOptionsWordWrap;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton menuEdit;
        private System.Windows.Forms.ToolStripMenuItem menuEditUndo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem menuEditCut;
        private System.Windows.Forms.ToolStripMenuItem menuEditCopy;
        private System.Windows.Forms.ToolStripMenuItem menuEditPaste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem menuEditSelectAll;
        private System.Windows.Forms.ToolStripMenuItem menuEditExtras;
        private System.Windows.Forms.ToolStrip toolBar;
        private System.Windows.Forms.ToolStripButton toolBold;
        private System.Windows.Forms.ToolStripButton toolItalic;
        private System.Windows.Forms.ToolStripButton toolUnderline;
        private System.Windows.Forms.ToolStripStatusLabel labelStatus;
        private System.Windows.Forms.ToolStripButton toolStrike;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripComboBox toolFontList;
        private System.Windows.Forms.ToolStripComboBox toolFontSize;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolAlignLeft;
        private System.Windows.Forms.ToolStripButton toolAlignCenter;
        private System.Windows.Forms.ToolStripButton toolAlignRight;
        private System.Windows.Forms.ToolStripMenuItem menuEditConvert;
        private System.Windows.Forms.ToolStripMenuItem menuEditConvertRich;
        private System.Windows.Forms.ToolStripMenuItem menuEditConvertText;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
    }
}

