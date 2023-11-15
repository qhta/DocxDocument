namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the Surface3DChartExtension Class.
/// </summary>
public partial class Surface3DChartExtension: ModelElement<DXDC.Surface3DChartExtension>
{
  public Surface3DChartExtension(): base(){ }
  
  public Surface3DChartExtension(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Surface3DChartExtension(DXDC.Surface3DChartExtension openXmlElement): base(openXmlElement) { }
  
  
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
  public DMDC13.FilteredSurfaceSeries? FilteredSurfaceSeries
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
