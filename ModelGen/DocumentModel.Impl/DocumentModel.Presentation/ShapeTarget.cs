namespace DocumentModel.Presentation;

/// <summary>
/// Shape Target.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Presentation.IGraphicElement))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IBackgroundAnimation))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IOleChartElement))]
[ChildElementInfo(typeof(DocumentModel.Presentation.ISubShape))]
[ChildElementInfo(typeof(DocumentModel.Presentation.ITextElement))]
public class ShapeTarget: IShapeTarget
{
  /// <summary>
  /// Shape ID
  /// </summary>
  public string? ShapeId
  {
    get;
    set;
  }
  
  /// <summary>
  /// Background.
  /// </summary>
  public IBackgroundAnimation? BackgroundAnimation
  {
    get;
    set;
  }
  
  /// <summary>
  /// Subshape.
  /// </summary>
  public ISubShape? SubShape
  {
    get;
    set;
  }
  
  /// <summary>
  /// OLE Chart Element.
  /// </summary>
  public IOleChartElement? OleChartElement
  {
    get;
    set;
  }
  
  /// <summary>
  /// Text Element.
  /// </summary>
  public ITextElement? TextElement
  {
    get;
    set;
  }
  
  /// <summary>
  /// Graphic Element.
  /// </summary>
  public IGraphicElement? GraphicElement
  {
    get;
    set;
  }
  
}
