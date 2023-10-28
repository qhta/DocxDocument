namespace DocumentModel.Drawings.ChartsStyle;


/// <summary>
///   Defines the TrendlineLabel Class.
/// </summary>
public partial class TrendlineLabel
{
  public DMDCS.LineReference? LineReference { get; set; }
  
  public DMDCS.LineWidthScale? LineWidthScale { get; set; }
  
  public DMDCS.FillReference? FillReference { get; set; }
  
  public DMDCS.EffectReference? EffectReference { get; set; }
  
  public DMDCS.FontReference? FontReference { get; set; }
  
  public DMDCS.ShapeProperties? ShapeProperties { get; set; }
  
  public DMDCS.TextCharacterPropertiesType? TextCharacterPropertiesType { get; set; }
  
  public DMDCS.TextBodyProperties? TextBodyProperties { get; set; }
  
  public DMDCS.OfficeArtExtensionList? OfficeArtExtensionList { get; set; }
  
}
