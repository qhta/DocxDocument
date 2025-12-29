namespace DocxEd.Views;
/// <summary>
/// Interaction logic for TypeRelationshipsView.xaml
/// </summary>
public partial class TypeRelationshipsView : UserControl
{
  public TypeRelationshipsView()
  {
    InitializeComponent();
    dataGridColumnCreator = new DataGridColumnCreator(MainDataGrid,
              typeof(TypeRelationshipsListViewModel), typeof(TypeRelationshipViewModel));
  }

  private DataGridColumnCreator dataGridColumnCreator = null!;

  private void DataGrid_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs args)
  {
    dataGridColumnCreator.GenerateColumn(sender, args);
    if (sender is DataGrid dataGrid)
      if (args.PropertyName == "Acceptance")
      {
        BindingOperations.SetBinding(args.Column, DataGridColumn.VisibilityProperty,
          new Binding("Members.ShowAcceptedOnly")
          { Source = DataContext, Converter = (IValueConverter)dataGrid.FindResource("BoolToVisibilityConverter"), ConverterParameter = "Collapsed,Visible" });
      }
  }

}
