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
      var element = _Element?.GetFirstChild<DXCXDP.SchemaReferences>();
      if (element != null)
        return SchemaReferencesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXCXDP.SchemaReferences>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SchemaReferencesConverter.CreateOpenXmlElement<DXCXDP.SchemaReferences>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
