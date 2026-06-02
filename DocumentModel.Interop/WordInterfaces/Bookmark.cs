namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single bookmark.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.bookmark?view=word-pia"/>
public partial interface IBookmark : IInteropObject
{
  /// <summary>
  /// Gets the name of the bookmark.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.bookmark.name?view=word-pia"/>
  public string Name { get; }

  /// <summary>
  /// Gets the range that represents the bookmark.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.bookmark.range?view=word-pia"/>
  public Range Range { get; }

  /// <summary>
  /// Gets a value indicating whether the bookmark is empty.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.bookmark.empty?view=word-pia"/>
  public bool Empty { get; }

  /// <summary>
  /// Gets or sets the starting character position of the bookmark.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.bookmark.start?view=word-pia"/>
  public int Start { get; set; }

  /// <summary>
  /// Gets or sets the ending character position of the bookmark.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.bookmark.end?view=word-pia"/>
  public int End { get; set; }

  /// <summary>
  /// Gets a value indicating whether the bookmark is a table column bookmark.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.bookmark.column?view=word-pia"/>
  public bool Column { get; }

  /// <summary>
  /// Gets the story type for the bookmark.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.bookmark.storytype?view=word-pia"/>
  public StoryType StoryType { get; }
}
