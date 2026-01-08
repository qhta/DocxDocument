namespace DocumentModel.Drawings.ChartsStyle;

/// <summary>
/// Represents the style configuration for chart legends, including line, fill, effect, font, and shape properties.
/// </summary>
public interface LegendStyle : OfficeArtExtendableElement
{
  /// <summary>
  /// Reference to the line style applied to the legend border.
  /// </summary>
  public LineReference? LineReference { get; set; }

  /// <summary>
  /// Scale factor for the legend border line width.
  /// </summary>
  public string? LineWidthScale { get; set; }

  /// <summary>
  /// Reference to the fill style used for the legend background.
  /// </summary>
  public FillReference? FillReference { get; set; }

  /// <summary>
  /// Reference to the effect style applied to the legend.
  /// </summary>
  public EffectReference? EffectReference { get; set; }

  /// <summary>
  /// Reference to the font style used for legend text.
  /// </summary>
  public FontReference? FontReference { get; set; }

  /// <summary>
  /// Shape properties for customizing the legend appearance.
  /// </summary>
  public ShapeProperties? ShapeProperties { get; set; }

  /// <summary>
  /// Character-level text formatting for legend labels.
  /// </summary>
  public TextCharacterPropertiesType? TextCharacterPropertiesType { get; set; }

  /// <summary>
  /// Body-level text formatting and layout for legend labels.
  /// </summary>
  public TextBodyProperties? TextBodyProperties { get; set; }
}