namespace DocumentModel.Presentation;

/// <summary>
/// Defines the TimeListConditionalType Class.
/// </summary>
public interface ITimeListConditionalType // : DocumentModel.ITypedOpenXmlCompositeElement
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
  public ITargetElement? TargetElement { get ; set; }
  
  /// <summary>
  /// Time Node.
  /// </summary>
  public UInt32? TimeNode { get ; set; }
  
  /// <summary>
  /// Runtime Node Trigger Choice.
  /// </summary>
  public TriggerRuntimeNodeKind? RuntimeNodeTrigger { get ; set; }
  
}
