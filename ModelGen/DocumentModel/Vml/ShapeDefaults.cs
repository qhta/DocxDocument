namespace DocumentModel.Vml;


/// <summary>
///   New Shape Defaults.
/// </summary>
public partial class ShapeDefaults
{
  
  /// <summary>
  ///   Shape ID Optional Storage
  /// </summary>
  public Int64? MaxShapeId { get; set; }
  
  
  /// <summary>
  ///   style
  /// </summary>
  public String? Style { get; set; }
  
  
  /// <summary>
  ///   Shape Fill Toggle
  /// </summary>
  public DM.TrueFalseValue? BeFilled { get; set; }
  
  
  /// <summary>
  ///   Default Fill Color
  /// </summary>
  public String? FillColor { get; set; }
  
  
  /// <summary>
  ///   Shape Stroke Toggle
  /// </summary>
  public DM.TrueFalseValue? IsStroke { get; set; }
  
  
  /// <summary>
  ///   Shape Stroke Color
  /// </summary>
  public String? StrokeColor { get; set; }
  
  
  /// <summary>
  ///   Allow in Table Cell
  /// </summary>
  public DM.TrueFalseValue? AllowInCell { get; set; }
  
  
  /// <summary>
  ///   allowoverlap
  /// </summary>
  public DM.TrueFalseValue? AllowOverlap { get; set; }
  
  
  /// <summary>
  ///   Fill.
  /// </summary>
  public DMVML.Fill? Fill { get; set; }
  
  
  /// <summary>
  ///   ImageData.
  /// </summary>
  public DMVML.ImageData? ImageData { get; set; }
  
  
  /// <summary>
  ///   Stroke.
  /// </summary>
  public DMVML.Stroke? Stroke { get; set; }
  
  
  /// <summary>
  ///   TextBox.
  /// </summary>
  public DMVML.TextBox? TextBox { get; set; }
  
  
  /// <summary>
  ///   Shadow.
  /// </summary>
  public DMVML.Shadow? Shadow { get; set; }
  
  
  /// <summary>
  ///   Skew.
  /// </summary>
  public DMVML.Skew? Skew { get; set; }
  
  
  /// <summary>
  ///   Extrusion.
  /// </summary>
  public DMVML.Extrusion? Extrusion { get; set; }
  
  
  /// <summary>
  ///   Callout.
  /// </summary>
  public DMVML.Callout? Callout { get; set; }
  
  
  /// <summary>
  ///   Shape Protections.
  /// </summary>
  public DMVML.Lock? Lock { get; set; }
  
  
  /// <summary>
  ///   Most Recently Used Colors.
  /// </summary>
  public DMVML.ColorMostRecentlyUsed? ColorMostRecentlyUsed { get; set; }
  
  
  /// <summary>
  ///   UI Default Colors.
  /// </summary>
  public DMVML.ColorMenu? ColorMenu { get; set; }
  
}
