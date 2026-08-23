namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a collection of document variables in a WordprocessingML document.
/// This class provides access to and management of <see cref = "DocumentVariable"/> objects, enabling advanced storage, retrieval, and organization of custom metadata or automation variables within the document.
/// </summary>
[OpenXmlType(typeof(DXW.DocumentVariables))]
[DataContract]
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
  public DocumentVariables(Wordprocessing.Document document) : base(document, document.WordprocessingDocument?.GetDocumentVariables())
  {
  }

}