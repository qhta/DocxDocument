namespace DocumentModel.InkML;

/// <summary>
/// Defines the Context Class.
/// </summary>
public interface IContext // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// id
  /// </summary>
  public String? Id { get ; set; }
  
  /// <summary>
  /// contextRef
  /// </summary>
  public String? ContextRef { get ; set; }
  
  /// <summary>
  /// canvasRef
  /// </summary>
  public String? CanvasRef { get ; set; }
  
  /// <summary>
  /// canvasTransformRef
  /// </summary>
  public String? CanvasTransformRef { get ; set; }
  
  /// <summary>
  /// traceFormatRef
  /// </summary>
  public String? TraceFromatRef { get ; set; }
  
  /// <summary>
  /// inkSourceRef
  /// </summary>
  public String? InkSourceRef { get ; set; }
  
  /// <summary>
  /// brushRef
  /// </summary>
  public String? BrushRef { get ; set; }
  
  /// <summary>
  /// timestampRef
  /// </summary>
  public String? TimestampRef { get ; set; }
  
  /// <summary>
  /// Canvas.
  /// </summary>
  public ICanvas? Canvas { get ; set; }
  
  /// <summary>
  /// CanvasTransform.
  /// </summary>
  public ICanvasTransform? CanvasTransform { get ; set; }
  
  /// <summary>
  /// TraceFormat.
  /// </summary>
  public ITraceFormat? TraceFormat { get ; set; }
  
  /// <summary>
  /// InkSource.
  /// </summary>
  public InkSource? InkSource { get ; set; }
  
  /// <summary>
  /// Brush.
  /// </summary>
  public IBrush? Brush { get ; set; }
  
  /// <summary>
  /// Timestamp.
  /// </summary>
  public ITimestamp? Timestamp { get ; set; }
  
}
