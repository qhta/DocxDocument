namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single comment.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.comment?view=word-pia"/>
public partial interface Comment : InteropObject
{
  /// <summary>
  /// Gets the range that contains the comment text.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.comment.range?view=word-pia"/>
  public Range Range { get; }

  /// <summary>
  /// Gets the range marked by the comment reference mark.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.comment.reference?view=word-pia"/>
  public Range Reference { get; }

  /// <summary>
  /// Gets the range in the document to which the comment applies.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.comment.scope?view=word-pia"/>
  public Range Scope { get; }

  /// <summary>
  /// Gets the index number of the comment in the `Comments` collection.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.comment.index?view=word-pia"/>
  public int Index { get; }

  /// <summary>
  /// Gets or sets the name of the comment author.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.comment.author?view=word-pia"/>
  public string Author { get; set; }

  /// <summary>
  /// Gets or sets the initials of the comment author.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.comment.initial?view=word-pia"/>
  public string Initial { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether the comment tip is displayed.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.comment.showtip?view=word-pia"/>
  public bool ShowTip { get; set; }

  /// <summary>
  /// Gets the date and time when the comment was created.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.comment.date?view=word-pia"/>
  public DateTime Date { get; }

  /// <summary>
  /// Gets a value indicating whether the comment is an ink comment.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.comment.isink?view=word-pia"/>
  public bool IsInk { get; }

  /// <summary>
  /// Gets or sets a value indicating whether the comment is marked as done.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.comment.done?view=word-pia"/>
  public bool Done { get; set; }

  /// <summary>
  /// Gets the parent comment for a reply.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.comment.ancestor?view=word-pia"/>
  public Comment Ancestor { get; }

  /// <summary>
  /// Gets the co-author associated with the comment.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.comment.contact?view=word-pia"/>
  public CoAuthor Contact { get; }

  /// <summary>
  /// Gets the collection of replies to the comment.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.comment.replies?view=word-pia"/>
  public Comments Replies { get; }
}
