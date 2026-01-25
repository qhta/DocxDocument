namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a move bookmark type for tracked move revisions in a WordprocessingML document.
/// This class extends <see cref = "IdentifiedChange"/>, <see cref = "MarkupRangeElement"/>, and <see cref = "ICommonContent"/>, providing properties for the bookmark name, author, date, and column range. Used to group and identify content that has been moved as part of a single named move, enabling revision tracking and review of content relocations within tables and other structures.
/// </summary>
public abstract partial class MoveBookmarkType<T1, T2> : MarkupStartRangeElement<T1, T2>,  ICommonContent 
  where T1: DXW.MoveBookmarkType
  where T2: DX.OpenXmlElement
{
  /// <summary>
  /// FontName of the move bookmark, used to link move source and destination content.
  /// </summary>
  public string? Name { get; set; }
  /// <summary>
  /// First column index for the move, used to specify the column range affected by the move in tables.
  /// </summary>
  public Int32? ColumnFirst { get; set; }
  /// <summary>
  /// Last column index for the move, used to specify the column range affected by the move in tables.
  /// </summary>
  public Int32? ColumnLast { get; set; }


}