namespace stockboi
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
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
            this.titlelabel = new System.Windows.Forms.Label();
            this.optiontypebox = new System.Windows.Forms.ComboBox();
            this.optiontypelabel = new System.Windows.Forms.Label();
            this.strikepricelabel = new System.Windows.Forms.Label();
            this.askpricelabel = new System.Windows.Forms.Label();
            this.calculatebutton = new System.Windows.Forms.Button();
            this.strikepricebox = new System.Windows.Forms.TextBox();
            this.askpricebox = new System.Windows.Forms.TextBox();
            this.outputbox = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.twopercentoutputbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.stoplosspricetextbox = new System.Windows.Forms.TextBox();
            this.ppslabel = new System.Windows.Forms.Label();
            this.ppstextbox = new System.Windows.Forms.TextBox();
            this.acctvaluelabel = new System.Windows.Forms.Label();
            this.acctvaluetextbox = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.currentpriceLabel = new System.Windows.Forms.Label();
            this.currentpricebox = new System.Windows.Forms.TextBox();
            this.calculaterulebutton = new System.Windows.Forms.Button();
            this.melabel = new System.Windows.Forms.Label();
            this.toggleverbosebutton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // titlelabel
            // 
            this.titlelabel.AutoSize = true;
            this.titlelabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlelabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.titlelabel.Location = new System.Drawing.Point(207, 12);
            this.titlelabel.Name = "titlelabel";
            this.titlelabel.Size = new System.Drawing.Size(204, 37);
            this.titlelabel.TabIndex = 0;
            this.titlelabel.Text = "Trading Buddy";
            this.titlelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // optiontypebox
            // 
            this.optiontypebox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optiontypebox.FormattingEnabled = true;
            this.optiontypebox.Location = new System.Drawing.Point(47, 118);
            this.optiontypebox.Name = "optiontypebox";
            this.optiontypebox.Size = new System.Drawing.Size(121, 29);
            this.optiontypebox.TabIndex = 1;
            // 
            // optiontypelabel
            // 
            this.optiontypelabel.AutoSize = true;
            this.optiontypelabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optiontypelabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.optiontypelabel.Location = new System.Drawing.Point(44, 97);
            this.optiontypelabel.Name = "optiontypelabel";
            this.optiontypelabel.Size = new System.Drawing.Size(103, 21);
            this.optiontypelabel.TabIndex = 2;
            this.optiontypelabel.Text = "Option Type";
            // 
            // strikepricelabel
            // 
            this.strikepricelabel.AutoSize = true;
            this.strikepricelabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.strikepricelabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.strikepricelabel.Location = new System.Drawing.Point(44, 155);
            this.strikepricelabel.Name = "strikepricelabel";
            this.strikepricelabel.Size = new System.Drawing.Size(96, 21);
            this.strikepricelabel.TabIndex = 6;
            this.strikepricelabel.Text = "Strike Price";
            // 
            // askpricelabel
            // 
            this.askpricelabel.AutoSize = true;
            this.askpricelabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.askpricelabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.askpricelabel.Location = new System.Drawing.Point(44, 215);
            this.askpricelabel.Name = "askpricelabel";
            this.askpricelabel.Size = new System.Drawing.Size(79, 21);
            this.askpricelabel.TabIndex = 8;
            this.askpricelabel.Text = "Ask Price";
            // 
            // calculatebutton
            // 
            this.calculatebutton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculatebutton.Location = new System.Drawing.Point(46, 286);
            this.calculatebutton.Name = "calculatebutton";
            this.calculatebutton.Size = new System.Drawing.Size(101, 32);
            this.calculatebutton.TabIndex = 9;
            this.calculatebutton.Text = "Calculate";
            this.calculatebutton.UseVisualStyleBackColor = true;
            this.calculatebutton.Click += new System.EventHandler(this.Calculatebutton_Click);
            // 
            // strikepricebox
            // 
            this.strikepricebox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.strikepricebox.Location = new System.Drawing.Point(48, 183);
            this.strikepricebox.Name = "strikepricebox";
            this.strikepricebox.Size = new System.Drawing.Size(120, 29);
            this.strikepricebox.TabIndex = 10;
            // 
            // askpricebox
            // 
            this.askpricebox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.askpricebox.Location = new System.Drawing.Point(46, 239);
            this.askpricebox.Name = "askpricebox";
            this.askpricebox.Size = new System.Drawing.Size(120, 29);
            this.askpricebox.TabIndex = 11;
            // 
            // outputbox
            // 
            this.outputbox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputbox.Location = new System.Drawing.Point(273, 42);
            this.outputbox.Multiline = true;
            this.outputbox.Name = "outputbox";
            this.outputbox.Size = new System.Drawing.Size(322, 276);
            this.outputbox.TabIndex = 13;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(0, 52);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(637, 423);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Black;
            this.tabPage2.Controls.Add(this.toggleverbosebutton);
            this.tabPage2.Controls.Add(this.calculaterulebutton);
            this.tabPage2.Controls.Add(this.twopercentoutputbox);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.stoplosspricetextbox);
            this.tabPage2.Controls.Add(this.ppslabel);
            this.tabPage2.Controls.Add(this.ppstextbox);
            this.tabPage2.Controls.Add(this.acctvaluelabel);
            this.tabPage2.Controls.Add(this.acctvaluetextbox);
            this.tabPage2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(629, 397);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "2% Rule";
            // 
            // twopercentoutputbox
            // 
            this.twopercentoutputbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twopercentoutputbox.Location = new System.Drawing.Point(259, 30);
            this.twopercentoutputbox.Multiline = true;
            this.twopercentoutputbox.Name = "twopercentoutputbox";
            this.twopercentoutputbox.ReadOnly = true;
            this.twopercentoutputbox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.twopercentoutputbox.Size = new System.Drawing.Size(351, 231);
            this.twopercentoutputbox.TabIndex = 19;
            this.twopercentoutputbox.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(66, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 21);
            this.label1.TabIndex = 25;
            this.label1.Text = "Stop Loss Price";
            // 
            // stoplosspricetextbox
            // 
            this.stoplosspricetextbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stoplosspricetextbox.Location = new System.Drawing.Point(69, 175);
            this.stoplosspricetextbox.Name = "stoplosspricetextbox";
            this.stoplosspricetextbox.Size = new System.Drawing.Size(120, 29);
            this.stoplosspricetextbox.TabIndex = 16;
            // 
            // ppslabel
            // 
            this.ppslabel.AutoSize = true;
            this.ppslabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ppslabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ppslabel.Location = new System.Drawing.Point(65, 89);
            this.ppslabel.Name = "ppslabel";
            this.ppslabel.Size = new System.Drawing.Size(124, 21);
            this.ppslabel.TabIndex = 26;
            this.ppslabel.Text = "Price Per Share";
            // 
            // ppstextbox
            // 
            this.ppstextbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ppstextbox.Location = new System.Drawing.Point(69, 113);
            this.ppstextbox.Name = "ppstextbox";
            this.ppstextbox.Size = new System.Drawing.Size(120, 29);
            this.ppstextbox.TabIndex = 15;
            // 
            // acctvaluelabel
            // 
            this.acctvaluelabel.AutoSize = true;
            this.acctvaluelabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acctvaluelabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.acctvaluelabel.Location = new System.Drawing.Point(65, 30);
            this.acctvaluelabel.Name = "acctvaluelabel";
            this.acctvaluelabel.Size = new System.Drawing.Size(120, 21);
            this.acctvaluelabel.TabIndex = 27;
            this.acctvaluelabel.Text = "Account Value";
            // 
            // acctvaluetextbox
            // 
            this.acctvaluetextbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acctvaluetextbox.Location = new System.Drawing.Point(69, 54);
            this.acctvaluetextbox.Name = "acctvaluetextbox";
            this.acctvaluetextbox.Size = new System.Drawing.Size(120, 29);
            this.acctvaluetextbox.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Black;
            this.tabPage1.Controls.Add(this.currentpriceLabel);
            this.tabPage1.Controls.Add(this.currentpricebox);
            this.tabPage1.Controls.Add(this.outputbox);
            this.tabPage1.Controls.Add(this.optiontypebox);
            this.tabPage1.Controls.Add(this.optiontypelabel);
            this.tabPage1.Controls.Add(this.askpricebox);
            this.tabPage1.Controls.Add(this.strikepricelabel);
            this.tabPage1.Controls.Add(this.strikepricebox);
            this.tabPage1.Controls.Add(this.askpricelabel);
            this.tabPage1.Controls.Add(this.calculatebutton);
            this.tabPage1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(629, 397);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Options";
            // 
            // currentpriceLabel
            // 
            this.currentpriceLabel.AutoSize = true;
            this.currentpriceLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentpriceLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.currentpriceLabel.Location = new System.Drawing.Point(42, 42);
            this.currentpriceLabel.Name = "currentpriceLabel";
            this.currentpriceLabel.Size = new System.Drawing.Size(109, 21);
            this.currentpriceLabel.TabIndex = 14;
            this.currentpriceLabel.Text = "Current Price";
            // 
            // currentpricebox
            // 
            this.currentpricebox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentpricebox.Location = new System.Drawing.Point(46, 66);
            this.currentpricebox.Name = "currentpricebox";
            this.currentpricebox.Size = new System.Drawing.Size(120, 29);
            this.currentpricebox.TabIndex = 15;
            // 
            // calculaterulebutton
            // 
            this.calculaterulebutton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculaterulebutton.Location = new System.Drawing.Point(69, 229);
            this.calculaterulebutton.Name = "calculaterulebutton";
            this.calculaterulebutton.Size = new System.Drawing.Size(101, 32);
            this.calculaterulebutton.TabIndex = 17;
            this.calculaterulebutton.Text = "Calculate";
            this.calculaterulebutton.UseVisualStyleBackColor = true;
            this.calculaterulebutton.Click += new System.EventHandler(this.calculaterulebutton_Click);
            // 
            // melabel
            // 
            this.melabel.AutoSize = true;
            this.melabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.melabel.Location = new System.Drawing.Point(558, 9);
            this.melabel.Name = "melabel";
            this.melabel.Size = new System.Drawing.Size(75, 13);
            this.melabel.TabIndex = 15;
            this.melabel.Text = "By Winbutlose";
            // 
            // toggleverbosebutton
            // 
            this.toggleverbosebutton.BackColor = System.Drawing.Color.Red;
            this.toggleverbosebutton.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toggleverbosebutton.Location = new System.Drawing.Point(511, 357);
            this.toggleverbosebutton.Name = "toggleverbosebutton";
            this.toggleverbosebutton.Size = new System.Drawing.Size(111, 32);
            this.toggleverbosebutton.TabIndex = 28;
            this.toggleverbosebutton.Text = "Verbose Output";
            this.toggleverbosebutton.UseVisualStyleBackColor = false;
            this.toggleverbosebutton.Click += new System.EventHandler(this.toggleverbosebutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(637, 475);
            this.Controls.Add(this.melabel);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.titlelabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titlelabel;
        private System.Windows.Forms.ComboBox optiontypebox;
        private System.Windows.Forms.Label optiontypelabel;
        private System.Windows.Forms.Label strikepricelabel;
        private System.Windows.Forms.Label askpricelabel;
        private System.Windows.Forms.Button calculatebutton;
        private System.Windows.Forms.TextBox strikepricebox;
        private System.Windows.Forms.TextBox askpricebox;
        private System.Windows.Forms.TextBox outputbox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox twopercentoutputbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox stoplosspricetextbox;
        private System.Windows.Forms.Label ppslabel;
        private System.Windows.Forms.TextBox ppstextbox;
        private System.Windows.Forms.Label acctvaluelabel;
        private System.Windows.Forms.TextBox acctvaluetextbox;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label currentpriceLabel;
        private System.Windows.Forms.TextBox currentpricebox;
        private System.Windows.Forms.Button calculaterulebutton;
        private System.Windows.Forms.Label melabel;
        private System.Windows.Forms.Button toggleverbosebutton;
    }
}

