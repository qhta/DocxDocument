namespace ModelGenApp.Views;
/// <summary>
/// Interaction logic for EnumValuesView.xaml
/// </summary>
public partial class EnumValuesView : UserControl
{
  public EnumValuesView()
  {
    InitializeComponent();
    dataGridColumnCreator = new DataGridColumnCreator(MainDataGrid,
              typeof(EnumListViewModel), typeof(EnumInfoViewModel));
  }

  private DataGridColumnCreator dataGridColumnCreator;

  private void DataGrid_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs args)
  {
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
          { Source = DataContext, Converter = (IValueConverter)dataGrid.FindResource("BoolToVisibilityConverter"), ConverterParameter = "Collapsed,Visible" });
      }
  }
}
