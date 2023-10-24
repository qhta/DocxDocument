namespace DocumentModel.Wordprocessing;
public partial class DocxDocument : IDisposable
{
#pragma warning disable CS0618 // Type or member is obsolete
  public DocxDocument(DXP.WordprocessingDocument wordprocessingDocument)
  {
    WordprocessingDocument = wordprocessingDocument;
  }
#pragma warning restore CS0618 // Type or member is obsolete

  private DXP.WordprocessingDocument WordprocessingDocument;

  #region Open/Create static methods
  public static DocxDocument Open(string path, bool isEditable)
    => Open(path, isEditable, new DXP.OpenSettings());

  public static DocxDocument Open(string path, bool isEditable, DXP.OpenSettings openSettings)
  {
    var wordprocessingDocument = DXP.WordprocessingDocument.Open(path, isEditable, openSettings);
    return new DocxDocument(wordprocessingDocument);
  }

  public static DocxDocument Open(Stream stream, bool isEditable)
    => Open(stream, isEditable, new DXP.OpenSettings());

  public static DocxDocument Open(Stream stream, bool isEditable, DXP.OpenSettings openSettings)
  {
    var wordprocessingDocument = DXP.WordprocessingDocument.Open(stream, isEditable, openSettings);
    return new DocxDocument(wordprocessingDocument);
  }

  public static DocxDocument Open(Package stream)
    => Open(stream, new DXP.OpenSettings());

  public static DocxDocument Open(Package stream, DXP.OpenSettings openSettings)
  {
    var wordprocessingDocument = DXP.WordprocessingDocument.Open(stream, openSettings);
    return new DocxDocument(wordprocessingDocument);
  }

  public static DocxDocument Create(string path, DX.WordprocessingDocumentType type)
      => Create(path, type, true);

  public static DocxDocument Create(Stream stream, DX.WordprocessingDocumentType type)
      => Create(stream, type, true);

  public static DocxDocument Create(Package package, DX.WordprocessingDocumentType type)
      => Create(package, type, true);


  public static DocxDocument Create(string path, DX.WordprocessingDocumentType type, bool autoSave)
  {
    var wordprocessingDocument = DXP.WordprocessingDocument.Create(path, type, autoSave);
    return new DocxDocument(wordprocessingDocument);
  }

  public static DocxDocument Create(Stream stream, DX.WordprocessingDocumentType type, bool autoSave)
  {
    var wordprocessingDocument = DXP.WordprocessingDocument.Create(stream, type, autoSave);
    return new DocxDocument(wordprocessingDocument);
  }

  public static DocxDocument Create(Package package, DX.WordprocessingDocumentType type, bool autoSave)
  {
    var wordprocessingDocument = DXP.WordprocessingDocument.Create(package, type, autoSave);
    return new DocxDocument(wordprocessingDocument);
  }

  public static DocxDocument CreateFromTemplate(string path)
      => CreateFromTemplate(path, true);
  public static DocxDocument CreateFromTemplate(string path, bool isTemplateAttached)
  {
    var wordprocessingDocument = DXP.WordprocessingDocument.CreateFromTemplate(path, isTemplateAttached);
    return new DocxDocument(wordprocessingDocument);
  }
  #endregion

  public void Dispose()
  {
    (WordprocessingDocument).Dispose();
  }

  public DX.WordprocessingDocumentType DocumentType => WordprocessingDocument.DocumentType;

}
