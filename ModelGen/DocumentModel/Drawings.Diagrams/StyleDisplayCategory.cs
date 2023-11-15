namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   Category.
/// </summary>
public partial class StyleDisplayCategory: ModelElement<DXDDD.StyleDisplayCategory>
{
  public StyleDisplayCategory(): base(){ }
  
  public StyleDisplayCategory(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public StyleDisplayCategory(DXDDD.StyleDisplayCategory openXmlElement): base(openXmlElement) { }
  
  
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
