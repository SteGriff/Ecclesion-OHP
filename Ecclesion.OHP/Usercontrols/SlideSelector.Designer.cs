﻿namespace Ecclesion.OHP.Usercontrols
{
    partial class SlideSelector
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
            this.protoSlideSelection = new Ecclesion.OHP.Usercontrols.SlideSelection();
            this.SuspendLayout();
            // 
            // protoSlideSelection
            // 
            this.protoSlideSelection.Location = new System.Drawing.Point(0, 0);
            this.protoSlideSelection.Name = "protoSlideSelection";
            this.protoSlideSelection.Size = new System.Drawing.Size(300, 86);
            this.protoSlideSelection.TabIndex = 0;
            // 
            // SlideSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.protoSlideSelection);
            this.Name = "SlideSelector";
            this.Size = new System.Drawing.Size(300, 240);
            this.ResumeLayout(false);

        }

        #endregion

        private SlideSelection protoSlideSelection;
    }
}