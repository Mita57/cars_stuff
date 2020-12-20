
namespace Cars
{
    partial class AddOwnerInfo
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
            this.numberField = new System.Windows.Forms.TextBox();
            this.surnameField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nameField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.parentalField = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.adressField = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Гос номер";
            // 
            // numberField
            // 
            this.numberField.Location = new System.Drawing.Point(94, 12);
            this.numberField.Name = "numberField";
            this.numberField.Size = new System.Drawing.Size(243, 22);
            this.numberField.TabIndex = 1;
            this.numberField.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // surnameField
            // 
            this.surnameField.Location = new System.Drawing.Point(94, 47);
            this.surnameField.Name = "surnameField";
            this.surnameField.Size = new System.Drawing.Size(243, 22);
            this.surnameField.TabIndex = 3;
            this.surnameField.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Фамилия";
            // 
            // nameField
            // 
            this.nameField.Location = new System.Drawing.Point(94, 85);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(243, 22);
            this.nameField.TabIndex = 5;
            this.nameField.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Имя";
            // 
            // parentalField
            // 
            this.parentalField.Location = new System.Drawing.Point(94, 122);
            this.parentalField.Name = "parentalField";
            this.parentalField.Size = new System.Drawing.Size(243, 22);
            this.parentalField.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Отчество";
            // 
            // adressField
            // 
            this.adressField.Location = new System.Drawing.Point(94, 162);
            this.adressField.Name = "adressField";
            this.adressField.Size = new System.Drawing.Size(243, 22);
            this.adressField.TabIndex = 9;
            this.adressField.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Адрес";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(159, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddOwnerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 250);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.adressField);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.parentalField);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nameField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.surnameField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numberField);
            this.Controls.Add(this.label1);
            this.Name = "AddOwnerInfo";
            this.Text = "Добавить инфу о владельце автомобиля";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numberField;
        private System.Windows.Forms.TextBox surnameField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox parentalField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox adressField;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}