namespace DocumentModel.Wordprocessing;

  /// <summary>
  /// Represents line spacing settings for a paragraph in a WordprocessingML document.
  /// This interface provides properties for specifying spacing in twentieths of a point, line units, and automatic spacing, enabling advanced control over paragraph layout and readability.
  /// </summary>
  public interface SpacingBeforeOrAfter
  {
    
    /// <summary>
    /// Spacing specified in twentieths of a point.
    /// </summary>
    public Twips? Val { get; set; }
    
    /// <summary>
    /// Spacing between lines, specified in line units.
    /// </summary>
    public Int32? Lines { get; set; }
    
    /// <summary>
    /// Indicates whether spacing is determined automatically.
    /// </summary>
    public bool? AutoSpacing { get; set; }
  }