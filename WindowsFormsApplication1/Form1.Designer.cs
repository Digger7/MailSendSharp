namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.sendButton = new System.Windows.Forms.Button();
            this.subjectTextBox = new System.Windows.Forms.TextBox();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.fromTextBox = new System.Windows.Forms.TextBox();
            this.toTextBox = new System.Windows.Forms.TextBox();
            this.mailserverTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.textBoxAttach = new System.Windows.Forms.TextBox();
            this.buttonAttach = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelInfo = new System.Windows.Forms.Label();
            this.checkBoxMainMessageFirst = new System.Windows.Forms.CheckBox();
            this.numericUpDownDelay = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDownRetryCount = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonClearAttach = new System.Windows.Forms.Button();
            this.labelAttachCount = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRetryCount)).BeginInit();
            this.SuspendLayout();
            // 
            // sendButton
            // 
            this.sendButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sendButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sendButton.Location = new System.Drawing.Point(692, 254);
            this.sendButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(184, 46);
            this.sendButton.TabIndex = 0;
            this.sendButton.Text = "Отправить";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // subjectTextBox
            // 
            this.subjectTextBox.Location = new System.Drawing.Point(16, 31);
            this.subjectTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.subjectTextBox.MaxLength = 0;
            this.subjectTextBox.Name = "subjectTextBox";
            this.subjectTextBox.Size = new System.Drawing.Size(405, 22);
            this.subjectTextBox.TabIndex = 1;
            this.subjectTextBox.Text = "Тема";
            // 
            // messageTextBox
            // 
            this.messageTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.messageTextBox.Location = new System.Drawing.Point(16, 85);
            this.messageTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.messageTextBox.MaxLength = 0;
            this.messageTextBox.Multiline = true;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(404, 134);
            this.messageTextBox.TabIndex = 2;
            this.messageTextBox.Text = "Сообщение";
            // 
            // fromTextBox
            // 
            this.fromTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fromTextBox.Location = new System.Drawing.Point(431, 81);
            this.fromTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fromTextBox.MaxLength = 0;
            this.fromTextBox.Name = "fromTextBox";
            this.fromTextBox.Size = new System.Drawing.Size(521, 22);
            this.fromTextBox.TabIndex = 3;
            this.fromTextBox.Text = "info@mail.ru";
            // 
            // toTextBox
            // 
            this.toTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.toTextBox.Location = new System.Drawing.Point(431, 129);
            this.toTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.toTextBox.MaxLength = 0;
            this.toTextBox.Multiline = true;
            this.toTextBox.Name = "toTextBox";
            this.toTextBox.Size = new System.Drawing.Size(521, 118);
            this.toTextBox.TabIndex = 4;
            this.toTextBox.Text = "email@mail.ru, message;";
            // 
            // mailserverTextBox
            // 
            this.mailserverTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.mailserverTextBox.Location = new System.Drawing.Point(431, 31);
            this.mailserverTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mailserverTextBox.MaxLength = 0;
            this.mailserverTextBox.Name = "mailserverTextBox";
            this.mailserverTextBox.Size = new System.Drawing.Size(521, 22);
            this.mailserverTextBox.TabIndex = 5;
            this.mailserverTextBox.Text = "mailserver.ru";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "SUBJECT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "MESSAGE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(428, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "FROM";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(429, 111);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(306, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "TO ( email [,message] ; email [,message]; <...>)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(428, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "MAILSERVER";
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(121, 262);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(300, 28);
            this.progressBar1.TabIndex = 11;
            // 
            // textBoxAttach
            // 
            this.textBoxAttach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxAttach.Location = new System.Drawing.Point(156, 224);
            this.textBoxAttach.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxAttach.Name = "textBoxAttach";
            this.textBoxAttach.Size = new System.Drawing.Size(192, 22);
            this.textBoxAttach.TabIndex = 12;
            this.textBoxAttach.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAttach_KeyPress);
            // 
            // buttonAttach
            // 
            this.buttonAttach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAttach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAttach.Location = new System.Drawing.Point(352, 223);
            this.buttonAttach.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAttach.Name = "buttonAttach";
            this.buttonAttach.Size = new System.Drawing.Size(69, 27);
            this.buttonAttach.TabIndex = 13;
            this.buttonAttach.Text = "...";
            this.buttonAttach.UseVisualStyleBackColor = true;
            this.buttonAttach.Click += new System.EventHandler(this.buttonAttach_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 229);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "ATTACHMENT";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(865, 6);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "© 2016 Digger";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancel.Location = new System.Drawing.Point(877, 254);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(76, 46);
            this.buttonCancel.TabIndex = 16;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelInfo
            // 
            this.labelInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(432, 270);
            this.labelInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(28, 17);
            this.labelInfo.TabIndex = 17;
            this.labelInfo.Text = "0/0";
            // 
            // checkBoxMainMessageFirst
            // 
            this.checkBoxMainMessageFirst.AutoSize = true;
            this.checkBoxMainMessageFirst.Checked = true;
            this.checkBoxMainMessageFirst.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMainMessageFirst.Location = new System.Drawing.Point(200, 63);
            this.checkBoxMainMessageFirst.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxMainMessageFirst.Name = "checkBoxMainMessageFirst";
            this.checkBoxMainMessageFirst.Size = new System.Drawing.Size(217, 21);
            this.checkBoxMainMessageFirst.TabIndex = 18;
            this.checkBoxMainMessageFirst.Text = "main message to first position";
            this.checkBoxMainMessageFirst.UseVisualStyleBackColor = true;
            // 
            // numericUpDownDelay
            // 
            this.numericUpDownDelay.Location = new System.Drawing.Point(309, 5);
            this.numericUpDownDelay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDownDelay.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownDelay.Name = "numericUpDownDelay";
            this.numericUpDownDelay.Size = new System.Drawing.Size(112, 22);
            this.numericUpDownDelay.TabIndex = 19;
            this.numericUpDownDelay.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(261, 7);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "delay:";
            // 
            // numericUpDownRetryCount
            // 
            this.numericUpDownRetryCount.Location = new System.Drawing.Point(193, 5);
            this.numericUpDownRetryCount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDownRetryCount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownRetryCount.Name = "numericUpDownRetryCount";
            this.numericUpDownRetryCount.Size = new System.Drawing.Size(65, 22);
            this.numericUpDownRetryCount.TabIndex = 21;
            this.numericUpDownRetryCount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(152, 7);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 17);
            this.label9.TabIndex = 22;
            this.label9.Text = "retry:";
            // 
            // buttonClearAttach
            // 
            this.buttonClearAttach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonClearAttach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClearAttach.Image = global::WindowsFormsApplication1.Properties.Resources.delete;
            this.buttonClearAttach.Location = new System.Drawing.Point(121, 223);
            this.buttonClearAttach.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonClearAttach.Name = "buttonClearAttach";
            this.buttonClearAttach.Size = new System.Drawing.Size(33, 27);
            this.buttonClearAttach.TabIndex = 23;
            this.buttonClearAttach.UseVisualStyleBackColor = true;
            this.buttonClearAttach.Click += new System.EventHandler(this.buttonClearAttach_Click);
            // 
            // labelAttachCount
            // 
            this.labelAttachCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelAttachCount.AutoSize = true;
            this.labelAttachCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAttachCount.Location = new System.Drawing.Point(45, 256);
            this.labelAttachCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAttachCount.Name = "labelAttachCount";
            this.labelAttachCount.Size = new System.Drawing.Size(37, 39);
            this.labelAttachCount.TabIndex = 24;
            this.labelAttachCount.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 304);
            this.Controls.Add(this.labelAttachCount);
            this.Controls.Add(this.buttonClearAttach);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.numericUpDownRetryCount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numericUpDownDelay);
            this.Controls.Add(this.checkBoxMainMessageFirst);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonAttach);
            this.Controls.Add(this.textBoxAttach);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mailserverTextBox);
            this.Controls.Add(this.toTextBox);
            this.Controls.Add(this.fromTextBox);
            this.Controls.Add(this.messageTextBox);
            this.Controls.Add(this.subjectTextBox);
            this.Controls.Add(this.sendButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRetryCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.TextBox subjectTextBox;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.TextBox fromTextBox;
        private System.Windows.Forms.TextBox toTextBox;
        private System.Windows.Forms.TextBox mailserverTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox textBoxAttach;
        private System.Windows.Forms.Button buttonAttach;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.CheckBox checkBoxMainMessageFirst;
        private System.Windows.Forms.NumericUpDown numericUpDownDelay;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDownRetryCount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonClearAttach;
        private System.Windows.Forms.Label labelAttachCount;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

