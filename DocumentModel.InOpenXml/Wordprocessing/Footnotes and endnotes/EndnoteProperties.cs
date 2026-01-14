namespace DocumentModel.Wordprocessing;

  /// <summary>
  /// Represents the properties of an endnote in a WordprocessingML document.
  /// This interface extends <see cref="SectionPropertiesContent"/> and provides properties for endnote placement, numbering format, starting value, and numbering restart location, enabling advanced configuration and management of endnote behavior and formatting within document sections.
  /// </summary>
  public interface EndnoteProperties : ISectionPropertiesContent
  {
    
    /// <summary>
    /// Placement of the endnote, specifying where the endnote appears (e.g., end of section, end of document).
    /// </summary>
    public EndnotePositionKind? EndnotePosition { get; set; }
    
    /// <summary>
    /// Numbering format for the endnote, specifying the style of numbering (e.g., Arabic, Roman, letters).
    /// </summary>
    public NumberingFormat? NumberingFormat { get; set; }
    
    /// <summary>
    /// Starting value for footnote and endnote numbering, specifying the initial number used for the first note.
    /// </summary>
    public UInt16? NumberingStart { get; set; }
    
    /// <summary>
    /// Location where footnote and endnote numbering restarts (e.g., each section, each page, continuous).
    /// </summary>
    public RestartNumberKind? NumberingRestart { get; set; }
  }