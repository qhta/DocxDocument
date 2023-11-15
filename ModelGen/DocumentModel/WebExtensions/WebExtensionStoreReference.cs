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
    get => _Element?.Id;
    set => _ExistingElement.Id = value;
  }
  
  
  /// <summary>
  ///   version, this property is only available in Office 2013 and later.
  /// </summary>
  [DataMember]
  public String? Version
  {
    get => _Element?.Version;
    set => _ExistingElement.Version = value;
  }
  
  
  /// <summary>
  ///   store, this property is only available in Office 2013 and later.
  /// </summary>
  [DataMember]
  public String? Store
  {
    get => _Element?.Store;
    set => _ExistingElement.Store = value;
  }
  
  
  /// <summary>
  ///   storeType, this property is only available in Office 2013 and later.
  /// </summary>
  [DataMember]
  public String? StoreType
  {
    get => _Element?.StoreType;
    set => _ExistingElement.StoreType = value;
  }
  
  
  /// <summary>
  ///   OfficeArtExtensionList.
  /// </summary>
  [DataMember]
  public DMEX.OfficeArtExtensionList? OfficeArtExtensionList
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
