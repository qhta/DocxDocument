namespace DocumentModel.Vml;

/// <summary>
/// Defines the StrokeChildType Class.
/// </summary>
public partial interface StrokeChildType
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public DocumentModel.Vml.ExtensionHandlingBehaviorKind? Extension { get; set; }
  
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
  /// Stroke Alternate Pattern Color
  /// </summary>
  public String? Color2 { get; set; }
  
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
  public Decimal? MiterLimit { get; set; }
  
  /// <summary>
  /// Line End Join Style)
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
  /// Inset Border From Path
  /// </summary>
  public Boolean? InsetPen { get; set; }
  
  /// <summary>
  /// Stroke Image Style
  /// </summary>
  public DocumentModel.Vml.FillKind? FillType { get; set; }
  
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
  
}
