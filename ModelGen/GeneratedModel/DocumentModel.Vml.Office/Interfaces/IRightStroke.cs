namespace DocumentModel.Vml.Office;

/// <summary>
/// Text Box Right Stroke.
/// </summary>
public interface IRightStroke // : DocumentFormat.OpenXml.Vml.Office.StrokeChildType
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public ExtensionHandlingBehavior? Extension { get ; set; }
  
  /// <summary>
  /// Stroke Toggle
  /// </summary>
  public ITrueFalseValue? On { get ; set; }
  
  /// <summary>
  /// Stroke Weight
  /// </summary>
  public string? Weight { get ; set; }
  
  /// <summary>
  /// Stroke Color
  /// </summary>
  public string? Color { get ; set; }
  
  /// <summary>
  /// Stroke Alternate Pattern Color
  /// </summary>
  public string? Color2 { get ; set; }
  
  /// <summary>
  /// Stroke Opacity
  /// </summary>
  public string? Opacity { get ; set; }
  
  /// <summary>
  /// Stroke Line Style
  /// </summary>
  public StrokeLineStyle? LineStyle { get ; set; }
  
  /// <summary>
  /// Miter Joint Limit
  /// </summary>
  public decimal? MiterLimit { get ; set; }
  
  /// <summary>
  /// Line End Join Style)
  /// </summary>
  public StrokeJoinStyle? JoinStyle { get ; set; }
  
  /// <summary>
  /// Line End Cap
  /// </summary>
  public StrokeEndCap? EndCap { get ; set; }
  
  /// <summary>
  /// Stroke Dash Pattern
  /// </summary>
  public string? DashStyle { get ; set; }
  
  /// <summary>
  /// Inset Border From Path
  /// </summary>
  public ITrueFalseValue? InsetPen { get ; set; }
  
  /// <summary>
  /// Stroke Image Style
  /// </summary>
  public FillType? FillType { get ; set; }
  
  /// <summary>
  /// Stroke Image Location
  /// </summary>
  public string? Source { get ; set; }
  
  /// <summary>
  /// Stroke Image Aspect Ratio
  /// </summary>
  public ImageAspect? ImageAspect { get ; set; }
  
  /// <summary>
  /// Stroke Image Size
  /// </summary>
  public string? ImageSize { get ; set; }
  
  /// <summary>
  /// Stoke Image Alignment
  /// </summary>
  public ITrueFalseValue? ImageAlignShape { get ; set; }
  
  /// <summary>
  /// Line Start Arrowhead
  /// </summary>
  public StrokeArrow? StartArrow { get ; set; }
  
  /// <summary>
  /// Line Start Arrowhead Width
  /// </summary>
  public StrokeArrowWidth? StartArrowWidth { get ; set; }
  
  /// <summary>
  /// Line Start Arrowhead Length
  /// </summary>
  public StrokeArrowLength? StartArrowLength { get ; set; }
  
  /// <summary>
  /// Line End Arrowhead
  /// </summary>
  public StrokeArrow? EndArrow { get ; set; }
  
  /// <summary>
  /// Line End Arrowhead Width
  /// </summary>
  public StrokeArrowWidth? EndArrowWidth { get ; set; }
  
  /// <summary>
  /// Line End Arrowhead Length
  /// </summary>
  public StrokeArrowLength? EndArrowLength { get ; set; }
  
  /// <summary>
  /// Original Image Reference
  /// </summary>
  public string? Href { get ; set; }
  
  /// <summary>
  /// Alternate Image Reference
  /// </summary>
  public string? AlternateImageReference { get ; set; }
  
  /// <summary>
  /// Stroke Title
  /// </summary>
  public string? Title { get ; set; }
  
  /// <summary>
  /// Force Dashed Outline
  /// </summary>
  public ITrueFalseValue? ForceDash { get ; set; }
  
}
