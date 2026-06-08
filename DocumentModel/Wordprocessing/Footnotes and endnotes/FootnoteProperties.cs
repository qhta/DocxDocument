namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Represents properties of a footnote.
/// </summary>
public class FootnoteProperties: ModelElement, ISectionPropertiesContent
{
  /// <summary>
  ///   IFootnote Placement.
  /// </summary>
  public FootnotePositionKind? FootnotePosition { get; set; }

  /// <summary>
  ///   IFootnote Numbering Format.
  /// </summary>
  public NumberingFormat? NumberingFormat { get; set; }

  /// <summary>
  ///   IFootnote and IEndnote Numbering Starting Value.
  /// </summary>
  public UInt16? NumberingStart { get; set; }

  /// <summary>
  ///   IFootnote and IEndnote Numbering Restart Location.
  /// </summary>
  public RestartNumberKind? NumberingRestart { get; set; }
}
