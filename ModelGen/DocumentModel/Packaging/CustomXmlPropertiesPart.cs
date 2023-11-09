namespace DocumentModel.Packaging;


/// <summary>
///   Defines the CustomXmlPropertiesPart
/// </summary>
public partial class CustomXmlPropertiesPart: ModelPartElement<DXPack.CustomXmlPropertiesPart>
{
  public CustomXmlPropertiesPart(): base(){ }
  
  public CustomXmlPropertiesPart(DXPack.OpenXmlPart openXmlElement): base(openXmlElement) { }
  
  public CustomXmlPropertiesPart(DXPack.CustomXmlPropertiesPart openXmlElement): base(openXmlElement) { }
  
  [DataMember]
  public String? ContentType
  {
    get
    {
      return _Element?.ContentType;
    }
    set
    {
      _ExistingElement.ContentType = value;
    }
  }
  
  
  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  [DataMember]
  public DMCX.DataStoreItem? DataStoreItem
  {
    get
    {
        return DataStoreItemConverter.CreateModelElement(_Element?.RootElement as DXCXDP.DataStoreItem);
    }
    set
    {
      if (value != null)
      {
         var rootElement = DataStoreItemConverter.CreateOpenXmlElement<DXCXDP.DataStoreItem>(value);
         if (rootElement != null)
           _ExistingElement.DataStoreItem = rootElement;
      }
    }
  }
  
  [DataMember]
  public String? RelationshipType
  {
    get
    {
      return _Element?.RelationshipType;
    }
    set
    {
      _ExistingElement.RelationshipType = value;
    }
  }
  
}
