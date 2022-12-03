namespace DocumentModel.Drawings;

/// <summary>
/// Defines the TitleStyle Class.
/// </summary>
public interface TitleStyle // : DocumentModel.Drawings.StyleEntry
{
  public LineReference? LineReference { get ; set; }
  
  public String? LineWidthScale { get ; set; }
  
  public FillReference? FillReference { get ; set; }
  
  public EffectReference? EffectReference { get ; set; }
  
  public FontReference? FontReference { get ; set; }
  
  public ShapeProperties? ShapeProperties { get ; set; }
  
  public TextCharacterPropertiesType? TextCharacterPropertiesType { get ; set; }
  
  public TextBodyProperties? TextBodyProperties { get ; set; }
  
  public OfficeArtExtensionList? OfficeArtExtensionList { get ; set; }
  
}
