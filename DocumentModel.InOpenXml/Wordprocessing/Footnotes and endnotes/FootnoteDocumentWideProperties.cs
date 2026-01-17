namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents document-wide properties for footnotes in a WordprocessingML document.
/// This interface provides properties for footnote placement, numbering format, starting value, restart location, and special footnote references, enabling advanced configuration and management of footnote behavior and formatting across the entire document.
/// </summary>
public class FootnoteDocumentWideProperties: ModelElement<DXW.FootnoteDocumentWideProperties>
{
  
  /// <summary>
  /// Placement of footnotes in the document, specifying where footnotes appear (e.g., bottom of page, end of document).
  /// </summary>
  public FootnotePositionKind? FootnotePosition { get; set; }
  
  /// <summary>
  /// Numbering format for footnotes, specifying the style of numbering (e.g., Arabic, Roman, letters).
  /// </summary>
  public NumberingFormat? NumberingFormat { get; set; }
  
  /// <summary>
  /// Starting value for footnote numbering, specifying the initial number used for the first footnote.
  /// </summary>
  public UInt16? NumberingStart { get; set; }
  
  /// <summary>
  /// Location where footnote numbering restarts (e.g., each section, each page, continuous).
  /// </summary>
  public RestartNumberKind? NumberingRestart { get; set; }
  
  /// <summary>
  /// Special references for footnotes, such as separators and continuation notices.
  /// </summary>
  public FootnoteSeparators? FootnoteSeparators { get; set; }
}