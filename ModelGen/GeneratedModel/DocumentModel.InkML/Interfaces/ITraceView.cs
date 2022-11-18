namespace DocumentModel.InkML;

/// <summary>
/// Defines the TraceView Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.InkML.IAnnotation))]
[ChildElementInfo(typeof(DocumentModel.InkML.IAnnotationXml))]
[ChildElementInfo(typeof(DocumentModel.InkML.ITraceView))]
public interface ITraceView // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// id
  /// </summary>
  public string? Id { get ; set; }
  
  /// <summary>
  /// contextRef
  /// </summary>
  public string? ContextRef { get ; set; }
  
  /// <summary>
  /// traceDataRef
  /// </summary>
  public string? TraceDataRef { get ; set; }
  
  /// <summary>
  /// from
  /// </summary>
  public string? From { get ; set; }
  
  /// <summary>
  /// to
  /// </summary>
  public string? To { get ; set; }
  
}
