namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Multi Level String Reference.
/// </summary>
public partial class MultiLevelStringReference: ModelElement<DXDC.MultiLevelStringReference>
{
  public MultiLevelStringReference(): base(){ }
  
  public MultiLevelStringReference(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public MultiLevelStringReference(DXDC.MultiLevelStringReference openXmlElement): base(openXmlElement) { }
  
  
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
  ///   MultiLevelStringCache.
  /// </summary>
  [DataMember]
  public DMDC.MultiLevelStringCache? MultiLevelStringCache
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   MultiLvlStrRefExtensionList.
  /// </summary>
  [DataMember]
  public DMDC.MultiLvlStrRefExtensionList? MultiLvlStrRefExtensionList
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
