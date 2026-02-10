using System.Reflection;

using DocxEditor.Helpers;
using DocxEditor.ViewModels;

using Syncfusion.Windows.PropertyGrid;
using Syncfusion.Windows.Shared;

namespace DocxEditor.Views;
/// <summary>
/// View for displaying and editing document properties.
/// </summary>
public partial class DocumentPropertiesView : UserControl
{
  //PropertiesProvider propertiesProvider = new PropertiesProvider();
  /// <summary>
  /// Initializing constructor.
  /// </summary>
  public DocumentPropertiesView()
  {
    InitializeComponent();
  }

  private void PropertyGrid_OnAutoGeneratingPropertyGridItem(object? sender, AutoGeneratingPropertyGridItemEventArgs e)
  {
    var propertyItem = e.OriginalSource as PropertyItem;
    var resetCommand = new Syncfusion.Windows.Shared.DelegateCommand(ResetItem, CanResetItem);
    typeof(PropertyItem).GetField("_resetCommand", BindingFlags.Instance | BindingFlags.NonPublic)!.SetValue(propertyItem, resetCommand);
  }

  private void ResetItem(object propertyItem)
  {
    if (propertyItem is PropertyItem item)
    {
      item.SetValue(PropertyItem.ValueProperty, null);
    }
  }

  private bool CanResetItem(object propertyItem)
  {
    return true;
  }
}
