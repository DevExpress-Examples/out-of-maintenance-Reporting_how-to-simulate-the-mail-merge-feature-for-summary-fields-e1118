using System;
using DevExpress.XtraReports.UI;
// ...

namespace MailMergeSummary {
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport {
        public XtraReport1() {
            InitializeComponent();
        }

        private void xrLabel2_SummaryCalculated(object sender, TextFormatEventArgs e) {
            e.Text = String.Format("Category #{0} contains {1} items.", ((XRLabel)sender).Tag, e.Value);
        }

    }
}
