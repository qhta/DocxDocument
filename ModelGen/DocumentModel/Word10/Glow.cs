namespace DocumentModel.Word10;


/// <summary>
///   This element specifies the glow effect, a colored, blurred outline that is added outside the edges of text. By default, text does not have glow.
/// </summary>
public partial class Glow: ModelElement<DXO10W.Glow>
{
  public Glow(): base(){ }
  
  public Glow(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Glow(DXO10W.Glow openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   rad, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int64? GlowRadius
  {
    get => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertyGetCode: numeric propertyType baseType is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Int64]");
    set => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertySetCode: numeric propertyType baseclass is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Int64]");
  }
  
  
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
