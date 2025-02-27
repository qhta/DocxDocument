namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the MarkupRangeType Class.
/// </summary>
public partial class MarkupRangeTypeImpl: ModelElementImpl, MarkupRangeType
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Wordprocessing.MarkupRangeType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.MarkupRangeType?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public MarkupRangeTypeImpl(): base() {}
  
  public MarkupRangeTypeImpl(DocumentFormat.OpenXml.Wordprocessing.MarkupRangeType openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// displacedByCustomXml
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
  
  /// <summary>
  /// Annotation Identifier
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
