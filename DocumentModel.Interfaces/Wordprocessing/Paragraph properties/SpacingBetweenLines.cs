namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents the spacing settings between lines and paragraphs in a WordprocessingML document.
/// This interface provides properties for configuring spacing above and below paragraphs, automatic spacing, line spacing, and line spacing rules, enabling advanced control over paragraph layout and readability.
/// </summary>
public interface SpacingBetweenLines
{
  
  /// <summary>
  /// Spacing above the paragraph.
  /// </summary>
  public LinesSpacing? Before { get; set; }
  
  /// <summary>
  /// Spacing below the paragraph.
  /// </summary>
  public LinesSpacing? After { get; set; }
  
  /// <summary>
  /// Spacing between lines in the paragraph, specified in twentieths of a point or as a multiple of line height.
  /// </summary>
  public Twips? Line { get; set; }
  
  /// <summary>
  /// Type of spacing rule applied between lines (e.g., auto, exact, at least, multiple).
  /// </summary>
  public LineSpacingRuleKind? LineRule { get; set; }
} 