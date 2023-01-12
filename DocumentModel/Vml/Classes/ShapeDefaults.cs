namespace DocumentModel.Vml;

/// <summary>
/// New Shape Defaults.
/// </summary>
public partial class ShapeDefaults
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public DocumentModel.Vml.ExtensionHandlingBehaviorKind? Extension { get; set; }
  
  /// <summary>
  /// Shape ID Optional Storage
  /// </summary>
  public Int64? MaxShapeId { get; set; }
  
  /// <summary>
  /// style
  /// </summary>
  public String? Style { get; set; }
  
  /// <summary>
  /// Shape Fill Toggle
  /// </summary>
  public Boolean? BeFilled { get; set; }
  
  /// <summary>
  /// Default Fill Color
  /// </summary>
  public String? FillColor { get; set; }
  
  /// <summary>
  /// Shape Stroke Toggle
  /// </summary>
  public Boolean? IsStroke { get; set; }
  
  /// <summary>
  /// Shape Stroke Color
  /// </summary>
  public String? StrokeColor { get; set; }
  
  /// <summary>
  /// Allow in Table Cell
  /// </summary>
  public Boolean? AllowInCell { get; set; }
  
  /// <summary>
  /// allowoverlap
  /// </summary>
  public Boolean? AllowOverlap { get; set; }
  
  /// <summary>
  /// insetmode
  /// </summary>
  public DocumentModel.Vml.InsetMarginKind? InsetMode { get; set; }
  
  /// <summary>
  /// Fill.
  /// </summary>
  public DocumentModel.Vml.Fill? Fill { get; set; }
  
  /// <summary>
  /// ImageData.
  /// </summary>
  public DocumentModel.Vml.ImageData? ImageData { get; set; }
  
  /// <summary>
  /// Stroke.
  /// </summary>
  public DocumentModel.Vml.Stroke? Stroke { get; set; }
  
  /// <summary>
  /// TextBox.
  /// </summary>
  public DocumentModel.Vml.TextBox? TextBox { get; set; }
  
  /// <summary>
  /// Shadow.
  /// </summary>
  public DocumentModel.Vml.Shadow? Shadow { get; set; }
  
  /// <summary>
  /// Skew.
  /// </summary>
  public DocumentModel.Vml.Skew? Skew { get; set; }
  
  /// <summary>
  /// Extrusion.
  /// </summary>
  public DocumentModel.Vml.Extrusion? Extrusion { get; set; }
  
  /// <summary>
  /// Callout.
  /// </summary>
  public DocumentModel.Vml.Callout? Callout { get; set; }
  
  /// <summary>
  /// Shape Protections.
  /// </summary>
  public DocumentModel.Vml.Lock? Lock { get; set; }
  
  /// <summary>
  /// Most Recently Used Colors.
  /// </summary>
  public DocumentModel.Vml.ColorMostRecentlyUsed? ColorMostRecentlyUsed { get; set; }
  
  /// <summary>
  /// UI Default Colors.
  /// </summary>
  public DocumentModel.Vml.ColorMenu? ColorMenu { get; set; }
  
}
