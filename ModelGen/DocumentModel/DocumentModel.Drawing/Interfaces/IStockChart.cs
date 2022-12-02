namespace DocumentModel.Drawing;

/// <summary>
/// Stock Charts.
/// </summary>
public interface IStockChart // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<ILineChartSeries>? LineChartSerieses { get ; set; }
  
  public IDataLabels? DataLabels { get ; set; }
  
  public IDropLines? DropLines { get ; set; }
  
  public IHighLowLines? HighLowLines { get ; set; }
  
  public IUpDownBars? UpDownBars { get ; set; }
  
  public Collection<UInt32>? AxisIds { get ; set; }
  
  public IStockChartExtensionList? StockChartExtensionList { get ; set; }
  
}
