namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Stock Charts.
/// </summary>
public interface IStockChart // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.Charts.ILineChartSeries>? LineChartSerieses { get ; set; }
  
  public DocumentModel.Drawing.Charts.IDataLabels? DataLabels { get ; set; }
  
  public DocumentModel.Drawing.Charts.IDropLines? DropLines { get ; set; }
  
  public DocumentModel.Drawing.Charts.IHighLowLines? HighLowLines { get ; set; }
  
  public DocumentModel.Drawing.Charts.IUpDownBars? UpDownBars { get ; set; }
  
  public System.Collections.ObjectModel.Collection<System.UInt32>? AxisIds { get ; set; }
  
  public DocumentModel.Drawing.Charts.IStockChartExtensionList? StockChartExtensionList { get ; set; }
  
}
