namespace DocumentModel.Vml;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the StrokeChildType Class.
/// </summary>
public class StrokeChildType: ModelElement
{
  /// <summary>
  ///   VML Extension Handling Behavior
  /// </summary>
  public ExtensionHandlingBehaviorKind? Extension { get; set; }

  /// <summary>
  ///   Stroke Toggle
  /// </summary>
  public bool? On { get; set; }

  /// <summary>
  ///   Stroke Weight
  /// </summary>
  public string? Weight { get; set; }

  /// <summary>
  ///   Stroke Color
  /// </summary>
  public string? Color { get; set; }

  /// <summary>
  ///   Stroke Alternate Pattern Color
  /// </summary>
  public string? Color2 { get; set; }

  /// <summary>
  ///   Stroke Opacity
  /// </summary>
  public string? Opacity { get; set; }

  /// <summary>
  ///   Stroke Line Style
  /// </summary>
  public StrokeLineStyleKind? LineStyle { get; set; }

  /// <summary>
  ///   Miter Joint Limit
  /// </summary>
  public Decimal? MiterLimit { get; set; }

  /// <summary>
  ///   Line End Join Style)
  /// </summary>
  public StrokeJoinStyleKind? JoinStyle { get; set; }

  /// <summary>
  ///   Line End Cap
  /// </summary>
  public StrokeEndCapKind? EndCap { get; set; }

  /// <summary>
  ///   Stroke Dash Pattern
  /// </summary>
  public string? DashStyle { get; set; }

  /// <summary>
  ///   Inset Border From Path
  /// </summary>
  public bool? InsetPen { get; set; }

  /// <summary>
  ///   Stroke Image Style
  /// </summary>
  public FillKind? FillType { get; set; }

  /// <summary>
  ///   Stroke Image Location
  /// </summary>
  public string? Source { get; set; }

  /// <summary>
  ///   Stroke Image Aspect Ratio
  /// </summary>
  public ImageAspectKind? ImageAspect { get; set; }

  /// <summary>
  ///   Stroke Image Size
  /// </summary>
  public string? ImageSize { get; set; }

  /// <summary>
  ///   Stoke Image Alignment
  /// </summary>
  public bool? ImageAlignShape { get; set; }

  /// <summary>
  ///   Line Start Arrowhead
  /// </summary>
  public StrokeArrowKind? StartArrow { get; set; }

  /// <summary>
  ///   Line Start Arrowhead Width
  /// </summary>
  public StrokeArrowWidthKind? StartArrowWidth { get; set; }

  /// <summary>
  ///   Line Start Arrowhead Length
  /// </summary>
  public StrokeArrowLengthKind? StartArrowLength { get; set; }

  /// <summary>
  ///   Line End Arrowhead
  /// </summary>
  public StrokeArrowKind? EndArrow { get; set; }

  /// <summary>
  ///   Line End Arrowhead Width
  /// </summary>
  public StrokeArrowWidthKind? EndArrowWidth { get; set; }

  /// <summary>
  ///   Line End Arrowhead Length
  /// </summary>
  public StrokeArrowLengthKind? EndArrowLength { get; set; }

  /// <summary>
  ///   Original Image Reference
  /// </summary>
  public string? Href { get; set; }

  /// <summary>
  ///   Alternate Image Reference
  /// </summary>
  public string? AlternateImageReference { get; set; }

  /// <summary>
  ///   Stroke Title
  /// </summary>
  public string? Title { get; set; }

  /// <summary>
  ///   Force Dashed Outline
  /// </summary>
  public bool? ForceDash { get; set; }
}