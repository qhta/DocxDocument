namespace DocumentModel.Presentation;

/// <summary>
/// Condition.
/// </summary>
public interface ICondition // : DocumentModel.Presentation.ITimeListConditionalType
{
  public DocumentModel.Presentation.ITargetElement? TargetElement { get ; set; }
  
  public System.UInt32? TimeNode { get ; set; }
  
  public DocumentModel.Presentation.TriggerRuntimeNodeKind? RuntimeNodeTrigger { get ; set; }
  
}
