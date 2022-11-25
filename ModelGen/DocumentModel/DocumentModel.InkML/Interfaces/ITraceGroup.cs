namespace DocumentModel.InkML;

/// <summary>
/// Defines the TraceGroup Class.
/// </summary>
public interface ITraceGroup // : DocumentModel.ITypedOpenXmlCompositeElement
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
  /// brushRef
  /// </summary>
  public System.String? BrushRef { get ; set; }
  
}
