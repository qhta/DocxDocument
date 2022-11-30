namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Data Labels.
/// </summary>
public interface IDataLabels // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.Charts.IDataLabel>? DataLabels { get ; set; }
  
  public System.Boolean? Delete { get ; set; }
  
  public DocumentModel.Drawing.Charts.INumberingFormat? NumberingFormat { get ; set; }
  
  public DocumentModel.Drawing.Charts.IChartShapeProperties? ChartShapeProperties { get ; set; }
  
  public DocumentModel.Drawing.Charts.ITextProperties? TextProperties { get ; set; }
  
  public DocumentModel.Drawing.Charts.DataLabelPositionKind? DataLabelPosition { get ; set; }
  
  public System.Boolean? ShowLegendKey { get ; set; }
  
  public System.Boolean? ShowValue { get ; set; }
  
  public System.Boolean? ShowCategoryName { get ; set; }
  
  public System.Boolean? ShowSeriesName { get ; set; }
  
  public System.Boolean? ShowPercent { get ; set; }
  
  public System.Boolean? ShowBubbleSize { get ; set; }
  
  public System.String? Separator { get ; set; }
  
  public System.Boolean? ShowLeaderLines { get ; set; }
  
  public DocumentModel.Drawing.Charts.ILeaderLines? LeaderLines { get ; set; }
  
  public DocumentModel.Drawing.Charts.IDLblsExtensionList? DLblsExtensionList { get ; set; }
  
}
