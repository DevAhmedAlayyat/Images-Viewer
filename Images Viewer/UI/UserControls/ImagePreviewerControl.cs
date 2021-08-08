using Images_Viewer.UI.Forms;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace Images_Viewer.UI.UserControls
{
    public partial class ImagePreviewerControl : DevExpress.XtraEditors.XtraUserControl
    {
        public ImageViewerForm parentForm { get; set; }
        public ImagePreviewerControl()
        {
            InitializeComponent();
        }

        public void LoadImage(string imageFullName)
        {
            parentForm.SplashScreenManager.ShowWaitForm();
            if (pictureEdit_Preview.Image != null)
                pictureEdit_Preview.Image.Dispose();
            pictureEdit_Preview.Image = Image.FromFile(imageFullName);
            parentForm.SplashScreenManager.CloseWaitForm();

            parentForm.imagePropertiesControl.Enabled = true;
            parentForm.imagePropertiesControl.ClearControl();
        }

        public void ClearImage()
        {
            if (pictureEdit_Preview.Image != null)
            {
                pictureEdit_Preview.Image.Dispose();
                pictureEdit_Preview.Image = null;
            }
            parentForm.imagePropertiesControl.ClearControl();
            parentForm.imagePropertiesControl.Enabled = false;
        }

        private void simpleButton_RotateRight_Click(object sender, EventArgs e)
        {
            RotateImage(RotateFlipType.Rotate90FlipNone);
        }

        private void simpleButton_RotateLeft_Click(object sender, EventArgs e)
        {
            RotateImage(RotateFlipType.Rotate90FlipXY);
        }

        public byte[] GetImageAsByteArr()
        {
            if (pictureEdit_Preview.Image != null)
            {
                Image image = pictureEdit_Preview.Image.Clone() as Image;
                using(var ms = new MemoryStream())
                {
                    image.Save(ms, ImageFormat.Png);
                    return ms.ToArray();
                }
            }
            return null;
        }

        private void RotateImage(RotateFlipType rotateFlipType)
        {
            if (pictureEdit_Preview.Image == null)
                return;
            Image image = pictureEdit_Preview.Image.Clone() as Image;
            image.RotateFlip(rotateFlipType);
            pictureEdit_Preview.Image.Dispose();
            pictureEdit_Preview.Image = image;
        }
    }
}
