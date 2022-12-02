namespace DocumentModel.Vml;

/// <summary>
/// New Shape Defaults.
/// </summary>
public interface IShapeDefaults // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public DocumentModel.Vml.ExtensionHandlingBehaviorKind? Extension { get ; set; }
  
  /// <summary>
  /// Shape ID Optional Storage
  /// </summary>
  public System.Int32? MaxShapeId { get ; set; }
  
  /// <summary>
  /// style
  /// </summary>
  public System.String? Style { get ; set; }
  
  /// <summary>
  /// Shape Fill Toggle
  /// </summary>
  public System.Boolean? BeFilled { get ; set; }
  
  /// <summary>
  /// Default Fill Color
  /// </summary>
  public System.String? FillColor { get ; set; }
  
  /// <summary>
  /// Shape Stroke Toggle
  /// </summary>
  public System.Boolean? IsStroke { get ; set; }
  
  /// <summary>
  /// Shape Stroke Color
  /// </summary>
  public System.String? StrokeColor { get ; set; }
  
  /// <summary>
  /// Allow in Table Cell
  /// </summary>
  public System.Boolean? AllowInCell { get ; set; }
  
  /// <summary>
  /// allowoverlap
  /// </summary>
  public System.Boolean? AllowOverlap { get ; set; }
  
  /// <summary>
  /// insetmode
  /// </summary>
  public DocumentModel.Vml.InsetMarginKind? InsetMode { get ; set; }
  
  /// <summary>
  /// Fill.
  /// </summary>
  public DocumentModel.Vml.IFill? Fill { get ; set; }
  
  /// <summary>
  /// ImageData.
  /// </summary>
  public DocumentModel.Vml.IImageData? ImageData { get ; set; }
  
  /// <summary>
  /// Stroke.
  /// </summary>
  public DocumentModel.Vml.IStroke? Stroke { get ; set; }
  
  /// <summary>
  /// TextBox.
  /// </summary>
  public DocumentModel.Vml.ITextBox? TextBox { get ; set; }
  
  /// <summary>
  /// Shadow.
  /// </summary>
  public DocumentModel.Vml.IShadow? Shadow { get ; set; }
  
  /// <summary>
  /// Skew.
  /// </summary>
  public DocumentModel.Vml.ISkew? Skew { get ; set; }
  
  /// <summary>
  /// Extrusion.
  /// </summary>
  public DocumentModel.Vml.IExtrusion? Extrusion { get ; set; }
  
  /// <summary>
  /// Callout.
  /// </summary>
  public DocumentModel.Vml.ICallout? Callout { get ; set; }
  
  /// <summary>
  /// Shape Protections.
  /// </summary>
  public DocumentModel.Vml.ILock? Lock { get ; set; }
  
  /// <summary>
  /// Most Recently Used Colors.
  /// </summary>
  public DocumentModel.Vml.IColorMostRecentlyUsed? ColorMostRecentlyUsed { get ; set; }
  
  /// <summary>
  /// UI Default Colors.
  /// </summary>
  public DocumentModel.Vml.IColorMenu? ColorMenu { get ; set; }
  
}
