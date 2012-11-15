namespace Extension
{
    partial class ProjectMonitor : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public ProjectMonitor()
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
            this.group1 = this.Factory.CreateRibbonGroup();
            this.workload_tab = this.Factory.CreateRibbonTab();
            this.workloadGroup = this.Factory.CreateRibbonGroup();
            this.assignButton = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.workload_tab.SuspendLayout();
            this.workloadGroup.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.group1);
            this.tab1.Label = "TabAddIns";
            this.tab1.Name = "tab1";
            // 
            // group1
            // 
            this.group1.Label = "group1";
            this.group1.Name = "group1";
            // 
            // workload_tab
            // 
            this.workload_tab.Groups.Add(this.workloadGroup);
            this.workload_tab.Label = "878 workload";
            this.workload_tab.Name = "workload_tab";
            // 
            // workloadGroup
            // 
            this.workloadGroup.Items.Add(this.assignButton);
            this.workloadGroup.Label = "workload";
            this.workloadGroup.Name = "workloadGroup";
            // 
            // assignButton
            // 
            this.assignButton.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.assignButton.Image = global::Extension.Properties.Resources.logo_dnv;
            this.assignButton.Label = "Project Monitoring";
            this.assignButton.Name = "assignButton";
            this.assignButton.ShowImage = true;
            this.assignButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.assignButton_Click);
            // 
            // ProjectMonitor
            // 
            this.Name = "ProjectMonitor";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.tab1);
            this.Tabs.Add(this.workload_tab);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.ProjectMonitor_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.workload_tab.ResumeLayout(false);
            this.workload_tab.PerformLayout();
            this.workloadGroup.ResumeLayout(false);
            this.workloadGroup.PerformLayout();

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        private Microsoft.Office.Tools.Ribbon.RibbonTab workload_tab;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup workloadGroup;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton assignButton;
    }

    partial class ThisRibbonCollection
    {
        internal ProjectMonitor ProjectMonitor
        {
            get { return this.GetRibbon<ProjectMonitor>(); }
        }
    }
}
