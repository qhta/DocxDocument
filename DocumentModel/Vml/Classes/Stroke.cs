namespace DocumentModel.Vml;

/// <summary>
/// Defines the Stroke Class.
/// </summary>
public partial class Stroke
{
  /// <summary>
  /// Unique Identifier
  /// </summary>
  public String? Id { get; set; }
  
  /// <summary>
  /// Stroke Toggle
  /// </summary>
  public Boolean? On { get; set; }
  
  /// <summary>
  /// Stroke Weight
  /// </summary>
  public String? Weight { get; set; }
  
  /// <summary>
  /// Stroke Color
  /// </summary>
  public String? Color { get; set; }
  
  /// <summary>
  /// Stroke Opacity
  /// </summary>
  public String? Opacity { get; set; }
  
  /// <summary>
  /// Stroke Line Style
  /// </summary>
  public DocumentModel.Vml.StrokeLineStyleKind? LineStyle { get; set; }
  
  /// <summary>
  /// Miter Joint Limit
  /// </summary>
  public String? Miterlimit { get; set; }
  
  /// <summary>
  /// Line End Join Style
  /// </summary>
  public DocumentModel.Vml.StrokeJoinStyleKind? JoinStyle { get; set; }
  
  /// <summary>
  /// Line End Cap
  /// </summary>
  public DocumentModel.Vml.StrokeEndCapKind? EndCap { get; set; }
  
  /// <summary>
  /// Stroke Dash Pattern
  /// </summary>
  public String? DashStyle { get; set; }
  
  /// <summary>
  /// Stroke Image Style
  /// </summary>
  public DocumentModel.Vml.StrokeFillKind? FillType { get; set; }
  
  /// <summary>
  /// Stroke Image Location
  /// </summary>
  public String? Source { get; set; }
  
  /// <summary>
  /// Stroke Image Aspect Ratio
  /// </summary>
  public DocumentModel.Vml.ImageAspectKind? ImageAspect { get; set; }
  
  /// <summary>
  /// Stroke Image Size
  /// </summary>
  public String? ImageSize { get; set; }
  
  /// <summary>
  /// Stoke Image Alignment
  /// </summary>
  public Boolean? ImageAlignShape { get; set; }
  
  /// <summary>
  /// Stroke Alternate Pattern Color
  /// </summary>
  public String? Color2 { get; set; }
  
  /// <summary>
  /// Line Start Arrowhead
  /// </summary>
  public DocumentModel.Vml.StrokeArrowKind? StartArrow { get; set; }
  
  /// <summary>
  /// Line Start Arrowhead Width
  /// </summary>
  public DocumentModel.Vml.StrokeArrowWidthKind? StartArrowWidth { get; set; }
  
  /// <summary>
  /// Line Start Arrowhead Length
  /// </summary>
  public DocumentModel.Vml.StrokeArrowLengthKind? StartArrowLength { get; set; }
  
  /// <summary>
  /// Line End Arrowhead
  /// </summary>
  public DocumentModel.Vml.StrokeArrowKind? EndArrow { get; set; }
  
  /// <summary>
  /// Line End Arrowhead Width
  /// </summary>
  public DocumentModel.Vml.StrokeArrowWidthKind? EndArrowWidth { get; set; }
  
  /// <summary>
  /// Line End Arrowhead Length
  /// </summary>
  public DocumentModel.Vml.StrokeArrowLengthKind? EndArrowLength { get; set; }
  
  /// <summary>
  /// Original Image Reference
  /// </summary>
  public String? Href { get; set; }
  
  /// <summary>
  /// Alternate Image Reference
  /// </summary>
  public String? AlternateImageReference { get; set; }
  
  /// <summary>
  /// Stroke Title
  /// </summary>
  public String? Title { get; set; }
  
  /// <summary>
  /// Force Dashed Outline
  /// </summary>
  public Boolean? ForceDash { get; set; }
  
  /// <summary>
  /// Relationship
  /// </summary>
  public String? RelationshipId { get; set; }
  
  /// <summary>
  /// Inset Border From Path
  /// </summary>
  public Boolean? Insetpen { get; set; }
  
  /// <summary>
  /// LeftStroke.
  /// </summary>
  public DocumentModel.Vml.StrokeChildType? LeftStroke { get; set; }
  
  /// <summary>
  /// TopStroke.
  /// </summary>
  public DocumentModel.Vml.StrokeChildType? TopStroke { get; set; }
  
  /// <summary>
  /// RightStroke.
  /// </summary>
  public DocumentModel.Vml.StrokeChildType? RightStroke { get; set; }
  
  /// <summary>
  /// BottomStroke.
  /// </summary>
  public DocumentModel.Vml.StrokeChildType? BottomStroke { get; set; }
  
  /// <summary>
  /// ColumnStroke.
  /// </summary>
  public DocumentModel.Vml.StrokeChildType? ColumnStroke { get; set; }
  
}
