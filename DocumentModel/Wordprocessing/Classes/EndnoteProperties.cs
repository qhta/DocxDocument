namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Represents properties of an endnote.
/// </summary>
public class EndnoteProperties: ModelElement, ISectionPropertiesContent
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
}