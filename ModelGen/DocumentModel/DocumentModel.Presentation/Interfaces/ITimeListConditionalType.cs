namespace DocumentModel.Presentation;

/// <summary>
/// Defines the TimeListConditionalType Class.
/// </summary>
public interface ITimeListConditionalType // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Trigger Event
  /// </summary>
  public TriggerEventValues? Event { get ; set; }
  
  /// <summary>
  /// Trigger Delay
  /// </summary>
  public String? Delay { get ; set; }
  
  /// <summary>
  /// Target Element Trigger Choice.
  /// </summary>
  public ITargetElement? TargetElement { get ; set; }
  
  /// <summary>
  /// Time Node.
  /// </summary>
  public ITimeNode? TimeNode { get ; set; }
  
  /// <summary>
  /// Runtime Node Trigger Choice.
  /// </summary>
  public IRuntimeNodeTrigger? RuntimeNodeTrigger { get ; set; }
  
}
