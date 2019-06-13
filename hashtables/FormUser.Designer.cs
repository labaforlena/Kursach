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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUser));
            this.buttonOK = new System.Windows.Forms.Button();
            this.labelInHand = new System.Windows.Forms.Label();
            this.labelOnLegs = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listBoxItemsInHand = new System.Windows.Forms.ListBox();
            this.listBoxItemsInBag = new System.Windows.Forms.ListBox();
            this.levelUpBox = new System.Windows.Forms.GroupBox();
            this.btnAddDef = new System.Windows.Forms.Button();
            this.btnAddAttack = new System.Windows.Forms.Button();
            this.labelAtackCount = new System.Windows.Forms.Label();
            this.labelBankCount = new System.Windows.Forms.Label();
            this.labelStaminaCount = new System.Windows.Forms.Label();
            this.labelExp = new System.Windows.Forms.Label();
            this.labelLoginCount = new System.Windows.Forms.Label();
            this.labelExpCount = new System.Windows.Forms.Label();
            this.labelBank = new System.Windows.Forms.Label();
            this.labelBaseDef = new System.Windows.Forms.Label();
            this.labelBaseAtc = new System.Windows.Forms.Label();
            this.labelStamina = new System.Windows.Forms.Label();
            this.labelLevel = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelLevelCount = new System.Windows.Forms.Label();
            this.labelDefCount = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAva = new System.Windows.Forms.Button();
            this.groupBoxAva = new System.Windows.Forms.GroupBox();
            this.pictureBoxAva = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.levelUpBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBoxAva.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAva)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonOK.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold);
            this.buttonOK.Location = new System.Drawing.Point(688, 430);
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
            this.labelInHand.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInHand.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelInHand.Location = new System.Drawing.Point(17, 27);
            this.labelInHand.Name = "labelInHand";
            this.labelInHand.Size = new System.Drawing.Size(95, 26);
            this.labelInHand.TabIndex = 7;
            this.labelInHand.Text = "in Hand: ";
            // 
            // labelOnLegs
            // 
            this.labelOnLegs.AutoSize = true;
            this.labelOnLegs.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelOnLegs.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelOnLegs.Location = new System.Drawing.Point(164, 27);
            this.labelOnLegs.Name = "labelOnLegs";
            this.labelOnLegs.Size = new System.Drawing.Size(82, 26);
            this.labelOnLegs.TabIndex = 8;
            this.labelOnLegs.Text = "in Sack:";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox1.Location = new System.Drawing.Point(136, 31);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 25);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // listBoxItemsInHand
            // 
            this.listBoxItemsInHand.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxItemsInHand.FormattingEnabled = true;
            this.listBoxItemsInHand.ItemHeight = 17;
            this.listBoxItemsInHand.Location = new System.Drawing.Point(10, 66);
            this.listBoxItemsInHand.Name = "listBoxItemsInHand";
            this.listBoxItemsInHand.Size = new System.Drawing.Size(120, 123);
            this.listBoxItemsInHand.TabIndex = 19;
            this.listBoxItemsInHand.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxItemsInHand_MouseDoubleClick);
            // 
            // listBoxItemsInBag
            // 
            this.listBoxItemsInBag.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxItemsInBag.FormattingEnabled = true;
            this.listBoxItemsInBag.ItemHeight = 17;
            this.listBoxItemsInBag.Location = new System.Drawing.Point(141, 66);
            this.listBoxItemsInBag.Name = "listBoxItemsInBag";
            this.listBoxItemsInBag.Size = new System.Drawing.Size(120, 123);
            this.listBoxItemsInBag.TabIndex = 20;
            this.listBoxItemsInBag.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxItemsInBag_MouseDoubleClick);
            // 
            // levelUpBox
            // 
            this.levelUpBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Diagram;
            this.levelUpBox.BackColor = System.Drawing.Color.Transparent;
            this.levelUpBox.Controls.Add(this.btnAddDef);
            this.levelUpBox.Controls.Add(this.btnAddAttack);
            this.levelUpBox.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold);
            this.levelUpBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.levelUpBox.Location = new System.Drawing.Point(340, 13);
            this.levelUpBox.Name = "levelUpBox";
            this.levelUpBox.Size = new System.Drawing.Size(189, 128);
            this.levelUpBox.TabIndex = 23;
            this.levelUpBox.TabStop = false;
            this.levelUpBox.Text = "Level Up";
            // 
            // btnAddDef
            // 
            this.btnAddDef.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddDef.ForeColor = System.Drawing.Color.Black;
            this.btnAddDef.Location = new System.Drawing.Point(55, 82);
            this.btnAddDef.Name = "btnAddDef";
            this.btnAddDef.Size = new System.Drawing.Size(75, 23);
            this.btnAddDef.TabIndex = 2;
            this.btnAddDef.Text = "add def";
            this.btnAddDef.UseVisualStyleBackColor = true;
            this.btnAddDef.Click += new System.EventHandler(this.btnAddDef_Click);
            // 
            // btnAddAttack
            // 
            this.btnAddAttack.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddAttack.ForeColor = System.Drawing.Color.Black;
            this.btnAddAttack.Location = new System.Drawing.Point(55, 44);
            this.btnAddAttack.Name = "btnAddAttack";
            this.btnAddAttack.Size = new System.Drawing.Size(75, 23);
            this.btnAddAttack.TabIndex = 0;
            this.btnAddAttack.Text = "add attack";
            this.btnAddAttack.UseVisualStyleBackColor = true;
            this.btnAddAttack.Click += new System.EventHandler(this.btnAddAttack_Click);
            // 
            // labelAtackCount
            // 
            this.labelAtackCount.AutoSize = true;
            this.labelAtackCount.BackColor = System.Drawing.Color.Transparent;
            this.labelAtackCount.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAtackCount.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelAtackCount.Location = new System.Drawing.Point(174, 215);
            this.labelAtackCount.Name = "labelAtackCount";
            this.labelAtackCount.Size = new System.Drawing.Size(27, 32);
            this.labelAtackCount.TabIndex = 11;
            this.labelAtackCount.Text = "0";
            // 
            // labelBankCount
            // 
            this.labelBankCount.AutoSize = true;
            this.labelBankCount.BackColor = System.Drawing.Color.Transparent;
            this.labelBankCount.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBankCount.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelBankCount.Location = new System.Drawing.Point(174, 43);
            this.labelBankCount.Name = "labelBankCount";
            this.labelBankCount.Size = new System.Drawing.Size(27, 32);
            this.labelBankCount.TabIndex = 15;
            this.labelBankCount.Text = "0";
            // 
            // labelStaminaCount
            // 
            this.labelStaminaCount.AutoSize = true;
            this.labelStaminaCount.BackColor = System.Drawing.Color.Transparent;
            this.labelStaminaCount.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStaminaCount.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelStaminaCount.Location = new System.Drawing.Point(174, 172);
            this.labelStaminaCount.Name = "labelStaminaCount";
            this.labelStaminaCount.Size = new System.Drawing.Size(27, 32);
            this.labelStaminaCount.TabIndex = 10;
            this.labelStaminaCount.Text = "0";
            // 
            // labelExp
            // 
            this.labelExp.AutoSize = true;
            this.labelExp.BackColor = System.Drawing.Color.Transparent;
            this.labelExp.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelExp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelExp.Location = new System.Drawing.Point(3, 129);
            this.labelExp.Name = "labelExp";
            this.labelExp.Size = new System.Drawing.Size(126, 28);
            this.labelExp.TabIndex = 17;
            this.labelExp.Text = "Experience:";
            // 
            // labelLoginCount
            // 
            this.labelLoginCount.AutoSize = true;
            this.labelLoginCount.BackColor = System.Drawing.Color.Transparent;
            this.labelLoginCount.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLoginCount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelLoginCount.Location = new System.Drawing.Point(174, 0);
            this.labelLoginCount.Name = "labelLoginCount";
            this.labelLoginCount.Size = new System.Drawing.Size(27, 32);
            this.labelLoginCount.TabIndex = 9;
            this.labelLoginCount.Text = "0";
            // 
            // labelExpCount
            // 
            this.labelExpCount.AutoSize = true;
            this.labelExpCount.BackColor = System.Drawing.Color.Transparent;
            this.labelExpCount.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelExpCount.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelExpCount.Location = new System.Drawing.Point(174, 129);
            this.labelExpCount.Name = "labelExpCount";
            this.labelExpCount.Size = new System.Drawing.Size(27, 32);
            this.labelExpCount.TabIndex = 18;
            this.labelExpCount.Text = "0";
            // 
            // labelBank
            // 
            this.labelBank.AutoSize = true;
            this.labelBank.BackColor = System.Drawing.Color.Transparent;
            this.labelBank.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBank.ForeColor = System.Drawing.Color.Transparent;
            this.labelBank.Location = new System.Drawing.Point(3, 43);
            this.labelBank.Name = "labelBank";
            this.labelBank.Size = new System.Drawing.Size(74, 28);
            this.labelBank.TabIndex = 5;
            this.labelBank.Text = "Bank :";
            // 
            // labelBaseDef
            // 
            this.labelBaseDef.AutoSize = true;
            this.labelBaseDef.BackColor = System.Drawing.Color.Transparent;
            this.labelBaseDef.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBaseDef.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelBaseDef.Location = new System.Drawing.Point(3, 258);
            this.labelBaseDef.Name = "labelBaseDef";
            this.labelBaseDef.Size = new System.Drawing.Size(151, 28);
            this.labelBaseDef.TabIndex = 4;
            this.labelBaseDef.Text = "Basic defence:";
            // 
            // labelBaseAtc
            // 
            this.labelBaseAtc.AutoSize = true;
            this.labelBaseAtc.BackColor = System.Drawing.Color.Transparent;
            this.labelBaseAtc.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBaseAtc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelBaseAtc.Location = new System.Drawing.Point(3, 215);
            this.labelBaseAtc.Name = "labelBaseAtc";
            this.labelBaseAtc.Size = new System.Drawing.Size(122, 28);
            this.labelBaseAtc.TabIndex = 3;
            this.labelBaseAtc.Text = "Basic atacc:";
            // 
            // labelStamina
            // 
            this.labelStamina.AutoSize = true;
            this.labelStamina.BackColor = System.Drawing.Color.Transparent;
            this.labelStamina.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStamina.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelStamina.Location = new System.Drawing.Point(3, 172);
            this.labelStamina.Name = "labelStamina";
            this.labelStamina.Size = new System.Drawing.Size(99, 28);
            this.labelStamina.TabIndex = 2;
            this.labelStamina.Text = "Stamina:";
            // 
            // labelLevel
            // 
            this.labelLevel.AutoSize = true;
            this.labelLevel.BackColor = System.Drawing.Color.Transparent;
            this.labelLevel.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLevel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelLevel.Location = new System.Drawing.Point(3, 86);
            this.labelLevel.Name = "labelLevel";
            this.labelLevel.Size = new System.Drawing.Size(71, 28);
            this.labelLevel.TabIndex = 24;
            this.labelLevel.Text = "Level:";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.BackColor = System.Drawing.Color.Transparent;
            this.labelLogin.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelLogin.Location = new System.Drawing.Point(3, 0);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(75, 28);
            this.labelLogin.TabIndex = 0;
            this.labelLogin.Text = "Login:";
            // 
            // labelLevelCount
            // 
            this.labelLevelCount.AutoSize = true;
            this.labelLevelCount.BackColor = System.Drawing.Color.Transparent;
            this.labelLevelCount.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLevelCount.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelLevelCount.Location = new System.Drawing.Point(174, 86);
            this.labelLevelCount.Name = "labelLevelCount";
            this.labelLevelCount.Size = new System.Drawing.Size(27, 32);
            this.labelLevelCount.TabIndex = 25;
            this.labelLevelCount.Text = "0";
            // 
            // labelDefCount
            // 
            this.labelDefCount.AutoSize = true;
            this.labelDefCount.BackColor = System.Drawing.Color.Transparent;
            this.labelDefCount.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDefCount.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelDefCount.Location = new System.Drawing.Point(174, 258);
            this.labelDefCount.Name = "labelDefCount";
            this.labelDefCount.Size = new System.Drawing.Size(27, 32);
            this.labelDefCount.TabIndex = 12;
            this.labelDefCount.Text = "0";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.labelLogin, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelDefCount, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.labelLevelCount, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelAtackCount, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelBaseDef, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.labelExpCount, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelStaminaCount, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelBank, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelLevel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelExp, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelBankCount, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelStamina, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelBaseAtc, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelLoginCount, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(28, 165);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(342, 306);
            this.tableLayoutPanel1.TabIndex = 26;
            // 
            // btnAva
            // 
            this.btnAva.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAva.Location = new System.Drawing.Point(160, 82);
            this.btnAva.Name = "btnAva";
            this.btnAva.Size = new System.Drawing.Size(75, 23);
            this.btnAva.TabIndex = 27;
            this.btnAva.Text = "SET";
            this.btnAva.UseVisualStyleBackColor = true;
            this.btnAva.Click += new System.EventHandler(this.btnAva_Click);
            // 
            // groupBoxAva
            // 
            this.groupBoxAva.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxAva.Controls.Add(this.pictureBoxAva);
            this.groupBoxAva.Controls.Add(this.btnAva);
            this.groupBoxAva.Controls.Add(this.comboBox1);
            this.groupBoxAva.Location = new System.Drawing.Point(28, 12);
            this.groupBoxAva.Margin = new System.Windows.Forms.Padding(1);
            this.groupBoxAva.Name = "groupBoxAva";
            this.groupBoxAva.Size = new System.Drawing.Size(293, 128);
            this.groupBoxAva.TabIndex = 28;
            this.groupBoxAva.TabStop = false;
            // 
            // pictureBoxAva
            // 
            this.pictureBoxAva.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxAva.BackgroundImage")));
            this.pictureBoxAva.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxAva.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxAva.Location = new System.Drawing.Point(17, 19);
            this.pictureBoxAva.Name = "pictureBoxAva";
            this.pictureBoxAva.Size = new System.Drawing.Size(96, 91);
            this.pictureBoxAva.TabIndex = 1;
            this.pictureBoxAva.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.labelInHand);
            this.groupBox1.Controls.Add(this.labelOnLegs);
            this.groupBox1.Controls.Add(this.listBoxItemsInHand);
            this.groupBox1.Controls.Add(this.listBoxItemsInBag);
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Location = new System.Drawing.Point(546, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 221);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loot";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::hashtables.Properties.Resources.user4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(836, 494);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxAva);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.levelUpBox);
            this.Controls.Add(this.buttonOK);
            this.Name = "FormUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dungeons&Windows Forms ";
            this.levelUpBox.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBoxAva.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAva)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxAva;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label labelInHand;
        private System.Windows.Forms.Label labelOnLegs;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox listBoxItemsInHand;
        private System.Windows.Forms.ListBox listBoxItemsInBag;
        private System.Windows.Forms.GroupBox levelUpBox;
        private System.Windows.Forms.Button btnAddDef;
        private System.Windows.Forms.Button btnAddAttack;
        public System.Windows.Forms.Label labelAtackCount;
        public System.Windows.Forms.Label labelBankCount;
        public System.Windows.Forms.Label labelStaminaCount;
        private System.Windows.Forms.Label labelExp;
        public System.Windows.Forms.Label labelLoginCount;
        public System.Windows.Forms.Label labelExpCount;
        private System.Windows.Forms.Label labelBank;
        private System.Windows.Forms.Label labelBaseDef;
        private System.Windows.Forms.Label labelBaseAtc;
        private System.Windows.Forms.Label labelStamina;
        private System.Windows.Forms.Label labelLevel;
        private System.Windows.Forms.Label labelLogin;
        public System.Windows.Forms.Label labelLevelCount;
        public System.Windows.Forms.Label labelDefCount;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnAva;
        private System.Windows.Forms.GroupBox groupBoxAva;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ImageList imageList1;
    }
}