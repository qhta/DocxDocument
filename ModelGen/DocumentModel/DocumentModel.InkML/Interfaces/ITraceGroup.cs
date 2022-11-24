namespace DocumentModel.InkML;

/// <summary>
/// Defines the TraceGroup Class.
/// </summary>
public interface ITraceGroup // : DocumentModel.ITypedOpenXmlCompositeElement
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
  /// brushRef
  /// </summary>
  public String? BrushRef { get ; set; }
  
}
