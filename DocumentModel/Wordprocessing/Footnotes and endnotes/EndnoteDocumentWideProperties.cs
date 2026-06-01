namespace DocumentModel.Wordprocessing;

/// <summary>
///   IDocument-Wide IEndnote Properties.
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
  ///   IEndnote Placement.
  /// </summary>
  public EndnotePositionKind? EndnotePosition { get; set; }

  /// <summary>
  ///   IEndnote Numbering Format.
  /// </summary>
  public NumberingFormat? NumberingFormat { get; set; }

  /// <summary>
  ///  IEndnote Numbering Starting Value.
  /// </summary>
  public UInt16? NumberingStart { get; set; }

  /// <summary>
  ///   IEndnote Numbering Restart Location.
  /// </summary>
  public RestartNumberKind? NumberingRestart { get; set; }

  /// <summary>
  /// IEndnote special references.
  /// </summary>
  public EndnoteSeparators? EndnoteSeparators { get; set; }

  /// <summary>
  /// Modified Ifor tests.
  /// </summary>
  public override string ToString()
  {
    return $"EndnoteDocumentWideProperties(EndnotePosition={EndnotePosition})";
  }
}
