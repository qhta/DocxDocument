namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Minus.
/// </summary>
public partial class Minus: ModelElement<DXDC.Minus>
{
  public Minus(): base(){ }
  
  public Minus(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Minus(DXDC.Minus openXmlElement): base(openXmlElement) { }
  
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
