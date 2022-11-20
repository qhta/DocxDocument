namespace DocumentModel.Wordprocessing;

/// <summary>
/// Associated Status Text.
/// </summary>
public interface IStatusText // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Status Text Type
  /// </summary>
  public InfoTextValues? Type { get ; set; }
  
  /// <summary>
  /// Status Text Value
  /// </summary>
  public string? Val { get ; set; }
  
}
