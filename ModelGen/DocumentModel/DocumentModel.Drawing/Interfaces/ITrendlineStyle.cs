namespace DocumentModel.Drawing;

/// <summary>
/// Defines the TrendlineStyle Class.
/// </summary>
public interface ITrendlineStyle // : DocumentModel.Drawing.IStyleEntry
{
  public ILineReference? LineReference { get ; set; }
  
  public String? LineWidthScale { get ; set; }
  
  public IFillReference? FillReference { get ; set; }
  
  public IEffectReference? EffectReference { get ; set; }
  
  public IFontReference? FontReference { get ; set; }
  
  public IShapeProperties? ShapeProperties { get ; set; }
  
  public ITextCharacterPropertiesType? TextCharacterPropertiesType { get ; set; }
  
  public ITextBodyProperties? TextBodyProperties { get ; set; }
  
  public IOfficeArtExtensionList? OfficeArtExtensionList { get ; set; }
  
}
