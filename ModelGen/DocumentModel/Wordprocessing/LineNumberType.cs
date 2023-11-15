namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the LineNumberType Class.
/// </summary>
public partial class LineNumberType: ModelElement<DXW.LineNumberType>
{
  public LineNumberType(): base(){ }
  
  public LineNumberType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public LineNumberType(DXW.LineNumberType openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Line Number Increments to Display
  /// </summary>
  [DataMember]
  public Int16? CountBy
  {
    get => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertyGetCode: numeric propertyType baseType is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Int16]");
    set => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertySetCode: numeric propertyType baseclass is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Int16]");
  }
  
  
  /// <summary>
  ///   Line Numbering Starting Value
  /// </summary>
  [DataMember]
  public Int16? Start
  {
    get => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertyGetCode: numeric propertyType baseType is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Int16]");
    set => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertySetCode: numeric propertyType baseclass is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Int16]");
  }
  
  
  /// <summary>
  ///   Distance Between Text and Line Numbering
  /// </summary>
  [DataMember]
  public String? Distance
  {
    get => _Element?.Distance;
    set => _ExistingElement.Distance = value;
  }
  
}
