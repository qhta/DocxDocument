namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the HeaderFooterReferenceType Class.
/// </summary>
public partial class HeaderFooterReferenceTypeImpl: ModelElementImpl, HeaderFooterReferenceType
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Wordprocessing.HeaderFooterReferenceType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.HeaderFooterReferenceType?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public HeaderFooterReferenceTypeImpl(): base() {}
  
  public HeaderFooterReferenceTypeImpl(DocumentFormat.OpenXml.Wordprocessing.HeaderFooterReferenceType openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// type
  /// </summary>
  public DocumentModel.Wordprocessing.HeaderFooterKind? Type
  {
    get => (DocumentModel.Wordprocessing.HeaderFooterKind?)OpenXmlElement?.Type?.Value;
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
    get => (System.String?)OpenXmlElement?.Id?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Id = (System.String?)value;
    }
  }
  
}
