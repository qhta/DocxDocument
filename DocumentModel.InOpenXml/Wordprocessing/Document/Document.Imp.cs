namespace DocumentModel.Wordprocessing;
public partial class Document: DocumentModel.Interfaces.Word.Document
{
  /// <summary>
  /// Provides access to the built-in document properties of the specified document.
  /// </summary>
  public Interfaces.DocumentProperties BuiltInDocumentProperties { get; }
  /// <summary>
  /// Gets the collection of custom document properties associated with the document.
  /// </summary>
  public Interfaces.DocumentProperties CustomDocumentProperties { get; }
}