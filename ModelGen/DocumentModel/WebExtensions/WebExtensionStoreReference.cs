namespace DocumentModel.WebExtensions;


/// <summary>
///   Defines the WebExtensionStoreReference Class.
/// </summary>
public partial class WebExtensionStoreReference: ModelElement<DXO13WE.WebExtensionStoreReference>
{
  public WebExtensionStoreReference(): base(){ }
  
  public WebExtensionStoreReference(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public WebExtensionStoreReference(DXO13WE.WebExtensionStoreReference openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   id, this property is only available in Office 2013 and later.
  /// </summary>
  [DataMember]
  public String? Id
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Id);
    }
    set
    {
      _ExistingElement.Id = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   version, this property is only available in Office 2013 and later.
  /// </summary>
  [DataMember]
  public String? Version
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Version);
    }
    set
    {
      _ExistingElement.Version = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   store, this property is only available in Office 2013 and later.
  /// </summary>
  [DataMember]
  public String? Store
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Store);
    }
    set
    {
      _ExistingElement.Store = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   storeType, this property is only available in Office 2013 and later.
  /// </summary>
  [DataMember]
  public String? StoreType
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.StoreType);
    }
    set
    {
      _ExistingElement.StoreType = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   OfficeArtExtensionList.
  /// </summary>
  [DataMember]
  public DMEX.OfficeArtExtensionList? OfficeArtExtensionList
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO13WE.OfficeArtExtensionList>();
      if (element != null)
        return OfficeArtExtensionListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO13WE.OfficeArtExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = OfficeArtExtensionListConverter.CreateOpenXmlElement<DXO13WE.OfficeArtExtensionList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
