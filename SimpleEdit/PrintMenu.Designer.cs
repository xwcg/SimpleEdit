namespace SimpleEdit
{
    partial class PrintMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numCopies = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboPrinters = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.radioColorRGB = new System.Windows.Forms.RadioButton();
            this.radioColorBW = new System.Windows.Forms.RadioButton();
            this.radioRadioOrientationLandscape = new System.Windows.Forms.RadioButton();
            this.radioOrientationPortrait = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ( (System.ComponentModel.ISupportInitialize)( this.numCopies ) ).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 469);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(367, 91);
            this.panel1.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.DialogResult = System.Windows.Forms.DialogResult.Retry;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.button3.Location = new System.Drawing.Point(135, 50);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 25);
            this.button3.TabIndex = 0;
            this.button3.Text = "Preview";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.button1.Location = new System.Drawing.Point(146, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Print!";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "How many copies?";
            // 
            // numCopies
            // 
            this.numCopies.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numCopies.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.numCopies.Location = new System.Drawing.Point(45, 58);
            this.numCopies.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numCopies.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCopies.Name = "numCopies";
            this.numCopies.Size = new System.Drawing.Size(93, 25);
            this.numCopies.TabIndex = 2;
            this.numCopies.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numCopies.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(25, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Paper Orientation?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(25, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Printer?";
            // 
            // comboPrinters
            // 
            this.comboPrinters.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboPrinters.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboPrinters.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.comboPrinters.FormattingEnabled = true;
            this.comboPrinters.Location = new System.Drawing.Point(45, 347);
            this.comboPrinters.Name = "comboPrinters";
            this.comboPrinters.Size = new System.Drawing.Size(310, 28);
            this.comboPrinters.TabIndex = 4;
            this.comboPrinters.SelectedIndexChanged += new System.EventHandler(this.comboPrinters_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(25, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Colour?";
            // 
            // radioColorRGB
            // 
            this.radioColorRGB.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioColorRGB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.radioColorRGB.Image = global::SimpleEdit.Properties.Resources.color;
            this.radioColorRGB.Location = new System.Drawing.Point(116, 3);
            this.radioColorRGB.Name = "radioColorRGB";
            this.radioColorRGB.Size = new System.Drawing.Size(65, 65);
            this.radioColorRGB.TabIndex = 3;
            this.radioColorRGB.UseVisualStyleBackColor = true;
            // 
            // radioColorBW
            // 
            this.radioColorBW.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioColorBW.Checked = true;
            this.radioColorBW.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.radioColorBW.Image = global::SimpleEdit.Properties.Resources.bnw;
            this.radioColorBW.Location = new System.Drawing.Point(45, 3);
            this.radioColorBW.Name = "radioColorBW";
            this.radioColorBW.Size = new System.Drawing.Size(65, 65);
            this.radioColorBW.TabIndex = 3;
            this.radioColorBW.TabStop = true;
            this.radioColorBW.UseVisualStyleBackColor = true;
            // 
            // radioRadioOrientationLandscape
            // 
            this.radioRadioOrientationLandscape.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioRadioOrientationLandscape.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.radioRadioOrientationLandscape.Image = global::SimpleEdit.Properties.Resources.Generic_Document2;
            this.radioRadioOrientationLandscape.Location = new System.Drawing.Point(116, 138);
            this.radioRadioOrientationLandscape.Name = "radioRadioOrientationLandscape";
            this.radioRadioOrientationLandscape.Size = new System.Drawing.Size(65, 65);
            this.radioRadioOrientationLandscape.TabIndex = 3;
            this.radioRadioOrientationLandscape.UseVisualStyleBackColor = true;
            // 
            // radioOrientationPortrait
            // 
            this.radioOrientationPortrait.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioOrientationPortrait.Checked = true;
            this.radioOrientationPortrait.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.radioOrientationPortrait.Image = global::SimpleEdit.Properties.Resources.Generic_Document;
            this.radioOrientationPortrait.Location = new System.Drawing.Point(45, 138);
            this.radioOrientationPortrait.Name = "radioOrientationPortrait";
            this.radioOrientationPortrait.Size = new System.Drawing.Size(65, 65);
            this.radioOrientationPortrait.TabIndex = 3;
            this.radioOrientationPortrait.TabStop = true;
            this.radioOrientationPortrait.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioColorBW);
            this.panel2.Controls.Add(this.radioColorRGB);
            this.panel2.Location = new System.Drawing.Point(0, 242);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(367, 78);
            this.panel2.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.groupBox1.Location = new System.Drawing.Point(12, 390);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 62);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Advanced Options";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.button2.Location = new System.Drawing.Point(6, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(331, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "I know what I am doing. Show me the real magic.";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // PrintMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(367, 560);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.comboPrinters);
            this.Controls.Add(this.radioRadioOrientationLandscape);
            this.Controls.Add(this.radioOrientationPortrait);
            this.Controls.Add(this.numCopies);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ( (System.Drawing.Icon)( resources.GetObject("$this.Icon") ) );
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PrintMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Print Document";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ( (System.ComponentModel.ISupportInitialize)( this.numCopies ) ).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numCopies;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioOrientationPortrait;
        private System.Windows.Forms.RadioButton radioRadioOrientationLandscape;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboPrinters;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioColorBW;
        private System.Windows.Forms.RadioButton radioColorRGB;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}