Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraReports.UI
' ...

Namespace MailMergeSummary
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			Dim report As New XtraReport1()

			Using printTool As New ReportPrintTool(report)
				' Invoke the Ribbon Print Preview form modally, 
				' and load the report document into it.
				printTool.ShowPreviewDialog()
			End Using
		End Sub

	End Class
End Namespace