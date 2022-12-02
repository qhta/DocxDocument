namespace DocumentModel.Drawing;

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
  
  public DocumentModel.Drawing.ILayout? Layout { get ; set; }
  
  public DocumentModel.Drawing.IChartText? ChartText { get ; set; }
  
  public DocumentModel.Drawing.INumberingFormat? NumberingFormat { get ; set; }
  
  public DocumentModel.Drawing.IChartShapeProperties? ChartShapeProperties { get ; set; }
  
  public DocumentModel.Drawing.ITextProperties? TextProperties { get ; set; }
  
  public DocumentModel.Drawing.DataLabelPositionKind? DataLabelPosition { get ; set; }
  
  public System.Boolean? ShowLegendKey { get ; set; }
  
  public System.Boolean? ShowValue { get ; set; }
  
  public System.Boolean? ShowCategoryName { get ; set; }
  
  public System.Boolean? ShowSeriesName { get ; set; }
  
  public System.Boolean? ShowPercent { get ; set; }
  
  public System.Boolean? ShowBubbleSize { get ; set; }
  
  public System.String? Separator { get ; set; }
  
  public DocumentModel.Drawing.IDLblExtensionList? DLblExtensionList { get ; set; }
  
}
