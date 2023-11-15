namespace DocumentModel.Word10;


/// <summary>
///   Defines the ContourColor Class.
/// </summary>
public partial class ContourColor: ModelElement<DXO10W.ContourColor>
{
  public ContourColor(): base(){ }
  
  public ContourColor(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ContourColor(DXO10W.ContourColor openXmlElement): base(openXmlElement) { }
  
  [DataMember]
  public DM.HexBinary? RgbColorModelHex
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is System.Object");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.Object");
  }
  
  [DataMember]
  public DMW10.SchemeColorKind? SchemeColor
  {
    get => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertyGetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertySetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
