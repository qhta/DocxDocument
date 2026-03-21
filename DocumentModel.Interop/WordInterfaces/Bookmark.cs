namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single bookmark.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.bookmark?view=word-pia"/>
public partial interface Bookmark : InteropObject
{
  /// <summary>
  /// The name.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.bookmark.name?view=word-pia"/>
  public string Name { get; }

  /// <summary>
  /// The range.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.bookmark.range?view=word-pia"/>
  public Range Range { get; }

  /// <summary>
  /// The empty.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.bookmark.empty?view=word-pia"/>
  public bool Empty { get; }

  /// <summary>
  /// The start.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.bookmark.start?view=word-pia"/>
  public int Start { get; set; }

  /// <summary>
  /// The end.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.bookmark.end?view=word-pia"/>
  public int End { get; set; }

  /// <summary>
  /// The column.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.bookmark.column?view=word-pia"/>
  public bool Column { get; }

  /// <summary>
  /// The story type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.bookmark.storytype?view=word-pia"/>
  public WdStoryType StoryType { get; }
}
