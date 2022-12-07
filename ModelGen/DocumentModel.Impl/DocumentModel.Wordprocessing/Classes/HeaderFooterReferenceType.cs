namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the HeaderFooterReferenceType Class.
/// </summary>
public class HeaderFooterReferenceTypeImpl: ModelElement<DocumentFormat.OpenXml.Wordprocessing.HeaderFooterReferenceType>, HeaderFooterReferenceType
{
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
  
}
