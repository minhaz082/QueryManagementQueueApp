namespace WindowsFormsAppQuaryManagementEnqueDequeue
{
    partial class QuaryManagementUI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.enqueueButton = new System.Windows.Forms.Button();
            this.complainETextBox = new System.Windows.Forms.TextBox();
            this.nameEtextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.deequeueButton = new System.Windows.Forms.Button();
            this.complainDTextBox = new System.Windows.Forms.TextBox();
            this.nameDTextBox = new System.Windows.Forms.TextBox();
            this.serialDTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.waitingQueueListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clearButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.enqueueButton);
            this.groupBox1.Controls.Add(this.complainETextBox);
            this.groupBox1.Controls.Add(this.nameEtextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(29, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 119);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enqueue Customer";
            // 
            // enqueueButton
            // 
            this.enqueueButton.Location = new System.Drawing.Point(67, 84);
            this.enqueueButton.Name = "enqueueButton";
            this.enqueueButton.Size = new System.Drawing.Size(99, 23);
            this.enqueueButton.TabIndex = 4;
            this.enqueueButton.Text = "Enqueue";
            this.enqueueButton.UseVisualStyleBackColor = true;
            this.enqueueButton.Click += new System.EventHandler(this.enqueueButton_Click);
            // 
            // complainETextBox
            // 
            this.complainETextBox.Location = new System.Drawing.Point(67, 53);
            this.complainETextBox.Name = "complainETextBox";
            this.complainETextBox.Size = new System.Drawing.Size(256, 20);
            this.complainETextBox.TabIndex = 3;
            // 
            // nameEtextBox
            // 
            this.nameEtextBox.Location = new System.Drawing.Point(67, 24);
            this.nameEtextBox.Name = "nameEtextBox";
            this.nameEtextBox.Size = new System.Drawing.Size(256, 20);
            this.nameEtextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Complain";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.deequeueButton);
            this.groupBox2.Controls.Add(this.complainDTextBox);
            this.groupBox2.Controls.Add(this.nameDTextBox);
            this.groupBox2.Controls.Add(this.serialDTextBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(367, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(332, 119);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dequeue Customer";
            // 
            // deequeueButton
            // 
            this.deequeueButton.Location = new System.Drawing.Point(217, 19);
            this.deequeueButton.Name = "deequeueButton";
            this.deequeueButton.Size = new System.Drawing.Size(97, 23);
            this.deequeueButton.TabIndex = 5;
            this.deequeueButton.Text = "Dequeue";
            this.deequeueButton.UseVisualStyleBackColor = true;
            this.deequeueButton.Click += new System.EventHandler(this.deequeueButton_Click);
            // 
            // complainDTextBox
            // 
            this.complainDTextBox.Location = new System.Drawing.Point(58, 76);
            this.complainDTextBox.Name = "complainDTextBox";
            this.complainDTextBox.Size = new System.Drawing.Size(256, 20);
            this.complainDTextBox.TabIndex = 6;
            // 
            // nameDTextBox
            // 
            this.nameDTextBox.Location = new System.Drawing.Point(58, 50);
            this.nameDTextBox.Name = "nameDTextBox";
            this.nameDTextBox.Size = new System.Drawing.Size(256, 20);
            this.nameDTextBox.TabIndex = 5;
            // 
            // serialDTextBox
            // 
            this.serialDTextBox.Location = new System.Drawing.Point(58, 24);
            this.serialDTextBox.Name = "serialDTextBox";
            this.serialDTextBox.Size = new System.Drawing.Size(105, 20);
            this.serialDTextBox.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Complain";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Serial";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.waitingQueueListView);
            this.groupBox3.Location = new System.Drawing.Point(29, 162);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(670, 222);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Waiting Queue";
            // 
            // waitingQueueListView
            // 
            this.waitingQueueListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.waitingQueueListView.FullRowSelect = true;
            this.waitingQueueListView.GridLines = true;
            this.waitingQueueListView.Location = new System.Drawing.Point(9, 32);
            this.waitingQueueListView.Name = "waitingQueueListView";
            this.waitingQueueListView.Size = new System.Drawing.Size(650, 184);
            this.waitingQueueListView.TabIndex = 0;
            this.waitingQueueListView.UseCompatibleStateImageBehavior = false;
            this.waitingQueueListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Serial No";
            this.columnHeader1.Width = 57;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 222;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Complain";
            this.columnHeader3.Width = 335;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(38, 390);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(157, 23);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "Clear Waiting Queue";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // QuaryManagementUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 447);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "QuaryManagementUI";
            this.Text = "Customer Query Management";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button enqueueButton;
        private System.Windows.Forms.TextBox complainETextBox;
        private System.Windows.Forms.TextBox nameEtextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button deequeueButton;
        private System.Windows.Forms.TextBox complainDTextBox;
        private System.Windows.Forms.TextBox nameDTextBox;
        private System.Windows.Forms.TextBox serialDTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView waitingQueueListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button clearButton;
    }
}

