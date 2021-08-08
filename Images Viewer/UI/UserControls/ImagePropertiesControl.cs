using DevExpress.XtraEditors;
using Images_Viewer.Data;
using Images_Viewer.UI.Forms;
using System;

namespace Images_Viewer.UI.UserControls
{
    public partial class ImagePropertiesControl : DevExpress.XtraEditors.XtraUserControl
    {
        private readonly ImageViewerDbContext _dbContext;
        public ImageViewerForm parentForm { get; set; }
        public ImagePropertiesControl()
        {
            InitializeComponent();
            _dbContext = new ImageViewerDbContext();
        }

        private void simpleButton_Save_Click(object sender, EventArgs e)
        {
            if (!ValidateRequiredFields())
                return;

            parentForm.SplashScreenManager.ShowWaitForm();
            _dbContext.Attachments.Add(new Data.Entities.Attachment
            {
                Name = textEdit_Name.EditValue.ToString(),
                Address = textEdit_Address.EditValue?.ToString()?? "",
                Email = textEdit_Email.EditValue?.ToString() ?? "",
                Description = memoEditWithCounterControl.memoEdit.EditValue?.ToString() ?? "",
                Content = parentForm.imagePreviewerControl.GetImageAsByteArr()
            });

            _dbContext.SaveChanges();
            parentForm.SplashScreenManager.CloseWaitForm();
            XtraMessageBox.Show("Saved Sucessfuly.");
        }

        public void ClearControl()
        {
            textEdit_Address.Text =
            textEdit_Email.Text =
            textEdit_Name.Text =
            memoEditWithCounterControl.memoEdit.Text = string.Empty;
        }

        private bool ValidateRequiredFields()
        {
            bool isValid;

            if (string.IsNullOrEmpty(textEdit_Name.Text) || string.IsNullOrWhiteSpace(textEdit_Name.Text))
            {
                dxErrorProvider.SetError(textEdit_Name, "Name is mandatory field");
                XtraMessageBox.Show("Enter the required fields", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                isValid = false;
            }
            else
            {
                dxErrorProvider.ClearErrors();
                isValid = true;
            }

            return isValid;
        }
    }
}
