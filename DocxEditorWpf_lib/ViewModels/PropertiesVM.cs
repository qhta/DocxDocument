using DocxEditor.Helpers;

namespace DocxEditor.ViewModels;

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

  ///// <summary>
  ///// Populates the specified property grid with items that represent the known properties of the current document
  ///// model.
  ///// </summary>
  ///// <remarks>This method initializes the property grid with items based on the document's known properties,
  ///// allowing users to view and interact with the document's metadata or configurable attributes.</remarks>
  ///// <param name="propertyGrid">The property grid to populate with property items. Cannot be null.</param>
  //public void PopulateProperties(PropertyGrid propertyGrid)
  //{
  //  PropertiesProvider = new DocumentPropertiesProvider(Component.Document.KnownProperties);
  //  foreach (var property in PropertiesProvider.Models)
  //  {
  //    propertyGrid.Items.Add(new PropertyGridItem
  //    {
  //      PropertyName = property.Name,
  //      PropertyType = property.PropertyType,
  //    }
  //    );
  //  }
  //}

  /// <summary>
  /// Custom editors for known property types.
  /// </summary>
  public CustomEditorCollection CustomEditors => _customEditors;

  private static CustomEditorCollection _customEditors = new CustomEditorCollection
  {
    new CustomEditor { PropertyType = typeof(int), EditorType = typeof(IntegerBaseTypeEditor), HasPropertyType = true },
    new CustomEditor { PropertyType = typeof(int?), EditorType = typeof(IntegerBaseTypeEditor), HasPropertyType = true }
  };
}
