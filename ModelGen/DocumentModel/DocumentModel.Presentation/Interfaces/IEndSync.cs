namespace DocumentModel.Presentation;

/// <summary>
/// Defines the EndSync Class.
/// </summary>
public interface IEndSync // : DocumentModel.Presentation.ITimeListConditionalType
{
  public ITargetElement? TargetElement { get ; set; }
  
  public UInt32? TimeNode { get ; set; }
  
  public TriggerRuntimeNodeKind? RuntimeNodeTrigger { get ; set; }
  
}
