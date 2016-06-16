namespace Ecclesion.OHP.Usercontrols
{
    partial class SlideSelection
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.slideTextBox = new System.Windows.Forms.TextBox();
            this.shortcutLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // slideTextBox
            // 
            this.slideTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slideTextBox.Location = new System.Drawing.Point(21, 3);
            this.slideTextBox.Multiline = true;
            this.slideTextBox.Name = "slideTextBox";
            this.slideTextBox.Size = new System.Drawing.Size(276, 80);
            this.slideTextBox.TabIndex = 1;
            this.slideTextBox.Text = "Hello World";
            // 
            // shortcutLabel
            // 
            this.shortcutLabel.AutoSize = true;
            this.shortcutLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shortcutLabel.Location = new System.Drawing.Point(3, 3);
            this.shortcutLabel.Name = "shortcutLabel";
            this.shortcutLabel.Size = new System.Drawing.Size(16, 21);
            this.shortcutLabel.TabIndex = 2;
            this.shortcutLabel.Text = "1";
            // 
            // SlideSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.shortcutLabel);
            this.Controls.Add(this.slideTextBox);
            this.Name = "SlideSelection";
            this.Size = new System.Drawing.Size(300, 86);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox slideTextBox;
        private System.Windows.Forms.Label shortcutLabel;
    }
}
