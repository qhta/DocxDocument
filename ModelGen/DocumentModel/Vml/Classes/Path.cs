namespace DocumentModel.Vml;


/// <summary>
///   Defines the Path Class.
/// </summary>
public partial class Path
{
  
  /// <summary>
  ///   Unique Identifier
  /// </summary>
  [SchemaAttr("id")]
  public String? Id { get; set; }
  
  
  /// <summary>
  ///   Path Definition
  /// </summary>
  [SchemaAttr("v")]
  public String? Value { get; set; }
  
  
  /// <summary>
  ///   Limo Stretch Point
  /// </summary>
  [SchemaAttr("limo")]
  public String? Limo { get; set; }
  
  
  /// <summary>
  ///   Text Box Bounding Box
  /// </summary>
  [SchemaAttr("textboxrect")]
  public String? TextboxRectangle { get; set; }
  
  
  /// <summary>
  ///   Shape Fill Toggle
  /// </summary>
  [SchemaAttr("fillok")]
  public Boolean? AllowFill { get; set; }
  
  
  /// <summary>
  ///   Stroke Toggle
  /// </summary>
  [SchemaAttr("strokeok")]
  public Boolean? AllowStroke { get; set; }
  
  
  /// <summary>
  ///   Shadow Toggle
  /// </summary>
  [SchemaAttr("shadowok")]
  public Boolean? AllowShading { get; set; }
  
  
  /// <summary>
  ///   Arrowhead Display Toggle
  /// </summary>
  [SchemaAttr("arrowok")]
  public Boolean? ShowArrowhead { get; set; }
  
  
  /// <summary>
  ///   Gradient Shape Toggle
  /// </summary>
  [SchemaAttr("gradientshapeok")]
  public Boolean? AllowGradientShape { get; set; }
  
  
  /// <summary>
  ///   Text Path Toggle
  /// </summary>
  [SchemaAttr("textpathok")]
  public Boolean? AllowTextPath { get; set; }
  
  
  /// <summary>
  ///   Inset Stroke From Path Flag
  /// </summary>
  [SchemaAttr("insetpenok")]
  public Boolean? AllowInsetPen { get; set; }
  
  
  /// <summary>
  ///   Connection Point Type
  /// </summary>
  [SchemaAttr("o:connecttype")]
  public DocumentModel.Vml.Office.ConnectValues? ConnectionPointType { get; set; }
  
  
  /// <summary>
  ///   Connection Points
  /// </summary>
  [SchemaAttr("o:connectlocs")]
  public String? ConnectionPoints { get; set; }
  
  
  /// <summary>
  ///   Connection Point Connect Angles
  /// </summary>
  [SchemaAttr("o:connectangles")]
  public String? ConnectAngles { get; set; }
  
  
  /// <summary>
  ///   Extrusion Toggle
  /// </summary>
  [SchemaAttr("o:extrusionok")]
  public Boolean? AllowExtrusion { get; set; }
  
}
