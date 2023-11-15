namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the Bar3DChartExtension Class.
/// </summary>
public partial class Bar3DChartExtension: ModelElement<DXDC.Bar3DChartExtension>
{
  public Bar3DChartExtension(): base(){ }
  
  public Bar3DChartExtension(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Bar3DChartExtension(DXDC.Bar3DChartExtension openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   URI
  /// </summary>
  [DataMember]
  public String? Uri
  {
    get => _Element?.Uri;
    set => _ExistingElement.Uri = value;
  }
  
  [DataMember]
  public DMDC13.FilteredBarSeries? FilteredBarSeries
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
