namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Numeric Point.
/// </summary>
public partial class NumericPoint: ModelElement<DXDC.NumericPoint>
{
  public NumericPoint(): base(){ }
  
  public NumericPoint(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public NumericPoint(DXDC.NumericPoint openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Index
  /// </summary>
  [DataMember]
  public UInt32? Index
  {
    get => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertyGetCode: numeric propertyType baseType is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.UInt32]");
    set => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertySetCode: numeric propertyType baseclass is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.UInt32]");
  }
  
  
  /// <summary>
  ///   Number Format
  /// </summary>
  [DataMember]
  public String? FormatCode
  {
    get => _Element?.FormatCode;
    set => _ExistingElement.FormatCode = value;
  }
  
  
  /// <summary>
  ///   Numeric Value.
  /// </summary>
  [DataMember]
  public DM.NumericValue? NumericValue
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is System.ValueType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
}
