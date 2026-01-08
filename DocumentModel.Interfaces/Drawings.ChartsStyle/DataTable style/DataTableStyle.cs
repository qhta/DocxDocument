namespace DocumentModel.Drawings.ChartsStyle;

/// <summary>
/// Describes the style configuration for a chart's data table, including line, fill, effect, font, and shape properties.
/// </summary>
public interface DataTableStyle : OfficeArtExtendableElement
{
  /// <summary>
  /// Reference to the line style applied to the data table border.
  /// </summary>
  public LineReference? LineReference { get; set; }

  /// <summary>
  /// Scale factor for the data table border line width.
  /// </summary>
  public string? LineWidthScale { get; set; }

  /// <summary>
  /// Reference to the fill style used for the data table background.
  /// </summary>
  public FillReference? FillReference { get; set; }

  /// <summary>
  /// Reference to the effect style applied to the data table.
  /// </summary>
  public EffectReference? EffectReference { get; set; }

  /// <summary>
  /// Reference to the font style used for data table text.
  /// </summary>
  public FontReference? FontReference { get; set; }

  /// <summary>
  /// Shape properties for customizing the data table appearance.
  /// </summary>
  public ShapeProperties? ShapeProperties { get; set; }

  /// <summary>
  /// Character-level text formatting for data table labels.
  /// </summary>
  public TextCharacterPropertiesType? TextCharacterPropertiesType { get; set; }

  /// <summary>
  /// Body-level text formatting and layout for data table labels.
  /// </summary>
  public TextBodyProperties? TextBodyProperties { get; set; }
}