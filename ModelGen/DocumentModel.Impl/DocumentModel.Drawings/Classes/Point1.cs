namespace DocumentModel.Drawings;

/// <summary>
/// Point.
/// </summary>
public class Point1Impl: ModelElementImpl, Point1
{
  public DocumentFormat.OpenXml.Drawing.Diagrams.Point? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Diagrams.Point?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Model Identifier
  /// </summary>
  public String? ModelId
  {
    get;
    set;
  }
  
  /// <summary>
  /// Point Type
  /// </summary>
  public PointKind? Type
  {
    get => (PointKind?)OpenXmlElement?.Type?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Type = (DocumentFormat.OpenXml.Drawing.Diagrams.PointValues?)value;
    }
  }
  
  /// <summary>
  /// Connection Identifier
  /// </summary>
  public String? ConnectionId
  {
    get;
    set;
  }
  
  /// <summary>
  /// Property Set.
  /// </summary>
  public PropertySet? PropertySet
  {
    get;
    set;
  }
  
  /// <summary>
  /// Shape Properties.
  /// </summary>
  public ShapeProperties9? ShapeProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// Text Body.
  /// </summary>
  public TextBody1? TextBody
  {
    get;
    set;
  }
  
  /// <summary>
  /// PtExtensionList.
  /// </summary>
  public PtExtensionList? PtExtensionList
  {
    get;
    set;
  }
  
}
