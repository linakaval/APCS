namespace SortingStuff
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
            this.cmdCheck = new System.Windows.Forms.Button();
            this.txtMaxValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmdGo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblResults = new System.Windows.Forms.Label();
            this.txtLongQty = new System.Windows.Forms.TextBox();
            this.txtShortQty = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdCheck
            // 
            this.cmdCheck.Location = new System.Drawing.Point(509, 38);
            this.cmdCheck.Name = "cmdCheck";
            this.cmdCheck.Size = new System.Drawing.Size(75, 23);
            this.cmdCheck.TabIndex = 16;
            this.cmdCheck.Text = "Check Data";
            this.cmdCheck.Click += new System.EventHandler(this.cmdCheck_Click);
            // 
            // txtMaxValue
            // 
            this.txtMaxValue.Location = new System.Drawing.Point(285, 38);
            this.txtMaxValue.Name = "txtMaxValue";
            this.txtMaxValue.Size = new System.Drawing.Size(56, 20);
            this.txtMaxValue.TabIndex = 12;
            this.txtMaxValue.Text = "1000";
            this.txtMaxValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(269, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 23);
            this.label3.TabIndex = 15;
            this.label3.Text = "Max Value";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // cmdGo
            // 
            this.cmdGo.Location = new System.Drawing.Point(381, 38);
            this.cmdGo.Name = "cmdGo";
            this.cmdGo.Size = new System.Drawing.Size(75, 23);
            this.cmdGo.TabIndex = 13;
            this.cmdGo.Text = "Go";
            this.cmdGo.Click += new System.EventHandler(this.cmdGo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblResults);
            this.groupBox1.Location = new System.Drawing.Point(53, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(552, 230);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Results";
            // 
            // lblResults
            // 
            this.lblResults.BackColor = System.Drawing.Color.Linen;
            this.lblResults.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResults.Location = new System.Drawing.Point(16, 24);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(520, 190);
            this.lblResults.TabIndex = 0;
            // 
            // txtLongQty
            // 
            this.txtLongQty.Location = new System.Drawing.Point(181, 38);
            this.txtLongQty.Name = "txtLongQty";
            this.txtLongQty.Size = new System.Drawing.Size(56, 20);
            this.txtLongQty.TabIndex = 10;
            this.txtLongQty.Text = "10000";
            this.txtLongQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtShortQty
            // 
            this.txtShortQty.Location = new System.Drawing.Point(69, 38);
            this.txtShortQty.Name = "txtShortQty";
            this.txtShortQty.Size = new System.Drawing.Size(40, 20);
            this.txtShortQty.TabIndex = 8;
            this.txtShortQty.Text = "5000";
            this.txtShortQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(157, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Quantity for long list";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(37, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Quantity for short list";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 328);
            this.Controls.Add(this.cmdCheck);
            this.Controls.Add(this.txtMaxValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmdGo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtLongQty);
            this.Controls.Add(this.txtShortQty);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Sorting Stuff";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdCheck;
        private System.Windows.Forms.TextBox txtMaxValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cmdGo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.TextBox txtLongQty;
        private System.Windows.Forms.TextBox txtShortQty;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

