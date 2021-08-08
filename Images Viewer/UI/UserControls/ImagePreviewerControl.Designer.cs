
namespace Images_Viewer.UI.UserControls
{
    partial class ImagePreviewerControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImagePreviewerControl));
            this.simpleButton_RotateLeft = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton_RotateRight = new DevExpress.XtraEditors.SimpleButton();
            this.pictureEdit_Preview = new DevExpress.XtraEditors.PictureEdit();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit_Preview.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton_RotateLeft
            // 
            this.simpleButton_RotateLeft.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.simpleButton_RotateLeft.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton_RotateLeft.ImageOptions.SvgImage")));
            this.simpleButton_RotateLeft.Location = new System.Drawing.Point(12, 410);
            this.simpleButton_RotateLeft.Name = "simpleButton_RotateLeft";
            this.simpleButton_RotateLeft.Size = new System.Drawing.Size(385, 36);
            this.simpleButton_RotateLeft.StyleController = this.layoutControl1;
            this.simpleButton_RotateLeft.TabIndex = 0;
            this.simpleButton_RotateLeft.Click += new System.EventHandler(this.simpleButton_RotateLeft_Click);
            // 
            // simpleButton_RotateRight
            // 
            this.simpleButton_RotateRight.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.simpleButton_RotateRight.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton_RotateRight.ImageOptions.SvgImage")));
            this.simpleButton_RotateRight.Location = new System.Drawing.Point(401, 410);
            this.simpleButton_RotateRight.Name = "simpleButton_RotateRight";
            this.simpleButton_RotateRight.Size = new System.Drawing.Size(397, 36);
            this.simpleButton_RotateRight.StyleController = this.layoutControl1;
            this.simpleButton_RotateRight.TabIndex = 0;
            this.simpleButton_RotateRight.Click += new System.EventHandler(this.simpleButton_RotateRight_Click);
            // 
            // pictureEdit_Preview
            // 
            this.pictureEdit_Preview.Location = new System.Drawing.Point(12, 12);
            this.pictureEdit_Preview.Name = "pictureEdit_Preview";
            this.pictureEdit_Preview.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit_Preview.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEdit_Preview.Size = new System.Drawing.Size(786, 394);
            this.pictureEdit_Preview.StyleController = this.layoutControl1;
            this.pictureEdit_Preview.TabIndex = 1;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.simpleButton_RotateLeft);
            this.layoutControl1.Controls.Add(this.pictureEdit_Preview);
            this.layoutControl1.Controls.Add(this.simpleButton_RotateRight);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(374, 306, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(810, 458);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(810, 458);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.simpleButton_RotateRight;
            this.layoutControlItem2.Location = new System.Drawing.Point(389, 398);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(401, 40);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.simpleButton_RotateLeft;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 398);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(389, 40);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.pictureEdit_Preview;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(790, 398);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // ImagePreviewerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "ImagePreviewerControl";
            this.Size = new System.Drawing.Size(810, 458);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit_Preview.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.PictureEdit pictureEdit_Preview;
        private DevExpress.XtraEditors.SimpleButton simpleButton_RotateLeft;
        private DevExpress.XtraEditors.SimpleButton simpleButton_RotateRight;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}
