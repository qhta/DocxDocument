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
      return _Element?.GetObject<DMDC13.FilteredAreaSeries,DXO13DC.FilteredAreaSeries>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC13.FilteredAreaSeries,DXO13DC.FilteredAreaSeries>(value);
    }
  }
  
}
