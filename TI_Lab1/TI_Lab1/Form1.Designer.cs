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
            this.lblTest = new System.Windows.Forms.Label();
            this.rdbTest1 = new System.Windows.Forms.RadioButton();
            this.rdbTest2 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnEnterPlainText
            // 
            this.btnEnterPlainText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEnterPlainText.Location = new System.Drawing.Point(289, 98);
            this.btnEnterPlainText.Name = "btnEnterPlainText";
            this.btnEnterPlainText.Size = new System.Drawing.Size(125, 38);
            this.btnEnterPlainText.TabIndex = 0;
            this.btnEnterPlainText.Text = "Enter";
            this.btnEnterPlainText.UseVisualStyleBackColor = true;
            this.btnEnterPlainText.Click += new System.EventHandler(this.btnEnterPlainText_Click);
            // 
            // txtPlainText
            // 
            this.txtPlainText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPlainText.Location = new System.Drawing.Point(30, 98);
            this.txtPlainText.Name = "txtPlainText";
            this.txtPlainText.Size = new System.Drawing.Size(233, 38);
            this.txtPlainText.TabIndex = 1;
            this.txtPlainText.TextChanged += new System.EventHandler(this.txtPlainText_TextChanged);
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTest.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTest.Location = new System.Drawing.Point(547, 117);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(65, 26);
            this.lblTest.TabIndex = 2;
            this.lblTest.Text = "Label";
            // 
            // rdbTest1
            // 
            this.rdbTest1.AutoSize = true;
            this.rdbTest1.Location = new System.Drawing.Point(245, 272);
            this.rdbTest1.Name = "rdbTest1";
            this.rdbTest1.Size = new System.Drawing.Size(42, 17);
            this.rdbTest1.TabIndex = 3;
            this.rdbTest1.TabStop = true;
            this.rdbTest1.Text = "Lox";
            this.rdbTest1.UseVisualStyleBackColor = true;
            // 
            // rdbTest2
            // 
            this.rdbTest2.AutoSize = true;
            this.rdbTest2.Location = new System.Drawing.Point(245, 295);
            this.rdbTest2.Name = "rdbTest2";
            this.rdbTest2.Size = new System.Drawing.Size(49, 17);
            this.rdbTest2.TabIndex = 4;
            this.rdbTest2.TabStop = true;
            this.rdbTest2.Text = "Pidor";
            this.rdbTest2.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.rdbTest2);
            this.Controls.Add(this.rdbTest1);
            this.Controls.Add(this.lblTest);
            this.Controls.Add(this.txtPlainText);
            this.Controls.Add(this.btnEnterPlainText);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnterPlainText;
        private System.Windows.Forms.TextBox txtPlainText;
        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.RadioButton rdbTest1;
        private System.Windows.Forms.RadioButton rdbTest2;
    }
}

