namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the ChartLinesType Class.
/// </summary>
public partial class ChartLinesType: ModelElement<DXDC.ChartLinesType>
{
  public ChartLinesType(): base(){ }
  
  public ChartLinesType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ChartLinesType(DXDC.ChartLinesType openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   ChartShapeProperties.
  /// </summary>
  [DataMember]
  public DMDC.ChartShapeProperties? ChartShapeProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
