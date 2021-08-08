using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Images_Viewer.UI.UserControls
{
    public partial class MemoEditWithCounterControl : DevExpress.XtraEditors.XtraUserControl
    {
        int value = 0;
        public MemoEditWithCounterControl()
        {
            InitializeComponent();
            UpdateCounter();
        }
        private void UpdateCounter()
        {
            labelControl_Count.Text = string.Format("{0} -- Remaining characters", memoEdit.Properties.MaxLength - value);
        }

        private void memoEdit_EditValueChanged(object sender, EventArgs e)
        {
            value = memoEdit.Text.Length;
            UpdateCounter();
        }
    }
}
