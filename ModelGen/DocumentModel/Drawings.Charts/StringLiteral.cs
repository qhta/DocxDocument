namespace DocumentModel.Drawings.Charts;


/// <summary>
///   String Literal.
/// </summary>
public partial class StringLiteral: ModelElement<DXDC.StringLiteral>
{
  public StringLiteral(): base(){ }
  
  public StringLiteral(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public StringLiteral(DXDC.StringLiteral openXmlElement): base(openXmlElement) { }
  
  [DataMember]
  public DMDC.PointCount? PointCount
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.UnsignedIntegerType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.UnsignedIntegerType");
  }
  
  [DataMember]
  public DMDC.StrDataExtensionList? StrDataExtensionList
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
