namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single comment.
/// </summary>
public partial interface Comment : InteropObject
{
  /// <summary>
  /// The range.
  /// </summary>
  public Range Range { get; }

  /// <summary>
  /// The reference.
  /// </summary>
  public Range Reference { get; }

  /// <summary>
  /// The scope.
  /// </summary>
  public Range Scope { get; }

  /// <summary>
  /// The index.
  /// </summary>
  public int Index { get; }

  /// <summary>
  /// The author.
  /// </summary>
  public string Author { get; set; }

  /// <summary>
  /// The initial.
  /// </summary>
  public string Initial { get; set; }

  /// <summary>
  /// The show tip.
  /// </summary>
  public bool ShowTip { get; set; }

  /// <summary>
  /// The date.
  /// </summary>
  public DateTime Date { get; }

  /// <summary>
  /// The is ink.
  /// </summary>
  public bool IsInk { get; }

  /// <summary>
  /// The done.
  /// </summary>
  public bool Done { get; set; }

  /// <summary>
  /// The ancestor.
  /// </summary>
  public Comment Ancestor { get; }

  /// <summary>
  /// The contact.
  /// </summary>
  public CoAuthor Contact { get; }

  /// <summary>
  /// The replies.
  /// </summary>
  public Comments Replies { get; }
}
