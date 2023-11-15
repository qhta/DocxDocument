namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the SurfaceChartExtension Class.
/// </summary>
public partial class SurfaceChartExtension: ModelElement<DXDC.SurfaceChartExtension>
{
  public SurfaceChartExtension(): base(){ }
  
  public SurfaceChartExtension(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SurfaceChartExtension(DXDC.SurfaceChartExtension openXmlElement): base(openXmlElement) { }
  
  
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
