namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the Line3DChartExtension Class.
/// </summary>
public partial class Line3DChartExtension: ModelElement<DXDC.Line3DChartExtension>
{
  public Line3DChartExtension(): base(){ }
  
  public Line3DChartExtension(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Line3DChartExtension(DXDC.Line3DChartExtension openXmlElement): base(openXmlElement) { }
  
  
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
  public DMDC13.FilteredLineSeriesExtension? FilteredLineSeriesExtension
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
