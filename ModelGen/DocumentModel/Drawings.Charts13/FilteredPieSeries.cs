namespace DocumentModel.Drawings.Charts13;


/// <summary>
///   Defines the FilteredPieSeries Class.
/// </summary>
public partial class FilteredPieSeries: ModelElement<DXO13DC.FilteredPieSeries>
{
  public FilteredPieSeries(): base(){ }
  
  public FilteredPieSeries(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public FilteredPieSeries(DXO13DC.FilteredPieSeries openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   PieChartSeries.
  /// </summary>
  [DataMember]
  public DMDC13.PieChartSeries? PieChartSeries
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
