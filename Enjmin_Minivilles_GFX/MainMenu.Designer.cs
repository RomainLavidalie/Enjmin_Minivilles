using System.ComponentModel;

namespace Enjmin_Minivilles_GFX
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.groupName = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.playerName3 = new System.Windows.Forms.TextBox();
            this.playerName2 = new System.Windows.Forms.TextBox();
            this.playerName1 = new System.Windows.Forms.TextBox();
            this.gameTitle = new System.Windows.Forms.Label();
            this.launchGame = new System.Windows.Forms.Button();
            this.groupName.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupName
            // 
            this.groupName.Controls.Add(this.textBox1);
            this.groupName.Controls.Add(this.playerName3);
            this.groupName.Controls.Add(this.playerName2);
            this.groupName.Controls.Add(this.playerName1);
            this.groupName.Location = new System.Drawing.Point(87, 63);
            this.groupName.Name = "groupName";
            this.groupName.Size = new System.Drawing.Size(200, 172);
            this.groupName.TabIndex = 0;
            this.groupName.TabStop = false;
            this.groupName.Text = "Noms des joueurs";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 125);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 20);
            this.textBox1.TabIndex = 4;
            // 
            // playerName3
            // 
            this.playerName3.Location = new System.Drawing.Point(22, 99);
            this.playerName3.Name = "playerName3";
            this.playerName3.Size = new System.Drawing.Size(150, 20);
            this.playerName3.TabIndex = 3;
            // 
            // playerName2
            // 
            this.playerName2.Location = new System.Drawing.Point(22, 73);
            this.playerName2.Name = "playerName2";
            this.playerName2.Size = new System.Drawing.Size(150, 20);
            this.playerName2.TabIndex = 2;
            // 
            // playerName1
            // 
            this.playerName1.Location = new System.Drawing.Point(22, 47);
            this.playerName1.Name = "playerName1";
            this.playerName1.Size = new System.Drawing.Size(150, 20);
            this.playerName1.TabIndex = 1;
            // 
            // gameTitle
            // 
            this.gameTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.gameTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.gameTitle.Location = new System.Drawing.Point(0, 0);
            this.gameTitle.Name = "gameTitle";
            this.gameTitle.Size = new System.Drawing.Size(384, 51);
            this.gameTitle.TabIndex = 1;
            this.gameTitle.Text = "MINIVILLES\r\n";
            this.gameTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // launchGame
            // 
            this.launchGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.launchGame.Location = new System.Drawing.Point(87, 265);
            this.launchGame.Name = "launchGame";
            this.launchGame.Size = new System.Drawing.Size(205, 61);
            this.launchGame.TabIndex = 2;
            this.launchGame.Text = "Lancer la partie";
            this.launchGame.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.launchGame);
            this.Controls.Add(this.gameTitle);
            this.Controls.Add(this.groupName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minivilles";
            this.groupName.ResumeLayout(false);
            this.groupName.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button launchGame;

        private System.Windows.Forms.Label gameTitle;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.TextBox textBox1;

        private System.Windows.Forms.TextBox playerName3;

        private System.Windows.Forms.GroupBox groupName;
        private System.Windows.Forms.TextBox playerName1;
        private System.Windows.Forms.TextBox playerName2;

        #endregion
    }
}