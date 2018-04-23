Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Base

Namespace GridViewSaveChangesExample
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			' TODO: This line of code loads data into the 'nwindDataSet.Products' table. You can move, or remove it, as needed.
			Me.productsTableAdapter.Fill(Me.nwindDataSet.Products)

		End Sub

		Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
			Dim view As ColumnView = CType(gridControl1.FocusedView, ColumnView)
			view.CloseEditor()
			If view.UpdateCurrentRow() Then
				productsTableAdapter.Update(nwindDataSet.Products)
			End If
		End Sub
	End Class
End Namespace