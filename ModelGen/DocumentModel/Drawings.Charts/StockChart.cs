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
      var element = _Element?.GetFirstChild<DXDC.DataLabels>();
      if (element != null)
        return DataLabelsConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.DataLabels>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DataLabelsConverter.CreateOpenXmlElement<DXDC.DataLabels>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDC.DropLines? DropLines
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.DropLines>();
      if (element != null)
        return DropLinesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.DropLines>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DropLinesConverter.CreateOpenXmlElement<DXDC.DropLines>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDC.HighLowLines? HighLowLines
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.HighLowLines>();
      if (element != null)
        return HighLowLinesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.HighLowLines>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = HighLowLinesConverter.CreateOpenXmlElement<DXDC.HighLowLines>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDC.UpDownBars? UpDownBars
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.UpDownBars>();
      if (element != null)
        return UpDownBarsConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.UpDownBars>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = UpDownBarsConverter.CreateOpenXmlElement<DXDC.UpDownBars>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDC.StockChartExtensionList? StockChartExtensionList
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.StockChartExtensionList>();
      if (element != null)
        return StockChartExtensionListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.StockChartExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = StockChartExtensionListConverter.CreateOpenXmlElement<DXDC.StockChartExtensionList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
