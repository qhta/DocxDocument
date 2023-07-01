using System.Windows.Controls;
using System.Windows.Data;

using ModelGenApp.ViewHelpers;
using ModelGenApp.ViewModels;

namespace ModelGenApp.Views;
/// <summary>
/// Interaction logic for PhaseResultsView.xaml
/// </summary>
public partial class PhaseResultsView : UserControl
{
  public PhaseResultsView()
  {
    InitializeComponent();
  }

  private void DataGrid_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
  {
    if (e.PropertyType == typeof(TypeListViewModel))
    {
      var str = ((string)e.Column.Header).ReplaceEnd("Count", "");
      var ss = str.SplitCamelCase();
      for (int i = 1; i < ss.Length; i++)
        ss[i] = ss[i].ToLower();
      e.Column.Header = String.Join(" ", ss);

      DataTemplate? template = (DataTemplate)Resources["SpecificColumnTemplate"];
      if (template != null)
      {
        var aColumn = (DataGridBoundColumn)e.Column;
        var col = new NamespacePropertyBoundColumn();
        var aBinding = (Binding)aColumn.Binding;
        col.Binding = aBinding;
        col.ContentTemplate = template;
        col.Header = e.Column.Header;
        col.SortMemberPath = aBinding.Path.Path + ".Count";
        col.ClipboardContentBinding =
            new Binding
            {
              Source = aBinding.Source,
              Path = new PropertyPath(aBinding.Path.Path + ".Count"),
            };
        col.CopyingCellClipboardContent += Col_CopyingCellClipboardContent;
        e.Column = col;
      }
    }
    else
      e.Cancel = true;
  }

  private void Col_CopyingCellClipboardContent(object? sender, DataGridCellClipboardEventArgs e)
  {
    var column = sender as NamespacePropertyBoundColumn;
    if (column != null)
    {
      var obj = e.Item;
      if (obj != null)
      {
        var binding = (column.ClipboardContentBinding as Binding);
        if (binding != null)
        {
          string boundProperty = binding.Path.Path;
          object? value = GetPropertyWithPath(obj, boundProperty);
            if (value != null)
          {
            var propertyValue = value.ToString();
            e.Content = propertyValue;
          }
        }
      }
    }
  }

  private static object? GetPropertyWithPath(object obj, string aPath)
  {
    var k = aPath.IndexOf(".");
    if (k > 0)
    {
      var propName = aPath.Substring(0, k);
      aPath = aPath.Substring(k + 1);
      PropertyInfo? pi = obj.GetType().GetProperty(propName);
      if (pi != null)
      {
        object? value = pi.GetValue(obj);
        if (value != null)
        {
          var propertyValue = GetPropertyWithPath(value, aPath);
          return propertyValue;
        }
      }
    }
    else
    {
      PropertyInfo? pi = obj.GetType().GetProperty(aPath);
      if (pi != null)
      {
        object? value = pi.GetValue(obj);
        if (value != null)
        {
          var propertyValue = value.ToString();
          return propertyValue;
        }
      }
    }
    return null;
  }
}
