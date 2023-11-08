namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the SurfaceChartExtension Class.
/// </summary>
public partial class SurfaceChartExtension: ModelElement<DXDC.SurfaceChartExtension>
{
  public SurfaceChartExtension(): base(){ }
  
  public SurfaceChartExtension(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SurfaceChartExtension(DXDC.SurfaceChartExtension openXmlElement): base(openXmlElement) { }
  
  
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
  public DMDC13.FilteredSurfaceSeries? FilteredSurfaceSeries
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO13DC.FilteredSurfaceSeries>();
      if (element != null)
        return FilteredSurfaceSeriesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO13DC.FilteredSurfaceSeries>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FilteredSurfaceSeriesConverter.CreateOpenXmlElement<DXO13DC.FilteredSurfaceSeries>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
