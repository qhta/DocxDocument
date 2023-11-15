namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the LineChartExtension Class.
/// </summary>
public partial class LineChartExtension: ModelElement<DXDC.LineChartExtension>
{
  public LineChartExtension(): base(){ }
  
  public LineChartExtension(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public LineChartExtension(DXDC.LineChartExtension openXmlElement): base(openXmlElement) { }
  
  
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
