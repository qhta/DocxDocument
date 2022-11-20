namespace DocumentModel.InkML;

/// <summary>
/// Defines the Timestamp Class.
/// </summary>
public interface ITimestamp // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// id
  /// </summary>
  public string? Id { get ; set; }
  
  /// <summary>
  /// time
  /// </summary>
  public decimal? Time { get ; set; }
  
  /// <summary>
  /// timestampRef
  /// </summary>
  public string? TimestampRef { get ; set; }
  
  /// <summary>
  /// timeString
  /// </summary>
  public DateTime? TimeString { get ; set; }
  
  /// <summary>
  /// timeOffset
  /// </summary>
  public decimal? TimeOffset { get ; set; }
  
}
