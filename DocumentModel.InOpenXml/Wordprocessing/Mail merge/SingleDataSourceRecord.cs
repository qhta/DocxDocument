namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a single data source record for mail merge in a WordprocessingML document.
/// This class extends <see cref="CollectionItem"/> and provides properties for record inclusion and a unique hash code, enabling advanced configuration and management of individual recipient records in mail merge operations.
/// </summary>
public class SingleDataSourceRecord: ModelElement<DXOW.SingleDataSourceRecord>
{
  /// <summary>
  /// Indicates whether the record is included in the mail merge.
  /// </summary>
  public bool? RecordIncluded { get; set; }

  /// <summary>
  /// Unique hash code for the record, used to identify and track the record in the data source.
  /// </summary>
  public Int64? RecordHashCode { get; set; }
}