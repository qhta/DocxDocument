namespace DocumentModel.Vml;

/// <summary>
/// Defines the Stroke Class.
/// </summary>
public class Stroke
{
  /// <summary>
  /// Stroke Line Style
  /// </summary>
  public StrokeLineStyleKind? LineStyle
  {
    get;
    set;
  }
  
  /// <summary>
  /// Line End Join Style
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
  public StrokeFillKind? FillType
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
  
  /// <summary>
  /// LeftStroke.
  /// </summary>
  public StrokeChildType? LeftStroke
  {
    get;
    set;
  }
  
  /// <summary>
  /// TopStroke.
  /// </summary>
  public StrokeChildType? TopStroke
  {
    get;
    set;
  }
  
  /// <summary>
  /// RightStroke.
  /// </summary>
  public StrokeChildType? RightStroke
  {
    get;
    set;
  }
  
  /// <summary>
  /// BottomStroke.
  /// </summary>
  public StrokeChildType? BottomStroke
  {
    get;
    set;
  }
  
  /// <summary>
  /// ColumnStroke.
  /// </summary>
  public StrokeChildType? ColumnStroke
  {
    get;
    set;
  }
  
}
