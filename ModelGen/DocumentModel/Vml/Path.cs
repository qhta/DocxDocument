namespace DocumentModel.Vml;


/// <summary>
///   Defines the Path Class.
/// </summary>
public partial class Path
{
  
  /// <summary>
  ///   Unique Identifier
  /// </summary>
  public String? Id { get; set; }
  
  
  /// <summary>
  ///   Path Definition
  /// </summary>
  public String? Value { get; set; }
  
  
  /// <summary>
  ///   Limo Stretch Point
  /// </summary>
  public String? Limo { get; set; }
  
  
  /// <summary>
  ///   Text Box Bounding Box
  /// </summary>
  public String? TextboxRectangle { get; set; }
  
  
  /// <summary>
  ///   Shape Fill Toggle
  /// </summary>
  public DM.TrueFalseValue? AllowFill { get; set; }
  
  
  /// <summary>
  ///   Stroke Toggle
  /// </summary>
  public DM.TrueFalseValue? AllowStroke { get; set; }
  
  
  /// <summary>
  ///   Shadow Toggle
  /// </summary>
  public DM.TrueFalseValue? AllowShading { get; set; }
  
  
  /// <summary>
  ///   Arrowhead Display Toggle
  /// </summary>
  public DM.TrueFalseValue? ShowArrowhead { get; set; }
  
  
  /// <summary>
  ///   Gradient Shape Toggle
  /// </summary>
  public DM.TrueFalseValue? AllowGradientShape { get; set; }
  
  
  /// <summary>
  ///   Text Path Toggle
  /// </summary>
  public DM.TrueFalseValue? AllowTextPath { get; set; }
  
  
  /// <summary>
  ///   Inset Stroke From Path Flag
  /// </summary>
  public DM.TrueFalseValue? AllowInsetPen { get; set; }
  
  
  /// <summary>
  ///   Connection Points
  /// </summary>
  public String? ConnectionPoints { get; set; }
  
  
  /// <summary>
  ///   Connection Point Connect Angles
  /// </summary>
  public String? ConnectAngles { get; set; }
  
  
  /// <summary>
  ///   Extrusion Toggle
  /// </summary>
  public DM.TrueFalseValue? AllowExtrusion { get; set; }
  
}
