using Color = System.Windows.Media.Color;

namespace DocxEditor.Helpers
{
  /// <summary>
  /// Selects a style for TreeGrid rows based on IPropertyVM properties.
  /// </summary>
  public class PropertiesViewRowStyleSelector : StyleSelector
  {
    /// <summary>
    /// Selects a style for TreeGrid rows based on IPropertyVM properties.
    /// </summary>
    /// <param name="item"></param>
    /// <param name="container"></param>
    /// <returns></returns>
    public override Style? SelectStyle(object item, DependencyObject container)
    {
      string? backgroundColor = null;
      Style? style = null;
      IPropertyVM? propertyVM = null;
      if (item is TreeDataRow treeDataRow && treeDataRow.RowData is IPropertyVM node1)
      {
        propertyVM = node1;
        style = new Style(typeof(TreeGridRowControl));
      }
      else
      if (item is DataRow gridDataRow && gridDataRow.RowData is IPropertyVM node2)
      {
        propertyVM = node2;
        style = new Style(typeof(VirtualizingCellsControl));
      }

      if (propertyVM != null)
      {
        var propertyInfo = propertyVM.GetType().GetProperty("BackgroundColor");
        if (propertyInfo != null)
        {
          backgroundColor = propertyInfo.GetValue(propertyVM) as string;
        }
        if (propertyVM.IsEmpty) { }
      }
      if (style!=null)
      {
        if (backgroundColor != null)
        {
          var mediaColor = (Color)System.Windows.Media.ColorConverter.ConvertFromString(backgroundColor);
          style.Setters.Add(new Setter(Control.BackgroundProperty, new SolidColorBrush(mediaColor)));
          if (IsColorDark(mediaColor))
          {
            style.Setters.Add(new Setter(Control.ForegroundProperty, Brushes.White));
          }
          else
          {
            style.Setters.Add(new Setter(Control.ForegroundProperty, Brushes.Black));
          }
        }
        return style;
      }
      return base.SelectStyle(item, container);
    }

    private static bool IsColorDark(Color color)
    {
      // Calculate luminance
      double luminance = (0.299 * color.R + 0.587 * color.G + 0.114 * color.B) / 255;
      return luminance < 0.5; // Dark if luminance is less than 0.5
    }

  }
}