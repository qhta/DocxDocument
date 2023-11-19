namespace DocumentModel.Word10;


/// <summary>
///   Defines the ColorType Class.
/// </summary>
public partial class ColorType: ModelElement<DXO10W.ColorType>
{
  public ColorType(): base(){ }
  
  public ColorType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ColorType(DXO10W.ColorType openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   RgbColorModelHex.
  /// </summary>
  [DataMember]
  public DM.HexRgb? RgbColorModelHex
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is System.ValueType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  
  /// <summary>
  ///   SchemeColor.
  /// </summary>
  [DataMember]
  public DMW10.SchemeColorKind? SchemeColor
  {
    get => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertyGetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertySetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
