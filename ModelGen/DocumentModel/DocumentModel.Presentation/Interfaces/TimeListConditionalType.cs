namespace DocumentModel.Presentation;

/// <summary>
/// Defines the TimeListConditionalType Class.
/// </summary>
public interface TimeListConditionalType // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Trigger Event
  /// </summary>
  public TriggerEventKind? Event { get ; set; }
  
  /// <summary>
  /// Trigger Delay
  /// </summary>
  public String? Delay { get ; set; }
  
  /// <summary>
  /// Target Element Trigger Choice.
  /// </summary>
  public TargetElement? TargetElement { get ; set; }
  
  /// <summary>
  /// Time Node.
  /// </summary>
  public UInt32? TimeNode { get ; set; }
  
  /// <summary>
  /// Runtime Node Trigger Choice.
  /// </summary>
  public TriggerRuntimeNodeKind? RuntimeNodeTrigger { get ; set; }
  
}
