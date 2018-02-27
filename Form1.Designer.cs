namespace TP_lab2_square
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cb_1 = new System.Windows.Forms.CheckBox();
            this.cb_2 = new System.Windows.Forms.CheckBox();
            this.cb_3 = new System.Windows.Forms.CheckBox();
            this.tb_A = new System.Windows.Forms.TextBox();
            this.tb_B = new System.Windows.Forms.TextBox();
            this.tb_C = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.l_equation = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bClose = new System.Windows.Forms.Button();
            this.bClear = new System.Windows.Forms.Button();
            this.b_decision = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.l_D = new System.Windows.Forms.Label();
            this.l_X2 = new System.Windows.Forms.Label();
            this.l_X1 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.l_Error = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_1
            // 
            this.cb_1.AutoSize = true;
            this.cb_1.Location = new System.Drawing.Point(6, 36);
            this.cb_1.Name = "cb_1";
            this.cb_1.Size = new System.Drawing.Size(78, 19);
            this.cb_1.TabIndex = 0;
            this.cb_1.Text = "Способ 1";
            this.cb_1.UseVisualStyleBackColor = true;
            // 
            // cb_2
            // 
            this.cb_2.AutoSize = true;
            this.cb_2.Location = new System.Drawing.Point(6, 91);
            this.cb_2.Name = "cb_2";
            this.cb_2.Size = new System.Drawing.Size(78, 19);
            this.cb_2.TabIndex = 1;
            this.cb_2.Text = "Способ 2";
            this.cb_2.UseVisualStyleBackColor = true;
            // 
            // cb_3
            // 
            this.cb_3.AutoSize = true;
            this.cb_3.Location = new System.Drawing.Point(6, 143);
            this.cb_3.Name = "cb_3";
            this.cb_3.Size = new System.Drawing.Size(78, 19);
            this.cb_3.TabIndex = 2;
            this.cb_3.Text = "Способ 3";
            this.cb_3.UseVisualStyleBackColor = true;
            // 
            // tb_A
            // 
            this.tb_A.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_A.Location = new System.Drawing.Point(43, 36);
            this.tb_A.Multiline = true;
            this.tb_A.Name = "tb_A";
            this.tb_A.Size = new System.Drawing.Size(54, 31);
            this.tb_A.TabIndex = 3;
            this.tb_A.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_A_KeyPress);
            // 
            // tb_B
            // 
            this.tb_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_B.Location = new System.Drawing.Point(43, 83);
            this.tb_B.Multiline = true;
            this.tb_B.Name = "tb_B";
            this.tb_B.Size = new System.Drawing.Size(54, 29);
            this.tb_B.TabIndex = 4;
            // 
            // tb_C
            // 
            this.tb_C.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_C.Location = new System.Drawing.Point(43, 133);
            this.tb_C.Multiline = true;
            this.tb_C.Name = "tb_C";
            this.tb_C.Size = new System.Drawing.Size(54, 29);
            this.tb_C.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "a = ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "b = ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "c = ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.l_equation);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(22, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(528, 85);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Уравнение";
            // 
            // l_equation
            // 
            this.l_equation.AutoSize = true;
            this.l_equation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_equation.Location = new System.Drawing.Point(38, 36);
            this.l_equation.Name = "l_equation";
            this.l_equation.Size = new System.Drawing.Size(0, 25);
            this.l_equation.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_C);
            this.groupBox2.Controls.Add(this.tb_A);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tb_B);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(22, 115);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(157, 207);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Входные данные";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bClose);
            this.groupBox3.Controls.Add(this.bClear);
            this.groupBox3.Controls.Add(this.b_decision);
            this.groupBox3.Controls.Add(this.cb_3);
            this.groupBox3.Controls.Add(this.cb_1);
            this.groupBox3.Controls.Add(this.cb_2);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(185, 115);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(365, 207);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Панель упровления";
            // 
            // bClose
            // 
            this.bClose.BackColor = System.Drawing.Color.Red;
            this.bClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bClose.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bClose.Location = new System.Drawing.Point(171, 128);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(137, 43);
            this.bClose.TabIndex = 5;
            this.bClose.Text = "Выйти";
            this.bClose.UseVisualStyleBackColor = false;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // bClear
            // 
            this.bClear.BackColor = System.Drawing.Color.Aqua;
            this.bClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bClear.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bClear.Location = new System.Drawing.Point(171, 79);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(137, 43);
            this.bClear.TabIndex = 4;
            this.bClear.Text = "Очистить поля";
            this.bClear.UseVisualStyleBackColor = false;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // b_decision
            // 
            this.b_decision.BackColor = System.Drawing.Color.Lime;
            this.b_decision.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.b_decision.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_decision.Location = new System.Drawing.Point(171, 30);
            this.b_decision.Name = "b_decision";
            this.b_decision.Size = new System.Drawing.Size(137, 43);
            this.b_decision.TabIndex = 3;
            this.b_decision.Text = "Решить";
            this.b_decision.UseVisualStyleBackColor = false;
            this.b_decision.Click += new System.EventHandler(this.b_decision_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.l_D);
            this.groupBox4.Controls.Add(this.l_X2);
            this.groupBox4.Controls.Add(this.l_X1);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.Location = new System.Drawing.Point(567, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(301, 238);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Решение";
            // 
            // l_D
            // 
            this.l_D.AutoSize = true;
            this.l_D.Location = new System.Drawing.Point(16, 43);
            this.l_D.Name = "l_D";
            this.l_D.Size = new System.Drawing.Size(0, 18);
            this.l_D.TabIndex = 2;
            // 
            // l_X2
            // 
            this.l_X2.AutoSize = true;
            this.l_X2.Location = new System.Drawing.Point(16, 189);
            this.l_X2.Name = "l_X2";
            this.l_X2.Size = new System.Drawing.Size(0, 18);
            this.l_X2.TabIndex = 1;
            // 
            // l_X1
            // 
            this.l_X1.AutoSize = true;
            this.l_X1.Location = new System.Drawing.Point(16, 122);
            this.l_X1.Name = "l_X1";
            this.l_X1.Size = new System.Drawing.Size(0, 18);
            this.l_X1.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.l_Error);
            this.groupBox5.Location = new System.Drawing.Point(567, 256);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(301, 64);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Ошибки";
            // 
            // l_Error
            // 
            this.l_Error.AutoSize = true;
            this.l_Error.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_Error.ForeColor = System.Drawing.Color.Red;
            this.l_Error.Location = new System.Drawing.Point(6, 30);
            this.l_Error.Name = "l_Error";
            this.l_Error.Size = new System.Drawing.Size(0, 15);
            this.l_Error.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 334);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Решение квадратных уравнений";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox cb_1;
        private System.Windows.Forms.CheckBox cb_2;
        private System.Windows.Forms.CheckBox cb_3;
        private System.Windows.Forms.TextBox tb_A;
        private System.Windows.Forms.TextBox tb_B;
        private System.Windows.Forms.TextBox tb_C;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.Button b_decision;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label l_Error;
        private System.Windows.Forms.Label l_equation;
        private System.Windows.Forms.Label l_X2;
        private System.Windows.Forms.Label l_X1;
        private System.Windows.Forms.Label l_D;
    }
}

