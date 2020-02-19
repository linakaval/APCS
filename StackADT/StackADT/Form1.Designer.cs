namespace StackADT
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblExpression = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Postfix Expression";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(96, 96);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(236, 20);
            this.txtInput.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(147, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblExpression
            // 
            this.lblExpression.AutoSize = true;
            this.lblExpression.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpression.Location = new System.Drawing.Point(214, 234);
            this.lblExpression.Name = "lblExpression";
            this.lblExpression.Size = new System.Drawing.Size(0, 18);
            this.lblExpression.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Answer";
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Location = new System.Drawing.Point(214, 305);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(0, 13);
            this.lblAnswer.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 427);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblExpression);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Postfix Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblExpression;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAnswer;
    }
}

