namespace DocumentModel.Word10;


/// <summary>
///   This element specifies the shadow effect. By default, text does not have shadow.
/// </summary>
public partial class Shadow: ModelElement<DXO10W.Shadow>
{
  public Shadow(): base(){ }
  
  public Shadow(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Shadow(DXO10W.Shadow openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   blurRad, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int64? BlurRadius
  {
    get => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertyGetCode: numeric propertyType baseType is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Int64]");
    set => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertySetCode: numeric propertyType baseclass is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Int64]");
  }
  
  
  /// <summary>
  ///   dist, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int64? DistanceFromText
  {
    get => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertyGetCode: numeric propertyType baseType is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Int64]");
    set => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertySetCode: numeric propertyType baseclass is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Int64]");
  }
  
  
  /// <summary>
  ///   dir, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int32? DirectionAngle
  {
    get => _Element?.DirectionAngle?.Value;
    set => _ExistingElement.DirectionAngle = value;
  }
  
  
  /// <summary>
  ///   sx, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int32? HorizontalScalingFactor
  {
    get => _Element?.HorizontalScalingFactor?.Value;
    set => _ExistingElement.HorizontalScalingFactor = value;
  }
  
  
  /// <summary>
  ///   sy, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int32? VerticalScalingFactor
  {
    get => _Element?.VerticalScalingFactor?.Value;
    set => _ExistingElement.VerticalScalingFactor = value;
  }
  
  
  /// <summary>
  ///   kx, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int32? HorizontalSkewAngle
  {
    get => _Element?.HorizontalSkewAngle?.Value;
    set => _ExistingElement.HorizontalSkewAngle = value;
  }
  
  
  /// <summary>
  ///   ky, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int32? VerticalSkewAngle
  {
    get => _Element?.VerticalSkewAngle?.Value;
    set => _ExistingElement.VerticalSkewAngle = value;
  }
  
  
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
