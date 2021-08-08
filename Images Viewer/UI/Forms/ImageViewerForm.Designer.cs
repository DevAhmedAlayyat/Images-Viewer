
using Images_Viewer.UI.UserControls;

namespace Images_Viewer.UI.Forms
{
    partial class ImageViewerForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageViewerForm));
            this.splashScreenManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::Images_Viewer.UI.Forms.WaitForm1), true, true);
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.imagesBrowerControl = new Images_Viewer.UI.UserControls.ImagesBrowerControl();
            this.dockPanel3 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel3_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.imagePropertiesControl = new Images_Viewer.UI.UserControls.ImagePropertiesControl();
            this.dockPanel2 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel2_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.imagePreviewerControl = new Images_Viewer.UI.UserControls.ImagePreviewerControl();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dockPanel1.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            this.dockPanel3.SuspendLayout();
            this.dockPanel3_Container.SuspendLayout();
            this.dockPanel2.SuspendLayout();
            this.dockPanel2_Container.SuspendLayout();
            this.SuspendLayout();
            // 
            // splashScreenManager
            // 
            this.splashScreenManager.ClosingDelay = 500;
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPanel1,
            this.dockPanel3,
            this.dockPanel2});
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane",
            "DevExpress.XtraBars.TabFormControl",
            "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl",
            "DevExpress.XtraBars.ToolbarForm.ToolbarFormControl"});
            // 
            // dockPanel1
            // 
            this.dockPanel1.Controls.Add(this.dockPanel1_Container);
            this.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dockPanel1.ID = new System.Guid("3f05dfd2-e42f-40af-81a1-d9e063c3f2a4");
            this.dockPanel1.Location = new System.Drawing.Point(0, 0);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.Options.ShowAutoHideButton = false;
            this.dockPanel1.Options.ShowCloseButton = false;
            this.dockPanel1.OriginalSize = new System.Drawing.Size(200, 200);
            this.dockPanel1.Size = new System.Drawing.Size(200, 516);
            this.dockPanel1.Text = "Images Browser";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.imagesBrowerControl);
            this.dockPanel1_Container.Location = new System.Drawing.Point(3, 26);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(193, 487);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // imagesBrowerControl
            // 
            this.imagesBrowerControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imagesBrowerControl.Location = new System.Drawing.Point(0, 0);
            this.imagesBrowerControl.Name = "imagesBrowerControl";
            this.imagesBrowerControl.parentForm = null;
            this.imagesBrowerControl.Size = new System.Drawing.Size(193, 487);
            this.imagesBrowerControl.TabIndex = 0;
            // 
            // dockPanel3
            // 
            this.dockPanel3.Controls.Add(this.dockPanel3_Container);
            this.dockPanel3.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right;
            this.dockPanel3.ID = new System.Guid("11322bf9-1b02-4353-85f4-85260f7f9667");
            this.dockPanel3.Location = new System.Drawing.Point(827, 0);
            this.dockPanel3.Name = "dockPanel3";
            this.dockPanel3.Options.ShowAutoHideButton = false;
            this.dockPanel3.Options.ShowCloseButton = false;
            this.dockPanel3.OriginalSize = new System.Drawing.Size(232, 200);
            this.dockPanel3.Size = new System.Drawing.Size(232, 516);
            this.dockPanel3.Text = "Image Properties";
            // 
            // dockPanel3_Container
            // 
            this.dockPanel3_Container.Controls.Add(this.imagePropertiesControl);
            this.dockPanel3_Container.Location = new System.Drawing.Point(4, 26);
            this.dockPanel3_Container.Name = "dockPanel3_Container";
            this.dockPanel3_Container.Size = new System.Drawing.Size(225, 487);
            this.dockPanel3_Container.TabIndex = 0;
            // 
            // imagePropertiesControl
            // 
            this.imagePropertiesControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imagePropertiesControl.Enabled = false;
            this.imagePropertiesControl.Location = new System.Drawing.Point(0, 0);
            this.imagePropertiesControl.Name = "imagePropertiesControl";
            this.imagePropertiesControl.parentForm = null;
            this.imagePropertiesControl.Size = new System.Drawing.Size(225, 487);
            this.imagePropertiesControl.TabIndex = 0;
            // 
            // dockPanel2
            // 
            this.dockPanel2.Controls.Add(this.dockPanel2_Container);
            this.dockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.dockPanel2.ID = new System.Guid("6fd34bd5-de04-4c61-9f44-54f6f68b3956");
            this.dockPanel2.Location = new System.Drawing.Point(200, 0);
            this.dockPanel2.Name = "dockPanel2";
            this.dockPanel2.Options.ShowAutoHideButton = false;
            this.dockPanel2.Options.ShowCloseButton = false;
            this.dockPanel2.OriginalSize = new System.Drawing.Size(627, 200);
            this.dockPanel2.Size = new System.Drawing.Size(627, 516);
            this.dockPanel2.Text = "Image Preview";
            // 
            // dockPanel2_Container
            // 
            this.dockPanel2_Container.Controls.Add(this.imagePreviewerControl);
            this.dockPanel2_Container.Location = new System.Drawing.Point(3, 26);
            this.dockPanel2_Container.Name = "dockPanel2_Container";
            this.dockPanel2_Container.Size = new System.Drawing.Size(621, 486);
            this.dockPanel2_Container.TabIndex = 0;
            // 
            // imagePreviewerControl
            // 
            this.imagePreviewerControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imagePreviewerControl.Location = new System.Drawing.Point(0, 0);
            this.imagePreviewerControl.Name = "imagePreviewerControl";
            this.imagePreviewerControl.parentForm = null;
            this.imagePreviewerControl.Size = new System.Drawing.Size(621, 486);
            this.imagePreviewerControl.TabIndex = 0;
            // 
            // ImageViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 516);
            this.Controls.Add(this.dockPanel2);
            this.Controls.Add(this.dockPanel3);
            this.Controls.Add(this.dockPanel1);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ImageViewerForm.IconOptions.SvgImage")));
            this.Name = "ImageViewerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Viewer -- Ahmed Alayat";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dockPanel1.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            this.dockPanel3.ResumeLayout(false);
            this.dockPanel3_Container.ResumeLayout(false);
            this.dockPanel2.ResumeLayout(false);
            this.dockPanel2_Container.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel2;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel2_Container;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel3;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel3_Container;
        private ImagesBrowerControl imagesBrowerControl;
        public ImagePreviewerControl imagePreviewerControl;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager;
        public ImagePropertiesControl imagePropertiesControl;
    }
}