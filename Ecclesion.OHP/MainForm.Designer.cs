namespace Ecclesion.OHP
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.actionMenu = new System.Windows.Forms.ToolStrip();
            this.newPlanButton = new System.Windows.Forms.ToolStripButton();
            this.createItemButton = new System.Windows.Forms.ToolStripButton();
            this.planOutline = new System.Windows.Forms.Label();
            this.planItemsList = new System.Windows.Forms.ListBox();
            this.planItemsLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.actionMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // actionMenu
            // 
            this.actionMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newPlanButton,
            this.createItemButton});
            this.actionMenu.Location = new System.Drawing.Point(0, 0);
            this.actionMenu.Name = "actionMenu";
            this.actionMenu.Size = new System.Drawing.Size(784, 25);
            this.actionMenu.TabIndex = 0;
            this.actionMenu.Text = "actionMenu";
            // 
            // newPlanButton
            // 
            this.newPlanButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.newPlanButton.Image = ((System.Drawing.Image)(resources.GetObject("newPlanButton.Image")));
            this.newPlanButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newPlanButton.Name = "newPlanButton";
            this.newPlanButton.Size = new System.Drawing.Size(61, 22);
            this.newPlanButton.Text = "New Plan";
            this.newPlanButton.Click += new System.EventHandler(this.newPlanButton_Click);
            // 
            // createItemButton
            // 
            this.createItemButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.createItemButton.Image = ((System.Drawing.Image)(resources.GetObject("createItemButton.Image")));
            this.createItemButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.createItemButton.Name = "createItemButton";
            this.createItemButton.Size = new System.Drawing.Size(72, 22);
            this.createItemButton.Text = "Create Item";
            this.createItemButton.Click += new System.EventHandler(this.newItemButton_Click);
            // 
            // planOutline
            // 
            this.planOutline.AutoSize = true;
            this.planOutline.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.planOutline.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.planOutline.Location = new System.Drawing.Point(12, 25);
            this.planOutline.Name = "planOutline";
            this.planOutline.Padding = new System.Windows.Forms.Padding(4);
            this.planOutline.Size = new System.Drawing.Size(105, 31);
            this.planOutline.TabIndex = 1;
            this.planOutline.Text = "Plan Outline";
            // 
            // planItemsList
            // 
            this.planItemsList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.planItemsList.FormattingEnabled = true;
            this.planItemsList.ItemHeight = 21;
            this.planItemsList.Location = new System.Drawing.Point(12, 100);
            this.planItemsList.Name = "planItemsList";
            this.planItemsList.Size = new System.Drawing.Size(244, 403);
            this.planItemsList.TabIndex = 2;
            // 
            // planItemsLabel
            // 
            this.planItemsLabel.AutoSize = true;
            this.planItemsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.planItemsLabel.Location = new System.Drawing.Point(12, 77);
            this.planItemsLabel.Name = "planItemsLabel";
            this.planItemsLabel.Size = new System.Drawing.Size(99, 20);
            this.planItemsLabel.TabIndex = 3;
            this.planItemsLabel.Text = "Service plan:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(227, 520);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 29);
            this.button1.TabIndex = 5;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // newItemInput
            // 
            this.newItemInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newItemInput.ForeColor = System.Drawing.SystemColors.GrayText;
            this.newItemInput.Location = new System.Drawing.Point(12, 520);
            this.newItemInput.Name = "newItemInput";
            this.newItemInput.Placeholder = "Start typing a song name...";
            this.newItemInput.Size = new System.Drawing.Size(209, 29);
            this.newItemInput.TabIndex = 4;
            this.newItemInput.Text = "Start typing a song name...";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.newItemInput);
            this.Controls.Add(this.planItemsLabel);
            this.Controls.Add(this.planItemsList);
            this.Controls.Add(this.planOutline);
            this.Controls.Add(this.actionMenu);
            this.Name = "MainForm";
            this.Text = "OHP";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.actionMenu.ResumeLayout(false);
            this.actionMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip actionMenu;
        private System.Windows.Forms.ToolStripButton createItemButton;
        private System.Windows.Forms.ToolStripButton newPlanButton;
        private System.Windows.Forms.Label planOutline;
        private System.Windows.Forms.ListBox planItemsList;
        private System.Windows.Forms.Label planItemsLabel;
        private System.Windows.Forms.Button button1;
        private PlaceholderTextbox newItemInput;
    }
}

