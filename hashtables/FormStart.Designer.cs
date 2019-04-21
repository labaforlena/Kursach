namespace hashtables
{
    partial class FormStart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStart));
            this.btnStartQuest = new System.Windows.Forms.Button();
            this.btnSeeUser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStartQuest
            // 
            this.btnStartQuest.BackColor = System.Drawing.Color.IndianRed;
            this.btnStartQuest.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStartQuest.Location = new System.Drawing.Point(153, 250);
            this.btnStartQuest.Name = "btnStartQuest";
            this.btnStartQuest.Size = new System.Drawing.Size(137, 52);
            this.btnStartQuest.TabIndex = 0;
            this.btnStartQuest.Text = "Start Quest";
            this.btnStartQuest.UseVisualStyleBackColor = false;
            this.btnStartQuest.Click += new System.EventHandler(this.btnStartQuest_Click);
            // 
            // btnSeeUser
            // 
            this.btnSeeUser.BackColor = System.Drawing.Color.IndianRed;
            this.btnSeeUser.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSeeUser.Location = new System.Drawing.Point(153, 350);
            this.btnSeeUser.Name = "btnSeeUser";
            this.btnSeeUser.Size = new System.Drawing.Size(137, 48);
            this.btnSeeUser.TabIndex = 1;
            this.btnSeeUser.Text = "Edit User";
            this.btnSeeUser.UseVisualStyleBackColor = false;
            this.btnSeeUser.Click += new System.EventHandler(this.btnSeeUser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.IndianRed;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label1.Location = new System.Drawing.Point(108, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 52);
            this.label1.TabIndex = 2;
            this.label1.Text = "So, here you come, stranger.\r\nWanna have some fun?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(153, 443);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 48);
            this.button1.TabIndex = 3;
            this.button1.Text = "Quit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(466, 562);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSeeUser);
            this.Controls.Add(this.btnStartQuest);
            this.DoubleBuffered = true;
            this.Name = "FormStart";
            this.Text = "Dungeons&Windows Forms ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartQuest;
        private System.Windows.Forms.Button btnSeeUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}