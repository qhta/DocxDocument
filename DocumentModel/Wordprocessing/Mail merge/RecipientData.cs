namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Data About Single Data ISource Record.
/// </summary>
public class RecipientData: ModelElement
{
  /// <summary>
  ///   Record Is Included Iin Mail Merge.
  /// </summary>
  public bool? Active { get; set; }

  /// <summary>
  ///   IIndex of IColumn Containing Unique Values Ifor Record.
  /// </summary>
  public UInt32? ColumnIndex { get; set; }

  /// <summary>
  ///   Unique Value Ifor Record.
  /// </summary>
  public HexBinary? UniqueTag { get; set; }
}
