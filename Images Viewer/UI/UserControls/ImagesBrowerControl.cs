using DevExpress.XtraEditors;
using Images_Viewer.UI.Forms;
using System;
using System.IO;
using System.Windows.Forms;

namespace Images_Viewer.UI.UserControls
{
    public partial class ImagesBrowerControl : DevExpress.XtraEditors.XtraUserControl
    {

        public ImageViewerForm parentForm { get; set; }
        public ImagesBrowerControl()
        {
            InitializeComponent();
        }

        private void simpleButton_OpenFolder_Click(object sender, EventArgs e)
        {
            try
            {
                var dialogResult = xtraFolderBrowserDialog.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    parentForm.imagePreviewerControl.ClearImage();
                    parentForm.SplashScreenManager.ShowWaitForm();
                    treeView_Images.Nodes.Clear();
                    DirectoryInfo directoryInfo = new DirectoryInfo(xtraFolderBrowserDialog.SelectedPath);
                    BuildTree(directoryInfo, treeView_Images.Nodes);
                    parentForm.SplashScreenManager.CloseWaitForm();
                }
            }
            catch (Exception ex)
            {
                parentForm.SplashScreenManager.CloseWaitForm();
                treeView_Images.Nodes.Clear();
                if (ex is UnauthorizedAccessException)
                {
                    XtraMessageBox.Show("App has no access to load this folder.\r\nNote: try any folder in different partition. ex(d:\\ or e:\\)"
                                        , "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void BuildTree(DirectoryInfo directoryInfo, TreeNodeCollection mainTreeNodes)
        {
            TreeNode node = mainTreeNodes.Add(directoryInfo.Name);
            node.ImageIndex = 0;

            foreach (FileInfo file in directoryInfo.GetFiles())
            {
                if (!file.Extension.HasImageExtensions()) // .png | .jpg | .jpeg
                    continue;

                TreeNode imageNode = node.Nodes.Add(file.FullName, file.Name);
                imageNode.ImageIndex = 1;
            }
            foreach (DirectoryInfo subdir in directoryInfo.GetDirectories())
            {
                BuildTree(subdir, node.Nodes);
            }
        }

        private void treeView_Images_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node == null || !e.Node.Name.HasImageExtensions())
            {
                parentForm.imagePreviewerControl.ClearImage();
            }
            else
                parentForm.imagePreviewerControl.LoadImage(e.Node.Name);
        }
    }
}
