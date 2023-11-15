namespace DocumentModel.Drawings.Charts13;


/// <summary>
///   Defines the FilteredLineSeriesExtension Class.
/// </summary>
public partial class FilteredLineSeriesExtension: ModelElement<DXO13DC.FilteredLineSeriesExtension>
{
  public FilteredLineSeriesExtension(): base(){ }
  
  public FilteredLineSeriesExtension(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public FilteredLineSeriesExtension(DXO13DC.FilteredLineSeriesExtension openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   LineChartSeries.
  /// </summary>
  [DataMember]
  public DMDC13.LineChartSeries? LineChartSeries
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
