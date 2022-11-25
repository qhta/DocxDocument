namespace DocumentModel.InkML;

/// <summary>
/// Defines the Context Class.
/// </summary>
public interface IContext // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// id
  /// </summary>
  public System.String? Id { get ; set; }
  
  /// <summary>
  /// contextRef
  /// </summary>
  public System.String? ContextRef { get ; set; }
  
  /// <summary>
  /// canvasRef
  /// </summary>
  public System.String? CanvasRef { get ; set; }
  
  /// <summary>
  /// canvasTransformRef
  /// </summary>
  public System.String? CanvasTransformRef { get ; set; }
  
  /// <summary>
  /// traceFormatRef
  /// </summary>
  public System.String? TraceFromatRef { get ; set; }
  
  /// <summary>
  /// inkSourceRef
  /// </summary>
  public System.String? InkSourceRef { get ; set; }
  
  /// <summary>
  /// brushRef
  /// </summary>
  public System.String? BrushRef { get ; set; }
  
  /// <summary>
  /// timestampRef
  /// </summary>
  public System.String? TimestampRef { get ; set; }
  
  /// <summary>
  /// Canvas.
  /// </summary>
  public DocumentModel.InkML.ICanvas? Canvas { get ; set; }
  
  /// <summary>
  /// CanvasTransform.
  /// </summary>
  public DocumentModel.InkML.ICanvasTransform? CanvasTransform { get ; set; }
  
  /// <summary>
  /// TraceFormat.
  /// </summary>
  public DocumentModel.InkML.ITraceFormat? TraceFormat { get ; set; }
  
  /// <summary>
  /// InkSource.
  /// </summary>
  public DocumentModel.InkML.IInkSource? InkSource { get ; set; }
  
  /// <summary>
  /// Brush.
  /// </summary>
  public DocumentModel.InkML.IBrush? Brush { get ; set; }
  
  /// <summary>
  /// Timestamp.
  /// </summary>
  public DocumentModel.InkML.ITimestamp? Timestamp { get ; set; }
  
}
