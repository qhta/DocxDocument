namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the PermEnd Class.
/// </summary>
public class PermEndImpl: ModelElementImpl, PermEnd
{
  public DocumentFormat.OpenXml.Wordprocessing.PermEnd? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.PermEnd?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public PermEndImpl(): base() {}
  
  public PermEndImpl(DocumentFormat.OpenXml.Wordprocessing.PermEnd openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Annotation ID
  /// </summary>
  public Int32? Id
  {
    get => (Int32?)OpenXmlElement?.Id?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Id = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// Annotation Displaced By Custom XML Markup
  /// </summary>
  public DisplacedByCustomXmlKind? DisplacedByCustomXml
  {
    get => (DisplacedByCustomXmlKind?)OpenXmlElement?.DisplacedByCustomXml?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.DisplacedByCustomXml = (DocumentFormat.OpenXml.Wordprocessing.DisplacedByCustomXmlValues?)value;
    }
  }
  
}
