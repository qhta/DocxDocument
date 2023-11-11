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
      return _Element?.GetObject<DMDC13.FilteredRadarSeries,DXO13DC.FilteredRadarSeries>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC13.FilteredRadarSeries,DXO13DC.FilteredRadarSeries>(value);
    }
  }
  
}
