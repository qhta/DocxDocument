namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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