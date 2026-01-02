namespace DocumentModel.Vml;

/// <summary>
///   Defines the Stroke Class.
/// </summary>
public class Stroke: ModelElement
{
  /// <summary>
  ///   Unique Identifier
  /// </summary>
  public string? Id { get; set; }
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
  public string? Miterlimit { get; set; }
  /// <summary>
  ///   Line End Join Style
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
  ///   Stroke Image Style
  /// </summary>
  public StrokeFillKind? FillType { get; set; }
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
  ///   Stroke Alternate Pattern Color
  /// </summary>
  public string? Color2 { get; set; }
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
  /// <summary>
  ///   Relationship
  /// </summary>
  public string? RelationshipId { get; set; }
  /// <summary>
  ///   Inset Border From Path
  /// </summary>
  public bool? Insetpen { get; set; }
  /// <summary>
  ///   LeftStroke.
  /// </summary>
  public StrokeChildType? LeftStroke { get; set; }
  /// <summary>
  ///   TopStroke.
  /// </summary>
  public StrokeChildType? TopStroke { get; set; }
  /// <summary>
  ///   RightStroke.
  /// </summary>
  public StrokeChildType? RightStroke { get; set; }
  /// <summary>
  ///   BottomStroke.
  /// </summary>
  public StrokeChildType? BottomStroke { get; set; }
  /// <summary>
  ///   ColumnStroke.
  /// </summary>
  public StrokeChildType? ColumnStroke { get; set; }
}