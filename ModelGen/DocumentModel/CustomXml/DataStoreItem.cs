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
  public String? ItemId
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.ItemId);
    }
    set
    {
      _ExistingElement.ItemId = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Set of Associated XML Schemas.
  /// </summary>
  [DataMember]
  public DMCX.SchemaReferences? SchemaReferences
  {
    get
    {
      return _Element?.GetObject<DMCX.SchemaReferences,DXCXDP.SchemaReferences>();
    }
    set
    {
      _ExistingElement.SetObject<DMCX.SchemaReferences,DXCXDP.SchemaReferences>(value);
    }
  }
  
}
