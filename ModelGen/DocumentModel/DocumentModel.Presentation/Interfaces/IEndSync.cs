namespace DocumentModel.Presentation;

/// <summary>
/// Defines the EndSync Class.
/// </summary>
public interface IEndSync // : DocumentModel.Presentation.ITimeListConditionalType
{
  public DocumentModel.Presentation.ITargetElement? TargetElement { get ; set; }
  
  public System.UInt32? TimeNode { get ; set; }
  
  public DocumentModel.Presentation.TriggerRuntimeNodeKind? RuntimeNodeTrigger { get ; set; }
  
}
