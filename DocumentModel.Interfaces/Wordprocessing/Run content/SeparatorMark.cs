namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a separator mark within the current run in a WordprocessingML document.
/// A separator mark is a horizontal line used to separate the main document story from the contents of footnotes or endnotes on a page. It is typically used in the context of separator footnotes or endnotes, and can indicate either a standard or continuation separator.
/// </summary>
public interface SeparatorMark : RunContent
{
  
  /// <summary>
  /// Specifies whether the separator mark occurs in an endnote, footnote, or annotation.
  /// </summary>
  public NoteReferenceKind? Value { get; set; }
  
  /// <summary>
  /// Indicates whether this instance is a continuation separator mark, used when footnotes or endnotes continue across pages.
  /// </summary>
  public bool Continuation { get; set; }
}