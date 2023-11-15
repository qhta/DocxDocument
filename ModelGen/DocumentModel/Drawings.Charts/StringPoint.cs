namespace DocumentModel.Drawings.Charts;


/// <summary>
///   String Point.
/// </summary>
public partial class StringPoint: ModelElement<DXDC.StringPoint>
{
  public StringPoint(): base(){ }
  
  public StringPoint(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public StringPoint(DXDC.StringPoint openXmlElement): base(openXmlElement) { }
  
  
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
  ///   Text Value.
  /// </summary>
  [DataMember]
  public DM.NumericValue? NumericValue
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is System.ValueType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
}
