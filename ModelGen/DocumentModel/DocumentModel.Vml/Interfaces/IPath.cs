namespace DocumentModel.Vml;

/// <summary>
/// Defines the Path Class.
/// </summary>
public interface IPath // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Unique Identifier
  /// </summary>
  public System.String? Id { get ; set; }
  
  /// <summary>
  /// Path Definition
  /// </summary>
  public System.String? Value { get ; set; }
  
  /// <summary>
  /// Limo Stretch Point
  /// </summary>
  public System.String? Limo { get ; set; }
  
  /// <summary>
  /// Text Box Bounding Box
  /// </summary>
  public System.String? TextboxRectangle { get ; set; }
  
  /// <summary>
  /// Shape Fill Toggle
  /// </summary>
  public System.Boolean? AllowFill { get ; set; }
  
  /// <summary>
  /// Stroke Toggle
  /// </summary>
  public System.Boolean? AllowStroke { get ; set; }
  
  /// <summary>
  /// Shadow Toggle
  /// </summary>
  public System.Boolean? AllowShading { get ; set; }
  
  /// <summary>
  /// Arrowhead Display Toggle
  /// </summary>
  public System.Boolean? ShowArrowhead { get ; set; }
  
  /// <summary>
  /// Gradient Shape Toggle
  /// </summary>
  public System.Boolean? AllowGradientShape { get ; set; }
  
  /// <summary>
  /// Text Path Toggle
  /// </summary>
  public System.Boolean? AllowTextPath { get ; set; }
  
  /// <summary>
  /// Inset Stroke From Path Flag
  /// </summary>
  public System.Boolean? AllowInsetPen { get ; set; }
  
  /// <summary>
  /// Connection Point Type
  /// </summary>
  public DocumentModel.Vml.ConnectKind? ConnectionPointType { get ; set; }
  
  /// <summary>
  /// Connection Points
  /// </summary>
  public System.String? ConnectionPoints { get ; set; }
  
  /// <summary>
  /// Connection Point Connect Angles
  /// </summary>
  public System.String? ConnectAngles { get ; set; }
  
  /// <summary>
  /// Extrusion Toggle
  /// </summary>
  public System.Boolean? AllowExtrusion { get ; set; }
  
}
