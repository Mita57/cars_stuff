
namespace Cars
{
    partial class OwnersByMalfunctions
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
            this.malfucntions = new System.Windows.Forms.ComboBox();
            this.result = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Неисправность";
            // 
            // malfucntions
            // 
            this.malfucntions.FormattingEnabled = true;
            this.malfucntions.Location = new System.Drawing.Point(127, 21);
            this.malfucntions.Name = "malfucntions";
            this.malfucntions.Size = new System.Drawing.Size(453, 24);
            this.malfucntions.TabIndex = 1;
            this.malfucntions.SelectedIndexChanged += new System.EventHandler(this.malfucntions_SelectedIndexChanged);
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(13, 50);
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.Size = new System.Drawing.Size(566, 202);
            this.result.TabIndex = 2;
            this.result.Text = "";
            // 
            // OwnersByMalfunctions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 260);
            this.Controls.Add(this.result);
            this.Controls.Add(this.malfucntions);
            this.Controls.Add(this.label1);
            this.Name = "OwnersByMalfunctions";
            this.Text = "Узнать владельцев по неисправности";
            this.Load += new System.EventHandler(this.OwnersByMalfunctions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox malfucntions;
        private System.Windows.Forms.RichTextBox result;
    }
}