﻿namespace Carl_s_Jetpack_Adventure
{
    partial class Shop
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
            this.totalCoinsText = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.coin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.coin)).BeginInit();
            this.SuspendLayout();
            // 
            // totalCoinsText
            // 
            this.totalCoinsText.AutoSize = true;
            this.totalCoinsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCoinsText.Location = new System.Drawing.Point(90, 40);
            this.totalCoinsText.Name = "totalCoinsText";
            this.totalCoinsText.Size = new System.Drawing.Size(84, 33);
            this.totalCoinsText.TabIndex = 0;
            this.totalCoinsText.Text = "coins";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(314, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "MENU";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.backToMenu);
            // 
            // coin
            // 
            this.coin.Location = new System.Drawing.Point(30, 30);
            this.coin.Name = "coin";
            this.coin.Size = new System.Drawing.Size(50, 50);
            this.coin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin.TabIndex = 2;
            this.coin.TabStop = false;
            this.coin.Click += new System.EventHandler(this.coin_Click);
            // 
            // Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.coin);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.totalCoinsText);
            this.Name = "Shop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shop";
            this.Load += new System.EventHandler(this.Shop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.coin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label totalCoinsText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox coin;
    }
}