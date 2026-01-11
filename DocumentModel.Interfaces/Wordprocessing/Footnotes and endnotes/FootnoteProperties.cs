namespace DocumentModel.Wordprocessing;

/// <summary>
///   Represents the properties of a footnote in a WordprocessingML document.
///   This interface extends <see cref="SectionPropertiesContent"/> and provides properties for footnote placement, numbering format, starting value, and numbering restart location, enabling advanced configuration and management of footnote behavior and formatting within document sections.
/// </summary>
public interface FootnoteProperties : SectionPropertiesContent
{
  /// <summary>
  ///   Placement of the footnote, specifying where the footnote appears (e.g., bottom of page, end of document).
  /// </summary>
  public FootnotePositionKind? FootnotePosition { get; set; }

  /// <summary>
  ///   Numbering format for the footnote, specifying the style of numbering (e.g., Arabic, Roman, letters).
  /// </summary>
  public NumberingFormat? NumberingFormat { get; set; }

  /// <summary>
  ///   Starting value for footnote and endnote numbering, specifying the initial number used for the first note.
  /// </summary>
  public UInt16? NumberingStart { get; set; }

  /// <summary>
  ///   Location where footnote and endnote numbering restarts (e.g., each section, each page, continuous).
  /// </summary>
  public RestartNumberKind? NumberingRestart { get; set; }
}