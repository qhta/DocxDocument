namespace ModelGenApp.Views;

public partial class NamespacesConfigView : UserControl
{
  public NamespacesConfigView()
  {
    InitializeComponent();
    dataGridColumnCreator = new DataGridColumnCreator(MainDataGrid, typeof(NamespacesConfigListViewModel), typeof(NamespaceConfigViewModel))
    { IsFilterButtonVisible = true };
  }

  private DataGridColumnCreator dataGridColumnCreator = null!;

  private void DataGrid_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs args)
  {
    dataGridColumnCreator.GenerateColumn(sender, args);
    if (args.PropertyName == nameof(NamespaceConfigViewModel.ShortcutError))
    {
      BindingOperations.SetBinding(args.Column, DataGridColumn.VisibilityProperty,
        new Binding("DataContext." + nameof(NamespacesConfigListViewModel.AreAllShortcutsValid))
        {
          Source = dummyElement,
          Converter = new BoolToVisibilityConverter(),
          ConverterParameter = "Visible,Collapsed"
        });
    }
    if (args.PropertyName == nameof(NamespaceConfigViewModel.TargetNameError))
    {
      BindingOperations.SetBinding(args.Column, DataGridColumn.VisibilityProperty,
        new Binding("DataContext." + nameof(NamespacesConfigListViewModel.AreAllTypesUnique))
        {
          Source = dummyElement,
          Converter = new BoolToVisibilityConverter(),
          ConverterParameter = "Visible,Collapsed"
        });
    }
    if (args.PropertyName == nameof(NamespaceConfigViewModel.TargetShortcutError))
    {
      BindingOperations.SetBinding(args.Column, DataGridColumn.VisibilityProperty,
        new Binding("DataContext." + nameof(NamespacesConfigListViewModel.AreAllTargetShortcutsValid))
        {
          Source = dummyElement,
          Converter = new BoolToVisibilityConverter(),
          ConverterParameter = "Visible,Collapsed"
        });
    }
    if (args.PropertyType == typeof(bool))
    {
      if (args.Column is DataGridCheckBoxColumn checkBoxColumn)
      {
        (checkBoxColumn.Binding as Binding)!.BindsDirectlyToSource = true;
      }
    }
  }
}
