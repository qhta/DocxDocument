namespace DocumentModel.Vml.Office;

/// <summary>
/// Defines the StrokeChildType Class.
/// </summary>
public interface IStrokeChildType // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public ExtensionHandlingBehaviorValues? Extension { get ; set; }
  
  /// <summary>
  /// Stroke Toggle
  /// </summary>
  public ITrueFalseValue? On { get ; set; }
  
  /// <summary>
  /// Stroke Weight
  /// </summary>
  public String? Weight { get ; set; }
  
  /// <summary>
  /// Stroke Color
  /// </summary>
  public String? Color { get ; set; }
  
  /// <summary>
  /// Stroke Alternate Pattern Color
  /// </summary>
  public String? Color2 { get ; set; }
  
  /// <summary>
  /// Stroke Opacity
  /// </summary>
  public String? Opacity { get ; set; }
  
  /// <summary>
  /// Stroke Line Style
  /// </summary>
  public StrokeLineStyleValues? LineStyle { get ; set; }
  
  /// <summary>
  /// Miter Joint Limit
  /// </summary>
  public Decimal? MiterLimit { get ; set; }
  
  /// <summary>
  /// Line End Join Style)
  /// </summary>
  public StrokeJoinStyleValues? JoinStyle { get ; set; }
  
  /// <summary>
  /// Line End Cap
  /// </summary>
  public StrokeEndCapValues? EndCap { get ; set; }
  
  /// <summary>
  /// Stroke Dash Pattern
  /// </summary>
  public String? DashStyle { get ; set; }
  
  /// <summary>
  /// Inset Border From Path
  /// </summary>
  public ITrueFalseValue? InsetPen { get ; set; }
  
  /// <summary>
  /// Stroke Image Style
  /// </summary>
  public FillTypeValues? FillType { get ; set; }
  
  /// <summary>
  /// Stroke Image Location
  /// </summary>
  public String? Source { get ; set; }
  
  /// <summary>
  /// Stroke Image Aspect Ratio
  /// </summary>
  public ImageAspectValues? ImageAspect { get ; set; }
  
  /// <summary>
  /// Stroke Image Size
  /// </summary>
  public String? ImageSize { get ; set; }
  
  /// <summary>
  /// Stoke Image Alignment
  /// </summary>
  public ITrueFalseValue? ImageAlignShape { get ; set; }
  
  /// <summary>
  /// Line Start Arrowhead
  /// </summary>
  public StrokeArrowValues? StartArrow { get ; set; }
  
  /// <summary>
  /// Line Start Arrowhead Width
  /// </summary>
  public StrokeArrowWidthValues? StartArrowWidth { get ; set; }
  
  /// <summary>
  /// Line Start Arrowhead Length
  /// </summary>
  public StrokeArrowLengthValues? StartArrowLength { get ; set; }
  
  /// <summary>
  /// Line End Arrowhead
  /// </summary>
  public StrokeArrowValues? EndArrow { get ; set; }
  
  /// <summary>
  /// Line End Arrowhead Width
  /// </summary>
  public StrokeArrowWidthValues? EndArrowWidth { get ; set; }
  
  /// <summary>
  /// Line End Arrowhead Length
  /// </summary>
  public StrokeArrowLengthValues? EndArrowLength { get ; set; }
  
  /// <summary>
  /// Original Image Reference
  /// </summary>
  public String? Href { get ; set; }
  
  /// <summary>
  /// Alternate Image Reference
  /// </summary>
  public String? AlternateImageReference { get ; set; }
  
  /// <summary>
  /// Stroke Title
  /// </summary>
  public String? Title { get ; set; }
  
  /// <summary>
  /// Force Dashed Outline
  /// </summary>
  public ITrueFalseValue? ForceDash { get ; set; }
  
}
