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

  /// <summary>
  /// Handler for PropertyGrid's AutoGeneratingPropertyGridItem event, which is raised for each property item being generated.
  /// This handler sets a custom reset command for each property item, allowing users to reset the property value to its default state.
  /// The reset command is implemented using a DelegateCommand that calls the ResetItem method when executed
  /// and checks if the reset action can be performed using the CanResetItem method.
  /// </summary>
  /// <param name="sender">The PropertyGrid control.</param>
  /// <param name="e">Arguments for the event.</param>
  private void PropertyGrid_OnAutoGeneratingPropertyGridItem(object? sender, AutoGeneratingPropertyGridItemEventArgs e)
  {
    if (sender is not PropertyGrid propertyGrid)
      return;
    var propertyItem = e.OriginalSource as PropertyItem;

    if (propertyItem == null)
      return;
    if (propertyItem.PropertyType.Namespace!.StartsWith("DocumentFormat"))
    {
      e.Cancel = true;
      return;
    }

    var resetCommand = new Syncfusion.Windows.Shared.DelegateCommand(ResetItem, CanResetItem);
    typeof(PropertyItem).GetField("_resetCommand", BindingFlags.Instance | BindingFlags.NonPublic)!
      .SetValue(propertyItem, resetCommand);
    if (propertyItem.Name == "Revision")
    {
      Debug.Assert(true);
    }
  }

  /// <summary>
  /// Resets the value of the specified property item to its default state.
  /// This method is called when the reset command for a property item is executed.
  /// </summary>
  /// <param name="propertyItem"></param>
  private void ResetItem(object propertyItem)
  {
    if (propertyItem is PropertyItem item)
    {
      item.SetValue(PropertyItem.ValueProperty, item.DefaultValue);
    }
  }

  /// <summary>
  /// Returns a boolean value indicating whether the specified property item can be reset to its default state.
  /// </summary>
  /// <param name="propertyItem"></param>
  /// <returns></returns>
  private bool CanResetItem(object propertyItem)
  {
    return true;
  }

  //private void PropertyGrid_OnDataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
  //{
  //  if (sender is PropertyGrid aPropertyGrid && propertyGrid.DataContext is DocumentPropertiesVM viewModel)
  //  {
  //    viewModel.PopulateProperties(aPropertyGrid);
  //  }
  //}
}
