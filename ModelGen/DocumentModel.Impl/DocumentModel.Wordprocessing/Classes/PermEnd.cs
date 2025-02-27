namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the PermEnd Class.
/// </summary>
public partial class PermEndImpl: ModelElementImpl, PermEnd
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Wordprocessing.PermEnd? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.PermEnd?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
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
    get => (System.Int32?)OpenXmlElement?.Id?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Id = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// Annotation Displaced By Custom XML Markup
  /// </summary>
  public DocumentModel.Wordprocessing.DisplacedByCustomXmlKind? DisplacedByCustomXml
  {
    get => (DocumentModel.Wordprocessing.DisplacedByCustomXmlKind?)OpenXmlElement?.DisplacedByCustomXml?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.DisplacedByCustomXml = (DocumentFormat.OpenXml.Wordprocessing.DisplacedByCustomXmlValues?)value;
    }
  }
  
}
