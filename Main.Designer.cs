namespace DES
{
    partial class Main
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
            this.originalTextBox = new System.Windows.Forms.TextBox();
            this.encryptedTextBox = new System.Windows.Forms.TextBox();
            this.decryptedTextBox = new System.Windows.Forms.TextBox();
            this.openKeyTextBox = new System.Windows.Forms.TextBox();
            this.loadFileButton = new System.Windows.Forms.Button();
            this.saveFileButton = new System.Windows.Forms.Button();
            this.runButton = new System.Windows.Forms.Button();
            this.encryptRadioButton = new System.Windows.Forms.RadioButton();
            this.decryptRadioButton = new System.Windows.Forms.RadioButton();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.closedKeyTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // originalTextBox
            // 
            this.originalTextBox.Location = new System.Drawing.Point(12, 30);
            this.originalTextBox.Multiline = true;
            this.originalTextBox.Name = "originalTextBox";
            this.originalTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.originalTextBox.Size = new System.Drawing.Size(350, 300);
            this.originalTextBox.TabIndex = 0;
            // 
            // encryptedTextBox
            // 
            this.encryptedTextBox.Location = new System.Drawing.Point(417, 30);
            this.encryptedTextBox.Multiline = true;
            this.encryptedTextBox.Name = "encryptedTextBox";
            this.encryptedTextBox.Size = new System.Drawing.Size(350, 300);
            this.encryptedTextBox.TabIndex = 1;
            // 
            // decryptedTextBox
            // 
            this.decryptedTextBox.Location = new System.Drawing.Point(822, 30);
            this.decryptedTextBox.Multiline = true;
            this.decryptedTextBox.Name = "decryptedTextBox";
            this.decryptedTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.decryptedTextBox.Size = new System.Drawing.Size(350, 300);
            this.decryptedTextBox.TabIndex = 2;
            // 
            // openKeyTextBox
            // 
            this.openKeyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openKeyTextBox.Location = new System.Drawing.Point(12, 389);
            this.openKeyTextBox.Name = "openKeyTextBox";
            this.openKeyTextBox.Size = new System.Drawing.Size(350, 26);
            this.openKeyTextBox.TabIndex = 3;
            this.openKeyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // loadFileButton
            // 
            this.loadFileButton.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadFileButton.Location = new System.Drawing.Point(417, 414);
            this.loadFileButton.Name = "loadFileButton";
            this.loadFileButton.Size = new System.Drawing.Size(350, 23);
            this.loadFileButton.TabIndex = 5;
            this.loadFileButton.Text = "Загрузить файл";
            this.loadFileButton.UseVisualStyleBackColor = true;
            this.loadFileButton.Click += new System.EventHandler(this.loadFileButton_Click);
            // 
            // saveFileButton
            // 
            this.saveFileButton.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveFileButton.Location = new System.Drawing.Point(417, 456);
            this.saveFileButton.Name = "saveFileButton";
            this.saveFileButton.Size = new System.Drawing.Size(350, 23);
            this.saveFileButton.TabIndex = 6;
            this.saveFileButton.Text = "Сохранить файл";
            this.saveFileButton.UseVisualStyleBackColor = true;
            this.saveFileButton.Click += new System.EventHandler(this.saveFileButton_Click);
            // 
            // runButton
            // 
            this.runButton.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runButton.Location = new System.Drawing.Point(822, 456);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(338, 23);
            this.runButton.TabIndex = 7;
            this.runButton.Text = "Выполнить";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // encryptRadioButton
            // 
            this.encryptRadioButton.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encryptRadioButton.Location = new System.Drawing.Point(828, 414);
            this.encryptRadioButton.Name = "encryptRadioButton";
            this.encryptRadioButton.Size = new System.Drawing.Size(110, 23);
            this.encryptRadioButton.TabIndex = 8;
            this.encryptRadioButton.TabStop = true;
            this.encryptRadioButton.Text = "Зашифровать";
            this.encryptRadioButton.UseVisualStyleBackColor = true;
            // 
            // decryptRadioButton
            // 
            this.decryptRadioButton.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decryptRadioButton.Location = new System.Drawing.Point(1044, 414);
            this.decryptRadioButton.Name = "decryptRadioButton";
            this.decryptRadioButton.Size = new System.Drawing.Size(116, 23);
            this.decryptRadioButton.TabIndex = 9;
            this.decryptRadioButton.TabStop = true;
            this.decryptRadioButton.Text = "Расшифровать";
            this.decryptRadioButton.UseVisualStyleBackColor = true;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // closedKeyTextBox
            // 
            this.closedKeyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closedKeyTextBox.Location = new System.Drawing.Point(12, 453);
            this.closedKeyTextBox.Name = "closedKeyTextBox";
            this.closedKeyTextBox.Size = new System.Drawing.Size(350, 26);
            this.closedKeyTextBox.TabIndex = 10;
            this.closedKeyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 373);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Открытый ключ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 434);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Закрытый ключ";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 491);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.closedKeyTextBox);
            this.Controls.Add(this.decryptRadioButton);
            this.Controls.Add(this.encryptRadioButton);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.saveFileButton);
            this.Controls.Add(this.loadFileButton);
            this.Controls.Add(this.openKeyTextBox);
            this.Controls.Add(this.decryptedTextBox);
            this.Controls.Add(this.encryptedTextBox);
            this.Controls.Add(this.originalTextBox);
            this.Name = "Main";
            this.Text = "Алгоритм DES by smeshmike";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox originalTextBox;
        private System.Windows.Forms.TextBox encryptedTextBox;
        private System.Windows.Forms.TextBox decryptedTextBox;
        private System.Windows.Forms.TextBox openKeyTextBox;
        private System.Windows.Forms.Button loadFileButton;
        private System.Windows.Forms.Button saveFileButton;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.RadioButton encryptRadioButton;
        private System.Windows.Forms.RadioButton decryptRadioButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox closedKeyTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

