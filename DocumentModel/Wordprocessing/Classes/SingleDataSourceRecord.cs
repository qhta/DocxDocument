namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the SingleDataSourceRecord Class.
/// </summary>
public record SingleDataSourceRecord
{
  /// <summary>
  ///   RecordIncluded.
  /// </summary>
  public Boolean? RecordIncluded { get; set; }

  /// <summary>
  ///   RecordHashCode.
  /// </summary>
  public Int64? RecordHashCode { get; set; }
}