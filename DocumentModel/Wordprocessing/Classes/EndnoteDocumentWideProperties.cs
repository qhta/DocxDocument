namespace DocumentModel.Wordprocessing;

/// <summary>
///   Document-Wide Endnote Properties.
/// </summary>
public class EndnoteDocumentWideProperties: ModelElement
{
  /// <summary>
  ///   Endnote Placement.
  /// </summary>
  public EndnotePositionKind? EndnotePosition { get; set; }

  /// <summary>
  ///   Endnote Numbering Format.
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

  public Collection<FootnoteEndnoteSeparatorReferenceType>? EndnoteSpecialReferences { get; set; }
}