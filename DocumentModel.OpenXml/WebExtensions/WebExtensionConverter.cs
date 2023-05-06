namespace DocumentModel.OpenXml.WebExtensions;

/// <summary>
/// Defines the WebExtension Class.
/// </summary>
public static class WebExtensionConverter
{
  /// <summary>
  /// Gets or sets the  value. It is only available for backwards compatibility
  /// </summary>
  private static Boolean? GetFronzen(DXO13WE.WebExtension openXmlElement)
  {
    return openXmlElement?.Fronzen?.Value;
  }
  
  private static bool CmpFronzen(DXO13WE.WebExtension openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Fronzen?.Value == value) return true;
    diffs?.Add(objName, "Fronzen", openXmlElement?.Fronzen?.Value, value);
    return false;
  }
  
  private static void SetFronzen(DXO13WE.WebExtension openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Fronzen = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Fronzen = null;
  }
  
  /// <summary>
  /// id, this property is only available in Office 2013 and later.
  /// </summary>
  private static String? GetId(DXO13WE.WebExtension openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Id);
  }
  
  private static bool CmpId(DXO13WE.WebExtension openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "AnnotationId");
  }
  
  private static void SetId(DXO13WE.WebExtension openXmlElement, String? value)
  {
    openXmlElement.Id = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// frozen, this property is only available in Office 2013 and later.
  /// </summary>
  private static Boolean? GetFrozen(DXO13WE.WebExtension openXmlElement)
  {
    return openXmlElement?.Frozen?.Value;
  }
  
  private static bool CmpFrozen(DXO13WE.WebExtension openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Frozen?.Value == value) return true;
    diffs?.Add(objName, "Frozen", openXmlElement?.Frozen?.Value, value);
    return false;
  }
  
  private static void SetFrozen(DXO13WE.WebExtension openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Frozen = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Frozen = null;
  }
  
  /// <summary>
  /// WebExtensionStoreReference.
  /// </summary>
  private static DMWE.WebExtensionStoreReference? GetWebExtensionStoreReference(DXO13WE.WebExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13WE.WebExtensionStoreReference>();
    if (element != null)
      return DMXWE.WebExtensionStoreReferenceConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpWebExtensionStoreReference(DXO13WE.WebExtension openXmlElement, DMWE.WebExtensionStoreReference? value, DiffList? diffs, string? objName)
  {
    return DMXWE.WebExtensionStoreReferenceConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO13WE.WebExtensionStoreReference>(), value, diffs, objName);
  }
  
  private static void SetWebExtensionStoreReference(DXO13WE.WebExtension openXmlElement, DMWE.WebExtensionStoreReference? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO13WE.WebExtensionStoreReference>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXWE.WebExtensionStoreReferenceConverter.CreateOpenXmlElement<DXO13WE.WebExtensionStoreReference>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// WebExtensionReferenceList.
  /// </summary>
  private static DMWE.WebExtensionReferenceList? GetWebExtensionReferenceList(DXO13WE.WebExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13WE.WebExtensionReferenceList>();
    if (element != null)
      return DMXWE.WebExtensionReferenceListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpWebExtensionReferenceList(DXO13WE.WebExtension openXmlElement, DMWE.WebExtensionReferenceList? value, DiffList? diffs, string? objName)
  {
    return DMXWE.WebExtensionReferenceListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO13WE.WebExtensionReferenceList>(), value, diffs, objName);
  }
  
  private static void SetWebExtensionReferenceList(DXO13WE.WebExtension openXmlElement, DMWE.WebExtensionReferenceList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO13WE.WebExtensionReferenceList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXWE.WebExtensionReferenceListConverter.CreateOpenXmlElement<DXO13WE.WebExtensionReferenceList>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// WebExtensionPropertyBag.
  /// </summary>
  private static DMWE.WebExtensionPropertyBag? GetWebExtensionPropertyBag(DXO13WE.WebExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13WE.WebExtensionPropertyBag>();
    if (element != null)
      return DMXWE.WebExtensionPropertyBagConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpWebExtensionPropertyBag(DXO13WE.WebExtension openXmlElement, DMWE.WebExtensionPropertyBag? value, DiffList? diffs, string? objName)
  {
    return DMXWE.WebExtensionPropertyBagConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO13WE.WebExtensionPropertyBag>(), value, diffs, objName);
  }
  
  private static void SetWebExtensionPropertyBag(DXO13WE.WebExtension openXmlElement, DMWE.WebExtensionPropertyBag? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO13WE.WebExtensionPropertyBag>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXWE.WebExtensionPropertyBagConverter.CreateOpenXmlElement<DXO13WE.WebExtensionPropertyBag>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// WebExtensionBindingList.
  /// </summary>
  private static DMWE.WebExtensionBindingList? GetWebExtensionBindingList(DXO13WE.WebExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13WE.WebExtensionBindingList>();
    if (element != null)
      return DMXWE.WebExtensionBindingListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpWebExtensionBindingList(DXO13WE.WebExtension openXmlElement, DMWE.WebExtensionBindingList? value, DiffList? diffs, string? objName)
  {
    return DMXWE.WebExtensionBindingListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO13WE.WebExtensionBindingList>(), value, diffs, objName);
  }
  
  private static void SetWebExtensionBindingList(DXO13WE.WebExtension openXmlElement, DMWE.WebExtensionBindingList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO13WE.WebExtensionBindingList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXWE.WebExtensionBindingListConverter.CreateOpenXmlElement<DXO13WE.WebExtensionBindingList>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Snapshot.
  /// </summary>
  private static DMWE.Snapshot? GetSnapshot(DXO13WE.WebExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13WE.Snapshot>();
    if (element != null)
      return DMXWE.SnapshotConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSnapshot(DXO13WE.WebExtension openXmlElement, DMWE.Snapshot? value, DiffList? diffs, string? objName)
  {
    return DMXWE.SnapshotConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO13WE.Snapshot>(), value, diffs, objName);
  }
  
  private static void SetSnapshot(DXO13WE.WebExtension openXmlElement, DMWE.Snapshot? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO13WE.Snapshot>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXWE.SnapshotConverter.CreateOpenXmlElement<DXO13WE.Snapshot>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  private static DMWE.OfficeArtExtensionList? GetOfficeArtExtensionList(DXO13WE.WebExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13WE.OfficeArtExtensionList>();
    if (element != null)
      return DMXWE.OfficeArtExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpOfficeArtExtensionList(DXO13WE.WebExtension openXmlElement, DMWE.OfficeArtExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXWE.OfficeArtExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO13WE.OfficeArtExtensionList>(), value, diffs, objName);
  }
  
  private static void SetOfficeArtExtensionList(DXO13WE.WebExtension openXmlElement, DMWE.OfficeArtExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO13WE.OfficeArtExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXWE.OfficeArtExtensionListConverter.CreateOpenXmlElement<DXO13WE.OfficeArtExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.WebExtensions.WebExtension? CreateModelElement(DXO13WE.WebExtension? openXmlElement)
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
  
  public static bool CompareModelElement(DXO13WE.WebExtension? openXmlElement, DMWE.WebExtension? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMWE.WebExtension value)
    where OpenXmlElementType: DXO13WE.WebExtension, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO13WE.WebExtension openXmlElement, DMWE.WebExtension value)
  {
    SetFronzen(openXmlElement, value?.Fronzen);
    SetId(openXmlElement, value?.Id);
    SetFrozen(openXmlElement, value?.Frozen);
    SetWebExtensionStoreReference(openXmlElement, value?.WebExtensionStoreReference);
    SetWebExtensionReferenceList(openXmlElement, value?.WebExtensionReferenceList);
    SetWebExtensionPropertyBag(openXmlElement, value?.WebExtensionPropertyBag);
    SetWebExtensionBindingList(openXmlElement, value?.WebExtensionBindingList);
    SetSnapshot(openXmlElement, value?.Snapshot);
    SetOfficeArtExtensionList(openXmlElement, value?.OfficeArtExtensionList);
  }
}
