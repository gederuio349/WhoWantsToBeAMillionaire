namespace WhoWantsToBeAMillionaire
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAnswerA = new System.Windows.Forms.Button();
            this.btnAnswerB = new System.Windows.Forms.Button();
            this.btnAnswerC = new System.Windows.Forms.Button();
            this.btnAnswerD = new System.Windows.Forms.Button();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lstLevel = new System.Windows.Forms.ListBox();
            this.btnFiftyFifty = new System.Windows.Forms.Button();
            this.btnMarginError = new System.Windows.Forms.Button();
            this.btnChangeQuestion = new System.Windows.Forms.Button();
            this.btnCallFriend = new System.Windows.Forms.Button();
            this.bthHelpGuests = new System.Windows.Forms.Button();
            this.lstRecords = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(130, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(487, 294);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnAnswerA
            // 
            this.btnAnswerA.Location = new System.Drawing.Point(130, 380);
            this.btnAnswerA.Name = "btnAnswerA";
            this.btnAnswerA.Size = new System.Drawing.Size(100, 40);
            this.btnAnswerA.TabIndex = 1;
            this.btnAnswerA.Tag = "1";
            this.btnAnswerA.Text = "button1";
            this.btnAnswerA.UseVisualStyleBackColor = true;
            this.btnAnswerA.Click += new System.EventHandler(this.btnAnswerA_Click);
            // 
            // btnAnswerB
            // 
            this.btnAnswerB.Location = new System.Drawing.Point(130, 460);
            this.btnAnswerB.Name = "btnAnswerB";
            this.btnAnswerB.Size = new System.Drawing.Size(100, 40);
            this.btnAnswerB.TabIndex = 2;
            this.btnAnswerB.Tag = "2";
            this.btnAnswerB.Text = "button2";
            this.btnAnswerB.UseVisualStyleBackColor = true;
            this.btnAnswerB.Click += new System.EventHandler(this.btnAnswerB_Click);
            // 
            // btnAnswerC
            // 
            this.btnAnswerC.Location = new System.Drawing.Point(520, 380);
            this.btnAnswerC.Name = "btnAnswerC";
            this.btnAnswerC.Size = new System.Drawing.Size(100, 40);
            this.btnAnswerC.TabIndex = 3;
            this.btnAnswerC.Tag = "3";
            this.btnAnswerC.Text = "button3";
            this.btnAnswerC.UseVisualStyleBackColor = true;
            this.btnAnswerC.Click += new System.EventHandler(this.btnAnswerC_Click);
            // 
            // btnAnswerD
            // 
            this.btnAnswerD.Location = new System.Drawing.Point(520, 460);
            this.btnAnswerD.Name = "btnAnswerD";
            this.btnAnswerD.Size = new System.Drawing.Size(100, 40);
            this.btnAnswerD.TabIndex = 4;
            this.btnAnswerD.Tag = "4";
            this.btnAnswerD.Text = "button4";
            this.btnAnswerD.UseVisualStyleBackColor = true;
            this.btnAnswerD.Click += new System.EventHandler(this.btnAnswerD_Click);
            // 
            // lblQuestion
            // 
            this.lblQuestion.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(130, 320);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(485, 50);
            this.lblQuestion.TabIndex = 5;
            this.lblQuestion.Text = "label1";
            // 
            // lstLevel
            // 
            this.lstLevel.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstLevel.FormattingEnabled = true;
            this.lstLevel.ItemHeight = 25;
            this.lstLevel.Items.AddRange(new object[] {
            "3 000 000",
            "1 500 000",
            "800 000",
            "400 000",
            "200 000",
            "100 000",
            "50 000",
            "25 000",
            "15 000",
            "10 000",
            "5 000",
            "3 000",
            "2 000",
            "1 000",
            "500"});
            this.lstLevel.Location = new System.Drawing.Point(650, 10);
            this.lstLevel.Name = "lstLevel";
            this.lstLevel.Size = new System.Drawing.Size(120, 379);
            this.lstLevel.TabIndex = 6;
            // 
            // btnFiftyFifty
            // 
            this.btnFiftyFifty.Location = new System.Drawing.Point(10, 100);
            this.btnFiftyFifty.Name = "btnFiftyFifty";
            this.btnFiftyFifty.Size = new System.Drawing.Size(100, 40);
            this.btnFiftyFifty.TabIndex = 7;
            this.btnFiftyFifty.Text = "50 на 50";
            this.btnFiftyFifty.UseVisualStyleBackColor = true;
            this.btnFiftyFifty.Click += new System.EventHandler(this.btnFiftyFifty_Click_1);
            // 
            // btnMarginError
            // 
            this.btnMarginError.Location = new System.Drawing.Point(10, 160);
            this.btnMarginError.Name = "btnMarginError";
            this.btnMarginError.Size = new System.Drawing.Size(100, 40);
            this.btnMarginError.TabIndex = 8;
            this.btnMarginError.Text = "Право на ошибку";
            this.btnMarginError.UseVisualStyleBackColor = true;
            this.btnMarginError.Click += new System.EventHandler(this.btnMarginError_Click);
            // 
            // btnChangeQuestion
            // 
            this.btnChangeQuestion.Location = new System.Drawing.Point(10, 220);
            this.btnChangeQuestion.Name = "btnChangeQuestion";
            this.btnChangeQuestion.Size = new System.Drawing.Size(100, 40);
            this.btnChangeQuestion.TabIndex = 9;
            this.btnChangeQuestion.Text = "Замена вопроса";
            this.btnChangeQuestion.UseVisualStyleBackColor = true;
            this.btnChangeQuestion.Click += new System.EventHandler(this.btnChangeQuestion_Click);
            // 
            // btnCallFriend
            // 
            this.btnCallFriend.Location = new System.Drawing.Point(10, 280);
            this.btnCallFriend.Name = "btnCallFriend";
            this.btnCallFriend.Size = new System.Drawing.Size(100, 40);
            this.btnCallFriend.TabIndex = 10;
            this.btnCallFriend.Text = "Звонок другу";
            this.btnCallFriend.UseVisualStyleBackColor = true;
            this.btnCallFriend.Click += new System.EventHandler(this.btnCallFriend_Click);
            // 
            // bthHelpGuests
            // 
            this.bthHelpGuests.Location = new System.Drawing.Point(10, 340);
            this.bthHelpGuests.Name = "bthHelpGuests";
            this.bthHelpGuests.Size = new System.Drawing.Size(100, 40);
            this.bthHelpGuests.TabIndex = 11;
            this.bthHelpGuests.Text = "Помощь зала";
            this.bthHelpGuests.UseVisualStyleBackColor = true;
            this.bthHelpGuests.Click += new System.EventHandler(this.bthHelpGuests_Click);
            // 
            // lstRecords
            // 
            this.lstRecords.FormattingEnabled = true;
            this.lstRecords.Location = new System.Drawing.Point(799, 10);
            this.lstRecords.Name = "lstRecords";
            this.lstRecords.Size = new System.Drawing.Size(213, 381);
            this.lstRecords.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 543);
            this.Controls.Add(this.lstRecords);
            this.Controls.Add(this.bthHelpGuests);
            this.Controls.Add(this.btnCallFriend);
            this.Controls.Add(this.btnChangeQuestion);
            this.Controls.Add(this.btnMarginError);
            this.Controls.Add(this.btnFiftyFifty);
            this.Controls.Add(this.lstLevel);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.btnAnswerD);
            this.Controls.Add(this.btnAnswerC);
            this.Controls.Add(this.btnAnswerB);
            this.Controls.Add(this.btnAnswerA);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAnswerA;
        private System.Windows.Forms.Button btnAnswerB;
        private System.Windows.Forms.Button btnAnswerC;
        private System.Windows.Forms.Button btnAnswerD;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.ListBox lstLevel;
        private System.Windows.Forms.Button btnFiftyFifty;
        private System.Windows.Forms.Button btnMarginError;
        private System.Windows.Forms.Button btnChangeQuestion;
        private System.Windows.Forms.Button btnCallFriend;
        private System.Windows.Forms.Button bthHelpGuests;
        private System.Windows.Forms.ListBox lstRecords;
    }
}

