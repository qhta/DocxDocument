namespace DocumentModel.Drawings;


/// <summary>
///   Defines the BevelType Class.
/// </summary>
public partial class BevelType: ModelElement<DXD.BevelType>
{
  public BevelType(): base(){ }
  
  public BevelType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public BevelType(DXD.BevelType openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Width
  /// </summary>
  [DataMember]
  public Int64? Width
  {
    get => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertyGetCode: numeric propertyType baseType is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Int64]");
    set => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertySetCode: numeric propertyType baseclass is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Int64]");
  }
  
  
  /// <summary>
  ///   Height
  /// </summary>
  [DataMember]
  public Int64? Height
  {
    get => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertyGetCode: numeric propertyType baseType is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Int64]");
    set => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertySetCode: numeric propertyType baseclass is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Int64]");
  }
  
}
