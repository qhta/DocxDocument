namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents the spacing settings between lines and paragraphs in a WordprocessingML document.
/// This interface provides properties for configuring spacing above and below paragraphs, automatic spacing, line spacing, and line spacing rules, enabling advanced control over paragraph layout and readability.
/// </summary>
public interface SpacingBetweenLines
{
  
  /// <summary>
  /// Spacing above the paragraph, specified in twentieths of a point.
  /// </summary>
  public string? Before { get; set; }
  
  /// <summary>
  /// Spacing above the paragraph in line units.
  /// </summary>
  public Int32? BeforeLines { get; set; }
  
  /// <summary>
  /// Indicates whether spacing above the paragraph is determined automatically.
  /// </summary>
  public bool? BeforeAutoSpacing { get; set; }
  
  /// <summary>
  /// Spacing below the paragraph, specified in twentieths of a point.
  /// </summary>
  public string? After { get; set; }
  
  /// <summary>
  /// Spacing below the paragraph in line units.
  /// </summary>
  public Int32? AfterLines { get; set; }
  
  /// <summary>
  /// Indicates whether spacing below the paragraph is determined automatically.
  /// </summary>
  public bool? AfterAutoSpacing { get; set; }
  
  /// <summary>
  /// Spacing between lines in the paragraph, specified in twentieths of a point or as a multiple of line height.
  /// </summary>
  public string? Line { get; set; }
  
  /// <summary>
  /// Type of spacing rule applied between lines (e.g., auto, exact, at least, multiple).
  /// </summary>
  public LineSpacingRuleKind? LineRule { get; set; }
}