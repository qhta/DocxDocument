namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   Constraint.
/// </summary>
public partial class Constraint: ModelElement<DXDDD.Constraint>
{
  public Constraint(): base(){ }
  
  public Constraint(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Constraint(DXDDD.Constraint openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   For Name
  /// </summary>
  [DataMember]
  public String? ForName
  {
    get => _Element?.ForName;
    set => _ExistingElement.ForName = value;
  }
  
  
  /// <summary>
  ///   Reference For Name
  /// </summary>
  [DataMember]
  public String? ReferenceForName
  {
    get => _Element?.ReferenceForName;
    set => _ExistingElement.ReferenceForName = value;
  }
  
  
  /// <summary>
  ///   Value
  /// </summary>
  [DataMember]
  public Double? Val
  {
    get => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertyGetCode: numeric propertyType baseType is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Double]");
    set => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertySetCode: numeric propertyType baseclass is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Double]");
  }
  
  
  /// <summary>
  ///   Factor
  /// </summary>
  [DataMember]
  public Double? Fact
  {
    get => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertyGetCode: numeric propertyType baseType is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Double]");
    set => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertySetCode: numeric propertyType baseclass is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Double]");
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
