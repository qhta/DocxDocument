namespace ModelGenApp.Views;

public partial class NamespacesConfigView : UserControl
{
  public NamespacesConfigView()
  {
    InitializeComponent();
    dataGridColumnCreator =  new DataGridColumnCreator(MainDataGrid, typeof(NamespacesConfigViewModel), typeof(NamespaceConfigViewModel)) 
    { IsFilterButtonVisible = true };
  }

  private DataGridColumnCreator dataGridColumnCreator = null!;

  private void DataGrid_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
  {
    dataGridColumnCreator.GenerateColumn(sender, e);
    if (e.PropertyName==nameof(NamespaceConfigViewModel.ShortcutErrorMsg))
    {
      BindingOperations.SetBinding(e.Column, DataGridColumn.VisibilityProperty, 
        new Binding("DataContext."+nameof(NamespacesConfigViewModel.AreAllShortcutsValid)) 
        { 
          Source = dummyElement,
          Converter=new BoolToVisibilityConverter(), 
          ConverterParameter="Visible,Collapsed" 
          });;
    }
    if (e.PropertyName==nameof(NamespaceConfigViewModel.TargetShortcutErrorMsg))
    {
      BindingOperations.SetBinding(e.Column, DataGridColumn.VisibilityProperty, 
        new Binding("DataContext."+nameof(NamespacesConfigViewModel.AreAllTargetShortcutsValid)) 
        { 
          Source = dummyElement,
          Converter=new BoolToVisibilityConverter(), 
          ConverterParameter="Visible,Collapsed" 
          });;
    }
  }
}
