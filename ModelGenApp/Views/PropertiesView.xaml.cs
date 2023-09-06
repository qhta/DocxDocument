namespace ModelGenApp.Views;
/// <summary>
/// Interaction logic for PropertiesView.xaml
/// </summary>
public partial class PropertiesView : UserControl
{
  public PropertiesView()
  {
    InitializeComponent();
  }

  private DataGridColumnCreator dataGridColumnCreator = null!;

  private void DataGrid_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs args)
  {
    if (dataGridColumnCreator == null)
        dataGridColumnCreator = new DataGridColumnCreator(MainDataGrid,
          typeof(PropListViewModel), typeof(PropInfoViewModel));
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
          new Binding("Members.ShowAcceptedOnly") 
          { Source = DataContext, Converter = (IValueConverter)dataGrid.FindResource("BoolToVisibilityConverter"), ConverterParameter="Collapsed,Visible" });
      }
  }
}
