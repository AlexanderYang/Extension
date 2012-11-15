namespace Extension
{
    partial class AssignForm
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
            this.project_label = new System.Windows.Forms.Label();
            this.projectTextBox = new System.Windows.Forms.TextBox();
            this.period_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.list_label = new System.Windows.Forms.Label();
            this.empComboBox = new System.Windows.Forms.ComboBox();
            this.assignButton = new System.Windows.Forms.Button();
            this.fromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.toDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.newRAELabel = new System.Windows.Forms.Label();
            this.newRAETextBox = new System.Windows.Forms.TextBox();
            this.backgroundButton = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // project_label
            // 
            this.project_label.AutoSize = true;
            this.project_label.Location = new System.Drawing.Point(12, 32);
            this.project_label.Name = "project_label";
            this.project_label.Size = new System.Drawing.Size(71, 13);
            this.project_label.TabIndex = 0;
            this.project_label.Text = "Project Name";
            // 
            // projectTextBox
            // 
            this.projectTextBox.Location = new System.Drawing.Point(90, 29);
            this.projectTextBox.Name = "projectTextBox";
            this.projectTextBox.Size = new System.Drawing.Size(200, 20);
            this.projectTextBox.TabIndex = 1;
            // 
            // period_label
            // 
            this.period_label.AutoSize = true;
            this.period_label.Location = new System.Drawing.Point(12, 80);
            this.period_label.Name = "period_label";
            this.period_label.Size = new System.Drawing.Size(60, 13);
            this.period_label.TabIndex = 2;
            this.period_label.Text = "Due Period";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 4;
            // 
            // list_label
            // 
            this.list_label.AutoSize = true;
            this.list_label.Location = new System.Drawing.Point(11, 190);
            this.list_label.Name = "list_label";
            this.list_label.Size = new System.Drawing.Size(72, 13);
            this.list_label.TabIndex = 5;
            this.list_label.Text = "Employee List";
            // 
            // empComboBox
            // 
            this.empComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.empComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.empComboBox.Location = new System.Drawing.Point(90, 186);
            this.empComboBox.Name = "empComboBox";
            this.empComboBox.Size = new System.Drawing.Size(167, 21);
            this.empComboBox.Sorted = true;
            this.empComboBox.TabIndex = 6;
            this.empComboBox.SelectedIndexChanged += new System.EventHandler(this.empComboBox_SelectedIndexChanged);
            // 
            // assignButton
            // 
            this.assignButton.Location = new System.Drawing.Point(376, 190);
            this.assignButton.Name = "assignButton";
            this.assignButton.Size = new System.Drawing.Size(89, 50);
            this.assignButton.TabIndex = 7;
            this.assignButton.Text = "Assign";
            this.assignButton.UseVisualStyleBackColor = true;
            this.assignButton.Click += new System.EventHandler(this.assButton_Click);
            // 
            // fromDateTimePicker
            // 
            this.fromDateTimePicker.Location = new System.Drawing.Point(90, 74);
            this.fromDateTimePicker.Name = "fromDateTimePicker";
            this.fromDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fromDateTimePicker.TabIndex = 8;
            // 
            // toDateTimePicker
            // 
            this.toDateTimePicker.Location = new System.Drawing.Point(90, 117);
            this.toDateTimePicker.Name = "toDateTimePicker";
            this.toDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.toDateTimePicker.TabIndex = 9;
            this.toDateTimePicker.ValueChanged += new System.EventHandler(this.toDateTimePicker_ValueChanged);
            // 
            // newRAELabel
            // 
            this.newRAELabel.AutoSize = true;
            this.newRAELabel.Location = new System.Drawing.Point(12, 245);
            this.newRAELabel.Name = "newRAELabel";
            this.newRAELabel.Size = new System.Drawing.Size(74, 13);
            this.newRAELabel.TabIndex = 10;
            this.newRAELabel.Text = "Add new RAE";
            // 
            // newRAETextBox
            // 
            this.newRAETextBox.Location = new System.Drawing.Point(92, 242);
            this.newRAETextBox.Name = "newRAETextBox";
            this.newRAETextBox.Size = new System.Drawing.Size(165, 20);
            this.newRAETextBox.TabIndex = 11;
            // 
            // backgroundButton
            // 
            this.backgroundButton.Location = new System.Drawing.Point(90, 291);
            this.backgroundButton.Name = "backgroundButton";
            this.backgroundButton.Size = new System.Drawing.Size(195, 39);
            this.backgroundButton.TabIndex = 12;
            this.backgroundButton.Text = "Select Background for new RAE";
            this.backgroundButton.UseVisualStyleBackColor = true;
            this.backgroundButton.Click += new System.EventHandler(this.backgroundButton_Click);
            // 
            // colorDialog
            // 
            this.colorDialog.AnyColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(376, 280);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(89, 50);
            this.cancelButton.TabIndex = 13;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // AssignForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 367);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.backgroundButton);
            this.Controls.Add(this.newRAETextBox);
            this.Controls.Add(this.newRAELabel);
            this.Controls.Add(this.toDateTimePicker);
            this.Controls.Add(this.fromDateTimePicker);
            this.Controls.Add(this.assignButton);
            this.Controls.Add(this.empComboBox);
            this.Controls.Add(this.list_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.period_label);
            this.Controls.Add(this.projectTextBox);
            this.Controls.Add(this.project_label);
            this.Name = "AssignForm";
            this.Text = "Assign a New Project";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label project_label;
        private System.Windows.Forms.TextBox projectTextBox;
        private System.Windows.Forms.Label period_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label list_label;
        private System.Windows.Forms.ComboBox empComboBox;
        private System.Windows.Forms.Button assignButton;
        private System.Windows.Forms.DateTimePicker fromDateTimePicker;
        private System.Windows.Forms.DateTimePicker toDateTimePicker;
        private System.Windows.Forms.Label newRAELabel;
        private System.Windows.Forms.TextBox newRAETextBox;
        private System.Windows.Forms.Button backgroundButton;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button cancelButton;
    }
}