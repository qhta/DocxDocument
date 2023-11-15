namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   Shape Adjust.
/// </summary>
public partial class Adjust: ModelElement<DXDDD.Adjust>
{
  public Adjust(): base(){ }
  
  public Adjust(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Adjust(DXDDD.Adjust openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Adjust Handle Index
  /// </summary>
  [DataMember]
  public UInt32? Index
  {
    get => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertyGetCode: numeric propertyType baseType is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.UInt32]");
    set => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertySetCode: numeric propertyType baseclass is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.UInt32]");
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
  
}
