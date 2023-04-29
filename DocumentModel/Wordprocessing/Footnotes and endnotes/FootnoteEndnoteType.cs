namespace DocumentModel.Wordprocessing;

/// <summary>
///   Common type for footnote/endnote.
/// </summary>
public abstract class FootnoteEndnoteType: Story
{
  /// <summary>
  ///   Footnote/Endnote Type
  /// </summary>
  public FootnoteEndnoteKind? Type { get; set; }

  /// <summary>
  ///   Footnote/Endnote ID
  /// </summary>
  public Int64? Id { get; set; }
}