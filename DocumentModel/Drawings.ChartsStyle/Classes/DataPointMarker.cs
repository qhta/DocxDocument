namespace DocumentModel.Drawings.ChartsStyle;

/// <summary>
/// Defines the DataPointMarker Class.
/// </summary>
public partial class DataPointMarker
{
  public DocumentModel.Drawings.ChartsStyle.LineReference? LineReference { get; set; }
  
  public String? LineWidthScale { get; set; }
  
  public DocumentModel.Drawings.ChartsStyle.FillReference? FillReference { get; set; }
  
  public DocumentModel.Drawings.ChartsStyle.EffectReference? EffectReference { get; set; }
  
  public DocumentModel.Drawings.ChartsStyle.FontReference? FontReference { get; set; }
  
  public DocumentModel.Drawings.ChartsStyle.ShapeProperties? ShapeProperties { get; set; }
  
  public DocumentModel.Drawings.ChartsStyle.TextCharacterPropertiesType? TextCharacterPropertiesType { get; set; }
  
  public DocumentModel.Drawings.ChartsStyle.TextBodyProperties? TextBodyProperties { get; set; }
  
  public DocumentModel.Drawings.ChartsStyle.OfficeArtExtensionList? OfficeArtExtensionList { get; set; }
  
}
