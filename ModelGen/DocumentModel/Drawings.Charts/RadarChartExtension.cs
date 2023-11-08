namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the RadarChartExtension Class.
/// </summary>
public partial class RadarChartExtension: ModelElement<DXDC.RadarChartExtension>
{
  public RadarChartExtension(): base(){ }
  
  public RadarChartExtension(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public RadarChartExtension(DXDC.RadarChartExtension openXmlElement): base(openXmlElement) { }
  
  
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
  public DMDC13.FilteredRadarSeries? FilteredRadarSeries
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO13DC.FilteredRadarSeries>();
      if (element != null)
        return FilteredRadarSeriesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO13DC.FilteredRadarSeries>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FilteredRadarSeriesConverter.CreateOpenXmlElement<DXO13DC.FilteredRadarSeries>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
