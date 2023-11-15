namespace DocumentModel.Word10;


/// <summary>
///   This element specifies a color bound to the document’s theme and an optional list of color transforms to apply to the base color.
/// </summary>
public partial class SolidColorFillProperties: ModelElement<DXO10W.SolidColorFillProperties>
{
  public SolidColorFillProperties(): base(){ }
  
  public SolidColorFillProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SolidColorFillProperties(DXO10W.SolidColorFillProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   RgbColorModelHex.
  /// </summary>
  [DataMember]
  public DM.HexBinary? RgbColorModelHex
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is System.Object");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.Object");
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
