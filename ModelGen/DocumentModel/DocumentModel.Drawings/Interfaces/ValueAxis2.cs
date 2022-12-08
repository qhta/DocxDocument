namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ValueAxis Class.
/// </summary>
public interface ValueAxis2
{
  public LineReference2? LineReference { get ; set; }
  
  public String? LineWidthScale { get ; set; }
  
  public FillReference2? FillReference { get ; set; }
  
  public EffectReference1? EffectReference { get ; set; }
  
  public FontReference1? FontReference { get ; set; }
  
  public ShapeProperties4? ShapeProperties { get ; set; }
  
  public TextCharacterPropertiesType2? TextCharacterPropertiesType { get ; set; }
  
  public TextBodyProperties? TextBodyProperties { get ; set; }
  
  public OfficeArtExtensionList4? OfficeArtExtensionList { get ; set; }
  
}
