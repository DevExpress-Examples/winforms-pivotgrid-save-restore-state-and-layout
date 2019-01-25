Imports System
Imports System.IO
Imports System.Windows.Forms
Imports DevExpress.Utils

Namespace XtraPivotGrid_SaveLoadCollapsedState
	Partial Public Class Form1
		Inherits Form

		Private layoutStream As New MemoryStream()
		Private collapseStateStream As New MemoryStream()
		Public Sub New()
			InitializeComponent()
			btnClear.Enabled = False
		End Sub
		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
			Dim adapter As New nwindDataSetTableAdapters.ProductReportsTableAdapter()
			pivotGridControl1.DataSource = adapter.GetData()
		End Sub
		Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
			If pivotGridControl1.Fields.Count > 0 Then
				layoutStream.Dispose()
				layoutStream = New MemoryStream()
				pivotGridControl1.SaveLayoutToStream(layoutStream, OptionsLayoutBase.FullLayout)
				collapseStateStream.Dispose()
				collapseStateStream = New MemoryStream()
				pivotGridControl1.SaveCollapsedStateToStream(collapseStateStream)
				btnClear.Enabled = True
			End If
		End Sub
		Private Sub btnLoad_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLoad.Click
			If layoutStream.Length > 0 AndAlso collapseStateStream.Length > 0 Then
				layoutStream.Seek(0, SeekOrigin.Begin)
				pivotGridControl1.RestoreLayoutFromStream(layoutStream, OptionsLayoutBase.FullLayout)
				collapseStateStream.Seek(0, SeekOrigin.Begin)
				pivotGridControl1.LoadCollapsedStateFromStream(collapseStateStream)
			End If
		End Sub
		Private Sub btnClear_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClear.Click
			If layoutStream.Length > 0 AndAlso collapseStateStream.Length > 0 Then
				pivotGridControl1.Fields.Clear()
			End If
		End Sub
	End Class
End Namespace