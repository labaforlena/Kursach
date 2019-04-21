namespace hashtables
{
    partial class FormUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUser));
            this.labelLogin = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelHP = new System.Windows.Forms.Label();
            this.labelBaseAtc = new System.Windows.Forms.Label();
            this.labelBaseDef = new System.Windows.Forms.Label();
            this.labelBank = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.labelInHand = new System.Windows.Forms.Label();
            this.labelOnLegs = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.BackColor = System.Drawing.Color.RosyBrown;
            this.labelLogin.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogin.Location = new System.Drawing.Point(34, 73);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(64, 27);
            this.labelLogin.TabIndex = 0;
            this.labelLogin.Text = "Login:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(442, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 176);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // labelHP
            // 
            this.labelHP.AutoSize = true;
            this.labelHP.BackColor = System.Drawing.Color.RosyBrown;
            this.labelHP.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHP.Location = new System.Drawing.Point(34, 125);
            this.labelHP.Name = "labelHP";
            this.labelHP.Size = new System.Drawing.Size(42, 27);
            this.labelHP.TabIndex = 2;
            this.labelHP.Text = "HP:";
            // 
            // labelBaseAtc
            // 
            this.labelBaseAtc.AutoSize = true;
            this.labelBaseAtc.BackColor = System.Drawing.Color.RosyBrown;
            this.labelBaseAtc.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBaseAtc.Location = new System.Drawing.Point(34, 181);
            this.labelBaseAtc.Name = "labelBaseAtc";
            this.labelBaseAtc.Size = new System.Drawing.Size(114, 27);
            this.labelBaseAtc.TabIndex = 3;
            this.labelBaseAtc.Text = "Basic atacc:";
            this.labelBaseAtc.Click += new System.EventHandler(this.labelBaseAtc_Click);
            // 
            // labelBaseDef
            // 
            this.labelBaseDef.AutoSize = true;
            this.labelBaseDef.BackColor = System.Drawing.Color.RosyBrown;
            this.labelBaseDef.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBaseDef.Location = new System.Drawing.Point(34, 236);
            this.labelBaseDef.Name = "labelBaseDef";
            this.labelBaseDef.Size = new System.Drawing.Size(164, 27);
            this.labelBaseDef.TabIndex = 4;
            this.labelBaseDef.Text = "Basic defendance:";
            // 
            // labelBank
            // 
            this.labelBank.AutoSize = true;
            this.labelBank.BackColor = System.Drawing.Color.RosyBrown;
            this.labelBank.Font = new System.Drawing.Font("Snap ITC", 13F, System.Drawing.FontStyle.Bold);
            this.labelBank.ForeColor = System.Drawing.Color.Black;
            this.labelBank.Location = new System.Drawing.Point(218, 21);
            this.labelBank.Name = "labelBank";
            this.labelBank.Size = new System.Drawing.Size(92, 24);
            this.labelBank.TabIndex = 5;
            this.labelBank.Text = "BANK :";
            // 
            // buttonOK
            // 
            this.buttonOK.BackColor = System.Drawing.Color.RosyBrown;
            this.buttonOK.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOK.Location = new System.Drawing.Point(467, 397);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(136, 41);
            this.buttonOK.TabIndex = 6;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = false;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // labelInHand
            // 
            this.labelInHand.AutoSize = true;
            this.labelInHand.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInHand.Location = new System.Drawing.Point(37, 304);
            this.labelInHand.Name = "labelInHand";
            this.labelInHand.Size = new System.Drawing.Size(89, 25);
            this.labelInHand.TabIndex = 7;
            this.labelInHand.Text = "in hand: ";
            // 
            // labelOnLegs
            // 
            this.labelOnLegs.AutoSize = true;
            this.labelOnLegs.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOnLegs.Location = new System.Drawing.Point(37, 367);
            this.labelOnLegs.Name = "labelOnLegs";
            this.labelOnLegs.Size = new System.Drawing.Size(69, 25);
            this.labelOnLegs.TabIndex = 8;
            this.labelOnLegs.Text = "on legs:";
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(629, 450);
            this.Controls.Add(this.labelOnLegs);
            this.Controls.Add(this.labelInHand);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.labelBank);
            this.Controls.Add(this.labelBaseDef);
            this.Controls.Add(this.labelBaseAtc);
            this.Controls.Add(this.labelHP);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelLogin);
            this.Name = "FormUser";
            this.Text = "FormUser";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelHP;
        private System.Windows.Forms.Label labelBaseAtc;
        private System.Windows.Forms.Label labelBaseDef;
        private System.Windows.Forms.Label labelBank;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label labelInHand;
        private System.Windows.Forms.Label labelOnLegs;
    }
}