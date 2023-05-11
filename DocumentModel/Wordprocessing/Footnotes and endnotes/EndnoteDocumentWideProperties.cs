namespace DocumentModel.Wordprocessing;

/// <summary>
///   Document-Wide Endnote Properties.
/// </summary>
public class EndnoteDocumentWideProperties: ModelElement
{
  /// <summary>
  /// Initializes <see cref="EndnoteSeparators"/>
  /// </summary>
  public void Init()
  {
    EndnoteSeparators = new EndnoteSeparators();
    EndnoteSeparators.Init();
  }

  /// <summary>
  ///   Endnote Placement.
  /// </summary>
  public EndnotePositionKind? EndnotePosition { get; set; }

  /// <summary>
  ///   Endnote Numbering Format.
  /// </summary>
  public NumberingFormat? NumberingFormat { get; set; }

  /// <summary>
  ///  Endnote Numbering Starting Value.
  /// </summary>
  public UInt16? NumberingStart { get; set; }

  /// <summary>
  ///   Endnote Numbering Restart Location.
  /// </summary>
  public RestartNumberKind? NumberingRestart { get; set; }

  /// <summary>
  /// Endnote special references.
  /// </summary>
  public EndnoteSeparators? EndnoteSeparators { get; set; }

  /// <summary>
  /// Modified for tests.
  /// </summary>
  public override string ToString()
  {
    return $"EndnoteDocumentWideProperties(EndnotePosition={EndnotePosition})";
  }
}