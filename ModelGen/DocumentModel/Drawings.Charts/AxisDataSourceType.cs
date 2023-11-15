namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the AxisDataSourceType Class.
/// </summary>
public partial class AxisDataSourceType: ModelElement<DXDC.AxisDataSourceType>
{
  public AxisDataSourceType(): base(){ }
  
  public AxisDataSourceType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public AxisDataSourceType(DXDC.AxisDataSourceType openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Multi Level String Reference.
  /// </summary>
  [DataMember]
  public DMDC.MultiLevelStringReference? MultiLevelStringReference
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
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
  
  
  /// <summary>
  ///   StringReference.
  /// </summary>
  [DataMember]
  public DMDC.StringReference? StringReference
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   String Literal.
  /// </summary>
  [DataMember]
  public DMDC.StringLiteral? StringLiteral
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.StringDataType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.StringDataType");
  }
  
}
