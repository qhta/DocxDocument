namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the FootnoteEndnoteType Class.
/// </summary>
public class FootnoteEndnoteType
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