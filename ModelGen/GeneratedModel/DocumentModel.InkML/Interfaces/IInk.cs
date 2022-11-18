namespace DocumentModel.InkML;

/// <summary>
/// Defines Ink.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.InkML.IAnnotation))]
[ChildElementInfo(typeof(DocumentModel.InkML.IAnnotationXml))]
[ChildElementInfo(typeof(DocumentModel.InkML.IContext))]
[ChildElementInfo(typeof(DocumentModel.InkML.IDefinitions))]
[ChildElementInfo(typeof(DocumentModel.InkML.ITrace))]
[ChildElementInfo(typeof(DocumentModel.InkML.ITraceGroup))]
[ChildElementInfo(typeof(DocumentModel.InkML.ITraceView))]
public interface IInk // : DocumentFormat.OpenXml.TypedOpenXmlPartRootElement
{
  /// <summary>
  /// documentID
  /// </summary>
  public string? DocumentId { get ; set; }
  
}
