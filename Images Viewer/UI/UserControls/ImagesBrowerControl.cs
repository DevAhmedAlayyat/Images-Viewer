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
            var dialogResult = xtraFolderBrowserDialog.ShowDialog();
            if(dialogResult == DialogResult.OK)
            {
                treeView_Images.Nodes.Clear();
                DirectoryInfo directoryInfo = new DirectoryInfo(xtraFolderBrowserDialog.SelectedPath);
                BuildTree(directoryInfo, treeView_Images.Nodes);
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
