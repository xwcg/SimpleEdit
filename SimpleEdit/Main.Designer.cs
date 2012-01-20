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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxSimple = new System.Windows.Forms.TextBox();
            this.textBoxRich = new System.Windows.Forms.RichTextBox();
            this.menuPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNewText = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNewRichText = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.statusStrip1.Location = new System.Drawing.Point(0, 480);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(808, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNew,
            this.menuOpen,
            this.menuPrint});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(808, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuNew
            // 
            this.menuNew.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNewText,
            this.menuNewRichText});
            this.menuNew.Name = "menuNew";
            this.menuNew.Size = new System.Drawing.Size(50, 20);
            this.menuNew.Text = "&New...";
            // 
            // menuOpen
            // 
            this.menuOpen.Name = "menuOpen";
            this.menuOpen.Size = new System.Drawing.Size(48, 20);
            this.menuOpen.Text = "&Open";
            // 
            // textBoxSimple
            // 
            this.textBoxSimple.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSimple.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxSimple.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.textBoxSimple.Location = new System.Drawing.Point(0, 24);
            this.textBoxSimple.Margin = new System.Windows.Forms.Padding(10);
            this.textBoxSimple.MaxLength = 2147483647;
            this.textBoxSimple.Multiline = true;
            this.textBoxSimple.Name = "textBoxSimple";
            this.textBoxSimple.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxSimple.Size = new System.Drawing.Size(808, 456);
            this.textBoxSimple.TabIndex = 2;
            // 
            // textBoxRich
            // 
            this.textBoxRich.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRich.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxRich.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.textBoxRich.Location = new System.Drawing.Point(0, 24);
            this.textBoxRich.Name = "textBoxRich";
            this.textBoxRich.Size = new System.Drawing.Size(808, 456);
            this.textBoxRich.TabIndex = 3;
            this.textBoxRich.Text = "";
            this.textBoxRich.Visible = false;
            // 
            // menuPrint
            // 
            this.menuPrint.Name = "menuPrint";
            this.menuPrint.Size = new System.Drawing.Size(46, 20);
            this.menuPrint.Text = "&Print";
            this.menuPrint.Click += new System.EventHandler(this.menuPrint_Click);
            // 
            // menuNewText
            // 
            this.menuNewText.AutoToolTip = true;
            this.menuNewText.Image = global::SimpleEdit.Properties.Resources.NewDocumentHS;
            this.menuNewText.Name = "menuNewText";
            this.menuNewText.Size = new System.Drawing.Size(180, 22);
            this.menuNewText.Text = "Text File";
            this.menuNewText.ToolTipText = "A text document with no text formatting. Like a .txt file.";
            // 
            // menuNewRichText
            // 
            this.menuNewRichText.AutoToolTip = true;
            this.menuNewRichText.Image = global::SimpleEdit.Properties.Resources.NewCardHS;
            this.menuNewRichText.Name = "menuNewRichText";
            this.menuNewRichText.Size = new System.Drawing.Size(180, 22);
            this.menuNewRichText.Text = "Rich Text Document";
            this.menuNewRichText.ToolTipText = "A rich text file with formatting. Like a word document.";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 502);
            this.Controls.Add(this.textBoxRich);
            this.Controls.Add(this.textBoxSimple);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ( (System.Drawing.Icon)( resources.GetObject("$this.Icon") ) );
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "SimpleEdit";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuNew;
        private System.Windows.Forms.ToolStripMenuItem menuOpen;
        private System.Windows.Forms.TextBox textBoxSimple;
        private System.Windows.Forms.RichTextBox textBoxRich;
        private System.Windows.Forms.ToolStripMenuItem menuNewText;
        private System.Windows.Forms.ToolStripMenuItem menuNewRichText;
        private System.Windows.Forms.ToolStripMenuItem menuPrint;
    }
}

