namespace Extension
{
    partial class WorkloadRibbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public WorkloadRibbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

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
            this.tab1 = this.Factory.CreateRibbonTab();
            this.Workload_878 = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.assign_button = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.Workload_878.SuspendLayout();
            this.group1.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Label = "TabAddIns";
            this.tab1.Name = "tab1";
            this.tab1.Tag = "";
            // 
            // Workload_878
            // 
            this.Workload_878.Groups.Add(this.group1);
            this.Workload_878.Label = "878 Workload";
            this.Workload_878.Name = "Workload_878";
            this.Workload_878.Tag = "Assign Project";
            // 
            // group1
            // 
            this.group1.Items.Add(this.assign_button);
            this.group1.Label = "workload";
            this.group1.Name = "group1";
            this.group1.Tag = "Assign Project";
            // 
            // assign_button
            // 
            this.assign_button.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.assign_button.Image = global::Extension.Properties.Resources.logo_dnv;
            this.assign_button.ImageName = "logo";
            this.assign_button.Label = "Project Monitoring";
            this.assign_button.Name = "assign_button";
            this.assign_button.ScreenTip = "Assign a project";
            this.assign_button.ShowImage = true;
            this.assign_button.Tag = "Assign Project";
            this.assign_button.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button1_Click);
            // 
            // WorkloadRibbon
            // 
            this.Name = "WorkloadRibbon";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.Workload_878.ResumeLayout(false);
            this.Workload_878.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        private Microsoft.Office.Tools.Ribbon.RibbonTab Workload_878;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton assign_button;
    }

    partial class ThisRibbonCollection
    {
        internal WorkloadRibbon Ribbon1
        {
            get { return this.GetRibbon<WorkloadRibbon>(); }
        }
    }
}
