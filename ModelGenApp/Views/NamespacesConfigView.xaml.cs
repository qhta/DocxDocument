namespace ModelGenApp.Views;

public partial class NamespacesConfigView : UserControl
{
  public NamespacesConfigView()
  {
    InitializeComponent();
    dataGridColumnCreator =  new DataGridColumnCreator(MainDataGrid, typeof(NamespaceConfigListViewModel), typeof(NamespaceConfigViewModel)) 
    { IsFilterButtonVisible = true };
  }

  private DataGridColumnCreator dataGridColumnCreator = null!;

  private void DataGrid_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
  {
    dataGridColumnCreator.GenerateColumn(sender, e);
    if (e.PropertyName==nameof(NamespaceConfigViewModel.ShortcutError))
    {
      BindingOperations.SetBinding(e.Column, DataGridColumn.VisibilityProperty, 
        new Binding("DataContext."+nameof(NamespaceConfigListViewModel.AreAllShortcutsValid)) 
        { 
          Source = dummyElement,
          Converter=new BoolToVisibilityConverter(), 
          ConverterParameter="Visible,Collapsed" 
          });;
    }
    if (e.PropertyName==nameof(NamespaceConfigViewModel.TargetNameError))
    {
      BindingOperations.SetBinding(e.Column, DataGridColumn.VisibilityProperty, 
        new Binding("DataContext."+nameof(NamespaceConfigListViewModel.AreAllTypesUnique)) 
        { 
          Source = dummyElement,
          Converter=new BoolToVisibilityConverter(), 
          ConverterParameter="Visible,Collapsed" 
          });;
    }
    if (e.PropertyName==nameof(NamespaceConfigViewModel.TargetShortcutError))
    {
      BindingOperations.SetBinding(e.Column, DataGridColumn.VisibilityProperty, 
        new Binding("DataContext."+nameof(NamespaceConfigListViewModel.AreAllTargetShortcutsValid)) 
        { 
          Source = dummyElement,
          Converter=new BoolToVisibilityConverter(), 
          ConverterParameter="Visible,Collapsed" 
          });;
    }
  }
}
