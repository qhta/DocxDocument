namespace ModelGenApp.Views;

public partial class NamespacesConfigView : UserControl
{
  public NamespacesConfigView()
  {
    InitializeComponent();
  }

  private void DataGrid_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
  {
    DataGridColumnCreator.GenerateColumn(sender, e);
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

  private void DataGrid_FilterButtonClick(object sender, RoutedEventArgs e)
  {

  }
}
