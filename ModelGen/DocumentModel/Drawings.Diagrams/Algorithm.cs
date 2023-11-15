namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   Algorithm.
/// </summary>
public partial class Algorithm: ModelElement<DXDDD.Algorithm>
{
  public Algorithm(): base(){ }
  
  public Algorithm(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Algorithm(DXDDD.Algorithm openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Revision Number
  /// </summary>
  [DataMember]
  public UInt32? Revision
  {
    get => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertyGetCode: numeric propertyType baseType is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.UInt32]");
    set => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertySetCode: numeric propertyType baseclass is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.UInt32]");
  }
  
  [DataMember]
  public DMDD.ExtensionList? ExtensionList
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
