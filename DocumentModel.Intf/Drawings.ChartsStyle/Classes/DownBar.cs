namespace DocumentModel.Drawings.ChartsStyle;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the DownBar Class.
/// </summary>
public class DownBar: ModelElement
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