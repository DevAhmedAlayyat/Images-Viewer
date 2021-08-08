
namespace Images_Viewer.UI.UserControls
{
    partial class ImagesBrowerControl
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImagesBrowerControl));
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.treeView_Images = new System.Windows.Forms.TreeView();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.simpleButton_OpenFolder = new DevExpress.XtraEditors.SimpleButton();
            this.xtraFolderBrowserDialog = new DevExpress.XtraEditors.XtraFolderBrowserDialog(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F)});
            this.tablePanel1.Controls.Add(this.treeView_Images);
            this.tablePanel1.Controls.Add(this.simpleButton_OpenFolder);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(231, 464);
            this.tablePanel1.TabIndex = 1;
            // 
            // treeView_Images
            // 
            this.tablePanel1.SetColumn(this.treeView_Images, 0);
            this.treeView_Images.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView_Images.ImageIndex = 0;
            this.treeView_Images.ImageList = this.imageList;
            this.treeView_Images.Location = new System.Drawing.Point(3, 44);
            this.treeView_Images.Name = "treeView_Images";
            this.tablePanel1.SetRow(this.treeView_Images, 1);
            this.treeView_Images.SelectedImageIndex = 2;
            this.treeView_Images.Size = new System.Drawing.Size(225, 417);
            this.treeView_Images.TabIndex = 2;
            this.treeView_Images.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_Images_AfterSelect);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "folder (2).png");
            this.imageList.Images.SetKeyName(1, "image.png");
            this.imageList.Images.SetKeyName(2, "right-arrow.png");
            // 
            // simpleButton_OpenFolder
            // 
            this.tablePanel1.SetColumn(this.simpleButton_OpenFolder, 0);
            this.simpleButton_OpenFolder.Location = new System.Drawing.Point(3, 3);
            this.simpleButton_OpenFolder.Name = "simpleButton_OpenFolder";
            this.tablePanel1.SetRow(this.simpleButton_OpenFolder, 0);
            this.simpleButton_OpenFolder.Size = new System.Drawing.Size(225, 35);
            this.simpleButton_OpenFolder.TabIndex = 1;
            this.simpleButton_OpenFolder.Text = "Select Images Folder";
            this.simpleButton_OpenFolder.Click += new System.EventHandler(this.simpleButton_OpenFolder_Click);
            // 
            // xtraFolderBrowserDialog
            // 
            this.xtraFolderBrowserDialog.SelectedPath = "xtraFolderBrowserDialog1";
            // 
            // ImagesBrowerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tablePanel1);
            this.Name = "ImagesBrowerControl";
            this.Size = new System.Drawing.Size(231, 464);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraEditors.SimpleButton simpleButton_OpenFolder;
        private DevExpress.XtraEditors.XtraFolderBrowserDialog xtraFolderBrowserDialog;
        private System.Windows.Forms.TreeView treeView_Images;
        private System.Windows.Forms.ImageList imageList;
    }
}
