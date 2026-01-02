namespace DocumentModel.Vml;
/// <summary>
///   New Shape Defaults.
/// </summary>
public interface IShapeDefaults: IModelElement
{
  /// <summary>
  ///   VML Extension Handling Behavior
  /// </summary>
  public ExtensionHandlingBehaviorKind? Extension { get; set; }
  /// <summary>
  ///   Shape ID Optional Storage
  /// </summary>
  public Int64? MaxShapeId { get; set; }
  /// <summary>
  ///   style
  /// </summary>
  public string? Style { get; set; }
  /// <summary>
  ///   Shape Fill Toggle
  /// </summary>
  public bool? BeFilled { get; set; }
  /// <summary>
  ///   Default Fill Color
  /// </summary>
  public string? FillColor { get; set; }
  /// <summary>
  ///   Shape Stroke Toggle
  /// </summary>
  public bool? IsStroke { get; set; }
  /// <summary>
  ///   Shape Stroke Color
  /// </summary>
  public string? StrokeColor { get; set; }
  /// <summary>
  ///   Allow in Table Cell
  /// </summary>
  public bool? AllowInCell { get; set; }
  /// <summary>
  ///   Allow shape overlap
  /// </summary>
  public bool? AllowOverlap { get; set; }
  /// <summary>
  ///   Type of Inset Margin
  /// </summary>
  public InsetMarginKind? InsetMode { get; set; }
  /// <summary>
  ///   Fill.
  /// </summary>
  public IFill? Fill { get; set; }
  /// <summary>
  ///   ImageData.
  /// </summary>
  public ImageData? ImageData { get; set; }
  /// <summary>
  ///   Stroke.
  /// </summary>
  public Stroke? Stroke { get; set; }
  /// <summary>
  ///   TextBox.
  /// </summary>
  public TextBox? TextBox { get; set; }
  /// <summary>
  ///   Shadow.
  /// </summary>
  public Shadow? Shadow { get; set; }
  /// <summary>
  ///   Skew.
  /// </summary>
  public Skew? Skew { get; set; }
  /// <summary>
  ///   Extrusion.
  /// </summary>
  public Extrusion? Extrusion { get; set; }
  /// <summary>
  ///   Callout.
  /// </summary>
  public Callout? Callout { get; set; }
  /// <summary>
  ///   Shape Protections.
  /// </summary>
  public Lock? Lock { get; set; }
  /// <summary>
  ///   Most Recently Used Colors.
  /// </summary>
  public ColorMostRecentlyUsed? ColorMostRecentlyUsed { get; set; }
  /// <summary>
  ///   UI Default Colors.
  /// </summary>
  public ColorMenu? ColorMenu { get; set; }
}