namespace DocumentModel.Vml.Office;

/// <summary>
/// New Shape Defaults.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Vml.Office.ICallout))]
[ChildElementInfo(typeof(DocumentModel.Vml.Office.IColorMenu))]
[ChildElementInfo(typeof(DocumentModel.Vml.Office.IColorMostRecentlyUsed))]
[ChildElementInfo(typeof(DocumentModel.Vml.Office.IExtrusion))]
[ChildElementInfo(typeof(DocumentModel.Vml.Office.ILock))]
[ChildElementInfo(typeof(DocumentModel.Vml.Office.ISkew))]
[ChildElementInfo(typeof(DocumentModel.Vml.IFill))]
[ChildElementInfo(typeof(DocumentModel.Vml.IImageData))]
[ChildElementInfo(typeof(DocumentModel.Vml.IShadow))]
[ChildElementInfo(typeof(DocumentModel.Vml.IStroke))]
[ChildElementInfo(typeof(DocumentModel.Vml.ITextBox))]
public interface IShapeDefaults // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public ExtensionHandlingBehavior? Extension { get ; set; }
  
  /// <summary>
  /// Shape ID Optional Storage
  /// </summary>
  public int? MaxShapeId { get ; set; }
  
  /// <summary>
  /// style
  /// </summary>
  public string? Style { get ; set; }
  
  /// <summary>
  /// Shape Fill Toggle
  /// </summary>
  public ITrueFalseValue? BeFilled { get ; set; }
  
  /// <summary>
  /// Default Fill Color
  /// </summary>
  public string? FillColor { get ; set; }
  
  /// <summary>
  /// Shape Stroke Toggle
  /// </summary>
  public ITrueFalseValue? IsStroke { get ; set; }
  
  /// <summary>
  /// Shape Stroke Color
  /// </summary>
  public string? StrokeColor { get ; set; }
  
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
  public InsetMargin? InsetMode { get ; set; }
  
  /// <summary>
  /// Fill.
  /// </summary>
  public DocumentModel.Vml.IFill? Fill { get ; set; }
  
  /// <summary>
  /// ImageData.
  /// </summary>
  public IImageData? ImageData { get ; set; }
  
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
  public DocumentModel.Vml.IShadow? Shadow { get ; set; }
  
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
  public DocumentModel.Vml.Office.ILock? Lock { get ; set; }
  
  /// <summary>
  /// Most Recently Used Colors.
  /// </summary>
  public DocumentModel.Vml.Office.IColorMostRecentlyUsed? ColorMostRecentlyUsed { get ; set; }
  
  /// <summary>
  /// UI Default Colors.
  /// </summary>
  public IColorMenu? ColorMenu { get ; set; }
  
}
