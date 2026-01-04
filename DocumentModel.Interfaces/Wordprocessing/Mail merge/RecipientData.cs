namespace DocumentModel.Wordprocessing;

/// <summary>
///   Data About Single Data Source Record.
/// </summary>
public interface RecipientData: IModelElement
{
  /// <summary>
  ///   Record Is Included in Mail Merge.
  /// </summary>
  public bool? Active { get; set; }
  /// <summary>
  ///   Index of IColumn Containing Unique Values for Record.
  /// </summary>
  public UInt32? ColumnIndex { get; set; }
  /// <summary>
  ///   Unique Value for Record.
  /// </summary>
  public HexBinary? UniqueTag { get; set; }
}