namespace DocumentModel.InkML;

/// <summary>
/// Defines the Canvas Class.
/// </summary>
public interface ICanvas // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// id
  /// </summary>
  public System.String? Id { get ; set; }
  
  /// <summary>
  /// traceFormatRef
  /// </summary>
  public System.String? TraceFormatRef { get ; set; }
  
  /// <summary>
  /// TraceFormat.
  /// </summary>
  public DocumentModel.InkML.ITraceFormat? TraceFormat { get ; set; }
  
}
