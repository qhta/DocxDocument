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
        _ExistingElement.Fronzen = new BooleanValue { Value = (Boolean)value };
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
        _ExistingElement.Frozen = new BooleanValue { Value = (Boolean)value };
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
      var element = _Element?.GetFirstChild<DXO13WE.WebExtensionStoreReference>();
      if (element != null)
        return WebExtensionStoreReferenceConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO13WE.WebExtensionStoreReference>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = WebExtensionStoreReferenceConverter.CreateOpenXmlElement<DXO13WE.WebExtensionStoreReference>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXO13WE.WebExtensionReferenceList>();
      if (element != null)
        return WebExtensionReferenceListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO13WE.WebExtensionReferenceList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = WebExtensionReferenceListConverter.CreateOpenXmlElement<DXO13WE.WebExtensionReferenceList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXO13WE.WebExtensionPropertyBag>();
      if (element != null)
        return WebExtensionPropertyBagConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO13WE.WebExtensionPropertyBag>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = WebExtensionPropertyBagConverter.CreateOpenXmlElement<DXO13WE.WebExtensionPropertyBag>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXO13WE.WebExtensionBindingList>();
      if (element != null)
        return WebExtensionBindingListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO13WE.WebExtensionBindingList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = WebExtensionBindingListConverter.CreateOpenXmlElement<DXO13WE.WebExtensionBindingList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXO13WE.Snapshot>();
      if (element != null)
        return SnapshotConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO13WE.Snapshot>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SnapshotConverter.CreateOpenXmlElement<DXO13WE.Snapshot>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
