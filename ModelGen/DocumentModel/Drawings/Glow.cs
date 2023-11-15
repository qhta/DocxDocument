namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies a glow effect, in which a color blurred outline is added outside the edges of the object.
/// </summary>
public partial class Glow: ModelElement<DXD.Glow>
{
  public Glow(): base(){ }
  
  public Glow(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Glow(DXD.Glow openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Specifies the radius of the glow.
  /// </summary>
  [DataMember]
  public Int64? Radius
  {
    get => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertyGetCode: numeric propertyType baseType is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Int64]");
    set => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertySetCode: numeric propertyType baseclass is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Int64]");
  }
  
  
  /// <summary>
  ///   RGB Color Model - Percentage Variant.
  /// </summary>
  [DataMember]
  public DMD.RgbColorModelPercentage? RgbColorModelPercentage
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   RGB Color Model - Hex Variant.
  /// </summary>
  [DataMember]
  public DMD.RgbColorModelHex? RgbColorModelHex
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   Hue, Saturation, Luminance Color Model.
  /// </summary>
  [DataMember]
  public DMD.HslColor? HslColor
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   System Color.
  /// </summary>
  [DataMember]
  public DMD.SystemColor? SystemColor
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   Scheme Color.
  /// </summary>
  [DataMember]
  public DMD.SchemeColorKind? SchemeColor
  {
    get => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertyGetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertySetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   Preset Color.
  /// </summary>
  [DataMember]
  public DMD.PresetColorKind? PresetColor
  {
    get => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertyGetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertySetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
