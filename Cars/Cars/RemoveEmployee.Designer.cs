
namespace Cars
{
    partial class RemoveEmployee
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
            this.employeesCB = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // employeesCB
            // 
            this.employeesCB.FormattingEnabled = true;
            this.employeesCB.Location = new System.Drawing.Point(10, 8);
            this.employeesCB.Name = "employeesCB";
            this.employeesCB.Size = new System.Drawing.Size(474, 24);
            this.employeesCB.TabIndex = 0;
            this.employeesCB.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Tomato;
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(193, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Удалить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RemoveEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 94);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.employeesCB);
            this.Name = "RemoveEmployee";
            this.Text = "RemoveEmployee";
            this.Load += new System.EventHandler(this.RemoveEmployee_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox employeesCB;
        private System.Windows.Forms.Button button1;
    }
}