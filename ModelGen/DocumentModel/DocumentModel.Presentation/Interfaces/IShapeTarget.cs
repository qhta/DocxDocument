namespace DocumentModel.Presentation;

/// <summary>
/// Shape Target.
/// </summary>
public interface IShapeTarget // : DocumentModel.ITypedOpenXmlCompositeElement
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
  public ITimeListSubShapeIdType? SubShape { get ; set; }
  
  /// <summary>
  /// OLE Chart Element.
  /// </summary>
  public IOleChartElement? OleChartElement { get ; set; }
  
  /// <summary>
  /// Text Element.
  /// </summary>
  public ITextElement? TextElement { get ; set; }
  
  /// <summary>
  /// Graphic Element.
  /// </summary>
  public IGraphicElement? GraphicElement { get ; set; }
  
}
