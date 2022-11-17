namespace DocumentModel.Office2013.Drawing.ChartStyle;

public interface IDataPointMarker // : DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleEntry
{
  public List<string>? Modifiers { get ; set; }
  
  public DocumentModel.Office2013.Drawing.ChartStyle.ILineReference? LineReference { get ; set; }
  
  public ILineWidthScale? LineWidthScale { get ; set; }
  
  public DocumentModel.Office2013.Drawing.ChartStyle.IFillReference? FillReference { get ; set; }
  
  public DocumentModel.Office2013.Drawing.ChartStyle.IEffectReference? EffectReference { get ; set; }
  
  public DocumentModel.Office2013.Drawing.ChartStyle.IFontReference? FontReference { get ; set; }
  
  public DocumentModel.Office2013.Drawing.ChartStyle.IShapeProperties? ShapeProperties { get ; set; }
  
  public DocumentModel.Office2013.Drawing.ChartStyle.ITextCharacterPropertiesType? TextCharacterPropertiesType { get ; set; }
  
  public DocumentModel.Office2013.Drawing.ChartStyle.ITextBodyProperties? TextBodyProperties { get ; set; }
  
  public DocumentModel.Office2013.Drawing.ChartStyle.IOfficeArtExtensionList? OfficeArtExtensionList { get ; set; }
  
}
