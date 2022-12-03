namespace DocumentModel.Presentation;

/// <summary>
/// Shape Target.
/// </summary>
public interface ShapeTarget // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Shape ID
  /// </summary>
  public String? ShapeId { get ; set; }
  
  /// <summary>
  /// Background.
  /// </summary>
  public Boolean? BackgroundAnimation { get ; set; }
  
  /// <summary>
  /// Subshape.
  /// </summary>
  public TimeListSubShapeIdType? SubShape { get ; set; }
  
  /// <summary>
  /// OLE Chart Element.
  /// </summary>
  public OleChartElement? OleChartElement { get ; set; }
  
  /// <summary>
  /// Text Element.
  /// </summary>
  public TextElement? TextElement { get ; set; }
  
  /// <summary>
  /// Graphic Element.
  /// </summary>
  public GraphicElement? GraphicElement { get ; set; }
  
}
