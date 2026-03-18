namespace DocumentModel.Drawings.ChartsStyle;

/// <summary>
/// Represents a style entry containing references to line, fill, effect, font, shape, and text formatting properties for chart elements.
/// </summary>
public class StyleEntry
{
  /// <summary>
  /// List of string modifiers that customize the style entry.
  /// </summary>
  public ListOf<String>? Modifiers { get; set; }

  /// <summary>
  /// Reference to the line style for borders or outlines.
  /// </summary>
  public LineReference? LineReference { get; set; }

  /// <summary>
  /// Scale factor for the line width.
  /// </summary>
  public string? LineWidthScale { get; set; }

  /// <summary>
  /// Reference to the fill style for backgrounds.
  /// </summary>
  public FillReference? FillReference { get; set; }

  /// <summary>
  /// Reference to the effect style for visual enhancements.
  /// </summary>
  public EffectReference? EffectReference { get; set; }

  /// <summary>
  /// Reference to the font style for text.
  /// </summary>
  public FontReference? FontReference { get; set; }

  /// <summary>
  /// Shape properties for customizing the appearance of chart elements.
  /// </summary>
  public ShapeProperties? ShapeProperties { get; set; }

  /// <summary>
  /// Character-level text formatting for labels and titles.
  /// </summary>
  public TextCharacterPropertiesType? TextCharacterPropertiesType { get; set; }

  /// <summary>
  /// Body-level text formatting and layout for chart elements.
  /// </summary>
  public TextBodyProperties? TextBodyProperties { get; set; }

  /// <summary>
  /// Extension list for additional OfficeArt features.
  /// </summary>
  public OfficeArtExtensionList? OfficeArtExtensionList { get; set; }
}