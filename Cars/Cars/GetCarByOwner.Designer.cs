﻿
namespace Cars
{
    partial class GetCarByOwner
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
            this.label1 = new System.Windows.Forms.Label();
            this.surnameField = new System.Windows.Forms.TextBox();
            this.nameField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.parentalField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия";
            // 
            // surnameField
            // 
            this.surnameField.Location = new System.Drawing.Point(102, 32);
            this.surnameField.Name = "surnameField";
            this.surnameField.Size = new System.Drawing.Size(265, 22);
            this.surnameField.TabIndex = 1;
            this.surnameField.TextChanged += new System.EventHandler(this.surnameField_TextChanged);
            // 
            // nameField
            // 
            this.nameField.Location = new System.Drawing.Point(102, 74);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(265, 22);
            this.nameField.TabIndex = 3;
            this.nameField.TextChanged += new System.EventHandler(this.surnameField_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Имя";
            // 
            // parentalField
            // 
            this.parentalField.Location = new System.Drawing.Point(102, 111);
            this.parentalField.Name = "parentalField";
            this.parentalField.Size = new System.Drawing.Size(265, 22);
            this.parentalField.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Отчество";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(175, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Узнать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(15, 176);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(0, 17);
            this.result.TabIndex = 7;
            // 
            // GetCarByOwner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 221);
            this.Controls.Add(this.result);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.parentalField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.surnameField);
            this.Controls.Add(this.label1);
            this.Name = "GetCarByOwner";
            this.Text = "Узнать машину по владельцу";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox surnameField;
        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox parentalField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label result;
    }
}