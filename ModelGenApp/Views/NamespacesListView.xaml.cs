
namespace ModelGenApp.Views;

public partial class NamespacesListView : UserControl
{
  public NamespacesListView()
  {
    InitializeComponent();
    dataGridColumnCreator = new DataGridColumnCreator(MainDataGrid, typeof(NamespacesViewModel), typeof(NamespaceViewModel))
    { IsFilterButtonVisible = true };
  }

  private DataGridColumnCreator dataGridColumnCreator = null!;

  private void DataGrid_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs args)
  {
    dataGridColumnCreator.GenerateColumn(sender, args);
    if (args.PropertyName==nameof(NamespaceViewModel.Name))
    {
      BindingOperations.SetBinding(args.Column, DataGridColumn.VisibilityProperty, 
        new Binding("DataContext."+nameof(NamespacesViewModel.ShowOriginalName)) 
        { 
          Source = dummyElement,
          Converter=new BoolToVisibilityConverter(), 
          ConverterParameter="Visible,Collapsed" 
          });
    }
    if (args.PropertyName==nameof(NamespaceViewModel.TargetName))
    {
      BindingOperations.SetBinding(args.Column, DataGridColumn.VisibilityProperty, 
        new Binding("DataContext."+nameof(NamespacesViewModel.ShowTargetName)) 
        { 
          Source = dummyElement,
          Converter=new BoolToVisibilityConverter(), 
          ConverterParameter="Visible,Collapsed" 
          });
    }

  }
}
