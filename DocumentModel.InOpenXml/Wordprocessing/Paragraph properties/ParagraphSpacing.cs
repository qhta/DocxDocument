namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents the spacing settings between lines and paragraphs in a WordprocessingML document.
/// This interface provides properties for configuring spacing above and below paragraphs, automatic spacing, line spacing, and line spacing rules, enabling advanced control over paragraph layout and readability.
/// </summary>
public class ParagraphSpacing: ModelElement
{
  
  /// <summary>
  /// Spacing above the paragraph.
  /// </summary>
  public SpacingBeforeOrAfter? Before { get; set; }
  
  /// <summary>
  /// Spacing below the paragraph.
  /// </summary>
  public SpacingBeforeOrAfter? After { get; set; }

  /// <summary>
  /// Spacing between lines within the paragraph.
  /// </summary>
  public SpacingBetween? Between { get; set; }

} 