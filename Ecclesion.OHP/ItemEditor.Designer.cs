namespace Ecclesion.OHP
{
    partial class ItemEditor
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
            this.itemEditorTabs = new System.Windows.Forms.TabControl();
            this.songTab = new System.Windows.Forms.TabPage();
            this.noticesTab = new System.Windows.Forms.TabPage();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.songTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.itemEditorTabs.SuspendLayout();
            this.songTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // itemEditorTabs
            // 
            this.itemEditorTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemEditorTabs.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.itemEditorTabs.Controls.Add(this.songTab);
            this.itemEditorTabs.Controls.Add(this.noticesTab);
            this.itemEditorTabs.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemEditorTabs.Location = new System.Drawing.Point(12, 12);
            this.itemEditorTabs.Name = "itemEditorTabs";
            this.itemEditorTabs.SelectedIndex = 0;
            this.itemEditorTabs.Size = new System.Drawing.Size(492, 433);
            this.itemEditorTabs.TabIndex = 0;
            // 
            // songTab
            // 
            this.songTab.Controls.Add(this.label1);
            this.songTab.Controls.Add(this.songTextBox);
            this.songTab.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songTab.Location = new System.Drawing.Point(4, 29);
            this.songTab.Name = "songTab";
            this.songTab.Padding = new System.Windows.Forms.Padding(3);
            this.songTab.Size = new System.Drawing.Size(484, 400);
            this.songTab.TabIndex = 0;
            this.songTab.Text = "Song";
            this.songTab.UseVisualStyleBackColor = true;
            // 
            // noticesTab
            // 
            this.noticesTab.Location = new System.Drawing.Point(4, 29);
            this.noticesTab.Name = "noticesTab";
            this.noticesTab.Padding = new System.Windows.Forms.Padding(3);
            this.noticesTab.Size = new System.Drawing.Size(473, 231);
            this.noticesTab.TabIndex = 1;
            this.noticesTab.Text = "Notices";
            this.noticesTab.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.Location = new System.Drawing.Point(320, 451);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(180, 29);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "Create and Add to plan";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Location = new System.Drawing.Point(214, 451);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 29);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // songTextBox
            // 
            this.songTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songTextBox.Location = new System.Drawing.Point(6, 27);
            this.songTextBox.Multiline = true;
            this.songTextBox.Name = "songTextBox";
            this.songTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.songTextBox.Size = new System.Drawing.Size(472, 367);
            this.songTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Song Lyrics:";
            // 
            // ItemEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 492);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.itemEditorTabs);
            this.Name = "ItemEditor";
            this.Text = "Edit Item";
            this.itemEditorTabs.ResumeLayout(false);
            this.songTab.ResumeLayout(false);
            this.songTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl itemEditorTabs;
        private System.Windows.Forms.TabPage songTab;
        private System.Windows.Forms.TabPage noticesTab;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.TextBox songTextBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label1;
    }
}