
namespace memoryGame
{
    partial class GameLevels
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.LeftArrow = new System.Windows.Forms.PictureBox();
            this.BackButton = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LeftArrow)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(295, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Game levels";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(37)))), ((int)(((byte)(52)))));
            this.button1.Location = new System.Drawing.Point(339, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 50);
            this.button1.TabIndex = 1;
            this.button1.Text = "Easy";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(37)))), ((int)(((byte)(52)))));
            this.button2.Location = new System.Drawing.Point(339, 266);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 50);
            this.button2.TabIndex = 2;
            this.button2.Text = "Medium";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(37)))), ((int)(((byte)(52)))));
            this.button3.Location = new System.Drawing.Point(339, 359);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 50);
            this.button3.TabIndex = 3;
            this.button3.Text = "Difficult";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // LeftArrow
            // 
            this.LeftArrow.Image = global::memoryGame.Properties.Resources.arrow_left_circle_318_1450_removebg_preview;
            this.LeftArrow.Location = new System.Drawing.Point(12, 12);
            this.LeftArrow.Name = "LeftArrow";
            this.LeftArrow.Size = new System.Drawing.Size(48, 44);
            this.LeftArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LeftArrow.TabIndex = 4;
            this.LeftArrow.TabStop = false;
            this.LeftArrow.Click += new System.EventHandler(this.LeftArrow_Click);
            // 
            // BackButton
            // 
            this.BackButton.AutoSize = true;
            this.BackButton.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BackButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackButton.Location = new System.Drawing.Point(12, 59);
            this.BackButton.Name = "BackButton";
            this.BackButton.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.BackButton.Size = new System.Drawing.Size(41, 16);
            this.BackButton.TabIndex = 5;
            this.BackButton.Text = "Back";
            // 
            // GameLevels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(37)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(859, 550);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.LeftArrow);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "GameLevels";
            this.Text = "Game levels";
            ((System.ComponentModel.ISupportInitialize)(this.LeftArrow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox LeftArrow;
        private System.Windows.Forms.Label BackButton;
    }
}