namespace DocumentModel.Vml;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   New IShape Defaults.
/// </summary>
public class ShapeDefaults: ModelElement
{
  /// <summary>
  ///   VML Extension Handling Behavior
  /// </summary>
  public ExtensionHandlingBehaviorKind? Extension { get; set; }

  /// <summary>
  ///   IShape ID Optional Storage
  /// </summary>
  public Int64? MaxShapeId { get; set; }

  /// <summary>
  ///   style
  /// </summary>
  public string? IStyle { get; set; }

  /// <summary>
  ///   IShape Fill Toggle
  /// </summary>
  public bool? BeFilled { get; set; }

  /// <summary>
  ///   Default Fill Color
  /// </summary>
  public string? FillColor { get; set; }

  /// <summary>
  ///   IShape Stroke Toggle
  /// </summary>
  public bool? IsStroke { get; set; }

  /// <summary>
  ///   IShape Stroke Color
  /// </summary>
  public string? StrokeColor { get; set; }

  /// <summary>
  ///   Allow in ITable ICell
  /// </summary>
  public bool? AllowInCell { get; set; }

  /// <summary>
  ///   allowoverlap
  /// </summary>
  public bool? AllowOverlap { get; set; }

  /// <summary>
  ///   insetmode
  /// </summary>
  public InsetMarginKind? InsetMode { get; set; }

  /// <summary>
  ///   Fill.
  /// </summary>
  public Fill? Fill { get; set; }

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
  ///   IShape Protections.
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
