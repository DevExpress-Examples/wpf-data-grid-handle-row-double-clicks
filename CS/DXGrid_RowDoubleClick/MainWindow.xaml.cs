using System.Windows;
using System.Windows.Input;
using DevExpress.Xpf.Grid;

namespace DXGrid_RowDoubleClick {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            grid.DataSource = new ProductList();
        }

        private void grid_MouseDoubleClick(object sender, MouseButtonEventArgs e) {
            int rowHandle = tView.GetRowHandleByMouseEventArgs(e);
            if (rowHandle == GridControl.InvalidRowHandle) return;
            if(grid.IsGroupRowHandle(rowHandle))
                MessageBox.Show("A group row has been double clicked.", "Info");
            else
                MessageBox.Show("A data row has been double clicked.", "Info");
        }
    }
}
