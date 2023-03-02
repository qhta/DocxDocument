namespace DocumentModel.Drawings.ChartsStyle;

/// <summary>
///   Defines the AxisTitle Class.
/// </summary>
public record AxisTitle
{
  public LineReference? LineReference { get; set; }

  public String? LineWidthScale { get; set; }

  public FillReference? FillReference { get; set; }

  public EffectReference? EffectReference { get; set; }

  public FontReference? FontReference { get; set; }

  public ShapeProperties? ShapeProperties { get; set; }

  public TextCharacterPropertiesType? TextCharacterPropertiesType { get; set; }

  public TextBodyProperties? TextBodyProperties { get; set; }

  public OfficeArtExtensionList? OfficeArtExtensionList { get; set; }
}