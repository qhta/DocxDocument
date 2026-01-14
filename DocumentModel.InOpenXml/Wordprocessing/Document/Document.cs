namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a Wordprocessing document and provides access to its settings and lifecycle management.
/// </summary>
public class Document : ModelElement, IDisposable
{
  /// <summary>
  /// The underlying OpenXml WordprocessingDocument instance.
  /// </summary>
  internal DXPP.WordprocessingDocument? WordprocessingDocument { get; private set; }

  /// <summary>
  /// Initializes a new instance of the Document class.
  /// </summary>
  public Document()
  {

  }

  /// <summary>
  /// Creates a new Wordprocessing document at the specified file path.
  /// </summary>
  /// <param name="filePath">The file path for the new document.</param>
  /// <returns>A new Document instance.</returns>
  public static Document CreateDocument(string filePath)
  {
    var newDocument = new Document();
    newDocument.WordprocessingDocument = WordprocessingHelper.CreateWordDocument(filePath);
    return newDocument;
  }

  /// <summary>
  /// Releases resources used by the document and notifies property change.
  /// </summary>
  public void Dispose()
  {
    WordprocessingDocument?.Dispose();
    WordprocessingDocument = null;
    NotifyPropertyChanged(nameof(WordprocessingDocument));
  }

  /// <summary>
  /// Provides access to document-level settings and properties.
  /// </summary>
  public DocumentSettings DocumentSettings { get; private set; } = new DocumentSettings();
}