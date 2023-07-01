using System.Windows.Controls;
using System.Windows.Data;

namespace ModelGenApp.ViewHelpers;
public class NamespacePropertyBoundColumn : DataGridBoundColumn
{
  public DataTemplate ContentTemplate { get; set; } = null!;

  protected override FrameworkElement GenerateEditingElement(DataGridCell cell, object dataItem)
  {
    throw new NotImplementedException();
  }

  protected override FrameworkElement GenerateElement(DataGridCell cell, object dataItem)
  {
    var control = new ContentControl();
    control.ContentTemplate = ContentTemplate;
    BindingOperations.SetBinding(control, ContentControl.ContentProperty, Binding);
    //BindingOperations.SetBinding(cell, DataGridCell.ContentProperty, ClipboardContentBinding);
    return control;
  }
}