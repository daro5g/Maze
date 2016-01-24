namespace Game
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
            this.la = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hiden = new System.Windows.Forms.Label();
            this.game_board1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.game_board1)).BeginInit();
            this.SuspendLayout();
            // 
            // la
            // 
            this.la.AutoSize = true;
            this.la.BackColor = System.Drawing.Color.White;
            this.la.ForeColor = System.Drawing.Color.White;
            this.la.Location = new System.Drawing.Point(305, 74);
            this.la.Name = "la";
            this.la.Size = new System.Drawing.Size(9, 13);
            this.la.TabIndex = 2;
            this.la.Text = "l";
            this.la.MouseEnter += new System.EventHandler(this.la_MouseEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 406);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 4;
            // 
            // hiden
            // 
            this.hiden.AutoSize = true;
            this.hiden.BackColor = System.Drawing.Color.White;
            this.hiden.ForeColor = System.Drawing.Color.White;
            this.hiden.Location = new System.Drawing.Point(449, 420);
            this.hiden.Name = "hiden";
            this.hiden.Size = new System.Drawing.Size(9, 13);
            this.hiden.TabIndex = 5;
            this.hiden.Text = "l";
            this.hiden.MouseEnter += new System.EventHandler(this.hiden_MouseEnter);
            // 
            // game_board1
            // 
            this.game_board1.Location = new System.Drawing.Point(-1, -3);
            this.game_board1.Name = "game_board1";
            this.game_board1.Size = new System.Drawing.Size(508, 494);
            this.game_board1.TabIndex = 1;
            this.game_board1.TabStop = false;
            this.game_board1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.game_board1_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 486);
            this.Controls.Add(this.hiden);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.la);
            this.Controls.Add(this.game_board1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maze";
            ((System.ComponentModel.ISupportInitialize)(this.game_board1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox game_board1;
        private System.Windows.Forms.Label la;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label hiden;
    }
}

