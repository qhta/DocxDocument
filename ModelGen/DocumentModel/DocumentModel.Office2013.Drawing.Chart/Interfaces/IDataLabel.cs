namespace DocumentModel.Office2013.Drawing.Chart;

/// <summary>
/// Defines the DataLabel Class.
/// </summary>
public interface IDataLabel // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Index.
  /// </summary>
  public System.UInt32? Index { get ; set; }
  
  public System.Boolean? Delete { get ; set; }
  
  public DocumentModel.Drawing.Charts.ILayout? Layout { get ; set; }
  
  public DocumentModel.Drawing.Charts.IChartText? ChartText { get ; set; }
  
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
  
  public DocumentModel.Drawing.Charts.IDLblExtensionList? DLblExtensionList { get ; set; }
  
}
