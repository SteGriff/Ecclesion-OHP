namespace Ecclesion.OHP.Usercontrols
{
    partial class StyleEditor
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
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.fontInfoLabel = new System.Windows.Forms.Label();
            this.editFontButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fontInfoLabel
            // 
            this.fontInfoLabel.AutoSize = true;
            this.fontInfoLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fontInfoLabel.Location = new System.Drawing.Point(3, 3);
            this.fontInfoLabel.Name = "fontInfoLabel";
            this.fontInfoLabel.Size = new System.Drawing.Size(111, 21);
            this.fontInfoLabel.TabIndex = 0;
            this.fontInfoLabel.Text = "Arial, 12pt, etc.";
            // 
            // editFontButton
            // 
            this.editFontButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editFontButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editFontButton.Location = new System.Drawing.Point(313, -1);
            this.editFontButton.Name = "editFontButton";
            this.editFontButton.Size = new System.Drawing.Size(100, 31);
            this.editFontButton.TabIndex = 1;
            this.editFontButton.Text = "Change Font";
            this.editFontButton.UseVisualStyleBackColor = true;
            this.editFontButton.Click += new System.EventHandler(this.editFontButton_Click);
            // 
            // StyleEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.editFontButton);
            this.Controls.Add(this.fontInfoLabel);
            this.Name = "StyleEditor";
            this.Size = new System.Drawing.Size(412, 31);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.Label fontInfoLabel;
        private System.Windows.Forms.Button editFontButton;
    }
}
