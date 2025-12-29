using DocxEd.ViewModels;
using Qhta.WPF.Utils;

namespace DocxEd.Views;

/// <summary>
/// Interaction logic for ErrorList.xaml
/// </summary>
public partial class ErrorListView : UserControl
{
  public ErrorListView()
  {
    InitializeComponent();
    dataGridColumnCreator = new DataGridColumnCreator(MainDataGrid, typeof(ErrorListViewModel), typeof(ErrorViewModel))
    { IsFilterButtonVisible = true };
  }

  private DataGridColumnCreator dataGridColumnCreator = null!;

  private void DataGrid_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
  {
    dataGridColumnCreator.GenerateColumn(sender, e);

  }
}
