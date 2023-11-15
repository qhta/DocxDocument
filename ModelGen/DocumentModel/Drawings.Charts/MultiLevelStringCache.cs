namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the MultiLevelStringCache Class.
/// </summary>
public partial class MultiLevelStringCache: ModelElement<DXDC.MultiLevelStringCache>
{
  public MultiLevelStringCache(): base(){ }
  
  public MultiLevelStringCache(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public MultiLevelStringCache(DXDC.MultiLevelStringCache openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   PointCount.
  /// </summary>
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
