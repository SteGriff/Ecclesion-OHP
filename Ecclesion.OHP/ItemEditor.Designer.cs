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
            this.itemEditorTabs.SuspendLayout();
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
            this.itemEditorTabs.Size = new System.Drawing.Size(481, 264);
            this.itemEditorTabs.TabIndex = 0;
            // 
            // songTab
            // 
            this.songTab.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songTab.Location = new System.Drawing.Point(4, 29);
            this.songTab.Name = "songTab";
            this.songTab.Padding = new System.Windows.Forms.Padding(3);
            this.songTab.Size = new System.Drawing.Size(473, 231);
            this.songTab.TabIndex = 0;
            this.songTab.Text = "Song";
            this.songTab.UseVisualStyleBackColor = true;
            // 
            // noticesTab
            // 
            this.noticesTab.Location = new System.Drawing.Point(4, 25);
            this.noticesTab.Name = "noticesTab";
            this.noticesTab.Padding = new System.Windows.Forms.Padding(3);
            this.noticesTab.Size = new System.Drawing.Size(473, 235);
            this.noticesTab.TabIndex = 1;
            this.noticesTab.Text = "Notices";
            this.noticesTab.UseVisualStyleBackColor = true;
            // 
            // ItemEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 288);
            this.Controls.Add(this.itemEditorTabs);
            this.Name = "ItemEditor";
            this.Text = "Edit Item";
            this.itemEditorTabs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl itemEditorTabs;
        private System.Windows.Forms.TabPage songTab;
        private System.Windows.Forms.TabPage noticesTab;
    }
}