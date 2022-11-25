namespace DocumentModel.Presentation;

/// <summary>
/// Defines the TimeListConditionalType Class.
/// </summary>
public interface ITimeListConditionalType // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Trigger Event
  /// </summary>
  public DocumentModel.Presentation.TriggerEventKind? Event { get ; set; }
  
  /// <summary>
  /// Trigger Delay
  /// </summary>
  public System.String? Delay { get ; set; }
  
  /// <summary>
  /// Target Element Trigger Choice.
  /// </summary>
  public DocumentModel.Presentation.ITargetElement? TargetElement { get ; set; }
  
  /// <summary>
  /// Time Node.
  /// </summary>
  public System.UInt32? TimeNode { get ; set; }
  
  /// <summary>
  /// Runtime Node Trigger Choice.
  /// </summary>
  public DocumentModel.Presentation.TriggerRuntimeNodeKind? RuntimeNodeTrigger { get ; set; }
  
}
