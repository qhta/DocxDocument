namespace DocumentModel.InkML;

/// <summary>
/// Defines the Canvas Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.InkML.ITraceFormat))]
public interface ICanvas // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// id
  /// </summary>
  public string? Id { get ; set; }
  
  /// <summary>
  /// traceFormatRef
  /// </summary>
  public string? TraceFormatRef { get ; set; }
  
  /// <summary>
  /// TraceFormat.
  /// </summary>
  public ITraceFormat? TraceFormat { get ; set; }
  
}
