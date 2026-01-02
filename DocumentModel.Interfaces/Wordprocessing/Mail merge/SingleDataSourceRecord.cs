namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the SingleDataSourceRecord Class.
/// </summary>
public class SingleDataSourceRecord: ModelElement
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