
namespace Assignment1
{
    partial class Assignment1
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
            this.button_Load = new System.Windows.Forms.Button();
            this.button_Spin = new System.Windows.Forms.Button();
            this.button_Shoot = new System.Windows.Forms.Button();
            this.button_Shoot_Away = new System.Windows.Forms.Button();
            this.button_Exit = new System.Windows.Forms.Button();
            this.button_PlayAgain = new System.Windows.Forms.Button();
            this.button_GameRules = new System.Windows.Forms.Button();
            this.Picbox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Picbox)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Load
            // 
            this.button_Load.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Load.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Load.Location = new System.Drawing.Point(34, 52);
            this.button_Load.Name = "button_Load";
            this.button_Load.Size = new System.Drawing.Size(209, 76);
            this.button_Load.TabIndex = 0;
            this.button_Load.Text = "Load";
            this.button_Load.UseVisualStyleBackColor = false;
            this.button_Load.Click += new System.EventHandler(this.Button_Load_Click);
            // 
            // button_Spin
            // 
            this.button_Spin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Spin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Spin.Location = new System.Drawing.Point(34, 227);
            this.button_Spin.Name = "button_Spin";
            this.button_Spin.Size = new System.Drawing.Size(209, 78);
            this.button_Spin.TabIndex = 1;
            this.button_Spin.Text = "Spin";
            this.button_Spin.UseVisualStyleBackColor = false;
            this.button_Spin.Click += new System.EventHandler(this.Button_Spin_Click);
            // 
            // button_Shoot
            // 
            this.button_Shoot.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Shoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Shoot.Location = new System.Drawing.Point(34, 414);
            this.button_Shoot.Name = "button_Shoot";
            this.button_Shoot.Size = new System.Drawing.Size(209, 78);
            this.button_Shoot.TabIndex = 2;
            this.button_Shoot.Text = "Shoot";
            this.button_Shoot.UseVisualStyleBackColor = false;
            this.button_Shoot.Click += new System.EventHandler(this.button_Shoot_Click);
            // 
            // button_Shoot_Away
            // 
            this.button_Shoot_Away.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Shoot_Away.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Shoot_Away.Location = new System.Drawing.Point(34, 598);
            this.button_Shoot_Away.Name = "button_Shoot_Away";
            this.button_Shoot_Away.Size = new System.Drawing.Size(224, 78);
            this.button_Shoot_Away.TabIndex = 3;
            this.button_Shoot_Away.Text = "ShootAway";
            this.button_Shoot_Away.UseVisualStyleBackColor = false;
            this.button_Shoot_Away.Click += new System.EventHandler(this.Button_ShootAway_Click_1);
            // 
            // button_Exit
            // 
            this.button_Exit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Exit.Location = new System.Drawing.Point(661, 595);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(148, 78);
            this.button_Exit.TabIndex = 4;
            this.button_Exit.Text = "Exit";
            this.button_Exit.UseVisualStyleBackColor = false;
            this.button_Exit.Click += new System.EventHandler(this.Button_Exit_Click_1);
            // 
            // button_PlayAgain
            // 
            this.button_PlayAgain.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_PlayAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_PlayAgain.Location = new System.Drawing.Point(981, 591);
            this.button_PlayAgain.Name = "button_PlayAgain";
            this.button_PlayAgain.Size = new System.Drawing.Size(230, 78);
            this.button_PlayAgain.TabIndex = 5;
            this.button_PlayAgain.Text = "PlayAgain";
            this.button_PlayAgain.UseVisualStyleBackColor = false;
            this.button_PlayAgain.Click += new System.EventHandler(this.button_PlayAgain_Click_1);
            // 
            // button_GameRules
            // 
            this.button_GameRules.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_GameRules.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_GameRules.Location = new System.Drawing.Point(661, 12);
            this.button_GameRules.Name = "button_GameRules";
            this.button_GameRules.Size = new System.Drawing.Size(294, 88);
            this.button_GameRules.TabIndex = 6;
            this.button_GameRules.Text = "Game Rules";
            this.button_GameRules.UseVisualStyleBackColor = false;
            this.button_GameRules.Click += new System.EventHandler(this.Button_GameRules_Click_1);
            // 
            // Picbox
            // 
            this.Picbox.Location = new System.Drawing.Point(262, 106);
            this.Picbox.Name = "Picbox";
            this.Picbox.Size = new System.Drawing.Size(977, 476);
            this.Picbox.TabIndex = 7;
            this.Picbox.TabStop = false;
            // 
            // Assignment1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1347, 688);
            this.Controls.Add(this.Picbox);
            this.Controls.Add(this.button_GameRules);
            this.Controls.Add(this.button_PlayAgain);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.button_Shoot_Away);
            this.Controls.Add(this.button_Shoot);
            this.Controls.Add(this.button_Spin);
            this.Controls.Add(this.button_Load);
            this.Name = "Assignment1";
            this.Text = "Russian_Game_form";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Picbox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Load;
        private System.Windows.Forms.Button button_Spin;
        private System.Windows.Forms.Button button_Shoot;
        private System.Windows.Forms.Button button_Shoot_Away;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Button button_PlayAgain;
        private System.Windows.Forms.Button button_GameRules;
        private System.Windows.Forms.PictureBox Picbox;
    }
}

