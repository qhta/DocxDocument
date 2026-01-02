namespace DocumentModel.Drawings.ChartsStyle;

/// <summary>
///   Defines the TrendlineLabel Class.
/// </summary>
public class TrendlineLabel: ModelElement
{
  public LineReference? LineReference { get; set; }
  public string? LineWidthScale { get; set; }
  public FillReference? FillReference { get; set; }
  public EffectReference? EffectReference { get; set; }
  public FontReference? FontReference { get; set; }
  public ShapeProperties? ShapeProperties { get; set; }
  public TextCharacterPropertiesType? TextCharacterPropertiesType { get; set; }
  public TextBodyProperties? TextBodyProperties { get; set; }
  public OfficeArtExtensionList? OfficeArtExtensionList { get; set; }
}