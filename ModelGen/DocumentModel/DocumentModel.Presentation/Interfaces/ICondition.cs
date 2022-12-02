namespace DocumentModel.Presentation;

/// <summary>
/// Condition.
/// </summary>
public interface ICondition // : DocumentModel.Presentation.ITimeListConditionalType
{
  public ITargetElement? TargetElement { get ; set; }
  
  public UInt32? TimeNode { get ; set; }
  
  public TriggerRuntimeNodeKind? RuntimeNodeTrigger { get ; set; }
  
}
