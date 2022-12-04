namespace DocumentModel.Vml;

/// <summary>
/// Defines the StrokeChildType Class.
/// </summary>
public class StrokeChildType
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public ExtensionHandlingBehaviorKind? Extension
  {
    get;
    set;
  }
  
  /// <summary>
  /// Stroke Line Style
  /// </summary>
  public StrokeLineStyleKind? LineStyle
  {
    get;
    set;
  }
  
  /// <summary>
  /// Line End Join Style)
  /// </summary>
  public StrokeJoinStyleKind? JoinStyle
  {
    get;
    set;
  }
  
  /// <summary>
  /// Line End Cap
  /// </summary>
  public StrokeEndCapKind? EndCap
  {
    get;
    set;
  }
  
  /// <summary>
  /// Stroke Image Style
  /// </summary>
  public FillKind? FillType
  {
    get;
    set;
  }
  
  /// <summary>
  /// Stroke Image Aspect Ratio
  /// </summary>
  public ImageAspectKind? ImageAspect
  {
    get;
    set;
  }
  
  /// <summary>
  /// Line Start Arrowhead
  /// </summary>
  public StrokeArrowKind? StartArrow
  {
    get;
    set;
  }
  
  /// <summary>
  /// Line Start Arrowhead Width
  /// </summary>
  public StrokeArrowWidthKind? StartArrowWidth
  {
    get;
    set;
  }
  
  /// <summary>
  /// Line Start Arrowhead Length
  /// </summary>
  public StrokeArrowLengthKind? StartArrowLength
  {
    get;
    set;
  }
  
  /// <summary>
  /// Line End Arrowhead
  /// </summary>
  public StrokeArrowKind? EndArrow
  {
    get;
    set;
  }
  
  /// <summary>
  /// Line End Arrowhead Width
  /// </summary>
  public StrokeArrowWidthKind? EndArrowWidth
  {
    get;
    set;
  }
  
  /// <summary>
  /// Line End Arrowhead Length
  /// </summary>
  public StrokeArrowLengthKind? EndArrowLength
  {
    get;
    set;
  }
  
}
