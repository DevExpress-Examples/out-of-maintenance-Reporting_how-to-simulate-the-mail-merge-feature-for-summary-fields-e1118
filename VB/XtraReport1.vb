Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraReports.UI
' ...

Namespace MailMergeSummary
	Partial Public Class XtraReport1
		Inherits DevExpress.XtraReports.UI.XtraReport
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub xrLabel2_SummaryCalculated(ByVal sender As Object, ByVal e As TextFormatEventArgs) Handles xrLabel2.SummaryCalculated
			e.Text = String.Format("Category #{0} contains {1} items.", (CType(sender, XRLabel)).Tag, e.Value)
		End Sub

	End Class
End Namespace
