
namespace P6
{
    partial class FormIssueDashboard
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelTotalIssues = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxIssueMonth = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxIssueDiscoverer = new System.Windows.Forms.ListBox();
            this.labelIssueAmount = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total Number of Issues:";
            // 
            // labelTotalIssues
            // 
            this.labelTotalIssues.AutoSize = true;
            this.labelTotalIssues.Location = new System.Drawing.Point(151, 85);
            this.labelTotalIssues.Name = "labelTotalIssues";
            this.labelTotalIssues.Size = new System.Drawing.Size(0, 13);
            this.labelTotalIssues.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Issues by Month";
            // 
            // listBoxIssueMonth
            // 
            this.listBoxIssueMonth.FormattingEnabled = true;
            this.listBoxIssueMonth.Location = new System.Drawing.Point(31, 101);
            this.listBoxIssueMonth.Name = "listBoxIssueMonth";
            this.listBoxIssueMonth.Size = new System.Drawing.Size(219, 95);
            this.listBoxIssueMonth.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Issues by Discoverer";
            // 
            // listBoxIssueDiscoverer
            // 
            this.listBoxIssueDiscoverer.FormattingEnabled = true;
            this.listBoxIssueDiscoverer.Location = new System.Drawing.Point(31, 226);
            this.listBoxIssueDiscoverer.Name = "listBoxIssueDiscoverer";
            this.listBoxIssueDiscoverer.Size = new System.Drawing.Size(219, 95);
            this.listBoxIssueDiscoverer.TabIndex = 6;
            // 
            // labelIssueAmount
            // 
            this.labelIssueAmount.AutoSize = true;
            this.labelIssueAmount.Location = new System.Drawing.Point(154, 55);
            this.labelIssueAmount.Name = "labelIssueAmount";
            this.labelIssueAmount.Size = new System.Drawing.Size(35, 13);
            this.labelIssueAmount.TabIndex = 7;
            this.labelIssueAmount.Text = "label4";
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(175, 374);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 8;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // FormIssueDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 439);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.labelIssueAmount);
            this.Controls.Add(this.listBoxIssueDiscoverer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBoxIssueMonth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelTotalIssues);
            this.Controls.Add(this.label1);
            this.Name = "FormIssueDashboard";
            this.Text = "Issue Dashboard";
            this.Load += new System.EventHandler(this.FormIssueDashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTotalIssues;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxIssueMonth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxIssueDiscoverer;
        private System.Windows.Forms.Label labelIssueAmount;
        private System.Windows.Forms.Button buttonClose;
    }
}