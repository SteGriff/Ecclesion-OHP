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
            this.planDisplaySplitter = new System.Windows.Forms.SplitContainer();
            this.newPlanButton = new System.Windows.Forms.Button();
            this.savePlanButton = new System.Windows.Forms.Button();
            this.loadPlanButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.planOutline = new System.Windows.Forms.Label();
            this.planItemsLabel = new System.Windows.Forms.Label();
            this.planItemsList = new System.Windows.Forms.ListBox();
            this.displayOffSwitch = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.displayOnSwitch = new System.Windows.Forms.RadioButton();
            this.projectionOnLight = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.plansToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newItemInput = new Ecclesion.OHP.PlaceholderTextbox();
            this.styleEditor = new Ecclesion.OHP.Usercontrols.StyleEditor();
            ((System.ComponentModel.ISupportInitialize)(this.planDisplaySplitter)).BeginInit();
            this.planDisplaySplitter.Panel1.SuspendLayout();
            this.planDisplaySplitter.Panel2.SuspendLayout();
            this.planDisplaySplitter.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
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
            this.planDisplaySplitter.Panel1.Controls.Add(this.newPlanButton);
            this.planDisplaySplitter.Panel1.Controls.Add(this.savePlanButton);
            this.planDisplaySplitter.Panel1.Controls.Add(this.loadPlanButton);
            this.planDisplaySplitter.Panel1.Controls.Add(this.clearButton);
            this.planDisplaySplitter.Panel1.Controls.Add(this.label2);
            this.planDisplaySplitter.Panel1.Controls.Add(this.planOutline);
            this.planDisplaySplitter.Panel1.Controls.Add(this.newItemInput);
            this.planDisplaySplitter.Panel1.Controls.Add(this.planItemsLabel);
            this.planDisplaySplitter.Panel1.Controls.Add(this.planItemsList);
            // 
            // planDisplaySplitter.Panel2
            // 
            this.planDisplaySplitter.Panel2.Controls.Add(this.styleEditor);
            this.planDisplaySplitter.Panel2.Controls.Add(this.displayOffSwitch);
            this.planDisplaySplitter.Panel2.Controls.Add(this.label1);
            this.planDisplaySplitter.Panel2.Controls.Add(this.displayOnSwitch);
            this.planDisplaySplitter.Panel2.Controls.Add(this.projectionOnLight);
            this.planDisplaySplitter.Size = new System.Drawing.Size(760, 521);
            this.planDisplaySplitter.SplitterDistance = 370;
            this.planDisplaySplitter.TabIndex = 6;
            // 
            // newPlanButton
            // 
            this.newPlanButton.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.newPlanButton.Location = new System.Drawing.Point(0, 34);
            this.newPlanButton.Name = "newPlanButton";
            this.newPlanButton.Size = new System.Drawing.Size(115, 31);
            this.newPlanButton.TabIndex = 15;
            this.newPlanButton.Text = "Start new plan";
            this.newPlanButton.UseVisualStyleBackColor = true;
            this.newPlanButton.Click += new System.EventHandler(this.newPlanButton_Click_1);
            // 
            // savePlanButton
            // 
            this.savePlanButton.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.savePlanButton.Location = new System.Drawing.Point(131, 34);
            this.savePlanButton.Name = "savePlanButton";
            this.savePlanButton.Size = new System.Drawing.Size(115, 31);
            this.savePlanButton.TabIndex = 14;
            this.savePlanButton.Text = "Save this plan";
            this.savePlanButton.UseVisualStyleBackColor = true;
            this.savePlanButton.Click += new System.EventHandler(this.savePlanButton_Click);
            // 
            // loadPlanButton
            // 
            this.loadPlanButton.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.loadPlanButton.Location = new System.Drawing.Point(252, 34);
            this.loadPlanButton.Name = "loadPlanButton";
            this.loadPlanButton.Size = new System.Drawing.Size(115, 31);
            this.loadPlanButton.TabIndex = 13;
            this.loadPlanButton.Text = "Open a plan";
            this.loadPlanButton.UseVisualStyleBackColor = true;
            this.loadPlanButton.Click += new System.EventHandler(this.loadPlanButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clearButton.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.clearButton.Location = new System.Drawing.Point(313, 488);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(55, 31);
            this.clearButton.TabIndex = 12;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(0, 465);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 21);
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
            this.planOutline.Size = new System.Drawing.Size(367, 31);
            this.planOutline.TabIndex = 10;
            this.planOutline.Text = "Plan Outline";
            // 
            // planItemsLabel
            // 
            this.planItemsLabel.AutoSize = true;
            this.planItemsLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.planItemsLabel.Location = new System.Drawing.Point(0, 71);
            this.planItemsLabel.Margin = new System.Windows.Forms.Padding(0);
            this.planItemsLabel.Name = "planItemsLabel";
            this.planItemsLabel.Size = new System.Drawing.Size(97, 21);
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
            this.planItemsList.Location = new System.Drawing.Point(0, 95);
            this.planItemsList.Name = "planItemsList";
            this.planItemsList.Size = new System.Drawing.Size(367, 361);
            this.planItemsList.TabIndex = 6;
            this.planItemsList.SelectedIndexChanged += new System.EventHandler(this.planItemsList_SelectedIndexChanged);
            // 
            // displayOffSwitch
            // 
            this.displayOffSwitch.Appearance = System.Windows.Forms.Appearance.Button;
            this.displayOffSwitch.Checked = true;
            this.displayOffSwitch.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayOffSwitch.Location = new System.Drawing.Point(146, 34);
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
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(3, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "Projection:";
            // 
            // displayOnSwitch
            // 
            this.displayOnSwitch.Appearance = System.Windows.Forms.Appearance.Button;
            this.displayOnSwitch.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayOnSwitch.Location = new System.Drawing.Point(92, 34);
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
            this.projectionOnLight.Location = new System.Drawing.Point(89, 31);
            this.projectionOnLight.Name = "projectionOnLight";
            this.projectionOnLight.Size = new System.Drawing.Size(55, 37);
            this.projectionOnLight.TabIndex = 13;
            this.projectionOnLight.Visible = false;
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plansToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(784, 25);
            this.menuStrip.TabIndex = 7;
            this.menuStrip.Text = "menuStrip1";
            // 
            // plansToolStripMenuItem
            // 
            this.plansToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.plansToolStripMenuItem.Name = "plansToolStripMenuItem";
            this.plansToolStripMenuItem.Size = new System.Drawing.Size(95, 21);
            this.plansToolStripMenuItem.Text = "Service &Plans";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(152, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(152, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator3,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator4,
            this.selectAllToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(42, 21);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.undoToolStripMenuItem.Text = "&Undo";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.redoToolStripMenuItem.Text = "&Redo";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(149, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem.Image")));
            this.cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cutToolStripMenuItem.Text = "Cu&t";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.copyToolStripMenuItem.Text = "&Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
            this.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pasteToolStripMenuItem.Text = "&Paste";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(149, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.selectAllToolStripMenuItem.Text = "Select &All";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customizeToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(51, 21);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // customizeToolStripMenuItem
            // 
            this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            this.customizeToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.customizeToolStripMenuItem.Text = "&Customize";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(47, 21);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.contentsToolStripMenuItem.Text = "&Contents";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.indexToolStripMenuItem.Text = "&Index";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.searchToolStripMenuItem.Text = "&Search";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(124, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
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
            this.newItemInput.Size = new System.Drawing.Size(312, 29);
            this.newItemInput.TabIndex = 8;
            this.newItemInput.Text = "Start typing a song name...";
            this.newItemInput.TextChanged += new System.EventHandler(this.newItemInput_TextChanged);
            // 
            // styleEditor
            // 
            this.styleEditor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.styleEditor.Location = new System.Drawing.Point(0, 0);
            this.styleEditor.Name = "styleEditor";
            this.styleEditor.Size = new System.Drawing.Size(386, 31);
            this.styleEditor.TabIndex = 14;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.planDisplaySplitter);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "OHP";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.planDisplaySplitter.Panel1.ResumeLayout(false);
            this.planDisplaySplitter.Panel1.PerformLayout();
            this.planDisplaySplitter.Panel2.ResumeLayout(false);
            this.planDisplaySplitter.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.planDisplaySplitter)).EndInit();
            this.planDisplaySplitter.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button newPlanButton;
        private System.Windows.Forms.Button savePlanButton;
        private System.Windows.Forms.Button loadPlanButton;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem plansToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private Usercontrols.StyleEditor styleEditor;
    }
}

