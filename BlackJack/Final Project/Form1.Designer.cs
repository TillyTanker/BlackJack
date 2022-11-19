
namespace Final_Project
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
            this.DhiddenCard = new System.Windows.Forms.PictureBox();
            this.Card2 = new System.Windows.Forms.PictureBox();
            this.Card1 = new System.Windows.Forms.PictureBox();
            this.DshowCard = new System.Windows.Forms.PictureBox();
            this.PlayBtn = new System.Windows.Forms.Button();
            this.HitBtn = new System.Windows.Forms.Button();
            this.StandBtn = new System.Windows.Forms.Button();
            this.Dcard2 = new System.Windows.Forms.PictureBox();
            this.labelPlayerScore = new System.Windows.Forms.Label();
            this.labelDealerScore = new System.Windows.Forms.Label();
            this.labelStack = new System.Windows.Forms.Label();
            this.numericUpDownBet = new System.Windows.Forms.NumericUpDown();
            this.labelBet = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DhiddenCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DshowCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dcard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBet)).BeginInit();
            this.SuspendLayout();
            // 
            // DhiddenCard
            // 
            this.DhiddenCard.Location = new System.Drawing.Point(158, 22);
            this.DhiddenCard.Name = "DhiddenCard";
            this.DhiddenCard.Size = new System.Drawing.Size(72, 106);
            this.DhiddenCard.TabIndex = 1;
            this.DhiddenCard.TabStop = false;
            this.DhiddenCard.Click += new System.EventHandler(this.DhiddenCard_Click);
            // 
            // Card2
            // 
            this.Card2.Location = new System.Drawing.Point(158, 389);
            this.Card2.Name = "Card2";
            this.Card2.Size = new System.Drawing.Size(72, 106);
            this.Card2.TabIndex = 3;
            this.Card2.TabStop = false;
            this.Card2.Click += new System.EventHandler(this.Card2_Click);
            // 
            // Card1
            // 
            this.Card1.Location = new System.Drawing.Point(66, 389);
            this.Card1.Name = "Card1";
            this.Card1.Size = new System.Drawing.Size(72, 106);
            this.Card1.TabIndex = 2;
            this.Card1.TabStop = false;
            this.Card1.Click += new System.EventHandler(this.Card1_Click);
            // 
            // DshowCard
            // 
            this.DshowCard.Location = new System.Drawing.Point(66, 22);
            this.DshowCard.Name = "DshowCard";
            this.DshowCard.Size = new System.Drawing.Size(72, 106);
            this.DshowCard.TabIndex = 4;
            this.DshowCard.TabStop = false;
            this.DshowCard.Click += new System.EventHandler(this.DshowCard_Click);
            // 
            // PlayBtn
            // 
            this.PlayBtn.Location = new System.Drawing.Point(570, 374);
            this.PlayBtn.Name = "PlayBtn";
            this.PlayBtn.Size = new System.Drawing.Size(131, 24);
            this.PlayBtn.TabIndex = 5;
            this.PlayBtn.Text = "Play";
            this.PlayBtn.UseVisualStyleBackColor = true;
            this.PlayBtn.Click += new System.EventHandler(this.PlayBtn_Click);
            // 
            // HitBtn
            // 
            this.HitBtn.Location = new System.Drawing.Point(570, 404);
            this.HitBtn.Name = "HitBtn";
            this.HitBtn.Size = new System.Drawing.Size(131, 24);
            this.HitBtn.TabIndex = 6;
            this.HitBtn.Text = "Hit Me";
            this.HitBtn.UseVisualStyleBackColor = true;
            this.HitBtn.Click += new System.EventHandler(this.HitBtn_Click);
            // 
            // StandBtn
            // 
            this.StandBtn.Location = new System.Drawing.Point(570, 434);
            this.StandBtn.Name = "StandBtn";
            this.StandBtn.Size = new System.Drawing.Size(131, 24);
            this.StandBtn.TabIndex = 7;
            this.StandBtn.Text = "Stand";
            this.StandBtn.UseVisualStyleBackColor = true;
            this.StandBtn.Click += new System.EventHandler(this.StandBtn_Click);
            // 
            // Dcard2
            // 
            this.Dcard2.Location = new System.Drawing.Point(158, 22);
            this.Dcard2.Name = "Dcard2";
            this.Dcard2.Size = new System.Drawing.Size(72, 106);
            this.Dcard2.TabIndex = 8;
            this.Dcard2.TabStop = false;
            this.Dcard2.Visible = false;
            this.Dcard2.Click += new System.EventHandler(this.Dcard2_Click);
            // 
            // labelPlayerScore
            // 
            this.labelPlayerScore.AutoSize = true;
            this.labelPlayerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelPlayerScore.Location = new System.Drawing.Point(256, 420);
            this.labelPlayerScore.Name = "labelPlayerScore";
            this.labelPlayerScore.Size = new System.Drawing.Size(36, 39);
            this.labelPlayerScore.TabIndex = 9;
            this.labelPlayerScore.Text = "0";
            this.labelPlayerScore.Click += new System.EventHandler(this.labelPlayerScore_Click);
            // 
            // labelDealerScore
            // 
            this.labelDealerScore.AutoSize = true;
            this.labelDealerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelDealerScore.Location = new System.Drawing.Point(256, 52);
            this.labelDealerScore.Name = "labelDealerScore";
            this.labelDealerScore.Size = new System.Drawing.Size(36, 39);
            this.labelDealerScore.TabIndex = 10;
            this.labelDealerScore.Text = "0";
            // 
            // labelStack
            // 
            this.labelStack.AutoSize = true;
            this.labelStack.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelStack.Location = new System.Drawing.Point(551, 471);
            this.labelStack.Name = "labelStack";
            this.labelStack.Size = new System.Drawing.Size(196, 39);
            this.labelStack.TabIndex = 11;
            this.labelStack.Text = "Stack: $100";
            this.labelStack.Click += new System.EventHandler(this.labelStack_Click);
            // 
            // numericUpDownBet
            // 
            this.numericUpDownBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.numericUpDownBet.Location = new System.Drawing.Point(728, 399);
            this.numericUpDownBet.Name = "numericUpDownBet";
            this.numericUpDownBet.Size = new System.Drawing.Size(60, 30);
            this.numericUpDownBet.TabIndex = 12;
            this.numericUpDownBet.ValueChanged += new System.EventHandler(this.numericUpDownBet_ValueChanged);
            // 
            // labelBet
            // 
            this.labelBet.AutoSize = true;
            this.labelBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelBet.Location = new System.Drawing.Point(735, 362);
            this.labelBet.Name = "labelBet";
            this.labelBet.Size = new System.Drawing.Size(41, 25);
            this.labelBet.TabIndex = 13;
            this.labelBet.Text = "Bet";
            this.labelBet.Click += new System.EventHandler(this.labelBet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(800, 519);
            this.Controls.Add(this.labelBet);
            this.Controls.Add(this.numericUpDownBet);
            this.Controls.Add(this.labelStack);
            this.Controls.Add(this.labelDealerScore);
            this.Controls.Add(this.labelPlayerScore);
            this.Controls.Add(this.Dcard2);
            this.Controls.Add(this.StandBtn);
            this.Controls.Add(this.HitBtn);
            this.Controls.Add(this.PlayBtn);
            this.Controls.Add(this.DshowCard);
            this.Controls.Add(this.Card2);
            this.Controls.Add(this.Card1);
            this.Controls.Add(this.DhiddenCard);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DhiddenCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DshowCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dcard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox DhiddenCard;
        private System.Windows.Forms.PictureBox Card2;
        private System.Windows.Forms.PictureBox Card1;
        private System.Windows.Forms.PictureBox DshowCard;
        private System.Windows.Forms.Button PlayBtn;
        private System.Windows.Forms.Button HitBtn;
        private System.Windows.Forms.Button StandBtn;
        private System.Windows.Forms.PictureBox Dcard2;
        private System.Windows.Forms.Label labelPlayerScore;
        private System.Windows.Forms.Label labelDealerScore;
        private System.Windows.Forms.Label labelStack;
        private System.Windows.Forms.NumericUpDown numericUpDownBet;
        private System.Windows.Forms.Label labelBet;
    }
}

