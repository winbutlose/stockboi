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
            this.currentpriceLabel = new System.Windows.Forms.Label();
            this.strikepricelabel = new System.Windows.Forms.Label();
            this.askpricelabel = new System.Windows.Forms.Label();
            this.calculatebutton = new System.Windows.Forms.Button();
            this.strikepricebox = new System.Windows.Forms.TextBox();
            this.askpricebox = new System.Windows.Forms.TextBox();
            this.currentpricebox = new System.Windows.Forms.TextBox();
            this.outputbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // titlelabel
            // 
            this.titlelabel.AutoSize = true;
            this.titlelabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlelabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.titlelabel.Location = new System.Drawing.Point(175, 9);
            this.titlelabel.Name = "titlelabel";
            this.titlelabel.Size = new System.Drawing.Size(277, 37);
            this.titlelabel.TabIndex = 0;
            this.titlelabel.Text = "Stock Option Helper";
            this.titlelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // optiontypebox
            // 
            this.optiontypebox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optiontypebox.FormattingEnabled = true;
            this.optiontypebox.Location = new System.Drawing.Point(44, 169);
            this.optiontypebox.Name = "optiontypebox";
            this.optiontypebox.Size = new System.Drawing.Size(121, 29);
            this.optiontypebox.TabIndex = 1;
            // 
            // optiontypelabel
            // 
            this.optiontypelabel.AutoSize = true;
            this.optiontypelabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optiontypelabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.optiontypelabel.Location = new System.Drawing.Point(41, 148);
            this.optiontypelabel.Name = "optiontypelabel";
            this.optiontypelabel.Size = new System.Drawing.Size(103, 21);
            this.optiontypelabel.TabIndex = 2;
            this.optiontypelabel.Text = "Option Type";
            // 
            // currentpriceLabel
            // 
            this.currentpriceLabel.AutoSize = true;
            this.currentpriceLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentpriceLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.currentpriceLabel.Location = new System.Drawing.Point(41, 93);
            this.currentpriceLabel.Name = "currentpriceLabel";
            this.currentpriceLabel.Size = new System.Drawing.Size(109, 21);
            this.currentpriceLabel.TabIndex = 4;
            this.currentpriceLabel.Text = "Current Price";
            // 
            // strikepricelabel
            // 
            this.strikepricelabel.AutoSize = true;
            this.strikepricelabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.strikepricelabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.strikepricelabel.Location = new System.Drawing.Point(41, 206);
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
            this.askpricelabel.Location = new System.Drawing.Point(41, 266);
            this.askpricelabel.Name = "askpricelabel";
            this.askpricelabel.Size = new System.Drawing.Size(79, 21);
            this.askpricelabel.TabIndex = 8;
            this.askpricelabel.Text = "Ask Price";
            // 
            // calculatebutton
            // 
            this.calculatebutton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculatebutton.Location = new System.Drawing.Point(43, 337);
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
            this.strikepricebox.Location = new System.Drawing.Point(45, 234);
            this.strikepricebox.Name = "strikepricebox";
            this.strikepricebox.Size = new System.Drawing.Size(120, 29);
            this.strikepricebox.TabIndex = 10;
            // 
            // askpricebox
            // 
            this.askpricebox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.askpricebox.Location = new System.Drawing.Point(43, 290);
            this.askpricebox.Name = "askpricebox";
            this.askpricebox.Size = new System.Drawing.Size(120, 29);
            this.askpricebox.TabIndex = 11;
            // 
            // currentpricebox
            // 
            this.currentpricebox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentpricebox.Location = new System.Drawing.Point(45, 117);
            this.currentpricebox.Name = "currentpricebox";
            this.currentpricebox.Size = new System.Drawing.Size(120, 29);
            this.currentpricebox.TabIndex = 12;
            // 
            // outputbox
            // 
            this.outputbox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputbox.Location = new System.Drawing.Point(281, 93);
            this.outputbox.Multiline = true;
            this.outputbox.Name = "outputbox";
            this.outputbox.Size = new System.Drawing.Size(322, 276);
            this.outputbox.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(645, 422);
            this.Controls.Add(this.outputbox);
            this.Controls.Add(this.currentpricebox);
            this.Controls.Add(this.askpricebox);
            this.Controls.Add(this.strikepricebox);
            this.Controls.Add(this.calculatebutton);
            this.Controls.Add(this.askpricelabel);
            this.Controls.Add(this.strikepricelabel);
            this.Controls.Add(this.currentpriceLabel);
            this.Controls.Add(this.optiontypelabel);
            this.Controls.Add(this.optiontypebox);
            this.Controls.Add(this.titlelabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titlelabel;
        private System.Windows.Forms.ComboBox optiontypebox;
        private System.Windows.Forms.Label optiontypelabel;
        private System.Windows.Forms.Label currentpriceLabel;
        private System.Windows.Forms.Label strikepricelabel;
        private System.Windows.Forms.Label askpricelabel;
        private System.Windows.Forms.Button calculatebutton;
        private System.Windows.Forms.TextBox strikepricebox;
        private System.Windows.Forms.TextBox askpricebox;
        private System.Windows.Forms.TextBox currentpricebox;
        private System.Windows.Forms.TextBox outputbox;
    }
}

