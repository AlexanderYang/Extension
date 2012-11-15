using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Tools.Ribbon;
using System.Windows.Forms;

namespace Extension
{
    public partial class AssignForm : Form
    {
        public AssignEventArgs Args { get; set; }
        public bool IsAssigned { get; set; }

        public AssignForm()
        {
            InitializeComponent();
        }

        public AssignForm(SortedDictionary<string, Color> empList)
        {
            InitializeComponent();
            Args = new AssignEventArgs();
            IsAssigned = false;
            empComboBox.DataSource = new BindingSource(empList, null);
            empComboBox.DisplayMember = "Key";
            empComboBox.ValueMember = "Value";
        }

        private void assButton_Click(object sender, EventArgs args)
        {
            //check if project name is empty
            if (this.projectTextBox.Text.Equals(""))
            {
                MessageBox.Show("You have to enter the project name.",
                      "Save Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Args.ProjectName = this.projectTextBox.Text;
            Args.FromDate = this.fromDateTimePicker.Value.Date;
            Args.ToDate = this.toDateTimePicker.Value.Date;

            if (this.newRAETextBox.Text.Equals("") && (this.empComboBox.Text.Contains("<")||this.empComboBox.Text.Equals("")))
            {
                MessageBox.Show("Please enter the assignee.",
                      "Save Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //if the assignee is selected from list, change the background color.
            if (this.newRAETextBox.Text.Equals("") && !this.empComboBox.Text.Contains("<"))
            {
                Args.backgroundColor = new Color();
            }
            Args.AssignedEmp = this.newRAETextBox.Text != "" ? this.newRAETextBox.Text : this.empComboBox.Text;
            this.IsAssigned = true;
            this.Close();
        }

        private void backgroundButton_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Args.backgroundColor = colorDialog.Color;
                this.newRAETextBox.BackColor = colorDialog.Color;
            }
        }

        private void empComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Args.AssignedEmp = empComboBox.Text;
        }

        private void toDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            //check if the toDate is later than fromDate
            if (this.fromDateTimePicker.Value.Date > this.toDateTimePicker.Value.Date)
            {
                MessageBox.Show("Your project start date is later than the end date. Please enter the right dates.",
                   "Save Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.IsAssigned = false;
            this.Close();
        }
    }

    //Assign arguments
    public class AssignEventArgs : EventArgs
    {
        public string ProjectName { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string AssignedEmp { get; set; }
        public Color backgroundColor { get; set; }

        public AssignEventArgs()
        { }
    }

}
