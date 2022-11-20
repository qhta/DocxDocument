namespace DocumentModel.Presentation;

/// <summary>
/// Parallel Time Node.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Presentation.ICommonTimeNode))]
public class ParallelTimeNode: IParallelTimeNode
{
  /// <summary>
  /// Parallel TimeNode.
  /// </summary>
  public ICommonTimeNode? CommonTimeNode
  {
    get;
    set;
  }
  
}
