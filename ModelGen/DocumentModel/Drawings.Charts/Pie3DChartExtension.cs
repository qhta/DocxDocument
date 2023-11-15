namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the Pie3DChartExtension Class.
/// </summary>
public partial class Pie3DChartExtension: ModelElement<DXDC.Pie3DChartExtension>
{
  public Pie3DChartExtension(): base(){ }
  
  public Pie3DChartExtension(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Pie3DChartExtension(DXDC.Pie3DChartExtension openXmlElement): base(openXmlElement) { }
  
  
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
  public DMDC13.FilteredPieSeries? FilteredPieSeries
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
