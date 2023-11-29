namespace CardGame
{
    partial class CardGameForm
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
            this.labelWinner = new System.Windows.Forms.Label();
            this.player1Label = new System.Windows.Forms.Label();
            this.player2Label = new System.Windows.Forms.Label();
            this.player3Label = new System.Windows.Forms.Label();
            this.player4Label = new System.Windows.Forms.Label();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.panelAntony = new System.Windows.Forms.FlowLayoutPanel();
            this.panelSharon = new System.Windows.Forms.FlowLayoutPanel();
            this.panelDavid = new System.Windows.Forms.FlowLayoutPanel();
            this.panelWilleam = new System.Windows.Forms.FlowLayoutPanel();
            this.againBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AntonyCheckBox = new System.Windows.Forms.CheckBox();
            this.SharonCheckBox = new System.Windows.Forms.CheckBox();
            this.DavidCheckBox = new System.Windows.Forms.CheckBox();
            this.WilleamCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // labelWinner
            // 
            this.labelWinner.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelWinner.Enabled = false;
            this.labelWinner.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelWinner.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelWinner.Location = new System.Drawing.Point(209, 357);
            this.labelWinner.Name = "labelWinner";
            this.labelWinner.Size = new System.Drawing.Size(452, 32);
            this.labelWinner.TabIndex = 3;
            this.labelWinner.Text = "The Winner is : ";
            // 
            // player1Label
            // 
            this.player1Label.AutoSize = true;
            this.player1Label.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold);
            this.player1Label.Location = new System.Drawing.Point(30, 151);
            this.player1Label.Name = "player1Label";
            this.player1Label.Size = new System.Drawing.Size(68, 26);
            this.player1Label.TabIndex = 4;
            this.player1Label.Text = "David";
            // 
            // player2Label
            // 
            this.player2Label.AutoSize = true;
            this.player2Label.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2Label.Location = new System.Drawing.Point(30, 29);
            this.player2Label.Name = "player2Label";
            this.player2Label.Size = new System.Drawing.Size(81, 26);
            this.player2Label.TabIndex = 5;
            this.player2Label.Text = "Antony";
            // 
            // player3Label
            // 
            this.player3Label.AutoSize = true;
            this.player3Label.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold);
            this.player3Label.Location = new System.Drawing.Point(30, 93);
            this.player3Label.Name = "player3Label";
            this.player3Label.Size = new System.Drawing.Size(78, 26);
            this.player3Label.TabIndex = 6;
            this.player3Label.Text = "Sharon";
            // 
            // player4Label
            // 
            this.player4Label.AutoSize = true;
            this.player4Label.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold);
            this.player4Label.Location = new System.Drawing.Point(30, 217);
            this.player4Label.Name = "player4Label";
            this.player4Label.Size = new System.Drawing.Size(91, 26);
            this.player4Label.TabIndex = 7;
            this.player4Label.Text = "Willeam";
            // 
            // btnStartGame
            // 
            this.btnStartGame.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnStartGame.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnStartGame.Location = new System.Drawing.Point(317, 406);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(125, 35);
            this.btnStartGame.TabIndex = 8;
            this.btnStartGame.Text = "Start";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // panelAntony
            // 
            this.panelAntony.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelAntony.Location = new System.Drawing.Point(121, 14);
            this.panelAntony.Name = "panelAntony";
            this.panelAntony.Size = new System.Drawing.Size(632, 52);
            this.panelAntony.TabIndex = 11;
            // 
            // panelSharon
            // 
            this.panelSharon.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelSharon.Location = new System.Drawing.Point(121, 76);
            this.panelSharon.Name = "panelSharon";
            this.panelSharon.Size = new System.Drawing.Size(632, 52);
            this.panelSharon.TabIndex = 12;
            // 
            // panelDavid
            // 
            this.panelDavid.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelDavid.Location = new System.Drawing.Point(121, 138);
            this.panelDavid.Name = "panelDavid";
            this.panelDavid.Size = new System.Drawing.Size(632, 52);
            this.panelDavid.TabIndex = 13;
            // 
            // panelWilleam
            // 
            this.panelWilleam.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelWilleam.Location = new System.Drawing.Point(121, 200);
            this.panelWilleam.Name = "panelWilleam";
            this.panelWilleam.Size = new System.Drawing.Size(632, 52);
            this.panelWilleam.TabIndex = 14;
            // 
            // againBtn
            // 
            this.againBtn.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold);
            this.againBtn.ForeColor = System.Drawing.Color.IndianRed;
            this.againBtn.Location = new System.Drawing.Point(448, 406);
            this.againBtn.Name = "againBtn";
            this.againBtn.Size = new System.Drawing.Size(125, 35);
            this.againBtn.TabIndex = 15;
            this.againBtn.Text = "Try Again";
            this.againBtn.UseVisualStyleBackColor = true;
            this.againBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(255, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 26);
            this.label1.TabIndex = 16;
            this.label1.Text = "Guess who will win the game";
            // 
            // AntonyCheckBox
            // 
            this.AntonyCheckBox.AutoSize = true;
            this.AntonyCheckBox.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold);
            this.AntonyCheckBox.Location = new System.Drawing.Point(170, 313);
            this.AntonyCheckBox.Name = "AntonyCheckBox";
            this.AntonyCheckBox.Size = new System.Drawing.Size(100, 30);
            this.AntonyCheckBox.TabIndex = 17;
            this.AntonyCheckBox.Text = "Antony";
            this.AntonyCheckBox.UseVisualStyleBackColor = true;
            this.AntonyCheckBox.CheckedChanged += new System.EventHandler(this.AntonyCheckBox_CheckedChanged);
            // 
            // SharonCheckBox
            // 
            this.SharonCheckBox.AutoSize = true;
            this.SharonCheckBox.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold);
            this.SharonCheckBox.Location = new System.Drawing.Point(300, 313);
            this.SharonCheckBox.Name = "SharonCheckBox";
            this.SharonCheckBox.Size = new System.Drawing.Size(97, 30);
            this.SharonCheckBox.TabIndex = 18;
            this.SharonCheckBox.Text = "Sharon";
            this.SharonCheckBox.UseVisualStyleBackColor = true;
            this.SharonCheckBox.CheckedChanged += new System.EventHandler(this.SharonCheckBox_CheckedChanged);
            // 
            // DavidCheckBox
            // 
            this.DavidCheckBox.AutoSize = true;
            this.DavidCheckBox.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold);
            this.DavidCheckBox.Location = new System.Drawing.Point(426, 313);
            this.DavidCheckBox.Name = "DavidCheckBox";
            this.DavidCheckBox.Size = new System.Drawing.Size(87, 30);
            this.DavidCheckBox.TabIndex = 19;
            this.DavidCheckBox.Text = "David";
            this.DavidCheckBox.UseVisualStyleBackColor = true;
            this.DavidCheckBox.CheckedChanged += new System.EventHandler(this.DavidCheckBox_CheckedChanged);
            // 
            // WilleamCheckBox
            // 
            this.WilleamCheckBox.AutoSize = true;
            this.WilleamCheckBox.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold);
            this.WilleamCheckBox.Location = new System.Drawing.Point(551, 313);
            this.WilleamCheckBox.Name = "WilleamCheckBox";
            this.WilleamCheckBox.Size = new System.Drawing.Size(110, 30);
            this.WilleamCheckBox.TabIndex = 20;
            this.WilleamCheckBox.Text = "Willeam";
            this.WilleamCheckBox.UseVisualStyleBackColor = true;
            this.WilleamCheckBox.CheckedChanged += new System.EventHandler(this.WilleamCheckBox_CheckedChanged);
            // 
            // CardGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.WilleamCheckBox);
            this.Controls.Add(this.DavidCheckBox);
            this.Controls.Add(this.SharonCheckBox);
            this.Controls.Add(this.AntonyCheckBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.againBtn);
            this.Controls.Add(this.panelWilleam);
            this.Controls.Add(this.panelDavid);
            this.Controls.Add(this.panelSharon);
            this.Controls.Add(this.panelAntony);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.player4Label);
            this.Controls.Add(this.player3Label);
            this.Controls.Add(this.player2Label);
            this.Controls.Add(this.player1Label);
            this.Controls.Add(this.labelWinner);
            this.Name = "CardGameForm";
            this.Text = "Card Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelWinner;
        private System.Windows.Forms.Label player1Label;
        private System.Windows.Forms.Label player2Label;
        private System.Windows.Forms.Label player3Label;
        private System.Windows.Forms.Label player4Label;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.FlowLayoutPanel panelAntony;
        private System.Windows.Forms.FlowLayoutPanel panelSharon;
        private System.Windows.Forms.FlowLayoutPanel panelDavid;
        private System.Windows.Forms.FlowLayoutPanel panelWilleam;
        private System.Windows.Forms.Button againBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox AntonyCheckBox;
        private System.Windows.Forms.CheckBox SharonCheckBox;
        private System.Windows.Forms.CheckBox DavidCheckBox;
        private System.Windows.Forms.CheckBox WilleamCheckBox;
    }
}

