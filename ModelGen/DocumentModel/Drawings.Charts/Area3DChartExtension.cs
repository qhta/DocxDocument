namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the Area3DChartExtension Class.
/// </summary>
public partial class Area3DChartExtension: ModelElement<DXDC.Area3DChartExtension>
{
  public Area3DChartExtension(): base(){ }
  
  public Area3DChartExtension(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Area3DChartExtension(DXDC.Area3DChartExtension openXmlElement): base(openXmlElement) { }
  
  
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
