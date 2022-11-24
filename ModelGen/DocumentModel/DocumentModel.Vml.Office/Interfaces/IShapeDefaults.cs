namespace DocumentModel.Vml.Office;

/// <summary>
/// New Shape Defaults.
/// </summary>
public interface IShapeDefaults // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public ExtensionHandlingBehaviorValues? Extension { get ; set; }
  
  /// <summary>
  /// Shape ID Optional Storage
  /// </summary>
  public Int32? MaxShapeId { get ; set; }
  
  /// <summary>
  /// style
  /// </summary>
  public String? Style { get ; set; }
  
  /// <summary>
  /// Shape Fill Toggle
  /// </summary>
  public ITrueFalseValue? BeFilled { get ; set; }
  
  /// <summary>
  /// Default Fill Color
  /// </summary>
  public String? FillColor { get ; set; }
  
  /// <summary>
  /// Shape Stroke Toggle
  /// </summary>
  public ITrueFalseValue? IsStroke { get ; set; }
  
  /// <summary>
  /// Shape Stroke Color
  /// </summary>
  public String? StrokeColor { get ; set; }
  
  /// <summary>
  /// Allow in Table Cell
  /// </summary>
  public ITrueFalseValue? AllowInCell { get ; set; }
  
  /// <summary>
  /// allowoverlap
  /// </summary>
  public ITrueFalseValue? AllowOverlap { get ; set; }
  
  /// <summary>
  /// insetmode
  /// </summary>
  public InsetMarginValues? InsetMode { get ; set; }
  
  /// <summary>
  /// Fill.
  /// </summary>
  public IFill? Fill { get ; set; }
  
  /// <summary>
  /// ImageData.
  /// </summary>
  public ImageData? ImageData { get ; set; }
  
  /// <summary>
  /// Stroke.
  /// </summary>
  public IStroke? Stroke { get ; set; }
  
  /// <summary>
  /// TextBox.
  /// </summary>
  public ITextBox? TextBox { get ; set; }
  
  /// <summary>
  /// Shadow.
  /// </summary>
  public IShadow? Shadow { get ; set; }
  
  /// <summary>
  /// Skew.
  /// </summary>
  public ISkew? Skew { get ; set; }
  
  /// <summary>
  /// Extrusion.
  /// </summary>
  public IExtrusion? Extrusion { get ; set; }
  
  /// <summary>
  /// Callout.
  /// </summary>
  public ICallout? Callout { get ; set; }
  
  /// <summary>
  /// Shape Protections.
  /// </summary>
  public ILock? Lock { get ; set; }
  
  /// <summary>
  /// Most Recently Used Colors.
  /// </summary>
  public IColorMostRecentlyUsed? ColorMostRecentlyUsed { get ; set; }
  
  /// <summary>
  /// UI Default Colors.
  /// </summary>
  public IColorMenu? ColorMenu { get ; set; }
  
}
