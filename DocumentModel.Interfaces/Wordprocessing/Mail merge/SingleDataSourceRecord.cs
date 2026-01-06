namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the SingleDataSourceRecord Class.
/// </summary>
public interface SingleDataSourceRecord
{
  /// <summary>
  ///   RecordIncluded.
  /// </summary>
  public bool? RecordIncluded { get; set; }
  /// <summary>
  ///   RecordHashCode.
  /// </summary>
  public Int64? RecordHashCode { get; set; }
}