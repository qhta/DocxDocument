namespace DocumentModel.Office2013.Drawing.ChartStyle;

/// <summary>
/// Defines the DataPoint3D Class.
/// </summary>
public interface IDataPoint3D // : DocumentModel.Office2013.Drawing.ChartStyle.IStyleEntry
{
  public DocumentModel.Office2013.Drawing.ChartStyle.ILineReference? LineReference { get ; set; }
  
  public System.String? LineWidthScale { get ; set; }
  
  public DocumentModel.Office2013.Drawing.ChartStyle.IFillReference? FillReference { get ; set; }
  
  public DocumentModel.Office2013.Drawing.ChartStyle.IEffectReference? EffectReference { get ; set; }
  
  public DocumentModel.Office2013.Drawing.ChartStyle.IFontReference? FontReference { get ; set; }
  
  public DocumentModel.Office2013.Drawing.ChartStyle.IShapeProperties? ShapeProperties { get ; set; }
  
  public DocumentModel.Office2013.Drawing.ChartStyle.ITextCharacterPropertiesType? TextCharacterPropertiesType { get ; set; }
  
  public DocumentModel.Office2013.Drawing.ChartStyle.ITextBodyProperties? TextBodyProperties { get ; set; }
  
  public DocumentModel.Office2013.Drawing.ChartStyle.IOfficeArtExtensionList? OfficeArtExtensionList { get ; set; }
  
}
