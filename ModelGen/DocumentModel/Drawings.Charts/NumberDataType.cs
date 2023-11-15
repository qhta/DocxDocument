namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the NumberDataType Class.
/// </summary>
public partial class NumberDataType: ModelElement<DXDC.NumberDataType>
{
  public NumberDataType(): base(){ }
  
  public NumberDataType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public NumberDataType(DXDC.NumberDataType openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Format Code.
  /// </summary>
  [DataMember]
  public DMDC.FormatCode? FormatCode
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement");
  }
  
  
  /// <summary>
  ///   Point Count.
  /// </summary>
  [DataMember]
  public DMDC.PointCount? PointCount
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.UnsignedIntegerType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.UnsignedIntegerType");
  }
  
}
