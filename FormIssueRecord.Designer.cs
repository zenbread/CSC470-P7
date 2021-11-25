
namespace P6
{
    partial class FormIssueRecord
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
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxComponent = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBoxAuthor = new System.Windows.Forms.ComboBox();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonCreateIssue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(100, 29);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.ReadOnly = true;
            this.textBoxId.Size = new System.Drawing.Size(47, 20);
            this.textBoxId.TabIndex = 1;
            this.textBoxId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(101, 55);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(353, 20);
            this.textBoxTitle.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Title:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Discovery Date:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Discoverer:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxComponent
            // 
            this.textBoxComponent.Location = new System.Drawing.Point(101, 136);
            this.textBoxComponent.Name = "textBoxComponent";
            this.textBoxComponent.Size = new System.Drawing.Size(353, 20);
            this.textBoxComponent.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Component:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Status:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Initial Description:";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(100, 227);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(354, 227);
            this.textBoxDescription.TabIndex = 13;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(101, 81);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(353, 20);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // comboBoxAuthor
            // 
            this.comboBoxAuthor.FormattingEnabled = true;
            this.comboBoxAuthor.Location = new System.Drawing.Point(101, 108);
            this.comboBoxAuthor.Name = "comboBoxAuthor";
            this.comboBoxAuthor.Size = new System.Drawing.Size(353, 21);
            this.comboBoxAuthor.TabIndex = 15;
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(100, 162);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(354, 21);
            this.comboBoxStatus.TabIndex = 16;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(239, 505);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 17;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonCreateIssue
            // 
            this.buttonCreateIssue.Location = new System.Drawing.Point(343, 505);
            this.buttonCreateIssue.Name = "buttonCreateIssue";
            this.buttonCreateIssue.Size = new System.Drawing.Size(75, 23);
            this.buttonCreateIssue.TabIndex = 18;
            this.buttonCreateIssue.Text = "Create Issue";
            this.buttonCreateIssue.UseVisualStyleBackColor = true;
            this.buttonCreateIssue.Click += new System.EventHandler(this.buttonCreateIssue_Click);
            // 
            // FormIssueRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 577);
            this.Controls.Add(this.buttonCreateIssue);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.comboBoxAuthor);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxComponent);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.label1);
            this.Name = "FormIssueRecord";
            this.Text = "FormIssueRecord";
            this.Load += new System.EventHandler(this.FormIssueRecord_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxComponent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBoxAuthor;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonCreateIssue;
    }
}