namespace DocumentModel.Drawings;

/// <summary>
/// Point.
/// </summary>
public class Point1Impl: ModelElement<DocumentFormat.OpenXml.Drawing.Diagrams.Point>, Point1
{
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
  public ShapeProperties4? ShapeProperties
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
