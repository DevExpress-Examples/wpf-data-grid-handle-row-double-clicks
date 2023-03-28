Imports System.Windows
Imports System.Windows.Input
Imports DevExpress.Xpf.Grid

Namespace DXGrid_RowDoubleClick

    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
            Me.grid.ItemsSource = New ProductList()
        End Sub

        Private Sub grid_MouseDoubleClick(ByVal sender As Object, ByVal e As MouseButtonEventArgs)
            Dim rowHandle As Integer = Me.tView.GetRowHandleByMouseEventArgs(e)
            If rowHandle = DataControlBase.InvalidRowHandle Then Return
            If Me.grid.IsGroupRowHandle(rowHandle) Then
                MessageBox.Show("A group row has been double clicked.", "Info")
            Else
                MessageBox.Show("A data row has been double clicked.", "Info")
            End If
        End Sub
    End Class
End Namespace
