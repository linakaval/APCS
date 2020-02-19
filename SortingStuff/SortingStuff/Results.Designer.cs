namespace SortingStuff
{
    partial class Results
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
            this.label3 = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstSorts = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 13;
            this.label3.Text = "Count";
            // 
            // lblCount
            // 
            this.lblCount.Location = new System.Drawing.Point(18, 175);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(100, 23);
            this.lblCount.TabIndex = 12;
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(154, 47);
            this.txtData.Multiline = true;
            this.txtData.Name = "txtData";
            this.txtData.ReadOnly = true;
            this.txtData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtData.Size = new System.Drawing.Size(88, 456);
            this.txtData.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(154, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Data";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Sorts";
            // 
            // lstSorts
            // 
            this.lstSorts.Location = new System.Drawing.Point(18, 47);
            this.lstSorts.Name = "lstSorts";
            this.lstSorts.Size = new System.Drawing.Size(80, 69);
            this.lstSorts.TabIndex = 8;
            this.lstSorts.SelectedIndexChanged += new System.EventHandler(this.lstSorts_SelectedIndexChanged);
            // 
            // Results
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 526);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstSorts);
            this.Name = "Results";
            this.Text = "Results";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstSorts;
    }
}