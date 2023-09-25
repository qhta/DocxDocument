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
    if (e.PropertyName==nameof(NamespaceConfigViewModel.ShortcutError))
    {
      BindingOperations.SetBinding(e.Column, DataGridColumn.VisibilityProperty, 
        new Binding("DataContext."+nameof(NamespacesConfigViewModel.AreAllShortcutsValid)) 
        { 
          Source = dummyElement,
          Converter=new BoolToVisibilityConverter(), 
          ConverterParameter="Visible,Collapsed" 
          });;
    }
    if (e.PropertyName==nameof(NamespaceConfigViewModel.TargetNameError))
    {
      BindingOperations.SetBinding(e.Column, DataGridColumn.VisibilityProperty, 
        new Binding("DataContext."+nameof(NamespacesConfigViewModel.AreAllTypesUnique)) 
        { 
          Source = dummyElement,
          Converter=new BoolToVisibilityConverter(), 
          ConverterParameter="Visible,Collapsed" 
          });;
    }
    if (e.PropertyName==nameof(NamespaceConfigViewModel.TargetShortcutError))
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
