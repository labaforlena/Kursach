namespace hashtables
{
    partial class FormQuest
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
            this.btnAns1 = new System.Windows.Forms.Button();
            this.btnAns2 = new System.Windows.Forms.Button();
            this.btnAns3 = new System.Windows.Forms.Button();
            this.questText = new System.Windows.Forms.Label();
            this.textBoxAnswer = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAns1
            // 
            this.btnAns1.AutoSize = true;
            this.btnAns1.BackColor = System.Drawing.Color.SlateGray;
            this.btnAns1.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAns1.Location = new System.Drawing.Point(0, 32);
            this.btnAns1.Margin = new System.Windows.Forms.Padding(0);
            this.btnAns1.Name = "btnAns1";
            this.btnAns1.Size = new System.Drawing.Size(100, 33);
            this.btnAns1.TabIndex = 0;
            this.btnAns1.Text = "money";
            this.btnAns1.UseVisualStyleBackColor = false;
            this.btnAns1.Click += new System.EventHandler(this.btnAns1_Click);
            // 
            // btnAns2
            // 
            this.btnAns2.AutoSize = true;
            this.btnAns2.BackColor = System.Drawing.Color.SlateGray;
            this.btnAns2.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAns2.Location = new System.Drawing.Point(279, 32);
            this.btnAns2.Name = "btnAns2";
            this.btnAns2.Size = new System.Drawing.Size(100, 33);
            this.btnAns2.TabIndex = 1;
            this.btnAns2.Text = "exp";
            this.btnAns2.UseVisualStyleBackColor = false;
            this.btnAns2.Click += new System.EventHandler(this.btnAns2_Click);
            // 
            // btnAns3
            // 
            this.btnAns3.AutoSize = true;
            this.btnAns3.BackColor = System.Drawing.Color.SlateGray;
            this.btnAns3.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold);
            this.btnAns3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAns3.Location = new System.Drawing.Point(146, 120);
            this.btnAns3.Name = "btnAns3";
            this.btnAns3.Size = new System.Drawing.Size(100, 32);
            this.btnAns3.TabIndex = 2;
            this.btnAns3.Text = "sarcasm";
            this.btnAns3.UseVisualStyleBackColor = false;
            this.btnAns3.Click += new System.EventHandler(this.btnAns3_Click);
            // 
            // questText
            // 
            this.questText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.questText.AutoSize = true;
            this.questText.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.questText.Location = new System.Drawing.Point(3, 0);
            this.questText.Name = "questText";
            this.questText.Size = new System.Drawing.Size(52, 21);
            this.questText.TabIndex = 3;
            this.questText.Text = "label1";
            this.questText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxAnswer
            // 
            this.textBoxAnswer.BackColor = System.Drawing.Color.SlateGray;
            this.textBoxAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAnswer.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold);
            this.textBoxAnswer.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxAnswer.Location = new System.Drawing.Point(130, 38);
            this.textBoxAnswer.Name = "textBoxAnswer";
            this.textBoxAnswer.Size = new System.Drawing.Size(125, 24);
            this.textBoxAnswer.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.questText);
            this.flowLayoutPanel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(105, 43);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(285, 231);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnAns1);
            this.panel1.Controls.Add(this.btnAns2);
            this.panel1.Controls.Add(this.textBoxAnswer);
            this.panel1.Controls.Add(this.btnAns3);
            this.panel1.Location = new System.Drawing.Point(53, 280);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(402, 170);
            this.panel1.TabIndex = 6;
            // 
            // FormQuest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::hashtables.Properties.Resources.dungeon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(491, 480);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.DoubleBuffered = true;
            this.Name = "FormQuest";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dungeons&Windows Forms ";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnAns1;
        private System.Windows.Forms.Button btnAns2;
        public System.Windows.Forms.Button btnAns3;
        private System.Windows.Forms.Label questText;
        public System.Windows.Forms.TextBox textBoxAnswer;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
    }
}