﻿namespace P7
{
    partial class FormMain
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
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesSelectProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesCreateProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesModifyProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesRemoveProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issuesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issuesDashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issuesRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issuesModifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issuesRemoveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.requirementsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.featureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.designToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preferencesToolStripMenuItem,
            this.issuesToolStripMenuItem,
            this.requirementsToolStripMenuItem,
            this.designToolStripMenuItem,
            this.testToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStripMain.Size = new System.Drawing.Size(838, 24);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStripMain";
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preferencesSelectProjectToolStripMenuItem,
            this.preferencesCreateProjectToolStripMenuItem,
            this.preferencesModifyProjectToolStripMenuItem,
            this.preferencesRemoveProjectToolStripMenuItem});
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.preferencesToolStripMenuItem.Text = "&Preferences";
            // 
            // preferencesSelectProjectToolStripMenuItem
            // 
            this.preferencesSelectProjectToolStripMenuItem.Name = "preferencesSelectProjectToolStripMenuItem";
            this.preferencesSelectProjectToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.preferencesSelectProjectToolStripMenuItem.Text = "&Select Project";
            this.preferencesSelectProjectToolStripMenuItem.Click += new System.EventHandler(this.preferencesSelectProjectToolStripMenuItem_Click);
            // 
            // preferencesCreateProjectToolStripMenuItem
            // 
            this.preferencesCreateProjectToolStripMenuItem.Name = "preferencesCreateProjectToolStripMenuItem";
            this.preferencesCreateProjectToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.preferencesCreateProjectToolStripMenuItem.Text = "&Create Project";
            this.preferencesCreateProjectToolStripMenuItem.Click += new System.EventHandler(this.preferencesCreateProjectToolStripMenuItem_Click);
            // 
            // preferencesModifyProjectToolStripMenuItem
            // 
            this.preferencesModifyProjectToolStripMenuItem.Name = "preferencesModifyProjectToolStripMenuItem";
            this.preferencesModifyProjectToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.preferencesModifyProjectToolStripMenuItem.Text = "&Modify Project";
            this.preferencesModifyProjectToolStripMenuItem.Click += new System.EventHandler(this.preferencesModifyProjectToolStripMenuItem_Click);
            // 
            // preferencesRemoveProjectToolStripMenuItem
            // 
            this.preferencesRemoveProjectToolStripMenuItem.Name = "preferencesRemoveProjectToolStripMenuItem";
            this.preferencesRemoveProjectToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.preferencesRemoveProjectToolStripMenuItem.Text = "&Remove Project";
            this.preferencesRemoveProjectToolStripMenuItem.Click += new System.EventHandler(this.preferencesRemoveProjectToolStripMenuItem_Click);
            // 
            // issuesToolStripMenuItem
            // 
            this.issuesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.issuesDashboardToolStripMenuItem,
            this.issuesRecordToolStripMenuItem,
            this.issuesModifyToolStripMenuItem,
            this.issuesRemoveToolStripMenuItem});
            this.issuesToolStripMenuItem.Name = "issuesToolStripMenuItem";
            this.issuesToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.issuesToolStripMenuItem.Text = "&Issue";
            // 
            // issuesDashboardToolStripMenuItem
            // 
            this.issuesDashboardToolStripMenuItem.Name = "issuesDashboardToolStripMenuItem";
            this.issuesDashboardToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.issuesDashboardToolStripMenuItem.Text = "&Dashboard";
            this.issuesDashboardToolStripMenuItem.Click += new System.EventHandler(this.issuesDashboardToolStripMenuItem_Click);
            // 
            // issuesRecordToolStripMenuItem
            // 
            this.issuesRecordToolStripMenuItem.Name = "issuesRecordToolStripMenuItem";
            this.issuesRecordToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.issuesRecordToolStripMenuItem.Text = "&Record";
            this.issuesRecordToolStripMenuItem.Click += new System.EventHandler(this.issuesRecordToolStripMenuItem_Click);
            // 
            // issuesModifyToolStripMenuItem
            // 
            this.issuesModifyToolStripMenuItem.Name = "issuesModifyToolStripMenuItem";
            this.issuesModifyToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.issuesModifyToolStripMenuItem.Text = "&Modify";
            this.issuesModifyToolStripMenuItem.Click += new System.EventHandler(this.issuesModifyToolStripMenuItem_Click);
            // 
            // issuesRemoveToolStripMenuItem
            // 
            this.issuesRemoveToolStripMenuItem.Name = "issuesRemoveToolStripMenuItem";
            this.issuesRemoveToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.issuesRemoveToolStripMenuItem.Text = "R&emove";
            this.issuesRemoveToolStripMenuItem.Click += new System.EventHandler(this.issuesRemoveToolStripMenuItem_Click);
            // 
            // requirementsToolStripMenuItem
            // 
            this.requirementsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.featureToolStripMenuItem,
            this.createToolStripMenuItem,
            this.modifyToolStripMenuItem,
            this.removeToolStripMenuItem});
            this.requirementsToolStripMenuItem.Name = "requirementsToolStripMenuItem";
            this.requirementsToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.requirementsToolStripMenuItem.Text = "&Requirement";
            // 
            // featureToolStripMenuItem
            // 
            this.featureToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem1,
            this.modifyToolStripMenuItem1,
            this.removeToolStripMenuItem1});
            this.featureToolStripMenuItem.Name = "featureToolStripMenuItem";
            this.featureToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.featureToolStripMenuItem.Text = "Feature";
            // 
            // createToolStripMenuItem1
            // 
            this.createToolStripMenuItem1.Name = "createToolStripMenuItem1";
            this.createToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.createToolStripMenuItem1.Text = "Create";
            this.createToolStripMenuItem1.Click += new System.EventHandler(this.createToolStripMenuItem1_Click);
            // 
            // modifyToolStripMenuItem1
            // 
            this.modifyToolStripMenuItem1.Name = "modifyToolStripMenuItem1";
            this.modifyToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.modifyToolStripMenuItem1.Text = "Modify";
            this.modifyToolStripMenuItem1.Click += new System.EventHandler(this.modifyToolStripMenuItem1_Click);
            // 
            // removeToolStripMenuItem1
            // 
            this.removeToolStripMenuItem1.Name = "removeToolStripMenuItem1";
            this.removeToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.removeToolStripMenuItem1.Text = "Remove";
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.createToolStripMenuItem.Text = "Create";
            // 
            // modifyToolStripMenuItem
            // 
            this.modifyToolStripMenuItem.Name = "modifyToolStripMenuItem";
            this.modifyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modifyToolStripMenuItem.Text = "Modify";
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            // 
            // designToolStripMenuItem
            // 
            this.designToolStripMenuItem.Name = "designToolStripMenuItem";
            this.designToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.designToolStripMenuItem.Text = "&Design";
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.testToolStripMenuItem.Text = "&Test";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 603);
            this.Controls.Add(this.menuStripMain);
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "FormMain";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferencesSelectProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferencesCreateProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferencesModifyProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferencesRemoveProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issuesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issuesDashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issuesRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issuesModifyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issuesRemoveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem requirementsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem designToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem featureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modifyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
    }
}

