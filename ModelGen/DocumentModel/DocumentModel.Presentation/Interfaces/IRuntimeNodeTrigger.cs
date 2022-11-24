namespace DocumentModel.Presentation;

/// <summary>
/// Runtime Node Trigger Choice.
/// </summary>
public interface IRuntimeNodeTrigger // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Value
  /// </summary>
  public TriggerRuntimeNodeValues? Val { get ; set; }
  
}
