using DocxEditor.Helpers;

namespace DocxEditor.ViewModels;

/// <summary>
/// ViewModel for DocumentModel.DocumentProperties.
/// </summary>
public sealed class DocumentPropertiesVM : ObservableCollection<DocumentPropertyVM>
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

}
