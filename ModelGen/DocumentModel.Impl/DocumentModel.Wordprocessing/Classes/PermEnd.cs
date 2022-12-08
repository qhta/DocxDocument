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
  
  /// <summary>
  /// Annotation ID
  /// </summary>
  public Int32? Id
  {
    get;
    set;
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
