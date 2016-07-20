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
            this.planDisplaySplitter = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.planOutline = new System.Windows.Forms.Label();
            this.newItemInput = new Ecclesion.OHP.PlaceholderTextbox();
            this.planItemsLabel = new System.Windows.Forms.Label();
            this.planItemsList = new System.Windows.Forms.ListBox();
            this.displayOffSwitch = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.displayOnSwitch = new System.Windows.Forms.RadioButton();
            this.projectionOnLight = new System.Windows.Forms.Label();
            this.actionMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.planDisplaySplitter)).BeginInit();
            this.planDisplaySplitter.Panel1.SuspendLayout();
            this.planDisplaySplitter.Panel2.SuspendLayout();
            this.planDisplaySplitter.SuspendLayout();
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
            // planDisplaySplitter
            // 
            this.planDisplaySplitter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.planDisplaySplitter.Location = new System.Drawing.Point(12, 28);
            this.planDisplaySplitter.Name = "planDisplaySplitter";
            // 
            // planDisplaySplitter.Panel1
            // 
            this.planDisplaySplitter.Panel1.Controls.Add(this.label2);
            this.planDisplaySplitter.Panel1.Controls.Add(this.planOutline);
            this.planDisplaySplitter.Panel1.Controls.Add(this.newItemInput);
            this.planDisplaySplitter.Panel1.Controls.Add(this.planItemsLabel);
            this.planDisplaySplitter.Panel1.Controls.Add(this.planItemsList);
            // 
            // planDisplaySplitter.Panel2
            // 
            this.planDisplaySplitter.Panel2.Controls.Add(this.displayOffSwitch);
            this.planDisplaySplitter.Panel2.Controls.Add(this.label1);
            this.planDisplaySplitter.Panel2.Controls.Add(this.displayOnSwitch);
            this.planDisplaySplitter.Panel2.Controls.Add(this.projectionOnLight);
            this.planDisplaySplitter.Size = new System.Drawing.Size(760, 521);
            this.planDisplaySplitter.SplitterDistance = 280;
            this.planDisplaySplitter.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 466);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Search for a song to add:";
            // 
            // planOutline
            // 
            this.planOutline.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.planOutline.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.planOutline.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.planOutline.Location = new System.Drawing.Point(0, 0);
            this.planOutline.Name = "planOutline";
            this.planOutline.Padding = new System.Windows.Forms.Padding(4);
            this.planOutline.Size = new System.Drawing.Size(277, 31);
            this.planOutline.TabIndex = 10;
            this.planOutline.Text = "Plan Outline";
            // 
            // newItemInput
            // 
            this.newItemInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newItemInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newItemInput.ForeColor = System.Drawing.SystemColors.GrayText;
            this.newItemInput.Location = new System.Drawing.Point(0, 489);
            this.newItemInput.Name = "newItemInput";
            this.newItemInput.Placeholder = "Start typing a song name...";
            this.newItemInput.Size = new System.Drawing.Size(277, 29);
            this.newItemInput.TabIndex = 8;
            this.newItemInput.Text = "Start typing a song name...";
            this.newItemInput.TextChanged += new System.EventHandler(this.newItemInput_TextChanged);
            // 
            // planItemsLabel
            // 
            this.planItemsLabel.AutoSize = true;
            this.planItemsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.planItemsLabel.Location = new System.Drawing.Point(0, 51);
            this.planItemsLabel.Margin = new System.Windows.Forms.Padding(0);
            this.planItemsLabel.Name = "planItemsLabel";
            this.planItemsLabel.Size = new System.Drawing.Size(99, 20);
            this.planItemsLabel.TabIndex = 7;
            this.planItemsLabel.Text = "Service plan:";
            // 
            // planItemsList
            // 
            this.planItemsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.planItemsList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.planItemsList.FormattingEnabled = true;
            this.planItemsList.ItemHeight = 21;
            this.planItemsList.Location = new System.Drawing.Point(0, 74);
            this.planItemsList.Name = "planItemsList";
            this.planItemsList.Size = new System.Drawing.Size(277, 382);
            this.planItemsList.TabIndex = 6;
            this.planItemsList.SelectedIndexChanged += new System.EventHandler(this.planItemsList_SelectedIndexChanged);
            // 
            // displayOffSwitch
            // 
            this.displayOffSwitch.Appearance = System.Windows.Forms.Appearance.Button;
            this.displayOffSwitch.Checked = true;
            this.displayOffSwitch.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayOffSwitch.Location = new System.Drawing.Point(133, 0);
            this.displayOffSwitch.Name = "displayOffSwitch";
            this.displayOffSwitch.Size = new System.Drawing.Size(48, 31);
            this.displayOffSwitch.TabIndex = 12;
            this.displayOffSwitch.TabStop = true;
            this.displayOffSwitch.Text = "Off";
            this.displayOffSwitch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.displayOffSwitch.UseVisualStyleBackColor = true;
            this.displayOffSwitch.CheckedChanged += new System.EventHandler(this.displayOffSwitch_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Projection:";
            // 
            // displayOnSwitch
            // 
            this.displayOnSwitch.Appearance = System.Windows.Forms.Appearance.Button;
            this.displayOnSwitch.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayOnSwitch.Location = new System.Drawing.Point(79, 0);
            this.displayOnSwitch.Name = "displayOnSwitch";
            this.displayOnSwitch.Size = new System.Drawing.Size(48, 31);
            this.displayOnSwitch.TabIndex = 10;
            this.displayOnSwitch.Text = "On";
            this.displayOnSwitch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.displayOnSwitch.UseVisualStyleBackColor = true;
            this.displayOnSwitch.CheckedChanged += new System.EventHandler(this.displayOnSwitch_CheckedChanged);
            // 
            // projectionOnLight
            // 
            this.projectionOnLight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(225)))), ((int)(((byte)(15)))));
            this.projectionOnLight.Location = new System.Drawing.Point(76, 0);
            this.projectionOnLight.Name = "projectionOnLight";
            this.projectionOnLight.Size = new System.Drawing.Size(55, 34);
            this.projectionOnLight.TabIndex = 13;
            this.projectionOnLight.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.planDisplaySplitter);
            this.Controls.Add(this.actionMenu);
            this.Name = "MainForm";
            this.Text = "OHP";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.actionMenu.ResumeLayout(false);
            this.actionMenu.PerformLayout();
            this.planDisplaySplitter.Panel1.ResumeLayout(false);
            this.planDisplaySplitter.Panel1.PerformLayout();
            this.planDisplaySplitter.Panel2.ResumeLayout(false);
            this.planDisplaySplitter.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.planDisplaySplitter)).EndInit();
            this.planDisplaySplitter.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip actionMenu;
        private System.Windows.Forms.ToolStripButton createItemButton;
        private System.Windows.Forms.ToolStripButton newPlanButton;
        private System.Windows.Forms.SplitContainer planDisplaySplitter;
        private PlaceholderTextbox newItemInput;
        private System.Windows.Forms.Label planItemsLabel;
        private System.Windows.Forms.ListBox planItemsList;
        private System.Windows.Forms.Label planOutline;
        private System.Windows.Forms.RadioButton displayOffSwitch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton displayOnSwitch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label projectionOnLight;
    }
}

