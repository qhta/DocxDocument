namespace ModelGenApp.Views;

/// <summary>
/// View of all properties of all classes.
/// </summary>
public partial class PropListView : UserControl
{
  public PropListView()
  {
    InitializeComponent();
  }

  private DataGridColumnCreator dataGridColumnCreator = null!;

  private void DataGrid_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs args)
  {
    if (args.PropertyName==nameof(PropInfoViewModel.Owner)
     || args.PropertyName==nameof(PropInfoViewModel.TypeNameSelector))
    {
      args.Cancel = true;
      return;
    }
    if (dataGridColumnCreator == null)
    {
      dataGridColumnCreator = new DataGridColumnCreator(MainDataGrid,
          typeof(PropListViewModel), typeof(PropInfoViewModel));
    }
    dataGridColumnCreator.GenerateColumn(sender, args);
    if (sender is DataGrid dataGrid)
      if (args.PropertyName.EndsWith("DeclaringType"))
      {
        BindingOperations.SetBinding(args.Column, DataGridColumn.VisibilityProperty,
          new Binding("Properties.ShowDeclaringType") 
          { Source = DataContext, Converter = (IValueConverter)dataGrid.FindResource("BoolToVisibilityConverter") });
      }
      else
      if (args.PropertyName == "Acceptance")
      {
        BindingOperations.SetBinding(args.Column, DataGridColumn.VisibilityProperty,
          new Binding("Properties.ShowAcceptedOnly") 
          { Source = DataContext, Converter = (IValueConverter)dataGrid.FindResource("BoolToVisibilityConverter"), ConverterParameter="Collapsed,Visible" });
      }
  }
}
