namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the AreaChartExtension Class.
/// </summary>
public partial class AreaChartExtension: ModelElement<DXDC.AreaChartExtension>
{
  public AreaChartExtension(): base(){ }
  
  public AreaChartExtension(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public AreaChartExtension(DXDC.AreaChartExtension openXmlElement): base(openXmlElement) { }
  
  
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
  public DMDC13.FilteredAreaSeries? FilteredAreaSeries
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
