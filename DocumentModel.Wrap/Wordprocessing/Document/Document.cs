namespace DocumentModel.Wordprocessing;

/// <summary>
///   Document.
/// </summary>
public partial class Document: ModelElement, IDisposable
{
  /// <summary>
  /// Gets wrapped WordprocessingDocument.
  /// </summary>
  public DXPack.WordprocessingDocument WordprocessingDocument { get; private set; }

  /// <summary>
  /// Gets wrapped WordprocessingDocument document.
  /// </summary>
  public DXW.Document DocxDocument { get; private set; }

  /// <summary>
  /// Gets wrapped WordprocessingDocument document body.
  /// </summary>
  public DXW.Body DocxBody { get; private set; } = null!;

  /// <summary>
  /// Specifies is WordprocessingDocument is editable;
  /// </summary>
  public bool IsEditable { get; private set; }

  /// <summary>
  /// Constructor based on a document filename. The file is staying opened.
  /// </summary>
  /// <param name="filename">Specifies the name of the Wordprocessing document file.</param>
  /// <param name="isEditable">Specifies whether the wordprocessing document can be edited.</param>
  public Document(string filename, bool isEditable = false) : this(DXPack.WordprocessingDocument.Open(filename, isEditable))
  {
    IsEditable = isEditable;
  }

  /// <summary>
  /// Constructor based on existring wordprocessing document.
  /// </summary>
  /// <param name="wordprocessingDocument">Specifies the the Wordprocessing document.</param>
  /// <param name="isEditable">Specifies whether the wordprocessing document can be edited.</param>
  public Document(DXPack.WordprocessingDocument wordprocessingDocument, bool isEditable = false)
  {
    IsEditable = isEditable;
    WordprocessingDocument = wordprocessingDocument;
    var mainDocumentPart = WordprocessingDocument.MainDocumentPart;
    if (mainDocumentPart == null)
    {
      WordprocessingDocument.AddMainDocumentPart();
      mainDocumentPart = WordprocessingDocument.MainDocumentPart;
    }
    Debug.Assert(mainDocumentPart != null, "MainDocumentPart does not exist");
    DocxDocument = mainDocumentPart.Document;
    if (DocxDocument == null)
      DocxDocument = mainDocumentPart.Document = new DXW.Document();
    Debug.Assert(DocxDocument != null, "MainDocumentPart.Document does not exist");
    var docxBody = DocxDocument.Body;
    if (docxBody == null)
      docxBody = DocxDocument.Body = new DXW.Body();
    DocxBody = docxBody;
    Debug.Assert(DocxBody != null, "MainDocumentPart.Document.Body does not exist");
    Body = new Body(docxBody);
  }

  /// <summary>
  ///   conformance
  /// </summary>
  public DocumentConformance? Conformance { get; set; }

  /// <summary>
  ///   Document Background.
  /// </summary>
  public DocumentBackground? DocumentBackground { get; set; }

  /// <summary>
  ///   Body.
  /// </summary>
  public Body Body { get; set; }


#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

  #region IDisposable interface implementation
  private bool disposedValue;
  protected virtual void Dispose(bool disposing)
  {
    if (!disposedValue)
    {
      if (disposing)
      {
        if (IsEditable)
          WordprocessingDocument.Save();
        WordprocessingDocument.Dispose();
      }

      // TODO: free unmanaged resources (unmanaged objects) and override finalizer
      // TODO: set large fields to null
      disposedValue = true;
    }
  }

  // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
  // ~Document()
  // {
  //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
  //     Dispose(disposing: false);
  // }

  public void Dispose()
  {
    // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
    Dispose(disposing: true);
    GC.SuppressFinalize(this);
  }
  #endregion

}