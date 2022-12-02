namespace DocumentModel.Drawing;

/// <summary>
/// Defines the DataLabel Class.
/// </summary>
public interface IDataLabel // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Index.
  /// </summary>
  public UInt32? Index { get ; set; }
  
  public Boolean? Delete { get ; set; }
  
  public ILayout? Layout { get ; set; }
  
  public IChartText? ChartText { get ; set; }
  
  public INumberingFormat? NumberingFormat { get ; set; }
  
  public IChartShapeProperties? ChartShapeProperties { get ; set; }
  
  public ITextProperties? TextProperties { get ; set; }
  
  public DataLabelPositionKind? DataLabelPosition { get ; set; }
  
  public Boolean? ShowLegendKey { get ; set; }
  
  public Boolean? ShowValue { get ; set; }
  
  public Boolean? ShowCategoryName { get ; set; }
  
  public Boolean? ShowSeriesName { get ; set; }
  
  public Boolean? ShowPercent { get ; set; }
  
  public Boolean? ShowBubbleSize { get ; set; }
  
  public String? Separator { get ; set; }
  
  public IDLblExtensionList? DLblExtensionList { get ; set; }
  
}
