namespace DocumentModel.Drawings10;


/// <summary>
///   Defines the HiddenShape3D Class.
/// </summary>
public partial class HiddenShape3D: ModelElement<DXO10D.HiddenShape3D>
{
  public HiddenShape3D(): base(){ }
  
  public HiddenShape3D(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public HiddenShape3D(DXO10D.HiddenShape3D openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Shape Depth
  /// </summary>
  [DataMember]
  public Int64? Z
  {
    get => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertyGetCode: numeric propertyType baseType is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Int64]");
    set => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertySetCode: numeric propertyType baseclass is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Int64]");
  }
  
  
  /// <summary>
  ///   Extrusion Height
  /// </summary>
  [DataMember]
  public Int64? ExtrusionHeight
  {
    get => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertyGetCode: numeric propertyType baseType is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Int64]");
    set => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertySetCode: numeric propertyType baseclass is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Int64]");
  }
  
  
  /// <summary>
  ///   Contour Width
  /// </summary>
  [DataMember]
  public Int64? ContourWidth
  {
    get => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertyGetCode: numeric propertyType baseType is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Int64]");
    set => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertySetCode: numeric propertyType baseclass is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Int64]");
  }
  
  
  /// <summary>
  ///   Top Bevel.
  /// </summary>
  [DataMember]
  public DMD.BevelTop? BevelTop
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.BevelType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.BevelType");
  }
  
  
  /// <summary>
  ///   Bottom Bevel.
  /// </summary>
  [DataMember]
  public DMD.BevelBottom? BevelBottom
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.BevelType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.BevelType");
  }
  
  
  /// <summary>
  ///   Extrusion Color.
  /// </summary>
  [DataMember]
  public DMD.ExtrusionColor? ExtrusionColor
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.ColorType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.ColorType");
  }
  
  
  /// <summary>
  ///   Contour Color.
  /// </summary>
  [DataMember]
  public DMD.ContourColor? ContourColor
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.ColorType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.ColorType");
  }
  
  
  /// <summary>
  ///   ExtensionList.
  /// </summary>
  [DataMember]
  public DMD.ExtensionList? ExtensionList
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
