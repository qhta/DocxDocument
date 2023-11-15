namespace DocumentModel.Drawings;


/// <summary>
///   This element defines a gradient stop. A gradient stop consists of a position where the stop appears in the color band.
/// </summary>
public partial class GradientStop: ModelElement<DXD.GradientStop>
{
  public GradientStop(): base(){ }
  
  public GradientStop(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public GradientStop(DXD.GradientStop openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Specifies where this gradient stop should appear in the color band. This position is specified in the range, which corresponds to the beginning and the end of the color band respectively.
  /// </summary>
  [DataMember]
  public Int32? Position
  {
    get => _Element?.Position?.Value;
    set => _ExistingElement.Position = value;
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
