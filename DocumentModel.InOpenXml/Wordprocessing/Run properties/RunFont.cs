namespace DocumentModel.Wordprocessing;
  /// <summary>
  /// Represents font selection information for a text run, including typeface name, theme font, bold, and italic specifications.
  /// This struct enables precise font selection and styling for character-level formatting in WordprocessingML documents.
  /// </summary>
  public struct RunFont
  {
    
    /// <summary>
    /// Default constructor. Needed for deserialization.
    /// </summary>
    public RunFont() { }
    
    /// <summary>
    /// Typeface name for the font to be used in the run.
    /// </summary>
    public string? Typeface { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
    
    /// <summary>
    /// Theme font to be used for this font, allowing theme-based font selection.
    /// </summary>
    public ThemeFont? Theme { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
    
    /// <summary>
    /// Indicates whether to select a bold version of the font.
    /// </summary>
    public bool? Bold { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
    
    /// <summary>
    /// Indicates whether to select an italic version of the font.
    /// </summary>
    public bool? Italic { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  }
