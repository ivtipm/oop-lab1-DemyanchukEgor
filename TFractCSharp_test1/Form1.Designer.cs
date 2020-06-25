namespace TFractCSharp_test1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

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
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.buttonResult = new System.Windows.Forms.Button();
            this.tBf1_num = new System.Windows.Forms.TextBox();
            this.tBf1_den = new System.Windows.Forms.TextBox();
            this.comboBoxOperation = new System.Windows.Forms.ComboBox();
            this.tBf2_den = new System.Windows.Forms.TextBox();
            this.tBf2_num = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonToFile = new System.Windows.Forms.Button();
            this.labelf1 = new System.Windows.Forms.Label();
            this.labelf2 = new System.Windows.Forms.Label();
            this.labelOp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(11, 181);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult.Size = new System.Drawing.Size(700, 174);
            this.textBoxResult.TabIndex = 0;
            // 
            // buttonResult
            // 
            this.buttonResult.Location = new System.Drawing.Point(11, 94);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(700, 23);
            this.buttonResult.TabIndex = 1;
            this.buttonResult.Text = "Результат";
            this.buttonResult.UseVisualStyleBackColor = true;
            this.buttonResult.Click += new System.EventHandler(this.buttonResult_Click);
            // 
            // tBf1_num
            // 
            this.tBf1_num.Location = new System.Drawing.Point(11, 32);
            this.tBf1_num.Name = "tBf1_num";
            this.tBf1_num.Size = new System.Drawing.Size(161, 20);
            this.tBf1_num.TabIndex = 2;
            this.tBf1_num.Text = "Числитель";
            this.tBf1_num.Click += new System.EventHandler(this.tBf1_num_Click);
            // 
            // tBf1_den
            // 
            this.tBf1_den.Location = new System.Drawing.Point(11, 68);
            this.tBf1_den.Name = "tBf1_den";
            this.tBf1_den.Size = new System.Drawing.Size(161, 20);
            this.tBf1_den.TabIndex = 3;
            this.tBf1_den.Text = "Знаменатель";
            this.tBf1_den.Click += new System.EventHandler(this.tBf1_den_Click);
            // 
            // comboBoxOperation
            // 
            this.comboBoxOperation.FormattingEnabled = true;
            this.comboBoxOperation.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/",
            "<",
            ">",
            "<=",
            ">=",
            "="});
            this.comboBoxOperation.Location = new System.Drawing.Point(319, 49);
            this.comboBoxOperation.Name = "comboBoxOperation";
            this.comboBoxOperation.Size = new System.Drawing.Size(106, 21);
            this.comboBoxOperation.TabIndex = 5;
            this.comboBoxOperation.Text = "+";
            this.comboBoxOperation.SelectedIndexChanged += new System.EventHandler(this.comboBoxOperation_SelectedIndexChanged);
            // 
            // tBf2_den
            // 
            this.tBf2_den.Location = new System.Drawing.Point(550, 58);
            this.tBf2_den.Name = "tBf2_den";
            this.tBf2_den.Size = new System.Drawing.Size(161, 20);
            this.tBf2_den.TabIndex = 7;
            this.tBf2_den.Text = "Знаменатель";
            this.tBf2_den.Click += new System.EventHandler(this.tBf2_den_Click);
            // 
            // tBf2_num
            // 
            this.tBf2_num.Location = new System.Drawing.Point(550, 32);
            this.tBf2_num.Name = "tBf2_num";
            this.tBf2_num.Size = new System.Drawing.Size(161, 20);
            this.tBf2_num.TabIndex = 6;
            this.tBf2_num.Text = "Числитель";
            this.tBf2_num.Click += new System.EventHandler(this.tBf2_num_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(11, 152);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(700, 23);
            this.buttonClear.TabIndex = 9;
            this.buttonClear.Text = "Очистить поле вывода";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonToFile
            // 
            this.buttonToFile.Location = new System.Drawing.Point(11, 123);
            this.buttonToFile.Name = "buttonToFile";
            this.buttonToFile.Size = new System.Drawing.Size(700, 23);
            this.buttonToFile.TabIndex = 10;
            this.buttonToFile.Text = "Вывести текст из поля вывода в файл";
            this.buttonToFile.UseVisualStyleBackColor = true;
            this.buttonToFile.Click += new System.EventHandler(this.buttonToFile_Click);
            // 
            // labelf1
            // 
            this.labelf1.AutoSize = true;
            this.labelf1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelf1.Location = new System.Drawing.Point(64, 11);
            this.labelf1.Name = "labelf1";
            this.labelf1.Size = new System.Drawing.Size(59, 18);
            this.labelf1.TabIndex = 12;
            this.labelf1.Text = "Дробь 1";
            this.labelf1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelf2
            // 
            this.labelf2.AutoSize = true;
            this.labelf2.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelf2.Location = new System.Drawing.Point(598, 11);
            this.labelf2.Name = "labelf2";
            this.labelf2.Size = new System.Drawing.Size(59, 18);
            this.labelf2.TabIndex = 13;
            this.labelf2.Text = "Дробь 2";
            this.labelf2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelOp
            // 
            this.labelOp.AutoSize = true;
            this.labelOp.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOp.Location = new System.Drawing.Point(329, 19);
            this.labelOp.Name = "labelOp";
            this.labelOp.Size = new System.Drawing.Size(73, 18);
            this.labelOp.TabIndex = 14;
            this.labelOp.Text = "Операция";
            this.labelOp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 368);
            this.Controls.Add(this.labelOp);
            this.Controls.Add(this.labelf2);
            this.Controls.Add(this.labelf1);
            this.Controls.Add(this.buttonToFile);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.tBf2_den);
            this.Controls.Add(this.tBf2_num);
            this.Controls.Add(this.comboBoxOperation);
            this.Controls.Add(this.tBf1_den);
            this.Controls.Add(this.tBf1_num);
            this.Controls.Add(this.buttonResult);
            this.Controls.Add(this.textBoxResult);
            this.Name = "Form1";
            this.Text = "Калькулятор Дробей";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Button buttonResult;
        private System.Windows.Forms.TextBox tBf1_num;
        private System.Windows.Forms.TextBox tBf1_den;
        private System.Windows.Forms.ComboBox comboBoxOperation;
        private System.Windows.Forms.TextBox tBf2_den;
        private System.Windows.Forms.TextBox tBf2_num;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonToFile;
        private System.Windows.Forms.Label labelf1;
        private System.Windows.Forms.Label labelf2;
        private System.Windows.Forms.Label labelOp;
    }
}

