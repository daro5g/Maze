namespace Game
{
    partial class StartMenu
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
            this.startgame = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.help = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startgame
            // 
            this.startgame.Location = new System.Drawing.Point(59, 44);
            this.startgame.Name = "startgame";
            this.startgame.Size = new System.Drawing.Size(177, 23);
            this.startgame.TabIndex = 0;
            this.startgame.Text = "Start Game";
            this.startgame.UseVisualStyleBackColor = true;
            this.startgame.Click += new System.EventHandler(this.startgame_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(59, 127);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(177, 23);
            this.exit.TabIndex = 1;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // help
            // 
            this.help.Location = new System.Drawing.Point(59, 87);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(177, 23);
            this.help.TabIndex = 2;
            this.help.Text = "Help";
            this.help.UseVisualStyleBackColor = true;
            this.help.Click += new System.EventHandler(this.help_Click);
            // 
            // StartMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 186);
            this.Controls.Add(this.help);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.startgame);
            this.Name = "StartMenu";
            this.Text = "Maze 1.6";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startgame;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button help;
    }
}