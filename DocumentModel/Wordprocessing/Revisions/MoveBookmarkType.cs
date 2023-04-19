namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the MoveBookmarkType Class.
/// </summary>
public class MoveBookmarkType: MarkupRangeElement, IRangeMarkupElement, ICommonContent
{

  /// <summary>
  ///   name
  /// </summary>
  public string? Name { get; set; }

  /// <summary>
  ///   author
  /// </summary>
  public string? Author { get; set; }

  /// <summary>
  ///   date
  /// </summary>
  public DateTime? Date { get; set; }

  /// <summary>
  ///   colFirst
  /// </summary>
  public Int32? ColumnFirst { get; set; }

  /// <summary>
  ///   colLast
  /// </summary>
  public Int32? ColumnLast { get; set; }

}