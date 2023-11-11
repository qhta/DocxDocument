namespace DocumentModel.WebExtensions;


/// <summary>
///   Defines the WebExtension Class.
/// </summary>
public partial class WebExtension: ModelElement<DXO13WE.WebExtension>
{
  public WebExtension(): base(){ }
  
  public WebExtension(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public WebExtension(DXO13WE.WebExtension openXmlElement): base(openXmlElement) { }
  
  [DataMember]
  public Boolean? Fronzen
  {
    get
    {
      return _Element?.Fronzen?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.Fronzen = new DX.BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.Fronzen = null;
    }
  }
  
  
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
  ///   frozen, this property is only available in Office 2013 and later.
  /// </summary>
  [DataMember]
  public Boolean? Frozen
  {
    get
    {
      return _Element?.Frozen?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.Frozen = new DX.BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.Frozen = null;
    }
  }
  
  
  /// <summary>
  ///   WebExtensionStoreReference.
  /// </summary>
  [DataMember]
  public DMEX.WebExtensionStoreReference? WebExtensionStoreReference
  {
    get
    {
      return _Element?.GetObject<DMEX.WebExtensionStoreReference,DXO13WE.WebExtensionStoreReference>();
    }
    set
    {
      _ExistingElement.SetObject<DMEX.WebExtensionStoreReference,DXO13WE.WebExtensionStoreReference>(value);
    }
  }
  
  
  /// <summary>
  ///   WebExtensionReferenceList.
  /// </summary>
  [DataMember]
  public DMEX.WebExtensionReferenceList? WebExtensionReferenceList
  {
    get
    {
      return _Element?.GetObject<DMEX.WebExtensionReferenceList,DXO13WE.WebExtensionReferenceList>();
    }
    set
    {
      _ExistingElement.SetObject<DMEX.WebExtensionReferenceList,DXO13WE.WebExtensionReferenceList>(value);
    }
  }
  
  
  /// <summary>
  ///   WebExtensionPropertyBag.
  /// </summary>
  [DataMember]
  public DMEX.WebExtensionPropertyBag? WebExtensionPropertyBag
  {
    get
    {
      return _Element?.GetObject<DMEX.WebExtensionPropertyBag,DXO13WE.WebExtensionPropertyBag>();
    }
    set
    {
      _ExistingElement.SetObject<DMEX.WebExtensionPropertyBag,DXO13WE.WebExtensionPropertyBag>(value);
    }
  }
  
  
  /// <summary>
  ///   WebExtensionBindingList.
  /// </summary>
  [DataMember]
  public DMEX.WebExtensionBindingList? WebExtensionBindingList
  {
    get
    {
      return _Element?.GetObject<DMEX.WebExtensionBindingList,DXO13WE.WebExtensionBindingList>();
    }
    set
    {
      _ExistingElement.SetObject<DMEX.WebExtensionBindingList,DXO13WE.WebExtensionBindingList>(value);
    }
  }
  
  
  /// <summary>
  ///   Snapshot.
  /// </summary>
  [DataMember]
  public DMEX.Snapshot? Snapshot
  {
    get
    {
      return _Element?.GetObject<DMEX.Snapshot,DXO13WE.Snapshot>();
    }
    set
    {
      _ExistingElement.SetObject<DMEX.Snapshot,DXO13WE.Snapshot>(value);
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
      return _Element?.GetObject<DMEX.OfficeArtExtensionList,DXO13WE.OfficeArtExtensionList>();
    }
    set
    {
      _ExistingElement.SetObject<DMEX.OfficeArtExtensionList,DXO13WE.OfficeArtExtensionList>(value);
    }
  }
  
}
