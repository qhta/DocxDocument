namespace DocumentModel.Presentation;

public interface IEndSync // : DocumentFormat.OpenXml.Presentation.TimeListConditionalType
{
  public TriggerEvent? Event { get ; set; }
  
  public string? Delay { get ; set; }
  
  public ITargetElement? TargetElement { get ; set; }
  
  public ITimeNode? TimeNode { get ; set; }
  
  public IRuntimeNodeTrigger? RuntimeNodeTrigger { get ; set; }
  
}
