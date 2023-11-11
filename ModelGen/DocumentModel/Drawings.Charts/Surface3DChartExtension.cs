namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the Surface3DChartExtension Class.
/// </summary>
public partial class Surface3DChartExtension: ModelElement<DXDC.Surface3DChartExtension>
{
  public Surface3DChartExtension(): base(){ }
  
  public Surface3DChartExtension(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Surface3DChartExtension(DXDC.Surface3DChartExtension openXmlElement): base(openXmlElement) { }
  
  
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
      return _Element?.GetObject<DMDC13.FilteredSurfaceSeries,DXO13DC.FilteredSurfaceSeries>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC13.FilteredSurfaceSeries,DXO13DC.FilteredSurfaceSeries>(value);
    }
  }
  
}
