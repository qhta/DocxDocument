namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the SingleDataSourceRecord Class.
/// </summary>
public partial interface SingleDataSourceRecord
{
  /// <summary>
  /// RecordIncluded.
  /// </summary>
  public Boolean? RecordIncluded { get; set; }
  
  /// <summary>
  /// RecordHashCode.
  /// </summary>
  public Int32? RecordHashCode { get; set; }
  
}
