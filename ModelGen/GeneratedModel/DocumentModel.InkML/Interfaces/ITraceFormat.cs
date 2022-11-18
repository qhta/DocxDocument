namespace DocumentModel.InkML;

/// <summary>
/// Defines the TraceFormat Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.InkML.IChannel))]
[ChildElementInfo(typeof(DocumentModel.InkML.IIntermittentChannels))]
public interface ITraceFormat // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// id
  /// </summary>
  public string? Id { get ; set; }
  
}
