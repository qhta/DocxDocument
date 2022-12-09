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
    get => (String?)OpenXmlElement?.Id?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Id = (System.String?)value;
    }
  }
  
}
