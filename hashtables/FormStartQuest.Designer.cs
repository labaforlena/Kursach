namespace hashtables
{
    partial class FormStartQuest
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
            this.btnToDungeon = new System.Windows.Forms.Button();
            this.btnAtackKorovan = new System.Windows.Forms.Button();
            this.btnAtackFort = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnToDungeon
            // 
            this.btnToDungeon.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnToDungeon.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnToDungeon.Location = new System.Drawing.Point(12, 214);
            this.btnToDungeon.Name = "btnToDungeon";
            this.btnToDungeon.Size = new System.Drawing.Size(168, 35);
            this.btnToDungeon.TabIndex = 0;
            this.btnToDungeon.Text = "> to dungeon";
            this.btnToDungeon.UseVisualStyleBackColor = false;
            this.btnToDungeon.Click += new System.EventHandler(this.btnToDungeon_Click);
            // 
            // btnAtackKorovan
            // 
            this.btnAtackKorovan.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAtackKorovan.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAtackKorovan.Location = new System.Drawing.Point(225, 214);
            this.btnAtackKorovan.Name = "btnAtackKorovan";
            this.btnAtackKorovan.Size = new System.Drawing.Size(168, 35);
            this.btnAtackKorovan.TabIndex = 1;
            this.btnAtackKorovan.Text = "> attack the karavan";
            this.btnAtackKorovan.UseVisualStyleBackColor = false;
            this.btnAtackKorovan.Click += new System.EventHandler(this.btnAtackKorovan_Click);
            // 
            // btnAtackFort
            // 
            this.btnAtackFort.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAtackFort.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAtackFort.Location = new System.Drawing.Point(450, 214);
            this.btnAtackFort.Name = "btnAtackFort";
            this.btnAtackFort.Size = new System.Drawing.Size(164, 35);
            this.btnAtackFort.TabIndex = 2;
            this.btnAtackFort.Text = "> attack the fort!";
            this.btnAtackFort.UseVisualStyleBackColor = false;
            this.btnAtackFort.Click += new System.EventHandler(this.btnAtackFort_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(156, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(465, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "...ah, you came here to fight. Choose your way!";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(501, 438);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "> leave";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormStartQuest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::hashtables.Properties.Resources.todungeon2;
            this.ClientSize = new System.Drawing.Size(624, 485);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAtackFort);
            this.Controls.Add(this.btnAtackKorovan);
            this.Controls.Add(this.btnToDungeon);
            this.Name = "FormStartQuest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dungeons&Windows Forms ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnToDungeon;
        private System.Windows.Forms.Button btnAtackKorovan;
        private System.Windows.Forms.Button btnAtackFort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}