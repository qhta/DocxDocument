namespace DocumentModel.Presentation;

/// <summary>
/// Parallel Time Node.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Presentation.ICommonTimeNode))]
public interface IParallelTimeNode // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Parallel TimeNode.
  /// </summary>
  public ICommonTimeNode? CommonTimeNode { get ; set; }
  
}
