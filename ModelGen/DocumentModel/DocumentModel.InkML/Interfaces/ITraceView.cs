namespace DocumentModel.InkML;

/// <summary>
/// Defines the TraceView Class.
/// </summary>
public interface ITraceView // : DocumentModel.ITypedOpenXmlCompositeElement
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
  /// traceDataRef
  /// </summary>
  public System.String? TraceDataRef { get ; set; }
  
  /// <summary>
  /// from
  /// </summary>
  public System.String? From { get ; set; }
  
  /// <summary>
  /// to
  /// </summary>
  public System.String? To { get ; set; }
  
}
