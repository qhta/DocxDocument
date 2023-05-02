namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Document-Wide Footnote Properties.
/// </summary>
public class FootnoteDocumentWideProperties: ModelElement
{
  /// <summary>
  ///   Footnote Placement.
  /// </summary>
  public FootnotePositionKind? FootnotePosition { get; set; }

  /// <summary>
  ///   Footnote Numbering Format.
  /// </summary>
  public NumberingFormat? NumberingFormat { get; set; }

  /// <summary>
  ///   Footnote and Endnote Numbering Starting Value.
  /// </summary>
  public UInt16? NumberingStart { get; set; }

  /// <summary>
  ///   Footnote and Endnote Numbering Restart Location.
  /// </summary>
  public RestartNumberKind? NumberingRestart { get; set; }

  public Collection<FootnoteEndnoteSeparatorReferenceType>? FootnoteSpecialReferences { get; set; }
}