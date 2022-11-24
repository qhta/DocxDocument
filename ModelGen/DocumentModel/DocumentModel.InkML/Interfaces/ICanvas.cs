namespace DocumentModel.InkML;

/// <summary>
/// Defines the Canvas Class.
/// </summary>
public interface ICanvas // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// id
  /// </summary>
  public String? Id { get ; set; }
  
  /// <summary>
  /// traceFormatRef
  /// </summary>
  public String? TraceFormatRef { get ; set; }
  
  /// <summary>
  /// TraceFormat.
  /// </summary>
  public ITraceFormat? TraceFormat { get ; set; }
  
}
