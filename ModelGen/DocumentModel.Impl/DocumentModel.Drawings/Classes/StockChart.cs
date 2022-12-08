namespace DocumentModel.Drawings;

/// <summary>
/// Stock Charts.
/// </summary>
public class StockChartImpl: ModelElementImpl, StockChart
{
  public DocumentFormat.OpenXml.Drawing.Charts.StockChart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.StockChart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Collection<LineChartSeries1>? LineChartSerieses
  {
    get;
    set;
  }
  
  public DataLabels2? DataLabels
  {
    get;
    set;
  }
  
  public DropLines? DropLines
  {
    get;
    set;
  }
  
  public HighLowLines? HighLowLines
  {
    get;
    set;
  }
  
  public UpDownBars? UpDownBars
  {
    get;
    set;
  }
  
  public Collection<UInt32>? AxisIds
  {
    get;
    set;
  }
  
  public StockChartExtensionList? StockChartExtensionList
  {
    get;
    set;
  }
  
}
