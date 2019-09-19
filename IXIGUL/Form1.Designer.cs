namespace IXIGUL
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
            
            
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    System.Windows.Forms.Button button = new System.Windows.Forms.Button();
                    this.SuspendLayout();
                    // 
                    // button1
                    // 
                    button.Location = new System.Drawing.Point(50 + (i-1)*100, 50 + (j-1) * 100);
                    button.Name = "button"+(i+j).ToString();
                    button.Size = new System.Drawing.Size(100, 100);
                    button.TabIndex = 0;
                    button.Text = "";
                    button.UseVisualStyleBackColor = true;
                    button.Click += new System.EventHandler(this.Button_Click);
                    this.Controls.Add(button);
                    this.buttons[i-1, j-1] = button;
                }
            }
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 400);
            
            this.Name = "Form1";
            this.Text = "X - 0 - X";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button[,] buttons = new System.Windows.Forms.Button[3, 3];
    }
}

