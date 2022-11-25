namespace DocumentModel.InkML;

/// <summary>
/// Defines the Timestamp Class.
/// </summary>
public interface ITimestamp // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// id
  /// </summary>
  public System.String? Id { get ; set; }
  
  /// <summary>
  /// time
  /// </summary>
  public System.Decimal? Time { get ; set; }
  
  /// <summary>
  /// timestampRef
  /// </summary>
  public System.String? TimestampRef { get ; set; }
  
  /// <summary>
  /// timeString
  /// </summary>
  public System.DateTime? TimeString { get ; set; }
  
  /// <summary>
  /// timeOffset
  /// </summary>
  public System.Decimal? TimeOffset { get ; set; }
  
}
