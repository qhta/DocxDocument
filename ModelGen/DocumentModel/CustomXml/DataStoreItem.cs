namespace DocumentModel.CustomXml;


/// <summary>
///   Custom XML Data Properties.
/// </summary>
public partial class DataStoreItem: ModelElement<DXCXDP.DataStoreItem>
{
  public DataStoreItem(): base(){ }
  
  public DataStoreItem(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DataStoreItem(DXCXDP.DataStoreItem openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Custom XML Data ID
  /// </summary>
  [DataMember]
  public DocumentModel.HexInt? ItemId
  {
    get => HexIntConverter.GetValue(_Element?.ItemId);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  
  /// <summary>
  ///   Set of Associated XML Schemas.
  /// </summary>
  [DataMember]
  public DMCX.SchemaReferences? SchemaReferences
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
