namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the HeaderFooterReferenceType Class.
/// </summary>
public class HeaderFooterReferenceTypeImpl: ModelElementImpl, HeaderFooterReferenceType
{
  public DocumentFormat.OpenXml.Wordprocessing.HeaderFooterReferenceType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.HeaderFooterReferenceType?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public HeaderFooterReferenceTypeImpl(): base() {}
  
  public HeaderFooterReferenceTypeImpl(DocumentFormat.OpenXml.Wordprocessing.HeaderFooterReferenceType openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// type
  /// </summary>
  public HeaderFooterKind? Type
  {
    get => (HeaderFooterKind?)OpenXmlElement?.Type?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Type = (DocumentFormat.OpenXml.Wordprocessing.HeaderFooterValues?)value;
    }
  }
  
  /// <summary>
  /// Relationship to Part
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
