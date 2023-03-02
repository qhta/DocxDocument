namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the FootnoteEndnoteType Class.
/// </summary>
public record FootnoteEndnoteType
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