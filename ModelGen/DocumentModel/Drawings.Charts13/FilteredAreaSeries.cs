namespace DocumentModel.Drawings.Charts13;


/// <summary>
///   Defines the FilteredAreaSeries Class.
/// </summary>
public partial class FilteredAreaSeries: ModelElement<DXO13DC.FilteredAreaSeries>
{
  public FilteredAreaSeries(): base(){ }
  
  public FilteredAreaSeries(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public FilteredAreaSeries(DXO13DC.FilteredAreaSeries openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   AreaChartSeries.
  /// </summary>
  [DataMember]
  public DMDC13.AreaChartSeries? AreaChartSeries
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
