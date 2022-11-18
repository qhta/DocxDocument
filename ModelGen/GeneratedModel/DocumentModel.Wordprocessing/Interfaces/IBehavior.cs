namespace DocumentModel.Wordprocessing;

/// <summary>
/// Entry Insertion Behavior.
/// </summary>
public interface IBehavior // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Insertion Behavior Value
  /// </summary>
  public DocPartBehavior? Val { get ; set; }
  
}
