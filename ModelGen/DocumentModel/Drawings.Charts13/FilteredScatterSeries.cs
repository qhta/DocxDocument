namespace DocumentModel.Drawings.Charts13;


/// <summary>
///   Defines the FilteredScatterSeries Class.
/// </summary>
public partial class FilteredScatterSeries: ModelElement<DXO13DC.FilteredScatterSeries>
{
  public FilteredScatterSeries(): base(){ }
  
  public FilteredScatterSeries(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public FilteredScatterSeries(DXO13DC.FilteredScatterSeries openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   ScatterChartSeries.
  /// </summary>
  [DataMember]
  public DMDC13.ScatterChartSeries? ScatterChartSeries
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
