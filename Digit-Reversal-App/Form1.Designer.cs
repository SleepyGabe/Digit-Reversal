
namespace OTFI1_Parinas_DigitReversal
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
            this.txt1 = new System.Windows.Forms.TextBox();
            this.Reverse = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOut = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter number";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(127, 30);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(100, 32);
            this.txt1.TabIndex = 1;
            // 
            // Reverse
            // 
            this.Reverse.BackColor = System.Drawing.Color.LightGray;
            this.Reverse.Location = new System.Drawing.Point(116, 84);
            this.Reverse.Name = "Reverse";
            this.Reverse.Size = new System.Drawing.Size(125, 38);
            this.Reverse.TabIndex = 2;
            this.Reverse.Text = "Reverse!";
            this.Reverse.UseVisualStyleBackColor = false;
            this.Reverse.Click += new System.EventHandler(this.Reverse_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Output";
            // 
            // txtOut
            // 
            this.txtOut.Location = new System.Drawing.Point(127, 139);
            this.txtOut.Name = "txtOut";
            this.txtOut.ReadOnly = true;
            this.txtOut.Size = new System.Drawing.Size(100, 32);
            this.txtOut.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 235);
            this.Controls.Add(this.txtOut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Reverse);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Button Reverse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOut;
    }
}

