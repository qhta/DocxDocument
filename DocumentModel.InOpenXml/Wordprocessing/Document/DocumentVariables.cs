namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a collection of document variables in a WordprocessingML document.
/// This class provides access to and management of <see cref = "DocumentVariable"/> objects, enabling advanced storage, retrieval, and organization of custom metadata or automation variables within the document.
/// </summary>
[OpenXmlType(typeof(DXW.DocumentVariables))]
[XmlRoot("DocumentVariables", Namespace = "DocumentModel.Wordprocessing")]
public sealed class DocumentVariables : ModelElementCollection<DocumentVariable, DXW.DocumentVariables, DXW.DocumentVariable>
{
  /// <summary>
  /// Default constructor.
  /// </summary>
  public DocumentVariables()
  {
  }

  /// <summary>
  /// Initializing constructor.
  /// </summary>
  /// <param name = "document">Wordprocessing document model</param>
  public DocumentVariables(Wordprocessing.Document document)
  {
    if (document.WordprocessingDocument != null)
      AttachAndLoad(document.WordprocessingDocument);
  }

  /// <summary>
  /// Attach this instance to the specified wordprocessingDocument. Data is loaded from the wordprocessingDocument's DocumentSettings.
  /// </summary>
  /// <param name = "wordprocessingDocument">Document to attach to.</param>
  public override void AttachAndLoad(DXPP.WordprocessingDocument wordprocessingDocument)
  {
    base.AttachAndLoad(wordprocessingDocument);
    var documentSettings = wordprocessingDocument.GetDocumentSettings();
    var documentVariables = documentSettings.Elements<DXW.DocumentVariables>().FirstOrDefault();
    if (documentVariables == null)
    {
      documentVariables = new DXW.DocumentVariables();
      documentSettings.AddChildUsingSchemaOrder(documentVariables);
    }
    SetUpdatableElement(documentVariables);
    LoadData(documentVariables);
  }

  /// <summary>
  /// Attach this instance to the specified document. Data is stored to the document's DocumentSettings.
  /// </summary>
  /// <param name = "wordprocessingDocument">Document to attach to.</param>
  public override void AttachAndUpdate(DXPP.WordprocessingDocument wordprocessingDocument)
  {
    base.AttachAndUpdate(wordprocessingDocument);
    var documentSettings = wordprocessingDocument.GetDocumentSettings();
    var DocumentVariables = documentSettings.Elements<DXW.DocumentVariables>().FirstOrDefault();
    if (DocumentVariables == null)
    {
      DocumentVariables = new DXW.DocumentVariables();
      documentSettings.AddChildUsingSchemaOrder(DocumentVariables);
    }

    SetUpdatableElement(DocumentVariables);
    UpdateData(DocumentVariables);
  }
}