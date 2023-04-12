namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Data About Single Data Source Record.
/// </summary>
public class RecipientData: ModelElement
{
  /// <summary>
  ///   Record Is Included in Mail Merge.
  /// </summary>
  public Boolean? Active { get; set; }

  /// <summary>
  ///   Index of Column Containing Unique Values for Record.
  /// </summary>
  public UInt32? ColumnIndex { get; set; }

  /// <summary>
  ///   Unique Value for Record.
  /// </summary>
  public HexBinary? UniqueTag { get; set; }
}