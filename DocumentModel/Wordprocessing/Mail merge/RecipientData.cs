namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Data About Single Data ISource Record.
/// </summary>
public class RecipientData: ModelElement
{
  /// <summary>
  ///   Record Is Included in Mail Merge.
  /// </summary>
  public bool? Active { get; set; }

  /// <summary>
  ///   IIndex of IColumn Containing Unique Values for Record.
  /// </summary>
  public UInt32? ColumnIndex { get; set; }

  /// <summary>
  ///   Unique Value for Record.
  /// </summary>
  public HexBinary? UniqueTag { get; set; }
}
