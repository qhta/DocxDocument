namespace DocumentModel.Word10;


/// <summary>
///   Defines the ExtrusionColor Class.
/// </summary>
public partial class ExtrusionColor: ModelElement<DXO10W.ExtrusionColor>
{
  public ExtrusionColor(): base(){ }
  
  public ExtrusionColor(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ExtrusionColor(DXO10W.ExtrusionColor openXmlElement): base(openXmlElement) { }
  
  [DataMember]
  public DM.HexRgb? RgbColorModelHex
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is System.ValueType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  [DataMember]
  public DMW10.SchemeColorKind? SchemeColor
  {
    get => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertyGetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertySetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
