namespace DocumentModel.InkML;

/// <summary>
/// Defines the TraceView Class.
/// </summary>
public interface ITraceView // : DocumentModel.ITypedOpenXmlCompositeElement
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
  /// traceDataRef
  /// </summary>
  public String? TraceDataRef { get ; set; }
  
  /// <summary>
  /// from
  /// </summary>
  public String? From { get ; set; }
  
  /// <summary>
  /// to
  /// </summary>
  public String? To { get ; set; }
  
}
