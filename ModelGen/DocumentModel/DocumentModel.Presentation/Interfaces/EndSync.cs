namespace DocumentModel.Presentation;

/// <summary>
/// Defines the EndSync Class.
/// </summary>
public interface EndSync // : DocumentModel.Presentation.TimeListConditionalType
{
  public TargetElement? TargetElement { get ; set; }
  
  public UInt32? TimeNode { get ; set; }
  
  public TriggerRuntimeNodeKind? RuntimeNodeTrigger { get ; set; }
  
}
