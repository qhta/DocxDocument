namespace DocumentModel.Presentation;

/// <summary>
/// Exclusive.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Presentation.ICommonTimeNode))]
public class ExclusiveTimeNode: IExclusiveTimeNode
{
  /// <summary>
  /// Common TimeNode Properties.
  /// </summary>
  public ICommonTimeNode? CommonTimeNode
  {
    get;
    set;
  }
  
}
