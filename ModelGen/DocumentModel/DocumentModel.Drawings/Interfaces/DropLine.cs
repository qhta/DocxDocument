namespace DocumentModel.Drawings;

/// <summary>
/// Defines the DropLine Class.
/// </summary>
public interface DropLine
{
  public LineReference1? LineReference { get ; set; }
  
  public FillReference1? FillReference { get ; set; }
  
  public EffectReference1? EffectReference { get ; set; }
  
  public FontReference1? FontReference { get ; set; }
  
  public ShapeProperties3? ShapeProperties { get ; set; }
  
  public TextCharacterPropertiesType1? TextCharacterPropertiesType { get ; set; }
  
  public TextBodyProperties? TextBodyProperties { get ; set; }
  
  public OfficeArtExtensionList1? OfficeArtExtensionList { get ; set; }
  
}
