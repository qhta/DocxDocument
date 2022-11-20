namespace DocumentModel.InkML;

/// <summary>
/// Defines the Context Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.InkML.IBrush))]
[ChildElementInfo(typeof(DocumentModel.InkML.ICanvas))]
[ChildElementInfo(typeof(DocumentModel.InkML.ICanvasTransform))]
[ChildElementInfo(typeof(DocumentModel.InkML.IInkSource))]
[ChildElementInfo(typeof(DocumentModel.InkML.ITimestamp))]
[ChildElementInfo(typeof(DocumentModel.InkML.ITraceFormat))]
public class Context: IContext
{
  /// <summary>
  /// id
  /// </summary>
  public string? Id
  {
    get;
    set;
  }
  
  /// <summary>
  /// contextRef
  /// </summary>
  public string? ContextRef
  {
    get;
    set;
  }
  
  /// <summary>
  /// canvasRef
  /// </summary>
  public string? CanvasRef
  {
    get;
    set;
  }
  
  /// <summary>
  /// canvasTransformRef
  /// </summary>
  public string? CanvasTransformRef
  {
    get;
    set;
  }
  
  /// <summary>
  /// traceFormatRef
  /// </summary>
  public string? TraceFromatRef
  {
    get;
    set;
  }
  
  /// <summary>
  /// inkSourceRef
  /// </summary>
  public string? InkSourceRef
  {
    get;
    set;
  }
  
  /// <summary>
  /// brushRef
  /// </summary>
  public string? BrushRef
  {
    get;
    set;
  }
  
  /// <summary>
  /// timestampRef
  /// </summary>
  public string? TimestampRef
  {
    get;
    set;
  }
  
  /// <summary>
  /// Canvas.
  /// </summary>
  public ICanvas? Canvas
  {
    get;
    set;
  }
  
  /// <summary>
  /// CanvasTransform.
  /// </summary>
  public ICanvasTransform? CanvasTransform
  {
    get;
    set;
  }
  
  /// <summary>
  /// TraceFormat.
  /// </summary>
  public ITraceFormat? TraceFormat
  {
    get;
    set;
  }
  
  /// <summary>
  /// InkSource.
  /// </summary>
  public IInkSource? InkSource
  {
    get;
    set;
  }
  
  /// <summary>
  /// Brush.
  /// </summary>
  public IBrush? Brush
  {
    get;
    set;
  }
  
  /// <summary>
  /// Timestamp.
  /// </summary>
  public ITimestamp? Timestamp
  {
    get;
    set;
  }
  
}
