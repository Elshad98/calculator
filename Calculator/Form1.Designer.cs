﻿namespace Calculator
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
            this.b1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.b0 = new System.Windows.Forms.Button();
            this.input = new System.Windows.Forms.Label();
            this.output = new System.Windows.Forms.Label();
            this.bShare = new System.Windows.Forms.Button();
            this.bMultiply = new System.Windows.Forms.Button();
            this.bMinus = new System.Windows.Forms.Button();
            this.bPlus = new System.Windows.Forms.Button();
            this.bEqually = new System.Windows.Forms.Button();
            this.bClear = new System.Windows.Forms.Button();
            this.bRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(121, 194);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(51, 45);
            this.b1.TabIndex = 0;
            this.b1.Text = "1";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(178, 194);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(51, 45);
            this.b2.TabIndex = 1;
            this.b2.Text = "2";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.b2_Click);
            // 
            // b3
            // 
            this.b3.Location = new System.Drawing.Point(235, 194);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(51, 45);
            this.b3.TabIndex = 2;
            this.b3.Text = "3";
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.b3_Click);
            // 
            // b4
            // 
            this.b4.Location = new System.Drawing.Point(121, 245);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(51, 45);
            this.b4.TabIndex = 3;
            this.b4.Text = "4";
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.b4_Click);
            // 
            // b5
            // 
            this.b5.Location = new System.Drawing.Point(178, 245);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(51, 45);
            this.b5.TabIndex = 4;
            this.b5.Text = "5";
            this.b5.UseVisualStyleBackColor = true;
            this.b5.Click += new System.EventHandler(this.b5_Click);
            // 
            // b6
            // 
            this.b6.Location = new System.Drawing.Point(235, 245);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(51, 45);
            this.b6.TabIndex = 5;
            this.b6.Text = "6";
            this.b6.UseVisualStyleBackColor = true;
            this.b6.Click += new System.EventHandler(this.b6_Click);
            // 
            // b9
            // 
            this.b9.Location = new System.Drawing.Point(235, 296);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(51, 45);
            this.b9.TabIndex = 8;
            this.b9.Text = "9";
            this.b9.UseVisualStyleBackColor = true;
            this.b9.Click += new System.EventHandler(this.b9_Click);
            // 
            // b8
            // 
            this.b8.Location = new System.Drawing.Point(178, 296);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(51, 45);
            this.b8.TabIndex = 7;
            this.b8.Text = "8";
            this.b8.UseVisualStyleBackColor = true;
            this.b8.Click += new System.EventHandler(this.b8_Click);
            // 
            // b7
            // 
            this.b7.Location = new System.Drawing.Point(121, 296);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(51, 45);
            this.b7.TabIndex = 6;
            this.b7.Text = "7";
            this.b7.UseVisualStyleBackColor = true;
            this.b7.Click += new System.EventHandler(this.b7_Click);
            // 
            // b0
            // 
            this.b0.Location = new System.Drawing.Point(178, 347);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(51, 45);
            this.b0.TabIndex = 9;
            this.b0.Text = "0";
            this.b0.UseVisualStyleBackColor = true;
            this.b0.Click += new System.EventHandler(this.b0_Click);
            // 
            // input
            // 
            this.input.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.input.Location = new System.Drawing.Point(-2, 119);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(306, 37);
            this.input.TabIndex = 10;
            this.input.Text = "0";
            this.input.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // output
            // 
            this.output.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.output.Location = new System.Drawing.Point(-1, 55);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(305, 37);
            this.output.TabIndex = 11;
            this.output.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bShare
            // 
            this.bShare.Location = new System.Drawing.Point(64, 347);
            this.bShare.Name = "bShare";
            this.bShare.Size = new System.Drawing.Size(51, 45);
            this.bShare.TabIndex = 15;
            this.bShare.Text = "/";
            this.bShare.UseVisualStyleBackColor = true;
            this.bShare.Click += new System.EventHandler(this.bShare_Click);
            // 
            // bMultiply
            // 
            this.bMultiply.Location = new System.Drawing.Point(64, 296);
            this.bMultiply.Name = "bMultiply";
            this.bMultiply.Size = new System.Drawing.Size(51, 45);
            this.bMultiply.TabIndex = 14;
            this.bMultiply.Text = "*";
            this.bMultiply.UseVisualStyleBackColor = true;
            this.bMultiply.Click += new System.EventHandler(this.bMultiply_Click);
            // 
            // bMinus
            // 
            this.bMinus.Location = new System.Drawing.Point(64, 245);
            this.bMinus.Name = "bMinus";
            this.bMinus.Size = new System.Drawing.Size(51, 45);
            this.bMinus.TabIndex = 13;
            this.bMinus.Text = "-";
            this.bMinus.UseVisualStyleBackColor = true;
            this.bMinus.Click += new System.EventHandler(this.bMinus_Click);
            // 
            // bPlus
            // 
            this.bPlus.Location = new System.Drawing.Point(64, 194);
            this.bPlus.Name = "bPlus";
            this.bPlus.Size = new System.Drawing.Size(51, 45);
            this.bPlus.TabIndex = 12;
            this.bPlus.Text = "+";
            this.bPlus.UseVisualStyleBackColor = true;
            this.bPlus.Click += new System.EventHandler(this.bPlus_Click);
            // 
            // bEqually
            // 
            this.bEqually.Location = new System.Drawing.Point(235, 347);
            this.bEqually.Name = "bEqually";
            this.bEqually.Size = new System.Drawing.Size(51, 45);
            this.bEqually.TabIndex = 16;
            this.bEqually.Text = "=";
            this.bEqually.UseVisualStyleBackColor = true;
            this.bEqually.Click += new System.EventHandler(this.bEqually_Click);
            // 
            // bClear
            // 
            this.bClear.Location = new System.Drawing.Point(3, 245);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(51, 45);
            this.bClear.TabIndex = 18;
            this.bClear.Text = "C";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // bRemove
            // 
            this.bRemove.Location = new System.Drawing.Point(3, 194);
            this.bRemove.Name = "bRemove";
            this.bRemove.Size = new System.Drawing.Size(51, 45);
            this.bRemove.TabIndex = 17;
            this.bRemove.Text = "<-";
            this.bRemove.UseVisualStyleBackColor = true;
            this.bRemove.Click += new System.EventHandler(this.bRemove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 415);
            this.Controls.Add(this.bClear);
            this.Controls.Add(this.bRemove);
            this.Controls.Add(this.bEqually);
            this.Controls.Add(this.bShare);
            this.Controls.Add(this.bMultiply);
            this.Controls.Add(this.bMinus);
            this.Controls.Add(this.bPlus);
            this.Controls.Add(this.output);
            this.Controls.Add(this.input);
            this.Controls.Add(this.b0);
            this.Controls.Add(this.b9);
            this.Controls.Add(this.b8);
            this.Controls.Add(this.b7);
            this.Controls.Add(this.b6);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Button b0;
        private System.Windows.Forms.Label input;
        private System.Windows.Forms.Label output;
        private System.Windows.Forms.Button bShare;
        private System.Windows.Forms.Button bMultiply;
        private System.Windows.Forms.Button bMinus;
        private System.Windows.Forms.Button bPlus;
        private System.Windows.Forms.Button bEqually;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.Button bRemove;
    }
}

