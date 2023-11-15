namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Number Reference.
/// </summary>
public partial class NumberReference: ModelElement<DXDC.NumberReference>
{
  public NumberReference(): base(){ }
  
  public NumberReference(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public NumberReference(DXDC.NumberReference openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Formula.
  /// </summary>
  [DataMember]
  public DMDC.Formula? Formula
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement");
  }
  
  
  /// <summary>
  ///   NumberingCache.
  /// </summary>
  [DataMember]
  public DMDC.NumberingCache? NumberingCache
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.NumberDataType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.NumberDataType");
  }
  
  
  /// <summary>
  ///   NumRefExtensionList.
  /// </summary>
  [DataMember]
  public DMDC.NumRefExtensionList? NumRefExtensionList
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
