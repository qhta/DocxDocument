namespace DocumentModel.Drawings.ChartsStyle;
/// <summary>
/// Represents a style entry containing references to line, fill, effect, font, shape, and text formatting properties for chart elements.
/// </summary>
[XmlRoot("StyleEntry", Namespace = "DocumentModel.Drawings.ChartsStyle")]
public partial class StyleEntry
{
  /// <summary>
  /// List of string modifiers that customize the style entry.
  /// </summary>
  public List<String>? Modifiers { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Reference to the line style for borders or outlines.
  /// </summary>
  public LineReference? LineReference { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Scale factor for the line width.
  /// </summary>
  public string? LineWidthScale { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Reference to the fill style for backgrounds.
  /// </summary>
  public FillReference? FillReference { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Reference to the effect style for visual enhancements.
  /// </summary>
  public EffectReference? EffectReference { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Reference to the font style for text.
  /// </summary>
  public FontReference? FontReference { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Shape properties for customizing the appearance of chart elements.
  /// </summary>
  public ShapeProperties? ShapeProperties { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Character-level text formatting for labels and titles.
  /// </summary>
  public TextCharacterPropertiesType? TextCharacterPropertiesType { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Body-level text formatting and layout for chart elements.
  /// </summary>
  public TextBodyProperties? TextBodyProperties { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Extension list for additional OfficeArt features.
  /// </summary>
  public OfficeArtExtensionList? OfficeArtExtensionList { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
}