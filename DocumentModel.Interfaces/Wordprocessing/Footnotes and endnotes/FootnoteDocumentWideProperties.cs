namespace DocumentModel.Wordprocessing;
/// <summary>
///   Document-Wide Footnote Properties.
/// </summary>
public class FootnoteDocumentWideProperties: ModelElement
{
  /// <summary>
  /// Initializes <see cref="DMW.FootnoteSeparators"/>
  /// </summary>
  public void Init()
  {
    FootnoteSeparators = new FootnoteSeparators();
    FootnoteSeparators.Init();
  }
  /// <summary>
  ///   Footnote Placement.
  /// </summary>
  public FootnotePositionKind? FootnotePosition { get; set; }
  /// <summary>
  ///   Footnote Numbering Format.
  /// </summary>
  public NumberingFormat? NumberingFormat { get; set; }
  /// <summary>
  ///   Footnote Numbering Starting Value.
  /// </summary>
  public UInt16? NumberingStart { get; set; }
  /// <summary>
  ///   Footnote Numbering Restart Location.
  /// </summary>
  public RestartNumberKind? NumberingRestart { get; set; }
  /// <summary>
  /// Footnote special references
  /// </summary>
  public FootnoteSeparators? FootnoteSeparators { get; set; }
}