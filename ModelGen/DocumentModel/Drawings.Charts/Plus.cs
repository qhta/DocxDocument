namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Plus.
/// </summary>
public partial class Plus: ModelElement<DXDC.Plus>
{
  public Plus(): base(){ }
  
  public Plus(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Plus(DXDC.Plus openXmlElement): base(openXmlElement) { }
  
  [DataMember]
  public DMDC.NumberReference? NumberReference
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  [DataMember]
  public DMDC.NumberLiteral? NumberLiteral
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.NumberDataType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.NumberDataType");
  }
  
}
