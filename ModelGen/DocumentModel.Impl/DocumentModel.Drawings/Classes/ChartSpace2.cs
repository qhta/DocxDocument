namespace DocumentModel.Drawings;

/// <summary>
/// Chart Space.
/// </summary>
public class ChartSpace2Impl: ModelElementImpl, ChartSpace2
{
  public DocumentFormat.OpenXml.Drawing.Charts.ChartSpace? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.ChartSpace?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Date1904.
  /// </summary>
  public Boolean? Date1904
  {
    get;
    set;
  }
  
  /// <summary>
  /// EditingLanguage.
  /// </summary>
  public String? EditingLanguage
  {
    get;
    set;
  }
  
  /// <summary>
  /// RoundedCorners.
  /// </summary>
  public Boolean? RoundedCorners
  {
    get;
    set;
  }
  
  public Byte? Style
  {
    get;
    set;
  }
  
  public ColorMapOverride? ColorMapOverride
  {
    get;
    set;
  }
  
  public PivotSource1? PivotSource
  {
    get;
    set;
  }
  
  public Protection? Protection
  {
    get;
    set;
  }
  
  public Chart3? Chart
  {
    get;
    set;
  }
  
  public ShapeProperties1? ShapeProperties
  {
    get;
    set;
  }
  
  public TextProperties2? TextProperties
  {
    get;
    set;
  }
  
  public ExternalData2? ExternalData
  {
    get;
    set;
  }
  
  public PrintSettings1? PrintSettings
  {
    get;
    set;
  }
  
  public RelationshipIdType? UserShapesReference
  {
    get;
    set;
  }
  
  public ChartSpaceExtensionList? ChartSpaceExtensionList
  {
    get;
    set;
  }
  
}
