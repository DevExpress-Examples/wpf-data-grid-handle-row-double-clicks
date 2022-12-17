Imports DevExpress.Xpf.Grid
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.Windows
Imports System.Windows.Controls

Namespace RowDoubleClick_CodeBehind

    Public Class Product

        Public Property ProductName As String

        Public Property Country As String

        Public Property City As String

        Public Property UnitPrice As Double

        Public Property Quantity As Integer
    End Class

    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
            Me.grid.ItemsSource = New ObservableCollection(Of Product)(GetProducts())
        End Sub

        Private Shared Iterator Function GetProducts() As IEnumerable(Of Product)
            Yield New Product() With {.ProductName = "Chang", .Country = "UK", .City = "Cowes", .UnitPrice = 19, .Quantity = 10}
            Yield New Product() With {.ProductName = "Gravad lax", .Country = "Italy", .City = "Reggio Emilia", .UnitPrice = 12.5, .Quantity = 16}
            Yield New Product() With {.ProductName = "Ravioli Angelo", .Country = "Brazil", .City = "Rio de Janeiro", .UnitPrice = 19, .Quantity = 12}
            Yield New Product() With {.ProductName = "Tarte au sucre", .Country = "Germany", .City = "QUICK-Stop", .UnitPrice = 22, .Quantity = 50}
            Yield New Product() With {.ProductName = "Steeleye Stout", .Country = "USA", .City = "Reggio Emilia", .UnitPrice = 18, .Quantity = 20}
            Yield New Product() With {.ProductName = "Pavlova", .Country = "Austria", .City = "Graz", .UnitPrice = 21, .Quantity = 52}
            Yield New Product() With {.ProductName = "Longlife Tofu", .Country = "USA", .City = "Boise", .UnitPrice = 7.75, .Quantity = 120}
            Yield New Product() With {.ProductName = "Alice Mutton", .Country = "Mexico", .City = "México D.F.", .UnitPrice = 21, .Quantity = 15}
            Yield New Product() With {.ProductName = "Alice Mutton", .Country = "Canada", .City = "Tsawwassen", .UnitPrice = 44, .Quantity = 16}
        End Function

        Private Sub OnRowDoubleClick(ByVal sender As Object, ByVal e As RowDoubleClickEventArgs)
            Dim rowHandle As Integer = e.HitInfo.RowHandle
            If rowHandle = DataControlBase.InvalidRowHandle Then Return
            If Me.grid.IsGroupRowHandle(rowHandle) Then
                MessageBox.Show("A group row has been double clicked.", "Info")
            Else
                MessageBox.Show("A data row has been double clicked.", "Info")
            End If
        End Sub
    End Class
End Namespace
