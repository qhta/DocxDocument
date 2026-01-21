namespace DocumentModel.Wordprocessing;
/// <summary>
/// Common type for footnote and endnote elements in a WordprocessingML document.
/// This interface extends <see cref = "IStory"/> and provides properties for the note type and unique identifier, enabling advanced management, referencing, and formatting of footnotes and endnotes throughout the document.
/// </summary>
public partial class FootnoteEndnoteType : Story
{
  /// <summary>
  /// Type of the note, specifying whether it is a footnote or endnote.
  /// </summary>
  public FootnoteEndnoteKind? Type { get; set; }
  /// <summary>
  /// Unique identifier for the footnote or endnote.
  /// </summary>
  public Int64? Id { get; set; }
}