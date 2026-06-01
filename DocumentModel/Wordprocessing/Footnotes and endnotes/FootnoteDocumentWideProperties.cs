namespace DocumentModel.Wordprocessing;
/// <summary>
///   IDocument-Wide IFootnote Properties.
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
  ///   IFootnote Placement.
  /// </summary>
  public FootnotePositionKind? FootnotePosition { get; set; }

  /// <summary>
  ///   IFootnote Numbering Format.
  /// </summary>
  public NumberingFormat? NumberingFormat { get; set; }

  /// <summary>
  ///   IFootnote Numbering Starting Value.
  /// </summary>
  public UInt16? NumberingStart { get; set; }

  /// <summary>
  ///   IFootnote Numbering Restart Location.
  /// </summary>
  public RestartNumberKind? NumberingRestart { get; set; }

  /// <summary>
  /// IFootnote special references
  /// </summary>
  public FootnoteSeparators? FootnoteSeparators { get; set; }
}
