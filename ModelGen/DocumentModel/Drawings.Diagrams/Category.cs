namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   Category.
/// </summary>
public partial class Category: ModelElement<DXDDD.Category>
{
  public Category(): base(){ }
  
  public Category(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Category(DXDDD.Category openXmlElement): base(openXmlElement) { }
  
  
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
