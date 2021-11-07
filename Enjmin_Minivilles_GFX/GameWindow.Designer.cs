using System.ComponentModel;

namespace Enjmin_Minivilles_GFX
{
    partial class GameWindow
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
            this.Player1Box = new System.Windows.Forms.GroupBox();
            this.Player1Cards = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Player1Money = new System.Windows.Forms.Label();
            this.Player1Label = new System.Windows.Forms.Label();
            this.Player2Box = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Player2Cards = new System.Windows.Forms.GroupBox();
            this.Player2Money = new System.Windows.Forms.Label();
            this.Player2Label = new System.Windows.Forms.Label();
            this.Player3Box = new System.Windows.Forms.GroupBox();
            this.Player3Cards = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.Player3Money = new System.Windows.Forms.Label();
            this.Player3Label = new System.Windows.Forms.Label();
            this.Player4Box = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.Player4Money = new System.Windows.Forms.Label();
            this.Player4Label = new System.Windows.Forms.Label();
            this.Player4Cards = new System.Windows.Forms.GroupBox();
            this.Dice1 = new System.Windows.Forms.PictureBox();
            this.Dice2 = new System.Windows.Forms.PictureBox();
            this.RollDice = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DiceN2 = new System.Windows.Forms.RadioButton();
            this.DiceN1 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.Player1Box.SuspendLayout();
            this.Player1Cards.SuspendLayout();
            this.Player2Box.SuspendLayout();
            this.Player3Box.SuspendLayout();
            this.Player3Cards.SuspendLayout();
            this.Player4Box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dice1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dice2)).BeginInit();
            this.SuspendLayout();
            // 
            // Player1Box
            // 
            this.Player1Box.Controls.Add(this.Player1Cards);
            this.Player1Box.Controls.Add(this.Player1Money);
            this.Player1Box.Controls.Add(this.Player1Label);
            this.Player1Box.Location = new System.Drawing.Point(12, 12);
            this.Player1Box.Name = "Player1Box";
            this.Player1Box.Size = new System.Drawing.Size(504, 241);
            this.Player1Box.TabIndex = 0;
            this.Player1Box.TabStop = false;
            this.Player1Box.Text = "Joueur 1";
            // 
            // Player1Cards
            // 
            this.Player1Cards.Controls.Add(this.tableLayoutPanel1);
            this.Player1Cards.Location = new System.Drawing.Point(29, 34);
            this.Player1Cards.Name = "Player1Cards";
            this.Player1Cards.Size = new System.Drawing.Size(469, 201);
            this.Player1Cards.TabIndex = 5;
            this.Player1Cards.TabStop = false;
            this.Player1Cards.Text = "Cartes";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(469, 176);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Player1Money
            // 
            this.Player1Money.Location = new System.Drawing.Point(75, 16);
            this.Player1Money.Name = "Player1Money";
            this.Player1Money.Size = new System.Drawing.Size(132, 15);
            this.Player1Money.TabIndex = 4;
            this.Player1Money.Text = "MONEY_PLACEHOLDER";
            // 
            // Player1Label
            // 
            this.Player1Label.Location = new System.Drawing.Point(29, 16);
            this.Player1Label.Name = "Player1Label";
            this.Player1Label.Size = new System.Drawing.Size(40, 15);
            this.Player1Label.TabIndex = 3;
            this.Player1Label.Text = "Argent";
            // 
            // Player2Box
            // 
            this.Player2Box.Controls.Add(this.tableLayoutPanel2);
            this.Player2Box.Controls.Add(this.Player2Cards);
            this.Player2Box.Controls.Add(this.Player2Money);
            this.Player2Box.Controls.Add(this.Player2Label);
            this.Player2Box.Location = new System.Drawing.Point(748, 12);
            this.Player2Box.Name = "Player2Box";
            this.Player2Box.Size = new System.Drawing.Size(504, 241);
            this.Player2Box.TabIndex = 1;
            this.Player2Box.TabStop = false;
            this.Player2Box.Text = "Joueur 2";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(29, 53);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(469, 176);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // Player2Cards
            // 
            this.Player2Cards.Location = new System.Drawing.Point(29, 34);
            this.Player2Cards.Name = "Player2Cards";
            this.Player2Cards.Size = new System.Drawing.Size(469, 201);
            this.Player2Cards.TabIndex = 6;
            this.Player2Cards.TabStop = false;
            this.Player2Cards.Text = "Cartes";
            // 
            // Player2Money
            // 
            this.Player2Money.Location = new System.Drawing.Point(75, 16);
            this.Player2Money.Name = "Player2Money";
            this.Player2Money.Size = new System.Drawing.Size(132, 15);
            this.Player2Money.TabIndex = 6;
            this.Player2Money.Text = "MONEY_PLACEHOLDER";
            // 
            // Player2Label
            // 
            this.Player2Label.Location = new System.Drawing.Point(29, 16);
            this.Player2Label.Name = "Player2Label";
            this.Player2Label.Size = new System.Drawing.Size(40, 15);
            this.Player2Label.TabIndex = 6;
            this.Player2Label.Text = "Argent";
            // 
            // Player3Box
            // 
            this.Player3Box.Controls.Add(this.Player3Cards);
            this.Player3Box.Controls.Add(this.Player3Money);
            this.Player3Box.Controls.Add(this.Player3Label);
            this.Player3Box.Location = new System.Drawing.Point(12, 428);
            this.Player3Box.Name = "Player3Box";
            this.Player3Box.Size = new System.Drawing.Size(504, 241);
            this.Player3Box.TabIndex = 1;
            this.Player3Box.TabStop = false;
            this.Player3Box.Text = "Joueur 3";
            // 
            // Player3Cards
            // 
            this.Player3Cards.Controls.Add(this.tableLayoutPanel3);
            this.Player3Cards.Location = new System.Drawing.Point(29, 34);
            this.Player3Cards.Name = "Player3Cards";
            this.Player3Cards.Size = new System.Drawing.Size(469, 201);
            this.Player3Cards.TabIndex = 10;
            this.Player3Cards.TabStop = false;
            this.Player3Cards.Text = "Cartes";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 7;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(469, 176);
            this.tableLayoutPanel3.TabIndex = 11;
            // 
            // Player3Money
            // 
            this.Player3Money.Location = new System.Drawing.Point(75, 16);
            this.Player3Money.Name = "Player3Money";
            this.Player3Money.Size = new System.Drawing.Size(132, 15);
            this.Player3Money.TabIndex = 7;
            this.Player3Money.Text = "MONEY_PLACEHOLDER";
            // 
            // Player3Label
            // 
            this.Player3Label.Location = new System.Drawing.Point(29, 16);
            this.Player3Label.Name = "Player3Label";
            this.Player3Label.Size = new System.Drawing.Size(40, 15);
            this.Player3Label.TabIndex = 7;
            this.Player3Label.Text = "Argent";
            // 
            // Player4Box
            // 
            this.Player4Box.Controls.Add(this.tableLayoutPanel4);
            this.Player4Box.Controls.Add(this.Player4Money);
            this.Player4Box.Controls.Add(this.Player4Label);
            this.Player4Box.Controls.Add(this.Player4Cards);
            this.Player4Box.Location = new System.Drawing.Point(748, 428);
            this.Player4Box.Name = "Player4Box";
            this.Player4Box.Size = new System.Drawing.Size(504, 241);
            this.Player4Box.TabIndex = 2;
            this.Player4Box.TabStop = false;
            this.Player4Box.Text = "Joueur 4";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 7;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel4.Location = new System.Drawing.Point(29, 59);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(469, 176);
            this.tableLayoutPanel4.TabIndex = 11;
            // 
            // Player4Money
            // 
            this.Player4Money.Location = new System.Drawing.Point(75, 16);
            this.Player4Money.Name = "Player4Money";
            this.Player4Money.Size = new System.Drawing.Size(132, 15);
            this.Player4Money.TabIndex = 11;
            this.Player4Money.Text = "MONEY_PLACEHOLDER";
            // 
            // Player4Label
            // 
            this.Player4Label.Location = new System.Drawing.Point(29, 16);
            this.Player4Label.Name = "Player4Label";
            this.Player4Label.Size = new System.Drawing.Size(40, 15);
            this.Player4Label.TabIndex = 11;
            this.Player4Label.Text = "Argent";
            // 
            // Player4Cards
            // 
            this.Player4Cards.Location = new System.Drawing.Point(29, 34);
            this.Player4Cards.Name = "Player4Cards";
            this.Player4Cards.Size = new System.Drawing.Size(469, 201);
            this.Player4Cards.TabIndex = 11;
            this.Player4Cards.TabStop = false;
            this.Player4Cards.Text = "Cartes";
            // 
            // Dice1
            // 
            this.Dice1.Location = new System.Drawing.Point(549, 282);
            this.Dice1.Name = "Dice1";
            this.Dice1.Size = new System.Drawing.Size(60, 60);
            this.Dice1.TabIndex = 3;
            this.Dice1.TabStop = false;
            // 
            // Dice2
            // 
            this.Dice2.Location = new System.Drawing.Point(650, 282);
            this.Dice2.Name = "Dice2";
            this.Dice2.Size = new System.Drawing.Size(60, 60);
            this.Dice2.TabIndex = 4;
            this.Dice2.TabStop = false;
            // 
            // RollDice
            // 
            this.RollDice.Location = new System.Drawing.Point(549, 348);
            this.RollDice.Name = "RollDice";
            this.RollDice.Size = new System.Drawing.Size(161, 26);
            this.RollDice.TabIndex = 5;
            this.RollDice.Text = "Lancer de dés";
            this.RollDice.UseVisualStyleBackColor = true;
            this.RollDice.Click += new System.EventHandler(this.RollDice_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(572, 389);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "N° de dés";
            // 
            // DiceN2
            // 
            this.DiceN2.Location = new System.Drawing.Point(629, 399);
            this.DiceN2.Name = "DiceN2";
            this.DiceN2.Size = new System.Drawing.Size(73, 16);
            this.DiceN2.TabIndex = 8;
            this.DiceN2.TabStop = true;
            this.DiceN2.Text = "Deux dés";
            this.DiceN2.UseVisualStyleBackColor = true;
            // 
            // DiceN1
            // 
            this.DiceN1.Location = new System.Drawing.Point(629, 377);
            this.DiceN1.Name = "DiceN1";
            this.DiceN1.Size = new System.Drawing.Size(55, 16);
            this.DiceN1.TabIndex = 9;
            this.DiceN1.TabStop = true;
            this.DiceN1.Text = "Un dé";
            this.DiceN1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(504, 135);
            this.label2.TabIndex = 10;
            this.label2.Text = "PLACEHOLDER_ACTION_TEXT";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DiceN1);
            this.Controls.Add(this.DiceN2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RollDice);
            this.Controls.Add(this.Dice2);
            this.Controls.Add(this.Dice1);
            this.Controls.Add(this.Player4Box);
            this.Controls.Add(this.Player3Box);
            this.Controls.Add(this.Player2Box);
            this.Controls.Add(this.Player1Box);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameWindow";
            this.Player1Box.ResumeLayout(false);
            this.Player1Cards.ResumeLayout(false);
            this.Player2Box.ResumeLayout(false);
            this.Player3Box.ResumeLayout(false);
            this.Player3Cards.ResumeLayout(false);
            this.Player4Box.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dice1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dice2)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.GroupBox Player2Cards;
        private System.Windows.Forms.GroupBox Player3Cards;
        private System.Windows.Forms.GroupBox Player4Cards;
        private System.Windows.Forms.Label Player4Label;
        private System.Windows.Forms.Label Player4Money;

        private System.Windows.Forms.Label Player2Label;
        private System.Windows.Forms.Label Player2Money;
        private System.Windows.Forms.Label Player3Label;
        private System.Windows.Forms.Label Player3Money;

        private System.Windows.Forms.PictureBox Dice1;
        private System.Windows.Forms.PictureBox Dice2;
        private System.Windows.Forms.Button RollDice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton DiceN1;
        private System.Windows.Forms.RadioButton DiceN2;

        private System.Windows.Forms.GroupBox Player1Cards;

        private System.Windows.Forms.Label Player1Label;
        private System.Windows.Forms.Label Player1Money;

        private System.Windows.Forms.GroupBox Player1Box;
        private System.Windows.Forms.GroupBox Player2Box;
        private System.Windows.Forms.GroupBox Player3Box;
        private System.Windows.Forms.GroupBox Player4Box;

        #endregion
    }
}