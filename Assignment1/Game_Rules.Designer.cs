
using System;

namespace Assignment1
{
    partial class Game_Rules
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
            this.button_age = new System.Windows.Forms.Button();
            this.button_id = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.label_Game_Rules = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_age
            // 
            this.button_age.BackColor = System.Drawing.Color.PapayaWhip;
            this.button_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_age.Location = new System.Drawing.Point(409, 140);
            this.button_age.Name = "button_age";
            this.button_age.Size = new System.Drawing.Size(619, 60);
            this.button_age.TabIndex = 0;
            this.button_age.Text = "You must be 18 years";
            this.button_age.UseVisualStyleBackColor = false;
            // 
            // button_id
            // 
            this.button_id.BackColor = System.Drawing.Color.PapayaWhip;
            this.button_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_id.Location = new System.Drawing.Point(409, 249);
            this.button_id.Name = "button_id";
            this.button_id.Size = new System.Drawing.Size(619, 59);
            this.button_id.TabIndex = 1;
            this.button_id.Text = "You must have valid ID";
            this.button_id.UseVisualStyleBackColor = false;
            this.button_id.Click += new System.EventHandler(this.button_id_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.PapayaWhip;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(409, 358);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(619, 61);
            this.button3.TabIndex = 2;
            this.button3.Text = "You can spin chamber once only";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.Color.PapayaWhip;
            this.button_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_back.Location = new System.Drawing.Point(1102, 518);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(169, 75);
            this.button_back.TabIndex = 3;
            this.button_back.Text = "Back";
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // label_Game_Rules
            // 
            this.label_Game_Rules.AutoSize = true;
            this.label_Game_Rules.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_Game_Rules.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Game_Rules.Location = new System.Drawing.Point(621, 22);
            this.label_Game_Rules.Name = "label_Game_Rules";
            this.label_Game_Rules.Size = new System.Drawing.Size(251, 46);
            this.label_Game_Rules.TabIndex = 4;
            this.label_Game_Rules.Text = "Game Rules";
            // 
            // Game_Rules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1283, 620);
            this.Controls.Add(this.label_Game_Rules);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button_id);
            this.Controls.Add(this.button_age);
            this.Name = "Game_Rules";
            this.Text = "Game_Rules";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button_id_Click(object sender, EventArgs e)
        {
            
        }

        #endregion

        private System.Windows.Forms.Button button_age;
        private System.Windows.Forms.Button button_id;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Label label_Game_Rules;
    }
}