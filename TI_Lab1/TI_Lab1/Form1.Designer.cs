﻿namespace TI_Lab1
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnEnterPlainText = new System.Windows.Forms.Button();
            this.txtPlainText = new System.Windows.Forms.TextBox();
            this.rbdRailway = new System.Windows.Forms.RadioButton();
            this.rdbColums = new System.Windows.Forms.RadioButton();
            this.lblEnterPlaintText = new System.Windows.Forms.Label();
            this.rdbVizhiner = new System.Windows.Forms.RadioButton();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.lblEnterKey = new System.Windows.Forms.Label();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblCipherText = new System.Windows.Forms.Label();
            this.btnEncipher = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEnterPlainText
            // 
            this.btnEnterPlainText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnterPlainText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEnterPlainText.Location = new System.Drawing.Point(737, 235);
            this.btnEnterPlainText.Name = "btnEnterPlainText";
            this.btnEnterPlainText.Size = new System.Drawing.Size(348, 55);
            this.btnEnterPlainText.TabIndex = 0;
            this.btnEnterPlainText.Text = "Зашифровать";
            this.btnEnterPlainText.UseVisualStyleBackColor = true;
            this.btnEnterPlainText.Click += new System.EventHandler(this.btnEnterPlainText_Click);
            // 
            // txtPlainText
            // 
            this.txtPlainText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPlainText.Location = new System.Drawing.Point(28, 52);
            this.txtPlainText.Multiline = true;
            this.txtPlainText.Name = "txtPlainText";
            this.txtPlainText.Size = new System.Drawing.Size(515, 130);
            this.txtPlainText.TabIndex = 1;
            // 
            // rbdRailway
            // 
            this.rbdRailway.AutoSize = true;
            this.rbdRailway.Checked = true;
            this.rbdRailway.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbdRailway.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbdRailway.Location = new System.Drawing.Point(737, 31);
            this.rbdRailway.Name = "rbdRailway";
            this.rbdRailway.Size = new System.Drawing.Size(321, 30);
            this.rbdRailway.TabIndex = 3;
            this.rbdRailway.TabStop = true;
            this.rbdRailway.Text = "Железнодорожная изгородь";
            this.rbdRailway.UseVisualStyleBackColor = true;
            // 
            // rdbColums
            // 
            this.rdbColums.AutoSize = true;
            this.rdbColums.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbColums.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rdbColums.Location = new System.Drawing.Point(737, 67);
            this.rdbColums.Name = "rdbColums";
            this.rdbColums.Size = new System.Drawing.Size(228, 30);
            this.rdbColums.TabIndex = 4;
            this.rdbColums.Text = "Столбцовый метод";
            this.rdbColums.UseVisualStyleBackColor = true;
            // 
            // lblEnterPlaintText
            // 
            this.lblEnterPlaintText.AutoSize = true;
            this.lblEnterPlaintText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEnterPlaintText.Location = new System.Drawing.Point(22, 9);
            this.lblEnterPlaintText.Name = "lblEnterPlaintText";
            this.lblEnterPlaintText.Size = new System.Drawing.Size(322, 31);
            this.lblEnterPlaintText.TabIndex = 5;
            this.lblEnterPlaintText.Text = "Введите исходный текст";
            // 
            // rdbVizhiner
            // 
            this.rdbVizhiner.AutoSize = true;
            this.rdbVizhiner.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbVizhiner.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rdbVizhiner.Location = new System.Drawing.Point(737, 103);
            this.rdbVizhiner.Name = "rdbVizhiner";
            this.rdbVizhiner.Size = new System.Drawing.Size(201, 30);
            this.rdbVizhiner.TabIndex = 6;
            this.rdbVizhiner.Text = "Шифр Вижинера";
            this.rdbVizhiner.UseVisualStyleBackColor = true;
            // 
            // txtKey
            // 
            this.txtKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtKey.Location = new System.Drawing.Point(28, 242);
            this.txtKey.Multiline = true;
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(515, 131);
            this.txtKey.TabIndex = 7;
            // 
            // lblEnterKey
            // 
            this.lblEnterKey.AutoSize = true;
            this.lblEnterKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEnterKey.Location = new System.Drawing.Point(22, 198);
            this.lblEnterKey.Name = "lblEnterKey";
            this.lblEnterKey.Size = new System.Drawing.Size(189, 31);
            this.lblEnterKey.TabIndex = 8;
            this.lblEnterKey.Text = "Введите ключ";
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOpenFile.Location = new System.Drawing.Point(737, 440);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(348, 52);
            this.btnOpenFile.TabIndex = 9;
            this.btnOpenFile.Text = "Открыть файл";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSaveFile.Location = new System.Drawing.Point(737, 518);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(348, 52);
            this.btnSaveFile.TabIndex = 10;
            this.btnSaveFile.Text = "Сохранить результаты в файл";
            this.btnSaveFile.UseVisualStyleBackColor = true;
            this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(28, 440);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(515, 130);
            this.textBox1.TabIndex = 11;
            // 
            // lblCipherText
            // 
            this.lblCipherText.AutoSize = true;
            this.lblCipherText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCipherText.Location = new System.Drawing.Point(22, 395);
            this.lblCipherText.Name = "lblCipherText";
            this.lblCipherText.Size = new System.Drawing.Size(143, 31);
            this.lblCipherText.TabIndex = 12;
            this.lblCipherText.Text = "Результат";
            // 
            // btnEncipher
            // 
            this.btnEncipher.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEncipher.Location = new System.Drawing.Point(737, 318);
            this.btnEncipher.Name = "btnEncipher";
            this.btnEncipher.Size = new System.Drawing.Size(348, 55);
            this.btnEncipher.TabIndex = 13;
            this.btnEncipher.Text = "Расшифровать";
            this.btnEncipher.UseVisualStyleBackColor = true;
            this.btnEncipher.Click += new System.EventHandler(this.btnEncipher_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "Document";
            this.openFileDialog1.Filter = "\"Text files(*.txt)|*.txt|All files(*.*)|*.*\"";
            this.openFileDialog1.InitialDirectory = "D:\\БГУИР\\4 сем\\TI\\TI_Lab1";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "Документ";
            this.saveFileDialog1.Filter = "\"Text files(*.txt)|*.txt|All files(*.*)|*.*\"";
            this.saveFileDialog1.InitialDirectory = "D:\\БГУИР\\4 сем\\TI\\TI_Lab1";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClear.Location = new System.Drawing.Point(28, 592);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(515, 48);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Очистить все поля";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 652);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnEncipher);
            this.Controls.Add(this.lblCipherText);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSaveFile);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.lblEnterKey);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.rdbVizhiner);
            this.Controls.Add(this.lblEnterPlaintText);
            this.Controls.Add(this.rdbColums);
            this.Controls.Add(this.rbdRailway);
            this.Controls.Add(this.txtPlainText);
            this.Controls.Add(this.btnEnterPlainText);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ТИ 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnterPlainText;
        private System.Windows.Forms.TextBox txtPlainText;
        private System.Windows.Forms.RadioButton rbdRailway;
        private System.Windows.Forms.RadioButton rdbColums;
        private System.Windows.Forms.Label lblEnterPlaintText;
        private System.Windows.Forms.RadioButton rdbVizhiner;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label lblEnterKey;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button btnSaveFile;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblCipherText;
        private System.Windows.Forms.Button btnEncipher;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnClear;
    }
}

