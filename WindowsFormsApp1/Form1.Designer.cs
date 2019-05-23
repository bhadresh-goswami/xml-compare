namespace WindowsFormsApp1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblFile2Name = new System.Windows.Forms.Label();
            this.lblFile1Name = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.xmlText1 = new System.Windows.Forms.RichTextBox();
            this.xmlText2 = new System.Windows.Forms.RichTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.xmlTextDiff = new System.Windows.Forms.RichTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(296, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Open File 1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(696, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Open File 2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.xmlText1);
            this.panel1.Location = new System.Drawing.Point(27, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 357);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.xmlText2);
            this.panel2.Location = new System.Drawing.Point(427, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(344, 357);
            this.panel2.TabIndex = 3;
            // 
            // lblFile2Name
            // 
            this.lblFile2Name.AutoSize = true;
            this.lblFile2Name.Location = new System.Drawing.Point(424, 51);
            this.lblFile2Name.Name = "lblFile2Name";
            this.lblFile2Name.Size = new System.Drawing.Size(0, 13);
            this.lblFile2Name.TabIndex = 4;
            // 
            // lblFile1Name
            // 
            this.lblFile1Name.AutoSize = true;
            this.lblFile1Name.Location = new System.Drawing.Point(24, 46);
            this.lblFile1Name.Name = "lblFile1Name";
            this.lblFile1Name.Size = new System.Drawing.Size(0, 13);
            this.lblFile1Name.TabIndex = 5;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "xml file";
            this.openFileDialog1.Filter = "xml files (*.xml)|*.xml";
            this.openFileDialog1.InitialDirectory = "C:\\";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "xml file 2";
            this.openFileDialog2.Filter = "xml files (*.xml)|*.xml";
            this.openFileDialog2.InitialDirectory = "C:\\";
            this.openFileDialog2.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog2_FileOk);
            // 
            // xmlText1
            // 
            this.xmlText1.Location = new System.Drawing.Point(15, 15);
            this.xmlText1.Name = "xmlText1";
            this.xmlText1.Size = new System.Drawing.Size(314, 326);
            this.xmlText1.TabIndex = 0;
            this.xmlText1.Text = "";
            // 
            // xmlText2
            // 
            this.xmlText2.Location = new System.Drawing.Point(15, 15);
            this.xmlText2.Name = "xmlText2";
            this.xmlText2.Size = new System.Drawing.Size(314, 326);
            this.xmlText2.TabIndex = 1;
            this.xmlText2.Text = "";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.xmlTextDiff);
            this.panel3.Location = new System.Drawing.Point(827, 70);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(344, 357);
            this.panel3.TabIndex = 6;
            // 
            // xmlTextDiff
            // 
            this.xmlTextDiff.Location = new System.Drawing.Point(15, 15);
            this.xmlTextDiff.Name = "xmlTextDiff";
            this.xmlTextDiff.Size = new System.Drawing.Size(314, 326);
            this.xmlTextDiff.TabIndex = 1;
            this.xmlTextDiff.Text = "";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1096, 41);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Procced";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 508);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lblFile1Name);
            this.Controls.Add(this.lblFile2Name);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblFile2Name;
        private System.Windows.Forms.Label lblFile1Name;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.RichTextBox xmlText1;
        private System.Windows.Forms.RichTextBox xmlText2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RichTextBox xmlTextDiff;
        private System.Windows.Forms.Button button3;
    }
}

