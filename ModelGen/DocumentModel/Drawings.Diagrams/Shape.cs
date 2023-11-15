namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   Shape.
/// </summary>
public partial class Shape: ModelElement<DXDDD.Shape>
{
  public Shape(): base(){ }
  
  public Shape(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Shape(DXDDD.Shape openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Rotation
  /// </summary>
  [DataMember]
  public Double? Rotation
  {
    get => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertyGetCode: numeric propertyType baseType is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Double]");
    set => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertySetCode: numeric propertyType baseclass is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Double]");
  }
  
  
  /// <summary>
  ///   Shape Type
  /// </summary>
  [DataMember]
  public String? Type
  {
    get => _Element?.Type;
    set => _ExistingElement.Type = value;
  }
  
  
  /// <summary>
  ///   Relationship to Image Part
  /// </summary>
  [DataMember]
  public String? Blip
  {
    get => _Element?.Blip;
    set => _ExistingElement.Blip = value;
  }
  
  
  /// <summary>
  ///   Z-Order Offset
  /// </summary>
  [DataMember]
  public Int32? ZOrderOffset
  {
    get => _Element?.ZOrderOffset?.Value;
    set => _ExistingElement.ZOrderOffset = value;
  }
  
  
  /// <summary>
  ///   Hide Geometry
  /// </summary>
  [DataMember]
  public Boolean? HideGeometry
  {
    get => _Element?.HideGeometry?.Value;
    set => _ExistingElement.HideGeometry = value;
  }
  
  
  /// <summary>
  ///   Prevent Text Editing
  /// </summary>
  [DataMember]
  public Boolean? LockedText
  {
    get => _Element?.LockedText?.Value;
    set => _ExistingElement.LockedText = value;
  }
  
  
  /// <summary>
  ///   Image Placeholder
  /// </summary>
  [DataMember]
  public Boolean? BlipPlaceholder
  {
    get => _Element?.BlipPlaceholder?.Value;
    set => _ExistingElement.BlipPlaceholder = value;
  }
  
  
  /// <summary>
  ///   Shape Adjust List.
  /// </summary>
  [DataMember]
  public DMDD.AdjustList? AdjustList
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   ExtensionList.
  /// </summary>
  [DataMember]
  public DMDD.ExtensionList? ExtensionList
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
