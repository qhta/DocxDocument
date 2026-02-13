using DocumentFormat.OpenXml.Office.CustomDocumentInformationPanel;

using DocxEditor.Helpers;

using Qhta.ObservableObjects;

namespace DocxEditor.ViewModels;

/// <summary>
/// ViewModel for DocumentModel.DocumentProperties.
/// </summary>
public sealed class DocumentPropertiesVM : ViewModel
{
  /// <summary>
  /// Initializing constructor.
  /// </summary>
  /// <param name="document">Model view for the document.</param>
  public DocumentPropertiesVM(DocumentVM document)
  {
    DocumentModel = document;
    PropertiesProvider = new DocumentPropertiesProvider(DocumentModel.Document.KnownProperties);
  }

  /// <summary>
  /// Model collection of document properties.
  /// </summary>
  public DocumentVM DocumentModel { get; private set; }

  /// <summary>
  /// Provider for dynamic properties recognition needed by PropertyGrid.
  /// </summary>
  public DocumentPropertiesProvider PropertiesProvider { get; private set; }

  ///// <summary>
  ///// Populates the specified property grid with items that represent the known properties of the current document
  ///// model.
  ///// </summary>
  ///// <remarks>This method initializes the property grid with items based on the document's known properties,
  ///// allowing users to view and interact with the document's metadata or configurable attributes.</remarks>
  ///// <param name="propertyGrid">The property grid to populate with property items. Cannot be null.</param>
  //public void PopulateProperties(PropertyGrid propertyGrid)
  //{
  //  PropertiesProvider = new DocumentPropertiesProvider(DocumentModel.Document.KnownProperties);
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

  public CustomEditorCollection CustomEditors => _customEditors;

  private static CustomEditorCollection _customEditors = new CustomEditorCollection
  {
    new CustomEditor { PropertyType = typeof(int), EditorType = typeof(IntegerBaseTypeEditor), HasPropertyType = true },
    new CustomEditor { PropertyType = typeof(int?), EditorType = typeof(IntegerBaseTypeEditor), HasPropertyType = true }
  };
}
