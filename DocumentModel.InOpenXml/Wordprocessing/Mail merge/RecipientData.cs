namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents data about a single data source record for mail merge in a WordprocessingML document.
/// This interface provides properties for record inclusion, unique column index, and unique value, enabling advanced configuration and management of recipient data for mail merge operations.
/// </summary>
public interface RecipientData: ICollectionItem
{
  /// <summary>
  /// Indicates whether the record is included in the mail merge.
  /// </summary>
  public bool? Active { get; set; }

  /// <summary>
  /// Index of the column containing unique values for the record, specified as a zero-based index.
  /// </summary>
  public UInt32? ColumnIndex { get; set; }

  /// <summary>
  /// Unique value for the record, specified as a hexadecimal binary value.
  /// </summary>
  public HexBinary? UniqueTag { get; set; }
}