using Color = System.Windows.Media.Color;

namespace DocxEditor.Helpers
{
  /// <summary>
  /// Selects a style for PropertiesView name cell based on IPropertyVM properties.
  /// </summary>
  public class PropertiesViewNameCellStyleSelector : StyleSelector
  {
    /// <summary>
    /// if item is IPropertyVM and is empty, set foreground to light gray.
    /// </summary>
    /// <param name="item"></param>
    /// <param name="container"></param>
    /// <returns></returns>
    public override Style? SelectStyle(object item, DependencyObject container)
    {
      Style? style = null;
      IPropertyVM? propertyVM = null;
      if (item is TreeDataRow treeDataRow && treeDataRow.RowData is IPropertyVM node1)
      {
        propertyVM = node1;
        style = new Style(typeof(TreeGridCell));
      }
      else
      if (item is DataRow gridDataRow && gridDataRow.RowData is IPropertyVM node2)
      {
        propertyVM = node2;
        style = new Style(typeof(VirtualizingCellsControl));
      }

      if (style!=null)
      {
        if (propertyVM != null && propertyVM.IsEmpty)
        {
          var mediaColor = Colors.LightGray;
          style.Setters.Add(new Setter(Control.ForegroundProperty, new SolidColorBrush(mediaColor)));
        }
        return style;
      }
      return base.SelectStyle(item, container);
    }
  }
}