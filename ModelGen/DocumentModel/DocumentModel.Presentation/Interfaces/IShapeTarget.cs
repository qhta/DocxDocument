namespace DocumentModel.Presentation;

/// <summary>
/// Shape Target.
/// </summary>
public interface IShapeTarget // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Shape ID
  /// </summary>
  public System.String? ShapeId { get ; set; }
  
  /// <summary>
  /// Background.
  /// </summary>
  public System.Boolean? BackgroundAnimation { get ; set; }
  
  /// <summary>
  /// Subshape.
  /// </summary>
  public DocumentModel.Presentation.ITimeListSubShapeIdType? SubShape { get ; set; }
  
  /// <summary>
  /// OLE Chart Element.
  /// </summary>
  public DocumentModel.Presentation.IOleChartElement? OleChartElement { get ; set; }
  
  /// <summary>
  /// Text Element.
  /// </summary>
  public DocumentModel.Presentation.ITextElement? TextElement { get ; set; }
  
  /// <summary>
  /// Graphic Element.
  /// </summary>
  public DocumentModel.Presentation.IGraphicElement? GraphicElement { get ; set; }
  
}
