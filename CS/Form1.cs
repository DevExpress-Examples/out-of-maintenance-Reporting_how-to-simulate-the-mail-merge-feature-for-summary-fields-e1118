using System;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
// ...

namespace MailMergeSummary {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            XtraReport1 report = new XtraReport1();

            using (ReportPrintTool printTool = new ReportPrintTool(report)) {
                // Invoke the Ribbon Print Preview form modally, 
                // and load the report document into it.
                printTool.ShowPreviewDialog();
            }
        }

    }
}