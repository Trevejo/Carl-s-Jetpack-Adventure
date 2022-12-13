namespace Carl_s_Jetpack_Adventure
{
    partial class DeathScreen
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
            this.label1 = new System.Windows.Forms.Label();
            this.coinsText = new System.Windows.Forms.Label();
            this.highDistText = new System.Windows.Forms.Label();
            this.distText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(140, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "MENU";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.backToMenu);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "GAME OVER";
            // 
            // coinsText
            // 
            this.coinsText.AutoSize = true;
            this.coinsText.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coinsText.Location = new System.Drawing.Point(11, 62);
            this.coinsText.Name = "coinsText";
            this.coinsText.Size = new System.Drawing.Size(55, 26);
            this.coinsText.TabIndex = 2;
            this.coinsText.Text = "coins";
            // 
            // highDistText
            // 
            this.highDistText.AutoSize = true;
            this.highDistText.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highDistText.Location = new System.Drawing.Point(12, 137);
            this.highDistText.Name = "highDistText";
            this.highDistText.Size = new System.Drawing.Size(124, 26);
            this.highDistText.TabIndex = 3;
            this.highDistText.Text = "high distance";
            // 
            // distText
            // 
            this.distText.AutoSize = true;
            this.distText.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.distText.Location = new System.Drawing.Point(12, 98);
            this.distText.Name = "distText";
            this.distText.Size = new System.Drawing.Size(84, 26);
            this.distText.TabIndex = 4;
            this.distText.Text = "distance";
            // 
            // DeathScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(343, 219);
            this.Controls.Add(this.distText);
            this.Controls.Add(this.highDistText);
            this.Controls.Add(this.coinsText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "DeathScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeathScreen";
            this.Load += new System.EventHandler(this.DeathScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label coinsText;
        private System.Windows.Forms.Label highDistText;
        private System.Windows.Forms.Label distText;
    }
}