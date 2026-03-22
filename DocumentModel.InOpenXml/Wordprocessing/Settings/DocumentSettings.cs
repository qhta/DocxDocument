using DocumentModel.CustomXml;
namespace DocumentModel.Wordprocessing;
/// <summary>
///   Specifies all document-level properties that affect the handling, behavior, and appearance of the current Wordprocessing document.
///   Provides access to settings for proofing, borders, custom XML, templates, protection, printing, captions, compatibility, styles, and more.
///   Enables advanced configuration and management of Wordprocessing document features.
/// </summary>
[OpenXmlType(typeof(DXW.Settings))]
public sealed partial class DocumentSettings: ModelElement<DXW.Settings>
{
  /// <summary>
  /// Known properties that can be set in DocumentSettings.
  /// </summary>
  public static KnownProperties KnownProperties
  {
    get
    {
      if (_KnownProperties == null)
        _KnownProperties = new KnownProperties(typeof(DocumentSettings));
      return _KnownProperties;
    }
  }
  private static KnownProperties? _KnownProperties;
  /// <summary>
  ///   Initializes a new instance of the <see cref="DocumentSettings"/> class with default values.
  /// </summary>
  public DocumentSettings()
  {
  }
  /// <summary>
  ///   Initializes a new instance of the <see cref="DocumentSettings"/> class and attaches it to the specified Wordprocessing document model.
  /// </summary>
  /// <param name="document">The Wordprocessing document model to attach to.</param>
  public DocumentSettings(Wordprocessing.Document document)
  {
    if (document.WordprocessingDocument != null)
      AttachAndLoad(document.WordprocessingDocument);
  }
  /// <summary>
  ///   Attaches this instance to the specified Wordprocessing document and loads data from the document's settings part.
  /// </summary>
  /// <param name="wordprocessingDocument">The document to attach to.</param>
  public override void AttachAndLoad(DXPP.WordprocessingDocument wordprocessingDocument)
  {
    base.AttachAndLoad(wordprocessingDocument);
    var documentSettings = wordprocessingDocument.GetDocumentSettings();
    SetUpdatableElement(documentSettings);
    LoadData(documentSettings);
  }
  /// <summary>
  ///   Attaches this instance to the specified Wordprocessing document and updates the document's settings part with current data.
  /// </summary>
  /// <param name="wordprocessingDocument">The document to attach to.</param>
  public override void AttachAndUpdate(DXPP.WordprocessingDocument wordprocessingDocument)
  {
    base.AttachAndUpdate(wordprocessingDocument);
    var documentSettings = wordprocessingDocument.GetDocumentSettings();
    SetUpdatableElement(documentSettings);
    UpdateData(documentSettings);
  }
}