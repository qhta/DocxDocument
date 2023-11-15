namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   Color Transform Category.
/// </summary>
public partial class ColorTransformCategory: ModelElement<DXDDD.ColorTransformCategory>
{
  public ColorTransformCategory(): base(){ }
  
  public ColorTransformCategory(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ColorTransformCategory(DXDDD.ColorTransformCategory openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Category Type
  /// </summary>
  [DataMember]
  public String? Type
  {
    get => _Element?.Type;
    set => _ExistingElement.Type = value;
  }
  
  
  /// <summary>
  ///   Priority
  /// </summary>
  [DataMember]
  public UInt32? Priority
  {
    get => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertyGetCode: numeric propertyType baseType is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.UInt32]");
    set => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertySetCode: numeric propertyType baseclass is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.UInt32]");
  }
  
}
