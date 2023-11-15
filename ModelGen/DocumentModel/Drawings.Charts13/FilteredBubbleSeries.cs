namespace DocumentModel.Drawings.Charts13;


/// <summary>
///   Defines the FilteredBubbleSeries Class.
/// </summary>
public partial class FilteredBubbleSeries: ModelElement<DXO13DC.FilteredBubbleSeries>
{
  public FilteredBubbleSeries(): base(){ }
  
  public FilteredBubbleSeries(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public FilteredBubbleSeries(DXO13DC.FilteredBubbleSeries openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   BubbleChartSeries.
  /// </summary>
  [DataMember]
  public DMDC13.BubbleChartSeries? BubbleChartSeries
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
