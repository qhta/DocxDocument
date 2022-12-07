namespace DocumentModel.Drawings;

/// <summary>
/// Stock Charts.
/// </summary>
public class StockChartImpl: ModelElement<DocumentFormat.OpenXml.Drawing.Charts.StockChart>, StockChart
{
  public DataLabels1? DataLabels
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
  
  public StockChartExtensionList? StockChartExtensionList
  {
    get;
    set;
  }
  
}
