namespace DocumentModel.Vml;

/// <summary>
/// Defines the Path Class.
/// </summary>
public class PathImpl: ModelElementImpl, Path
{
  public DocumentFormat.OpenXml.Vml.Path? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Vml.Path?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Unique Identifier
  /// </summary>
  public String? Id
  {
    get;
    set;
  }
  
  /// <summary>
  /// Path Definition
  /// </summary>
  public String? Value
  {
    get;
    set;
  }
  
  /// <summary>
  /// Limo Stretch Point
  /// </summary>
  public String? Limo
  {
    get;
    set;
  }
  
  /// <summary>
  /// Text Box Bounding Box
  /// </summary>
  public String? TextboxRectangle
  {
    get;
    set;
  }
  
  /// <summary>
  /// Shape Fill Toggle
  /// </summary>
  public Boolean? AllowFill
  {
    get;
    set;
  }
  
  /// <summary>
  /// Stroke Toggle
  /// </summary>
  public Boolean? AllowStroke
  {
    get;
    set;
  }
  
  /// <summary>
  /// Shadow Toggle
  /// </summary>
  public Boolean? AllowShading
  {
    get;
    set;
  }
  
  /// <summary>
  /// Arrowhead Display Toggle
  /// </summary>
  public Boolean? ShowArrowhead
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gradient Shape Toggle
  /// </summary>
  public Boolean? AllowGradientShape
  {
    get;
    set;
  }
  
  /// <summary>
  /// Text Path Toggle
  /// </summary>
  public Boolean? AllowTextPath
  {
    get;
    set;
  }
  
  /// <summary>
  /// Inset Stroke From Path Flag
  /// </summary>
  public Boolean? AllowInsetPen
  {
    get;
    set;
  }
  
  /// <summary>
  /// Connection Point Type
  /// </summary>
  public ConnectKind? ConnectionPointType
  {
    get => (ConnectKind?)OpenXmlElement?.ConnectionPointType?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ConnectionPointType = (DocumentFormat.OpenXml.Vml.Office.ConnectValues?)value;
    }
  }
  
  /// <summary>
  /// Connection Points
  /// </summary>
  public String? ConnectionPoints
  {
    get;
    set;
  }
  
  /// <summary>
  /// Connection Point Connect Angles
  /// </summary>
  public String? ConnectAngles
  {
    get;
    set;
  }
  
  /// <summary>
  /// Extrusion Toggle
  /// </summary>
  public Boolean? AllowExtrusion
  {
    get;
    set;
  }
  
}
