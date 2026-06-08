namespace DocumentModel.Wordprocessing;

/// <summary>
///   Common type for footnote/endnote.
/// </summary>
public abstract class FootnoteEndnoteType: Story
{
  /// <summary>
  ///   IFootnote/IEndnote Type
  /// </summary>
  public FootnoteEndnoteKind? Type { get; set; }

  /// <summary>
  ///   IFootnote/IEndnote ID
  /// </summary>
  public Int64? Id { get; set; }
}
