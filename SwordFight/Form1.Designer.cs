namespace SwordFight
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
            this.fastAttack = new System.Windows.Forms.Button();
            this.strongAttack = new System.Windows.Forms.Button();
            this.Block = new System.Windows.Forms.Button();
            this.you = new System.Windows.Forms.Label();
            this.opponent = new System.Windows.Forms.Label();
            this.yAction = new System.Windows.Forms.Label();
            this.oAction = new System.Windows.Forms.Label();
            this.yourName = new System.Windows.Forms.TextBox();
            this.Start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fastAttack
            // 
            this.fastAttack.Location = new System.Drawing.Point(336, 50);
            this.fastAttack.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.fastAttack.Name = "fastAttack";
            this.fastAttack.Size = new System.Drawing.Size(308, 45);
            this.fastAttack.TabIndex = 0;
            this.fastAttack.Text = "FAST ATTACK";
            this.fastAttack.UseVisualStyleBackColor = true;
            this.fastAttack.Visible = false;
            this.fastAttack.Click += new System.EventHandler(this.fastAttack_Click);
            // 
            // strongAttack
            // 
            this.strongAttack.Location = new System.Drawing.Point(336, 190);
            this.strongAttack.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.strongAttack.Name = "strongAttack";
            this.strongAttack.Size = new System.Drawing.Size(308, 51);
            this.strongAttack.TabIndex = 1;
            this.strongAttack.Text = "STRONG ATTACK";
            this.strongAttack.UseVisualStyleBackColor = true;
            this.strongAttack.Visible = false;
            this.strongAttack.Click += new System.EventHandler(this.strongAttack_Click);
            // 
            // Block
            // 
            this.Block.Location = new System.Drawing.Point(336, 335);
            this.Block.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Block.Name = "Block";
            this.Block.Size = new System.Drawing.Size(308, 54);
            this.Block.TabIndex = 2;
            this.Block.Text = "BLOCK";
            this.Block.UseVisualStyleBackColor = true;
            this.Block.Visible = false;
            this.Block.Click += new System.EventHandler(this.Block_Click);
            // 
            // you
            // 
            this.you.AutoSize = true;
            this.you.Location = new System.Drawing.Point(704, 58);
            this.you.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.you.Name = "you";
            this.you.Size = new System.Drawing.Size(59, 29);
            this.you.TabIndex = 3;
            this.you.Text = "You";
            this.you.Visible = false;
            // 
            // opponent
            // 
            this.opponent.AutoSize = true;
            this.opponent.Location = new System.Drawing.Point(704, 253);
            this.opponent.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.opponent.Name = "opponent";
            this.opponent.Size = new System.Drawing.Size(128, 29);
            this.opponent.TabIndex = 4;
            this.opponent.Text = "Opponent";
            this.opponent.Visible = false;
            // 
            // yAction
            // 
            this.yAction.AutoSize = true;
            this.yAction.Location = new System.Drawing.Point(704, 107);
            this.yAction.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.yAction.Name = "yAction";
            this.yAction.Size = new System.Drawing.Size(85, 29);
            this.yAction.TabIndex = 5;
            this.yAction.Text = "label3";
            this.yAction.Visible = false;
            // 
            // oAction
            // 
            this.oAction.AutoSize = true;
            this.oAction.Location = new System.Drawing.Point(704, 309);
            this.oAction.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.oAction.Name = "oAction";
            this.oAction.Size = new System.Drawing.Size(85, 29);
            this.oAction.TabIndex = 6;
            this.oAction.Text = "label4";
            this.oAction.Visible = false;
            // 
            // yourName
            // 
            this.yourName.Location = new System.Drawing.Point(40, 53);
            this.yourName.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.yourName.Name = "yourName";
            this.yourName.Size = new System.Drawing.Size(244, 35);
            this.yourName.TabIndex = 7;
            this.yourName.Text = "Enter your name";
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(40, 144);
            this.Start.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(188, 51);
            this.Start.TabIndex = 8;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.yourName);
            this.Controls.Add(this.oAction);
            this.Controls.Add(this.yAction);
            this.Controls.Add(this.opponent);
            this.Controls.Add(this.you);
            this.Controls.Add(this.Block);
            this.Controls.Add(this.strongAttack);
            this.Controls.Add(this.fastAttack);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fastAttack;
        private System.Windows.Forms.Button strongAttack;
        private System.Windows.Forms.Button Block;
        private System.Windows.Forms.Label you;
        private System.Windows.Forms.Label opponent;
        private System.Windows.Forms.Label yAction;
        private System.Windows.Forms.Label oAction;
        private System.Windows.Forms.TextBox yourName;
        private System.Windows.Forms.Button Start;
    }
}

