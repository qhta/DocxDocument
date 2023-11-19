namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies an Outer Shadow Effect.
/// </summary>
public partial class OuterShadow: ModelElement<DXD.OuterShadow>
{
  public OuterShadow(): base(){ }
  
  public OuterShadow(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public OuterShadow(DXD.OuterShadow openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Specifies the blur radius of the shadow.
  /// </summary>
  [DataMember]
  public Int64? BlurRadius
  {
    get => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertyGetCode: numeric propertyType baseType is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Int64]");
    set => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertySetCode: numeric propertyType baseclass is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Int64]");
  }
  
  
  /// <summary>
  ///   Specifies the how far to offset the shadow.
  /// </summary>
  [DataMember]
  public Int64? Distance
  {
    get => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertyGetCode: numeric propertyType baseType is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Int64]");
    set => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertySetCode: numeric propertyType baseclass is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Int64]");
  }
  
  
  /// <summary>
  ///   Specifies the direction to offset the shadow.
  /// </summary>
  [DataMember]
  public Int32? Direction
  {
    get => _Element?.Direction?.Value;
    set => _ExistingElement.Direction = value;
  }
  
  
  /// <summary>
  ///   Specifies the horizontal scaling factor; negative scaling causes a flip.
  /// </summary>
  [DataMember]
  public Int32? HorizontalRatio
  {
    get => _Element?.HorizontalRatio?.Value;
    set => _ExistingElement.HorizontalRatio = value;
  }
  
  
  /// <summary>
  ///   Specifies the vertical scaling factor; negative scaling causes a flip.
  /// </summary>
  [DataMember]
  public Int32? VerticalRatio
  {
    get => _Element?.VerticalRatio?.Value;
    set => _ExistingElement.VerticalRatio = value;
  }
  
  
  /// <summary>
  ///   Specifies the horizontal skew angle.
  /// </summary>
  [DataMember]
  public Int32? HorizontalSkew
  {
    get => _Element?.HorizontalSkew?.Value;
    set => _ExistingElement.HorizontalSkew = value;
  }
  
  
  /// <summary>
  ///   Specifies the vertical skew angle.
  /// </summary>
  [DataMember]
  public Int32? VerticalSkew
  {
    get => _Element?.VerticalSkew?.Value;
    set => _ExistingElement.VerticalSkew = value;
  }
  
  
  /// <summary>
  ///   Rotate With Shape
  /// </summary>
  [DataMember]
  public Boolean? RotateWithShape
  {
    get => _Element?.RotateWithShape?.Value;
    set => _ExistingElement.RotateWithShape = value;
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
  public DM.HexRgb? RgbColorModelHex
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is System.ValueType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
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
