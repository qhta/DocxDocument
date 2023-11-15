namespace DocumentModel.Drawings.Charts13;


/// <summary>
///   Defines the FilteredSeriesTitle Class.
/// </summary>
public partial class FilteredSeriesTitle: ModelElement<DXO13DC.FilteredSeriesTitle>
{
  public FilteredSeriesTitle(): base(){ }
  
  public FilteredSeriesTitle(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public FilteredSeriesTitle(DXO13DC.FilteredSeriesTitle openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   ChartText.
  /// </summary>
  [DataMember]
  public DMDC13.ChartText? ChartText
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
