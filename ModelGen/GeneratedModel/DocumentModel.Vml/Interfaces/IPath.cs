namespace DocumentModel.Vml;

/// <summary>
/// Defines the Path Class.
/// </summary>
public interface IPath // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Unique Identifier
  /// </summary>
  public string? Id { get ; set; }
  
  /// <summary>
  /// Path Definition
  /// </summary>
  public string? Value { get ; set; }
  
  /// <summary>
  /// Limo Stretch Point
  /// </summary>
  public string? Limo { get ; set; }
  
  /// <summary>
  /// Text Box Bounding Box
  /// </summary>
  public string? TextboxRectangle { get ; set; }
  
  /// <summary>
  /// Shape Fill Toggle
  /// </summary>
  public ITrueFalseValue? AllowFill { get ; set; }
  
  /// <summary>
  /// Stroke Toggle
  /// </summary>
  public ITrueFalseValue? AllowStroke { get ; set; }
  
  /// <summary>
  /// Shadow Toggle
  /// </summary>
  public ITrueFalseValue? AllowShading { get ; set; }
  
  /// <summary>
  /// Arrowhead Display Toggle
  /// </summary>
  public ITrueFalseValue? ShowArrowhead { get ; set; }
  
  /// <summary>
  /// Gradient Shape Toggle
  /// </summary>
  public ITrueFalseValue? AllowGradientShape { get ; set; }
  
  /// <summary>
  /// Text Path Toggle
  /// </summary>
  public ITrueFalseValue? AllowTextPath { get ; set; }
  
  /// <summary>
  /// Inset Stroke From Path Flag
  /// </summary>
  public ITrueFalseValue? AllowInsetPen { get ; set; }
  
  /// <summary>
  /// Connection Point Type
  /// </summary>
  public Connect? ConnectionPointType { get ; set; }
  
  /// <summary>
  /// Connection Points
  /// </summary>
  public string? ConnectionPoints { get ; set; }
  
  /// <summary>
  /// Connection Point Connect Angles
  /// </summary>
  public string? ConnectAngles { get ; set; }
  
  /// <summary>
  /// Extrusion Toggle
  /// </summary>
  public ITrueFalseValue? AllowExtrusion { get ; set; }
  
}
