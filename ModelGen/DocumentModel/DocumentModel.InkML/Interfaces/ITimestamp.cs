namespace DocumentModel.InkML;

/// <summary>
/// Defines the Timestamp Class.
/// </summary>
public interface ITimestamp // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// id
  /// </summary>
  public String? Id { get ; set; }
  
  /// <summary>
  /// time
  /// </summary>
  public Decimal? Time { get ; set; }
  
  /// <summary>
  /// timestampRef
  /// </summary>
  public String? TimestampRef { get ; set; }
  
  /// <summary>
  /// timeString
  /// </summary>
  public DateTime? TimeString { get ; set; }
  
  /// <summary>
  /// timeOffset
  /// </summary>
  public Decimal? TimeOffset { get ; set; }
  
}
