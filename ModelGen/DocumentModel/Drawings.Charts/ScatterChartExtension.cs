namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the ScatterChartExtension Class.
/// </summary>
public partial class ScatterChartExtension: ModelElement<DXDC.ScatterChartExtension>
{
  public ScatterChartExtension(): base(){ }
  
  public ScatterChartExtension(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ScatterChartExtension(DXDC.ScatterChartExtension openXmlElement): base(openXmlElement) { }
  
  
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
  public DMDC13.FilteredScatterSeries? FilteredScatterSeries
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO13DC.FilteredScatterSeries>();
      if (element != null)
        return FilteredScatterSeriesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO13DC.FilteredScatterSeries>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FilteredScatterSeriesConverter.CreateOpenXmlElement<DXO13DC.FilteredScatterSeries>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
