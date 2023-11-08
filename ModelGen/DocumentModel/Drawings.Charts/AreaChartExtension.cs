namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the AreaChartExtension Class.
/// </summary>
public partial class AreaChartExtension: ModelElement<DXDC.AreaChartExtension>
{
  public AreaChartExtension(): base(){ }
  
  public AreaChartExtension(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public AreaChartExtension(DXDC.AreaChartExtension openXmlElement): base(openXmlElement) { }
  
  
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
  public DMDC13.FilteredAreaSeries? FilteredAreaSeries
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO13DC.FilteredAreaSeries>();
      if (element != null)
        return FilteredAreaSeriesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO13DC.FilteredAreaSeries>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FilteredAreaSeriesConverter.CreateOpenXmlElement<DXO13DC.FilteredAreaSeries>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
