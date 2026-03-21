namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single comment.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.comment?view=word-pia"/>
public partial interface Comment : InteropObject
{
  /// <summary>
  /// The range.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.comment.range?view=word-pia"/>
  public Range Range { get; }

  /// <summary>
  /// The reference.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.comment.reference?view=word-pia"/>
  public Range Reference { get; }

  /// <summary>
  /// The scope.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.comment.scope?view=word-pia"/>
  public Range Scope { get; }

  /// <summary>
  /// The index.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.comment.index?view=word-pia"/>
  public int Index { get; }

  /// <summary>
  /// The author.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.comment.author?view=word-pia"/>
  public string Author { get; set; }

  /// <summary>
  /// The initial.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.comment.initial?view=word-pia"/>
  public string Initial { get; set; }

  /// <summary>
  /// The show tip.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.comment.showtip?view=word-pia"/>
  public bool ShowTip { get; set; }

  /// <summary>
  /// The date.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.comment.date?view=word-pia"/>
  public DateTime Date { get; }

  /// <summary>
  /// The is ink.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.comment.isink?view=word-pia"/>
  public bool IsInk { get; }

  /// <summary>
  /// The done.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.comment.done?view=word-pia"/>
  public bool Done { get; set; }

  /// <summary>
  /// The ancestor.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.comment.ancestor?view=word-pia"/>
  public Comment Ancestor { get; }

  /// <summary>
  /// The contact.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.comment.contact?view=word-pia"/>
  public CoAuthor Contact { get; }

  /// <summary>
  /// The replies.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.comment.replies?view=word-pia"/>
  public Comments Replies { get; }
}
