
namespace Cars
{
    partial class ChangeNumber
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
            this.label2 = new System.Windows.Forms.Label();
            this.oldNumber = new System.Windows.Forms.TextBox();
            this.newNumber = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Старый";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Новый";
            // 
            // oldNumber
            // 
            this.oldNumber.Location = new System.Drawing.Point(76, 17);
            this.oldNumber.Name = "oldNumber";
            this.oldNumber.Size = new System.Drawing.Size(237, 22);
            this.oldNumber.TabIndex = 2;
            this.oldNumber.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // newNumber
            // 
            this.newNumber.Location = new System.Drawing.Point(76, 55);
            this.newNumber.Name = "newNumber";
            this.newNumber.Size = new System.Drawing.Size(237, 22);
            this.newNumber.TabIndex = 3;
            this.newNumber.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(114, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 36);
            this.button1.TabIndex = 4;
            this.button1.Text = "Заменить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ChangeNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 142);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.newNumber);
            this.Controls.Add(this.oldNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ChangeNumber";
            this.Text = "Изменить гос номер";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox oldNumber;
        private System.Windows.Forms.TextBox newNumber;
        private System.Windows.Forms.Button button1;
    }
}