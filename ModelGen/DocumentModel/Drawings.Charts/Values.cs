namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the Values Class.
/// </summary>
public partial class Values: ModelElement<DXDC.Values>
{
  public Values(): base(){ }
  
  public Values(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Values(DXDC.Values openXmlElement): base(openXmlElement) { }
  
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
