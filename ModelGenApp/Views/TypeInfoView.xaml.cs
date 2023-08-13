using System.Windows.Data;

using Qhta.WPF.Converters;

namespace ModelGenApp.Views;

public partial class TypeInfoView : UserControl
{
  public TypeInfoView()
  {
    InitializeComponent();
  }

  private void DataGrid_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs args)
  {
    DataGridColumnCreator.GenerateColumn(sender, args);
    if (sender is DataGrid dataGrid)
      if (DataContext is ClassInfoViewModel)
      {
        if (args.Column is DataGridBoundColumn dataGridBoundColumn)
        {
          if (dataGridBoundColumn.Binding is Binding binding
              && binding.Path.Path.EndsWith("DeclaringType"))
          {
            BindingOperations.SetBinding(dataGridBoundColumn, DataGridColumn.VisibilityProperty,
              new Binding("Properties.ShowDeclaringType") { Source = DataContext, Converter = (IValueConverter)dataGrid.FindResource("BoolToVisibilityConverter") });
          }
        }
      }
  }
}
