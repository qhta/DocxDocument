namespace DocumentModel.Wordprocessing;

/// <summary>
/// Glossary Document Root Element.
/// </summary>
public class GlossaryDocumentImpl: ModelElementImpl, GlossaryDocument
{
  public DocumentFormat.OpenXml.Wordprocessing.GlossaryDocument? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.GlossaryDocument?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Document Background.
  /// </summary>
  public DocumentBackground? DocumentBackground
  {
    get;
    set;
  }
  
  /// <summary>
  /// List of Glossary Document Entries.
  /// </summary>
  public DocumentModel.ModelElement? DocParts
  {
    get;
    set;
  }
  
}
