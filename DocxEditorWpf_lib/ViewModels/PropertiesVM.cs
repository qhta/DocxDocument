namespace DocxEditor;

/// <summary>
/// ViewModel for properties of document component.
/// </summary>
public sealed class PropertiesVM : ViewModel
{
  /// <summary>
  /// Initializing constructor.
  /// </summary>
  /// <param name="component">Component of the document, which properties will be provided.</param>
  public PropertiesVM(object component)
  {
    Component = component;
    PropertiesProvider = new PropertiesProvider(component);
  }

  /// <summary>
  /// Model collection of document properties.
  /// </summary>
  public object Component { get; private set; }

  /// <summary>
  /// Provider for dynamic properties recognition needed by PropertyGrid.
  /// </summary>
  public PropertiesProvider PropertiesProvider { get; private set; }

}
