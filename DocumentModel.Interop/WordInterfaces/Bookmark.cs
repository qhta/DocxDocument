namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single bookmark.
/// </summary>
public partial interface Bookmark : InteropObject
{
  /// <summary>
  /// The name.
  /// </summary>
  public string Name { get; }

  /// <summary>
  /// The range.
  /// </summary>
  public Range Range { get; }

  /// <summary>
  /// The empty.
  /// </summary>
  public bool Empty { get; }

  /// <summary>
  /// The start.
  /// </summary>
  public int Start { get; set; }

  /// <summary>
  /// The end.
  /// </summary>
  public int End { get; set; }

  /// <summary>
  /// The column.
  /// </summary>
  public bool Column { get; }

  /// <summary>
  /// The story type.
  /// </summary>
  public WdStoryType StoryType { get; }
}
