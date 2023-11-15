namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the NumberDataSourceType Class.
/// </summary>
public partial class NumberDataSourceType: ModelElement<DXDC.NumberDataSourceType>
{
  public NumberDataSourceType(): base(){ }
  
  public NumberDataSourceType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public NumberDataSourceType(DXDC.NumberDataSourceType openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Number Reference.
  /// </summary>
  [DataMember]
  public DMDC.NumberReference? NumberReference
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   Number Literal.
  /// </summary>
  [DataMember]
  public DMDC.NumberLiteral? NumberLiteral
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.NumberDataType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.NumberDataType");
  }
  
}
