namespace DocumentModel.Presentation;

/// <summary>
/// Time Node List.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Presentation.IParallelTimeNode))]
public interface ITimeNodeList // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// ParallelTimeNode.
  /// </summary>
  public IParallelTimeNode? ParallelTimeNode { get ; set; }
  
}
