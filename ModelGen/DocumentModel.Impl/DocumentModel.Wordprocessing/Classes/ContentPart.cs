namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the ContentPart Class.
/// </summary>
public class ContentPartImpl: ModelElementImpl, ContentPart
{
  public DocumentFormat.OpenXml.Wordprocessing.ContentPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.ContentPart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// id
  /// </summary>
  public String? Id
  {
    get;
    set;
  }
  
}
