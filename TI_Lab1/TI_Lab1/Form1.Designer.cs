namespace TI_Lab1
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
            this.SuspendLayout();
            // 
            // btnEnterPlainText
            // 
            this.btnEnterPlainText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnterPlainText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEnterPlainText.Location = new System.Drawing.Point(28, 443);
            this.btnEnterPlainText.Name = "btnEnterPlainText";
            this.btnEnterPlainText.Size = new System.Drawing.Size(185, 54);
            this.btnEnterPlainText.TabIndex = 0;
            this.btnEnterPlainText.Text = "Зашифровать";
            this.btnEnterPlainText.UseVisualStyleBackColor = true;
            // 
            // txtPlainText
            // 
            this.txtPlainText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPlainText.Location = new System.Drawing.Point(28, 81);
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
            this.lblEnterPlaintText.Location = new System.Drawing.Point(22, 28);
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
            this.rdbVizhiner.Location = new System.Drawing.Point(737, 100);
            this.rdbVizhiner.Name = "rdbVizhiner";
            this.rdbVizhiner.Size = new System.Drawing.Size(201, 30);
            this.rdbVizhiner.TabIndex = 6;
            this.rdbVizhiner.Text = "Шифр Вижинера";
            this.rdbVizhiner.UseVisualStyleBackColor = true;
            // 
            // txtKey
            // 
            this.txtKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtKey.Location = new System.Drawing.Point(28, 282);
            this.txtKey.Multiline = true;
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(515, 131);
            this.txtKey.TabIndex = 7;
            // 
            // lblEnterKey
            // 
            this.lblEnterKey.AutoSize = true;
            this.lblEnterKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEnterKey.Location = new System.Drawing.Point(22, 236);
            this.lblEnterKey.Name = "lblEnterKey";
            this.lblEnterKey.Size = new System.Drawing.Size(189, 31);
            this.lblEnterKey.TabIndex = 8;
            this.lblEnterKey.Text = "Введите ключ";
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOpenFile.Location = new System.Drawing.Point(28, 574);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(316, 44);
            this.btnOpenFile.TabIndex = 9;
            this.btnOpenFile.Text = "Открыть файл";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSaveFile.Location = new System.Drawing.Point(834, 574);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(348, 44);
            this.btnSaveFile.TabIndex = 10;
            this.btnSaveFile.Text = "Сохранить результаты в файл";
            this.btnSaveFile.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 652);
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
    }
}

