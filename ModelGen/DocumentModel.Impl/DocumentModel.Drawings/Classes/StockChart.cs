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
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DataLabels1? DataLabels
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DropLines? DropLines
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public HighLowLines? HighLowLines
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public UpDownBars? UpDownBars
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<UInt32>? AxisIds
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public StockChartExtensionList? StockChartExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
