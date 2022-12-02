namespace DocumentModel.Drawing;

/// <summary>
/// Stock Charts.
/// </summary>
public interface IStockChart // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.ILineChartSeries>? LineChartSerieses { get ; set; }
  
  public DocumentModel.Drawing.IDataLabels? DataLabels { get ; set; }
  
  public DocumentModel.Drawing.IDropLines? DropLines { get ; set; }
  
  public DocumentModel.Drawing.IHighLowLines? HighLowLines { get ; set; }
  
  public DocumentModel.Drawing.IUpDownBars? UpDownBars { get ; set; }
  
  public System.Collections.ObjectModel.Collection<System.UInt32>? AxisIds { get ; set; }
  
  public DocumentModel.Drawing.IStockChartExtensionList? StockChartExtensionList { get ; set; }
  
}
