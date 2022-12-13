namespace DocumentModel.Drawings13.Charts;

/// <summary>
/// Defines the TitleStyle Class.
/// </summary>
public interface TitleStyle
{
  public DocumentModel.Drawings13.Charts.LineReference? LineReference { get ; set; }
  
  public String? LineWidthScale { get ; set; }
  
  public DocumentModel.Drawings13.Charts.FillReference? FillReference { get ; set; }
  
  public DocumentModel.Drawings13.Charts.EffectReference? EffectReference { get ; set; }
  
  public DocumentModel.Drawings13.Charts.FontReference? FontReference { get ; set; }
  
  public DocumentModel.Drawings13.Charts.ShapeProperties? ShapeProperties { get ; set; }
  
  public DocumentModel.Drawings13.Charts.TextCharacterPropertiesType? TextCharacterPropertiesType { get ; set; }
  
  public DocumentModel.Drawings13.Charts.TextBodyProperties? TextBodyProperties { get ; set; }
  
  public DocumentModel.Drawings13.Charts.OfficeArtExtensionList? OfficeArtExtensionList { get ; set; }
  
}
