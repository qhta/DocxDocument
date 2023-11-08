namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the BarChartExtension Class.
/// </summary>
public partial class BarChartExtension: ModelElement<DXDC.BarChartExtension>
{
  public BarChartExtension(): base(){ }
  
  public BarChartExtension(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public BarChartExtension(DXDC.BarChartExtension openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   URI
  /// </summary>
  [DataMember]
  public String? Uri
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Uri);
    }
    set
    {
      _ExistingElement.Uri = StringValueConverter.CreateStringValue(value);
    }
  }
  
  [DataMember]
  public DMDC13.FilteredBarSeries? FilteredBarSeries
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO13DC.FilteredBarSeries>();
      if (element != null)
        return FilteredBarSeriesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO13DC.FilteredBarSeries>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FilteredBarSeriesConverter.CreateOpenXmlElement<DXO13DC.FilteredBarSeries>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
