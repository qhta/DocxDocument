namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Stock Charts.
/// </summary>
public partial class StockChart: ModelElement<DXDC.StockChart>
{
  public StockChart(): base(){ }
  
  public StockChart(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public StockChart(DXDC.StockChart openXmlElement): base(openXmlElement) { }
  
  [DataMember]
  public DMDC.DataLabels? DataLabels
  {
    get
    {
      return _Element?.GetObject<DMDC.DataLabels,DXDC.DataLabels>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.DataLabels,DXDC.DataLabels>(value);
    }
  }
  
  [DataMember]
  public DMDC.DropLines? DropLines
  {
    get
    {
      return _Element?.GetObject<DMDC.DropLines,DXDC.DropLines>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.DropLines,DXDC.DropLines>(value);
    }
  }
  
  [DataMember]
  public DMDC.HighLowLines? HighLowLines
  {
    get
    {
      return _Element?.GetObject<DMDC.HighLowLines,DXDC.HighLowLines>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.HighLowLines,DXDC.HighLowLines>(value);
    }
  }
  
  [DataMember]
  public DMDC.UpDownBars? UpDownBars
  {
    get
    {
      return _Element?.GetObject<DMDC.UpDownBars,DXDC.UpDownBars>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.UpDownBars,DXDC.UpDownBars>(value);
    }
  }
  
  [DataMember]
  public DMDC.StockChartExtensionList? StockChartExtensionList
  {
    get
    {
      return _Element?.GetObject<DMDC.StockChartExtensionList,DXDC.StockChartExtensionList>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.StockChartExtensionList,DXDC.StockChartExtensionList>(value);
    }
  }
  
}
