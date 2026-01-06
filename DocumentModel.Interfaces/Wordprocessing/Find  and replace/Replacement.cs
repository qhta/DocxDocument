namespace DocumentModel.Wordprocessing;

/// <summary>
///   Represents replacement options and formatting for find and replace operations.
/// </summary>
public interface Replacement
{
  /// <summary>
  ///   Gets or sets the replacement text.
  /// </summary>
  public string? Text { get; set; }

  /// <summary>
  ///   Gets or sets the font formatting for replacement text.
  /// </summary>
  public TextFormat? Font { get; set; }

  /// <summary>
  ///   Gets or sets the paragraph formatting for replacement text.
  /// </summary>
  public ParagraphFormat? ParagraphFormat { get; set; }

  /// <summary>
  ///   Gets or sets the style to apply to replacement text.
  /// </summary>
  public string? Style { get; set; }

  /// <summary>
  ///   Gets or sets the highlight color for replacement text.
  /// </summary>
  public ColorKind? Highlight { get; set; }

  /// <summary>
  ///   Gets or sets the language ID for replacement text.
  /// </summary>
  public int? LanguageID { get; set; }

  /// <summary>
  ///   Gets or sets the frame formatting for replacement text.
  /// </summary>
  public Frame? Frame { get; set; }

  /// <summary>
  ///   Clears all formatting from the replacement object.
  /// </summary>
  public void ClearFormatting();
}