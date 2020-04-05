namespace CodeRead
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
            this.display = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aBOUTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBOUTSOFTWAREToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textSerial = new System.Windows.Forms.TextBox();
            this.generate = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Model = new System.Windows.Forms.Label();
            this.Serial = new System.Windows.Forms.Label();
            this.display2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // display
            // 
            this.display.AutoSize = true;
            this.display.Font = new System.Drawing.Font("Monospac821 BT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display.Location = new System.Drawing.Point(26, 325);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(0, 29);
            this.display.TabIndex = 5;
            this.display.Click += new System.EventHandler(this.label3_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aBOUTToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(373, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aBOUTToolStripMenuItem
            // 
            this.aBOUTToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.aBOUTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aBOUTSOFTWAREToolStripMenuItem});
            this.aBOUTToolStripMenuItem.Name = "aBOUTToolStripMenuItem";
            this.aBOUTToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.aBOUTToolStripMenuItem.Text = "ABOUT";
            // 
            // aBOUTSOFTWAREToolStripMenuItem
            // 
            this.aBOUTSOFTWAREToolStripMenuItem.Name = "aBOUTSOFTWAREToolStripMenuItem";
            this.aBOUTSOFTWAREToolStripMenuItem.Size = new System.Drawing.Size(205, 24);
            this.aBOUTSOFTWAREToolStripMenuItem.Text = "ABOUT SOFTWARE";
            this.aBOUTSOFTWAREToolStripMenuItem.Click += new System.EventHandler(this.aBOUTSOFTWAREToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monospac821 BT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Model Name:";
            // 
            // textName
            // 
            this.textName.Font = new System.Drawing.Font("Monospac821 BT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textName.Location = new System.Drawing.Point(55, 82);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(268, 35);
            this.textName.TabIndex = 2;
            this.textName.Text = " ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monospac821 BT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Serial Number: ";
            // 
            // textSerial
            // 
            this.textSerial.Font = new System.Drawing.Font("Monospac821 BT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSerial.Location = new System.Drawing.Point(55, 150);
            this.textSerial.Name = "textSerial";
            this.textSerial.Size = new System.Drawing.Size(268, 35);
            this.textSerial.TabIndex = 4;
            // 
            // generate
            // 
            this.generate.Font = new System.Drawing.Font("Monospac821 BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generate.Location = new System.Drawing.Point(55, 197);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(268, 36);
            this.generate.TabIndex = 6;
            this.generate.Text = "Generate Barcode";
            this.generate.UseVisualStyleBackColor = true;
            this.generate.Click += new System.EventHandler(this.generate_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Monospac821 BT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(133, 239);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 27);
            this.button2.TabIndex = 7;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Model
            // 
            this.Model.AutoSize = true;
            this.Model.Font = new System.Drawing.Font("Monospac821 BT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Model.Location = new System.Drawing.Point(26, 296);
            this.Model.Name = "Model";
            this.Model.Size = new System.Drawing.Size(167, 29);
            this.Model.TabIndex = 9;
            this.Model.Text = "Model Name:";
            this.Model.Click += new System.EventHandler(this.Model_Click);
            // 
            // Serial
            // 
            this.Serial.AutoSize = true;
            this.Serial.Font = new System.Drawing.Font("Monospac821 BT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Serial.Location = new System.Drawing.Point(26, 369);
            this.Serial.Name = "Serial";
            this.Serial.Size = new System.Drawing.Size(209, 29);
            this.Serial.TabIndex = 11;
            this.Serial.Text = "Serial Number:";
            this.Serial.Click += new System.EventHandler(this.Serial_Click);
            // 
            // display2
            // 
            this.display2.AutoSize = true;
            this.display2.Font = new System.Drawing.Font("Monospac821 BT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display2.Location = new System.Drawing.Point(26, 398);
            this.display2.Name = "display2";
            this.display2.Size = new System.Drawing.Size(0, 29);
            this.display2.TabIndex = 10;
            this.display2.Click += new System.EventHandler(this.display2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 507);
            this.Controls.Add(this.Serial);
            this.Controls.Add(this.display2);
            this.Controls.Add(this.Model);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.generate);
            this.Controls.Add(this.display);
            this.Controls.Add(this.textSerial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = ".:: CodeRead ::.";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label display;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aBOUTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBOUTSOFTWAREToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textSerial;
        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label Model;
        private System.Windows.Forms.Label Serial;
        private System.Windows.Forms.Label display2;

    }
}

