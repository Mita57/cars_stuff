
namespace Cars
{
    partial class GetServicesByEmployee
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
            this.employeesCB = new System.Windows.Forms.ComboBox();
            this.result = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Сотрудник";
            // 
            // employeesCB
            // 
            this.employeesCB.FormattingEnabled = true;
            this.employeesCB.Location = new System.Drawing.Point(96, 20);
            this.employeesCB.Name = "employeesCB";
            this.employeesCB.Size = new System.Drawing.Size(542, 24);
            this.employeesCB.TabIndex = 1;
            this.employeesCB.SelectedIndexChanged += new System.EventHandler(this.employeesCB_SelectedIndexChanged);
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(6, 54);
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.Size = new System.Drawing.Size(657, 288);
            this.result.TabIndex = 2;
            this.result.Text = "";
            // 
            // GetServicesByEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 354);
            this.Controls.Add(this.result);
            this.Controls.Add(this.employeesCB);
            this.Controls.Add(this.label1);
            this.Name = "GetServicesByEmployee";
            this.Text = "Узнать ремонты по сотруднику";
            this.Load += new System.EventHandler(this.GetServicesByEmployee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox employeesCB;
        private System.Windows.Forms.RichTextBox result;
    }
}