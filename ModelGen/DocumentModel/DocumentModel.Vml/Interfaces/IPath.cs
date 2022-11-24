namespace DocumentModel.Vml;

/// <summary>
/// Defines the Path Class.
/// </summary>
public interface IPath // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Unique Identifier
  /// </summary>
  public String? Id { get ; set; }
  
  /// <summary>
  /// Path Definition
  /// </summary>
  public String? Value { get ; set; }
  
  /// <summary>
  /// Limo Stretch Point
  /// </summary>
  public String? Limo { get ; set; }
  
  /// <summary>
  /// Text Box Bounding Box
  /// </summary>
  public String? TextboxRectangle { get ; set; }
  
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
  public ConnectValues? ConnectionPointType { get ; set; }
  
  /// <summary>
  /// Connection Points
  /// </summary>
  public String? ConnectionPoints { get ; set; }
  
  /// <summary>
  /// Connection Point Connect Angles
  /// </summary>
  public String? ConnectAngles { get ; set; }
  
  /// <summary>
  /// Extrusion Toggle
  /// </summary>
  public ITrueFalseValue? AllowExtrusion { get ; set; }
  
}
