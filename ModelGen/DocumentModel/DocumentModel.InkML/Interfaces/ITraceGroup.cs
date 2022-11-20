namespace DocumentModel.InkML;

/// <summary>
/// Defines the TraceGroup Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.InkML.IAnnotation))]
[ChildElementInfo(typeof(DocumentModel.InkML.IAnnotationXml))]
[ChildElementInfo(typeof(DocumentModel.InkML.ITrace))]
[ChildElementInfo(typeof(DocumentModel.InkML.ITraceGroup))]
public interface ITraceGroup // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
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
  /// brushRef
  /// </summary>
  public string? BrushRef { get ; set; }
  
}
