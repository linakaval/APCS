namespace Diver
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxDepth = new System.Windows.Forms.TextBox();
            this.btnEscape = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxSeed = new System.Windows.Forms.TextBox();
            this.btnNewCave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(27, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(515, 478);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(600, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 96);
            this.label1.TabIndex = 1;
            this.label1.Text = "Diver\'s Depth Rating (1-10)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtBoxDepth
            // 
            this.txtBoxDepth.Location = new System.Drawing.Point(604, 164);
            this.txtBoxDepth.Name = "txtBoxDepth";
            this.txtBoxDepth.Size = new System.Drawing.Size(70, 20);
            this.txtBoxDepth.TabIndex = 2;
            // 
            // btnEscape
            // 
            this.btnEscape.Location = new System.Drawing.Point(604, 190);
            this.btnEscape.Name = "btnEscape";
            this.btnEscape.Size = new System.Drawing.Size(70, 23);
            this.btnEscape.TabIndex = 3;
            this.btnEscape.Text = "Escape";
            this.btnEscape.UseVisualStyleBackColor = true;
            this.btnEscape.Click += new System.EventHandler(this.btnEscape_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(601, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 35);
            this.label2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(648, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Escape Path";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(603, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cave Seed Value";
            // 
            // txtBoxSeed
            // 
            this.txtBoxSeed.Location = new System.Drawing.Point(604, 369);
            this.txtBoxSeed.Name = "txtBoxSeed";
            this.txtBoxSeed.Size = new System.Drawing.Size(89, 20);
            this.txtBoxSeed.TabIndex = 8;
            // 
            // btnNewCave
            // 
            this.btnNewCave.Location = new System.Drawing.Point(609, 395);
            this.btnNewCave.Name = "btnNewCave";
            this.btnNewCave.Size = new System.Drawing.Size(75, 23);
            this.btnNewCave.TabIndex = 9;
            this.btnNewCave.Text = "New Cave";
            this.btnNewCave.UseVisualStyleBackColor = true;
            this.btnNewCave.Click += new System.EventHandler(this.btnNewCave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(609, 488);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 35);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.Location = new System.Drawing.Point(604, 292);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(0, 20);
            this.lblOutput.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 585);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnNewCave);
            this.Controls.Add(this.txtBoxSeed);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEscape);
            this.Controls.Add(this.txtBoxDepth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Diver Program";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxDepth;
        private System.Windows.Forms.Button btnEscape;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxSeed;
        private System.Windows.Forms.Button btnNewCave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblOutput;
    }
}

