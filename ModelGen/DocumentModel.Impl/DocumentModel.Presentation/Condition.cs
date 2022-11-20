namespace DocumentModel.Presentation;

/// <summary>
/// Condition.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Presentation.ITargetElement))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IRuntimeNodeTrigger))]
[ChildElementInfo(typeof(DocumentModel.Presentation.ITimeNode))]
public class Condition: ICondition
{
  /// <summary>
  /// Trigger Event
  /// </summary>
  public TriggerEventValues? Event
  {
    get;
    set;
  }
  
  /// <summary>
  /// Trigger Delay
  /// </summary>
  public string? Delay
  {
    get;
    set;
  }
  
  /// <summary>
  /// Target Element Trigger Choice.
  /// </summary>
  public ITargetElement? TargetElement
  {
    get;
    set;
  }
  
  /// <summary>
  /// Time Node.
  /// </summary>
  public ITimeNode? TimeNode
  {
    get;
    set;
  }
  
  /// <summary>
  /// Runtime Node Trigger Choice.
  /// </summary>
  public IRuntimeNodeTrigger? RuntimeNodeTrigger
  {
    get;
    set;
  }
  
}
