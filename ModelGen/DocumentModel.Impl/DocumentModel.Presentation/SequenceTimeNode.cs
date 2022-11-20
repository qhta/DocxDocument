namespace DocumentModel.Presentation;

/// <summary>
/// Sequence Time Node.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Presentation.ICommonTimeNode))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IPreviousConditionList))]
[ChildElementInfo(typeof(DocumentModel.Presentation.INextConditionList))]
public class SequenceTimeNode: ISequenceTimeNode
{
  /// <summary>
  /// Concurrent
  /// </summary>
  public bool? Concurrent
  {
    get;
    set;
  }
  
  /// <summary>
  /// Previous Action
  /// </summary>
  public PreviousActionValues? PreviousAction
  {
    get;
    set;
  }
  
  /// <summary>
  /// Next Action
  /// </summary>
  public NextActionValues? NextAction
  {
    get;
    set;
  }
  
  /// <summary>
  /// Common TimeNode Properties.
  /// </summary>
  public ICommonTimeNode? CommonTimeNode
  {
    get;
    set;
  }
  
  /// <summary>
  /// Previous Conditions List.
  /// </summary>
  public IPreviousConditionList? PreviousConditionList
  {
    get;
    set;
  }
  
  /// <summary>
  /// Next Conditions List.
  /// </summary>
  public INextConditionList? NextConditionList
  {
    get;
    set;
  }
  
}
