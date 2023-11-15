namespace DocumentModel.Drawings.Charts13;


/// <summary>
///   Defines the FilteredRadarSeries Class.
/// </summary>
public partial class FilteredRadarSeries: ModelElement<DXO13DC.FilteredRadarSeries>
{
  public FilteredRadarSeries(): base(){ }
  
  public FilteredRadarSeries(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public FilteredRadarSeries(DXO13DC.FilteredRadarSeries openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   RadarChartSeries.
  /// </summary>
  [DataMember]
  public DMDC13.RadarChartSeries? RadarChartSeries
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
