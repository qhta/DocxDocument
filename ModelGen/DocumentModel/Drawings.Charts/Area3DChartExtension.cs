namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the Area3DChartExtension Class.
/// </summary>
public partial class Area3DChartExtension: ModelElement<DXDC.Area3DChartExtension>
{
  public Area3DChartExtension(): base(){ }
  
  public Area3DChartExtension(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Area3DChartExtension(DXDC.Area3DChartExtension openXmlElement): base(openXmlElement) { }
  
  
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
