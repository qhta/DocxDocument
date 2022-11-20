namespace DocumentModel.Presentation;

/// <summary>
/// Time Node List.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Presentation.IParallelTimeNode))]
public class TimeNodeList: ITimeNodeList
{
  /// <summary>
  /// ParallelTimeNode.
  /// </summary>
  public IParallelTimeNode? ParallelTimeNode
  {
    get;
    set;
  }
  
}
