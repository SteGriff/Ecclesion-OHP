namespace Ecclesion.OHP.Usercontrols
{
    partial class ItemSuggestionsFrame
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
            this.components = new System.ComponentModel.Container();
            this.addItButton = new System.Windows.Forms.Button();
            this.itemSuggestions = new System.Windows.Forms.ListBox();
            this.suggestionsLabel = new System.Windows.Forms.Label();
            this.suggestionTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // addItButton
            // 
            this.addItButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addItButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addItButton.Location = new System.Drawing.Point(3, 348);
            this.addItButton.Name = "addItButton";
            this.addItButton.Size = new System.Drawing.Size(462, 36);
            this.addItButton.TabIndex = 18;
            this.addItButton.Text = "Add to plan";
            this.addItButton.UseVisualStyleBackColor = true;
            this.addItButton.Click += new System.EventHandler(this.addItButton_Click);
            // 
            // itemSuggestions
            // 
            this.itemSuggestions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemSuggestions.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemSuggestions.FormattingEnabled = true;
            this.itemSuggestions.ItemHeight = 21;
            this.itemSuggestions.Location = new System.Drawing.Point(3, 23);
            this.itemSuggestions.Name = "itemSuggestions";
            this.itemSuggestions.Size = new System.Drawing.Size(462, 319);
            this.itemSuggestions.TabIndex = 17;
            this.itemSuggestions.DoubleClick += new System.EventHandler(this.itemSuggestions_DoubleClick);
            this.itemSuggestions.KeyDown += new System.Windows.Forms.KeyEventHandler(this.itemSuggestions_KeyDown);
            // 
            // suggestionsLabel
            // 
            this.suggestionsLabel.AutoSize = true;
            this.suggestionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suggestionsLabel.Location = new System.Drawing.Point(0, 0);
            this.suggestionsLabel.Margin = new System.Windows.Forms.Padding(0);
            this.suggestionsLabel.Name = "suggestionsLabel";
            this.suggestionsLabel.Size = new System.Drawing.Size(211, 20);
            this.suggestionsLabel.TabIndex = 19;
            this.suggestionsLabel.Text = "Suggested songs and items:";
            // 
            // suggestionTimer
            // 
            this.suggestionTimer.Interval = 1000;
            this.suggestionTimer.Tick += new System.EventHandler(this.suggestionTimer_Tick);
            // 
            // ItemSuggestionsFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.suggestionsLabel);
            this.Controls.Add(this.addItButton);
            this.Controls.Add(this.itemSuggestions);
            this.Name = "ItemSuggestionsFrame";
            this.Size = new System.Drawing.Size(468, 389);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addItButton;
        private System.Windows.Forms.ListBox itemSuggestions;
        private System.Windows.Forms.Label suggestionsLabel;
        private System.Windows.Forms.Timer suggestionTimer;
    }
}
