namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the FootnoteEndnoteType Class.
/// </summary>
public class FootnoteEndnoteType: ModelElement
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