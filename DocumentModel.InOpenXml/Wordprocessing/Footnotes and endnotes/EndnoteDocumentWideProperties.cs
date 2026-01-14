namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents document-wide properties for endnotes in a WordprocessingML document.
/// This interface provides properties for endnote placement, numbering format, starting value, restart location, and special endnote references, enabling advanced configuration and management of endnote behavior and formatting across the entire document.
/// </summary>
public interface EndnoteDocumentWideProperties
{
  
  /// <summary>
  /// Placement of endnotes in the document, specifying where endnotes appear (e.g., end of section, end of document).
  /// </summary>
  public EndnotePositionKind? EndnotePosition { get; set; }
  
  /// <summary>
  /// Numbering format for endnotes, specifying the style of numbering (e.g., Arabic, Roman, letters).
  /// </summary>
  public NumberingFormat? NumberingFormat { get; set; }
  
  /// <summary>
  /// Starting value for endnote numbering, specifying the initial number used for the first endnote.
  /// </summary>
  public UInt16? NumberingStart { get; set; }
  
  /// <summary>
  /// Location where endnote numbering restarts (e.g., each section, each page, continuous).
  /// </summary>
  public RestartNumberKind? NumberingRestart { get; set; }
  
  /// <summary>
  /// Special references for endnotes, such as separators and continuation notices.
  /// </summary>
  public EndnoteSeparators? EndnoteSeparators { get; set; }
}