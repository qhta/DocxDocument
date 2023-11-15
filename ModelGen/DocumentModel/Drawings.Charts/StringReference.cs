namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the StringReference Class.
/// </summary>
public partial class StringReference: ModelElement<DXDC.StringReference>
{
  public StringReference(): base(){ }
  
  public StringReference(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public StringReference(DXDC.StringReference openXmlElement): base(openXmlElement) { }
  
  
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
  ///   StringCache.
  /// </summary>
  [DataMember]
  public DMDC.StringCache? StringCache
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.StringDataType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.StringDataType");
  }
  
  
  /// <summary>
  ///   StrRefExtensionList.
  /// </summary>
  [DataMember]
  public DMDC.StrRefExtensionList? StrRefExtensionList
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
