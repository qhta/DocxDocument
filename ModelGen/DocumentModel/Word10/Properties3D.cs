namespace DocumentModel.Word10;


/// <summary>
///   This element specifies the 3-D properties of text, including bevel, extrusion, contour, and material. By default, text does not have 3-D properties.
/// </summary>
public partial class Properties3D: ModelElement<DXO10W.Properties3D>
{
  public Properties3D(): base(){ }
  
  public Properties3D(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Properties3D(DXO10W.Properties3D openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   extrusionH, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int64? ExtrusionHeight
  {
    get => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertyGetCode: numeric propertyType baseType is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Int64]");
    set => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertySetCode: numeric propertyType baseclass is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Int64]");
  }
  
  
  /// <summary>
  ///   contourW, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int64? ContourWidth
  {
    get => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertyGetCode: numeric propertyType baseType is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Int64]");
    set => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertySetCode: numeric propertyType baseclass is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Int64]");
  }
  
  
  /// <summary>
  ///   BevelTop.
  /// </summary>
  [DataMember]
  public DMW10.BevelTop? BevelTop
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Office2010.Word.BevelType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Office2010.Word.BevelType");
  }
  
  
  /// <summary>
  ///   BevelBottom.
  /// </summary>
  [DataMember]
  public DMW10.BevelBottom? BevelBottom
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Office2010.Word.BevelType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Office2010.Word.BevelType");
  }
  
  
  /// <summary>
  ///   ExtrusionColor.
  /// </summary>
  [DataMember]
  public DMW10.ExtrusionColor? ExtrusionColor
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Office2010.Word.ColorType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Office2010.Word.ColorType");
  }
  
  
  /// <summary>
  ///   ContourColor.
  /// </summary>
  [DataMember]
  public DMW10.ContourColor? ContourColor
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Office2010.Word.ColorType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Office2010.Word.ColorType");
  }
  
}
