namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the NumberingCache Class.
/// </summary>
public partial class NumberingCache: ModelElement<DXDC.NumberingCache>
{
  public NumberingCache(): base(){ }
  
  public NumberingCache(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public NumberingCache(DXDC.NumberingCache openXmlElement): base(openXmlElement) { }
  
  [DataMember]
  public DMDC.FormatCode? FormatCode
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement");
  }
  
  [DataMember]
  public DMDC.PointCount? PointCount
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.UnsignedIntegerType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.UnsignedIntegerType");
  }
  
  [DataMember]
  public DMDC.ExtensionList? ExtensionList
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
