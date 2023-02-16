namespace DocumentModel.OpenXml.WebExtensions;

/// <summary>
/// Defines the WebExtension Class.
/// </summary>
public static class WebExtensionConverter
{
  /// <summary>
  /// Gets or sets the  value. It is only available for backwards compatibility
  /// </summary>
  private static Boolean? GetFronzen(DXO2013WebExt.WebExtension openXmlElement)
  {
    return openXmlElement?.Fronzen?.Value;
  }
  
  private static bool CmpFronzen(DXO2013WebExt.WebExtension openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Fronzen?.Value == value) return true;
    diffs?.Add(objName, "Fronzen", openXmlElement?.Fronzen?.Value, value);
    return false;
  }
  
  private static void SetFronzen(DXO2013WebExt.WebExtension openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Fronzen = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Fronzen = null;
  }
  
  /// <summary>
  /// id, this property is only available in Office 2013 and later.
  /// </summary>
  private static String? GetId(DXO2013WebExt.WebExtension openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static bool CmpId(DXO2013WebExt.WebExtension openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Id?.Value == value) return true;
    diffs?.Add(objName, "Id", openXmlElement?.Id?.Value, value);
    return false;
  }
  
  private static void SetId(DXO2013WebExt.WebExtension openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  /// <summary>
  /// frozen, this property is only available in Office 2013 and later.
  /// </summary>
  private static Boolean? GetFrozen(DXO2013WebExt.WebExtension openXmlElement)
  {
    return openXmlElement?.Frozen?.Value;
  }
  
  private static bool CmpFrozen(DXO2013WebExt.WebExtension openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Frozen?.Value == value) return true;
    diffs?.Add(objName, "Frozen", openXmlElement?.Frozen?.Value, value);
    return false;
  }
  
  private static void SetFrozen(DXO2013WebExt.WebExtension openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Frozen = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Frozen = null;
  }
  
  /// <summary>
  /// WebExtensionStoreReference.
  /// </summary>
  private static DMWebExt.WebExtensionStoreReference? GetWebExtensionStoreReference(DXO2013WebExt.WebExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2013WebExt.WebExtensionStoreReference>();
    if (element != null)
      return DMXWebExt.WebExtensionStoreReferenceConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpWebExtensionStoreReference(DXO2013WebExt.WebExtension openXmlElement, DMWebExt.WebExtensionStoreReference? value, DiffList? diffs, string? objName)
  {
    return DMXWebExt.WebExtensionStoreReferenceConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2013WebExt.WebExtensionStoreReference>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetWebExtensionStoreReference(DXO2013WebExt.WebExtension openXmlElement, DMWebExt.WebExtensionStoreReference? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013WebExt.WebExtensionStoreReference>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXWebExt.WebExtensionStoreReferenceConverter.CreateOpenXmlElement<DXO2013WebExt.WebExtensionStoreReference>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// WebExtensionReferenceList.
  /// </summary>
  private static DMWebExt.WebExtensionReferenceList? GetWebExtensionReferenceList(DXO2013WebExt.WebExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2013WebExt.WebExtensionReferenceList>();
    if (element != null)
      return DMXWebExt.WebExtensionReferenceListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpWebExtensionReferenceList(DXO2013WebExt.WebExtension openXmlElement, DMWebExt.WebExtensionReferenceList? value, DiffList? diffs, string? objName)
  {
    return DMXWebExt.WebExtensionReferenceListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2013WebExt.WebExtensionReferenceList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetWebExtensionReferenceList(DXO2013WebExt.WebExtension openXmlElement, DMWebExt.WebExtensionReferenceList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013WebExt.WebExtensionReferenceList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXWebExt.WebExtensionReferenceListConverter.CreateOpenXmlElement<DXO2013WebExt.WebExtensionReferenceList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// WebExtensionPropertyBag.
  /// </summary>
  private static DMWebExt.WebExtensionPropertyBag? GetWebExtensionPropertyBag(DXO2013WebExt.WebExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2013WebExt.WebExtensionPropertyBag>();
    if (element != null)
      return DMXWebExt.WebExtensionPropertyBagConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpWebExtensionPropertyBag(DXO2013WebExt.WebExtension openXmlElement, DMWebExt.WebExtensionPropertyBag? value, DiffList? diffs, string? objName)
  {
    return DMXWebExt.WebExtensionPropertyBagConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2013WebExt.WebExtensionPropertyBag>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetWebExtensionPropertyBag(DXO2013WebExt.WebExtension openXmlElement, DMWebExt.WebExtensionPropertyBag? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013WebExt.WebExtensionPropertyBag>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXWebExt.WebExtensionPropertyBagConverter.CreateOpenXmlElement<DXO2013WebExt.WebExtensionPropertyBag>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// WebExtensionBindingList.
  /// </summary>
  private static DMWebExt.WebExtensionBindingList? GetWebExtensionBindingList(DXO2013WebExt.WebExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2013WebExt.WebExtensionBindingList>();
    if (element != null)
      return DMXWebExt.WebExtensionBindingListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpWebExtensionBindingList(DXO2013WebExt.WebExtension openXmlElement, DMWebExt.WebExtensionBindingList? value, DiffList? diffs, string? objName)
  {
    return DMXWebExt.WebExtensionBindingListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2013WebExt.WebExtensionBindingList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetWebExtensionBindingList(DXO2013WebExt.WebExtension openXmlElement, DMWebExt.WebExtensionBindingList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013WebExt.WebExtensionBindingList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXWebExt.WebExtensionBindingListConverter.CreateOpenXmlElement<DXO2013WebExt.WebExtensionBindingList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Snapshot.
  /// </summary>
  private static DMWebExt.Snapshot? GetSnapshot(DXO2013WebExt.WebExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2013WebExt.Snapshot>();
    if (element != null)
      return DMXWebExt.SnapshotConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSnapshot(DXO2013WebExt.WebExtension openXmlElement, DMWebExt.Snapshot? value, DiffList? diffs, string? objName)
  {
    return DMXWebExt.SnapshotConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2013WebExt.Snapshot>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetSnapshot(DXO2013WebExt.WebExtension openXmlElement, DMWebExt.Snapshot? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013WebExt.Snapshot>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXWebExt.SnapshotConverter.CreateOpenXmlElement<DXO2013WebExt.Snapshot>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  private static DMWebExt.OfficeArtExtensionList? GetOfficeArtExtensionList(DXO2013WebExt.WebExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2013WebExt.OfficeArtExtensionList>();
    if (element != null)
      return DMXWebExt.OfficeArtExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpOfficeArtExtensionList(DXO2013WebExt.WebExtension openXmlElement, DMWebExt.OfficeArtExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXWebExt.OfficeArtExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2013WebExt.OfficeArtExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetOfficeArtExtensionList(DXO2013WebExt.WebExtension openXmlElement, DMWebExt.OfficeArtExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013WebExt.OfficeArtExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXWebExt.OfficeArtExtensionListConverter.CreateOpenXmlElement<DXO2013WebExt.OfficeArtExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.WebExtensions.WebExtension? CreateModelElement(DXO2013WebExt.WebExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.WebExtensions.WebExtension();
      value.Fronzen = GetFronzen(openXmlElement);
      value.Id = GetId(openXmlElement);
      value.Frozen = GetFrozen(openXmlElement);
      value.WebExtensionStoreReference = GetWebExtensionStoreReference(openXmlElement);
      value.WebExtensionReferenceList = GetWebExtensionReferenceList(openXmlElement);
      value.WebExtensionPropertyBag = GetWebExtensionPropertyBag(openXmlElement);
      value.WebExtensionBindingList = GetWebExtensionBindingList(openXmlElement);
      value.Snapshot = GetSnapshot(openXmlElement);
      value.OfficeArtExtensionList = GetOfficeArtExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2013WebExt.WebExtension? openXmlElement, DMWebExt.WebExtension? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpFronzen(openXmlElement, value.Fronzen, diffs, objName))
        ok = false;
      if (!CmpId(openXmlElement, value.Id, diffs, objName))
        ok = false;
      if (!CmpFrozen(openXmlElement, value.Frozen, diffs, objName))
        ok = false;
      if (!CmpWebExtensionStoreReference(openXmlElement, value.WebExtensionStoreReference, diffs, objName))
        ok = false;
      if (!CmpWebExtensionReferenceList(openXmlElement, value.WebExtensionReferenceList, diffs, objName))
        ok = false;
      if (!CmpWebExtensionPropertyBag(openXmlElement, value.WebExtensionPropertyBag, diffs, objName))
        ok = false;
      if (!CmpWebExtensionBindingList(openXmlElement, value.WebExtensionBindingList, diffs, objName))
        ok = false;
      if (!CmpSnapshot(openXmlElement, value.Snapshot, diffs, objName))
        ok = false;
      if (!CmpOfficeArtExtensionList(openXmlElement, value.OfficeArtExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMWebExt.WebExtension? value)
    where OpenXmlElementType: DXO2013WebExt.WebExtension, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetFronzen(openXmlElement, value?.Fronzen);
      SetId(openXmlElement, value?.Id);
      SetFrozen(openXmlElement, value?.Frozen);
      SetWebExtensionStoreReference(openXmlElement, value?.WebExtensionStoreReference);
      SetWebExtensionReferenceList(openXmlElement, value?.WebExtensionReferenceList);
      SetWebExtensionPropertyBag(openXmlElement, value?.WebExtensionPropertyBag);
      SetWebExtensionBindingList(openXmlElement, value?.WebExtensionBindingList);
      SetSnapshot(openXmlElement, value?.Snapshot);
      SetOfficeArtExtensionList(openXmlElement, value?.OfficeArtExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
