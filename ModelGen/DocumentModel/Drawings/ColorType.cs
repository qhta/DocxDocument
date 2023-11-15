namespace DocumentModel.Drawings;


/// <summary>
///   Defines the ColorType Class.
/// </summary>
public partial class ColorType: ModelElement<DXD.ColorType>
{
  public ColorType(): base(){ }
  
  public ColorType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ColorType(DXD.ColorType openXmlElement): base(openXmlElement) { }
  
  
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
