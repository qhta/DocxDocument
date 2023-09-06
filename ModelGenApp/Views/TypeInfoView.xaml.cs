namespace ModelGenApp.Views;

public partial class TypeInfoView : UserControl
{
  public TypeInfoView()
  {
    InitializeComponent();
  }

  //private DataGridColumnCreator dataGridColumnCreator = null!;

  //private void DataGrid_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs args)
  //{
  //  if (dataGridColumnCreator == null)
  //  {
  //    if (DataContext is ClassInfoViewModel)
  //      dataGridColumnCreator = new DataGridColumnCreator(MainDataGrid,
  //        typeof(PropListViewModel), typeof(PropInfoViewModel));
  //    else if (DataContext is EnumTypeInfoViewModel)
  //      dataGridColumnCreator = new DataGridColumnCreator(MainDataGrid,
  //        typeof(EnumListViewModel), typeof(EnumInfoViewModel));
  //    else
  //      return;
  //  }
  //  dataGridColumnCreator.GenerateColumn(sender, args);
  //  if (sender is DataGrid dataGrid)
  //    if (args.PropertyName.EndsWith("DeclaringType"))
  //    {
  //      BindingOperations.SetBinding(args.Column, DataGridColumn.VisibilityProperty,
  //        new Binding("Properties.ShowDeclaringType") 
  //        { Source = DataContext, Converter = (IValueConverter)dataGrid.FindResource("BoolToVisibilityConverter") });
  //    }
  //    else
  //    if (args.PropertyName == "Acceptance")
  //    {
  //      BindingOperations.SetBinding(args.Column, DataGridColumn.VisibilityProperty,
  //        new Binding("Members.ShowAcceptedOnly") 
  //        { Source = DataContext, Converter = (IValueConverter)dataGrid.FindResource("BoolToVisibilityConverter"), ConverterParameter="Collapsed,Visible" });
  //    }
  //}
}

