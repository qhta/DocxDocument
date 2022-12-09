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
    get => (String?)OpenXmlElement?.Id?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Id = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Path Definition
  /// </summary>
  public String? Value
  {
    get => (String?)OpenXmlElement?.Value?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Value = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Limo Stretch Point
  /// </summary>
  public String? Limo
  {
    get => (String?)OpenXmlElement?.Limo?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Limo = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Text Box Bounding Box
  /// </summary>
  public String? TextboxRectangle
  {
    get => (String?)OpenXmlElement?.TextboxRectangle?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.TextboxRectangle = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Shape Fill Toggle
  /// </summary>
  public Boolean? AllowFill
  {
    get => (Boolean?)OpenXmlElement?.AllowFill?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.AllowFill = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Stroke Toggle
  /// </summary>
  public Boolean? AllowStroke
  {
    get => (Boolean?)OpenXmlElement?.AllowStroke?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.AllowStroke = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Shadow Toggle
  /// </summary>
  public Boolean? AllowShading
  {
    get => (Boolean?)OpenXmlElement?.AllowShading?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.AllowShading = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Arrowhead Display Toggle
  /// </summary>
  public Boolean? ShowArrowhead
  {
    get => (Boolean?)OpenXmlElement?.ShowArrowhead?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ShowArrowhead = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Gradient Shape Toggle
  /// </summary>
  public Boolean? AllowGradientShape
  {
    get => (Boolean?)OpenXmlElement?.AllowGradientShape?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.AllowGradientShape = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Text Path Toggle
  /// </summary>
  public Boolean? AllowTextPath
  {
    get => (Boolean?)OpenXmlElement?.AllowTextPath?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.AllowTextPath = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Inset Stroke From Path Flag
  /// </summary>
  public Boolean? AllowInsetPen
  {
    get => (Boolean?)OpenXmlElement?.AllowInsetPen?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.AllowInsetPen = (System.Boolean?)value;
    }
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
    get => (String?)OpenXmlElement?.ConnectionPoints?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ConnectionPoints = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Connection Point Connect Angles
  /// </summary>
  public String? ConnectAngles
  {
    get => (String?)OpenXmlElement?.ConnectAngles?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ConnectAngles = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Extrusion Toggle
  /// </summary>
  public Boolean? AllowExtrusion
  {
    get => (Boolean?)OpenXmlElement?.AllowExtrusion?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.AllowExtrusion = (System.Boolean?)value;
    }
  }
  
}
