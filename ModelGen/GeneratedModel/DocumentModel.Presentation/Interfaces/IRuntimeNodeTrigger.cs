namespace DocumentModel.Presentation;

/// <summary>
/// Runtime Node Trigger Choice.
/// </summary>
public interface IRuntimeNodeTrigger // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Value
  /// </summary>
  public TriggerRuntimeNode? Val { get ; set; }
  
}
