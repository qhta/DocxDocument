namespace DocumentModel.Presentation;

/// <summary>
/// Condition.
/// </summary>
public interface Condition // : DocumentModel.Presentation.TimeListConditionalType
{
  public TargetElement? TargetElement { get ; set; }
  
  public UInt32? TimeNode { get ; set; }
  
  public TriggerRuntimeNodeKind? RuntimeNodeTrigger { get ; set; }
  
}
