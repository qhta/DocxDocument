namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the HighLowLines Class.
/// </summary>
public partial class HighLowLines: ModelElement<DXDC.HighLowLines>
{
  public HighLowLines(): base(){ }
  
  public HighLowLines(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public HighLowLines(DXDC.HighLowLines openXmlElement): base(openXmlElement) { }
  
  [DataMember]
  public DMDC.ChartShapeProperties? ChartShapeProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
