namespace DocumentModel.Word10;


/// <summary>
///   Defines the BevelType Class.
/// </summary>
public partial class BevelType: ModelElement<DXO10W.BevelType>
{
  public BevelType(): base(){ }
  
  public BevelType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public BevelType(DXO10W.BevelType openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   w, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int64? Width
  {
    get => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertyGetCode: numeric propertyType baseType is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Int64]");
    set => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertySetCode: numeric propertyType baseclass is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Int64]");
  }
  
  
  /// <summary>
  ///   h, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int64? Height
  {
    get => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertyGetCode: numeric propertyType baseType is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Int64]");
    set => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertySetCode: numeric propertyType baseclass is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Int64]");
  }
  
}
