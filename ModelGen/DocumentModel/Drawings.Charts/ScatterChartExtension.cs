namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the ScatterChartExtension Class.
/// </summary>
public partial class ScatterChartExtension: ModelElement<DXDC.ScatterChartExtension>
{
  public ScatterChartExtension(): base(){ }
  
  public ScatterChartExtension(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ScatterChartExtension(DXDC.ScatterChartExtension openXmlElement): base(openXmlElement) { }
  
  
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
  public DMDC13.FilteredScatterSeries? FilteredScatterSeries
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
