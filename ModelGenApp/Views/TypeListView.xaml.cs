namespace ModelGenApp.Views;
/// <summary>
/// Interaction logic for TypeListView.xaml
/// </summary>
public partial class TypeListView : UserControl
{
  public TypeListView()
  {
    InitializeComponent();
  }

  private DataGridColumnCreator dataGridColumnCreator = null!;

  private void DataGrid_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs args)
  {
    if (dataGridColumnCreator == null)
    {
      if (DataContext is ClassListViewModel)
        dataGridColumnCreator = new DataGridColumnCreator(MainDataGrid,
          typeof(ClassListViewModel), typeof(ClassInfoViewModel));
      else
      if (DataContext is EnumTypeListViewModel)
        dataGridColumnCreator = new DataGridColumnCreator(MainDataGrid,
          typeof(EnumTypeListViewModel), typeof(EnumTypeInfoViewModel));
      else
        dataGridColumnCreator = new DataGridColumnCreator(MainDataGrid, 
          typeof(TypeListViewModel), typeof(TypeInfoViewModel));
    }
    dataGridColumnCreator.GenerateColumn(sender, args);
    if (args.PropertyName==nameof(TypeInfoViewModel.TargetName))
    {
      BindingOperations.SetBinding(args.Column, DataGridColumn.VisibilityProperty, 
        new Binding("DataContext."+nameof(TypeListViewModel.ShowTargetName)) 
        { 
          Source = dummyElement,
          Converter=new BoolToVisibilityConverter(), 
          ConverterParameter="Visible,Collapsed" 
          });
    }
    if (args.PropertyName==nameof(TypeInfoViewModel.TargetType))
    {
      BindingOperations.SetBinding(args.Column, DataGridColumn.VisibilityProperty, 
        new Binding("DataContext."+nameof(TypeListViewModel.ShowTargetType)) 
        { 
          Source = dummyElement,
          Converter=new BoolToVisibilityConverter(), 
          ConverterParameter="Visible,Collapsed" 
          });
    }    if (args.PropertyName==nameof(TypeInfoViewModel.ValidationError))
    {
      BindingOperations.SetBinding(args.Column, DataGridColumn.VisibilityProperty, 
        new Binding("DataContext."+nameof(TypeListViewModel.HasAnyInvalidTypes)) 
        { 
          Source = dummyElement,
          Converter=new BoolToVisibilityConverter(), 
          ConverterParameter="Visible,Collapsed" 
          });
    }
  }

}