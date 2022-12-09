namespace DocumentModel.Drawings;

/// <summary>
/// Defines the DataPointWireframe Class.
/// </summary>
public interface DataPointWireframe
{
  public LineReference1? LineReference { get ; set; }
  
  public String? LineWidthScale { get ; set; }
  
  public FillReference2? FillReference { get ; set; }
  
  public EffectReference1? EffectReference { get ; set; }
  
  public FontReference2? FontReference { get ; set; }
  
  public ShapeProperties1? ShapeProperties { get ; set; }
  
  public TextCharacterPropertiesType1? TextCharacterPropertiesType { get ; set; }
  
  public TextBodyProperties? TextBodyProperties { get ; set; }
  
  public OfficeArtExtensionList5? OfficeArtExtensionList { get ; set; }
  
}
