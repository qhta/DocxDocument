namespace DocumentModel.OpenXml.WebExtensions;

/// <summary>
/// Defines the WebExtensionBinding Class.
/// </summary>
public static class WebExtensionBindingConverter
{
  /// <summary>
  /// id, this property is only available in Office 2013 and later.
  /// </summary>
  private static String? GetId(DXO13WE.WebExtensionBinding openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Id);
  }
  
  private static bool CmpId(DXO13WE.WebExtensionBinding openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "AnnotationId");
  }
  
  private static void SetId(DXO13WE.WebExtensionBinding openXmlElement, String? value)
  {
    openXmlElement.Id = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// type, this property is only available in Office 2013 and later.
  /// </summary>
  private static String? GetType(DXO13WE.WebExtensionBinding openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Type);
  }
  
  private static bool CmpType(DXO13WE.WebExtensionBinding openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Type, value, diffs, objName, "Type");
  }
  
  private static void SetType(DXO13WE.WebExtensionBinding openXmlElement, String? value)
  {
    openXmlElement.Type = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// appref, this property is only available in Office 2013 and later.
  /// </summary>
  private static String? GetAppReference(DXO13WE.WebExtensionBinding openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.AppReference);
  }
  
  private static bool CmpAppReference(DXO13WE.WebExtensionBinding openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.AppReference, value, diffs, objName, "AppReference");
  }
  
  private static void SetAppReference(DXO13WE.WebExtensionBinding openXmlElement, String? value)
  {
    openXmlElement.AppReference = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  private static DMWE.OfficeArtExtensionList? GetOfficeArtExtensionList(DXO13WE.WebExtensionBinding openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13WE.OfficeArtExtensionList>();
    if (element != null)
      return DMXWE.OfficeArtExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpOfficeArtExtensionList(DXO13WE.WebExtensionBinding openXmlElement, DMWE.OfficeArtExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXWE.OfficeArtExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO13WE.OfficeArtExtensionList>(), value, diffs, objName);
  }
  
  private static void SetOfficeArtExtensionList(DXO13WE.WebExtensionBinding openXmlElement, DMWE.OfficeArtExtensionList? value)
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
  
  public static DocumentModel.WebExtensions.WebExtensionBinding? CreateModelElement(DXO13WE.WebExtensionBinding? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.WebExtensions.WebExtensionBinding();
      value.Id = GetId(openXmlElement);
      value.Type = GetType(openXmlElement);
      value.AppReference = GetAppReference(openXmlElement);
      value.OfficeArtExtensionList = GetOfficeArtExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO13WE.WebExtensionBinding? openXmlElement, DMWE.WebExtensionBinding? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpId(openXmlElement, value.Id, diffs, objName))
        ok = false;
      if (!CmpType(openXmlElement, value.Type, diffs, objName))
        ok = false;
      if (!CmpAppReference(openXmlElement, value.AppReference, diffs, objName))
        ok = false;
      if (!CmpOfficeArtExtensionList(openXmlElement, value.OfficeArtExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMWE.WebExtensionBinding value)
    where OpenXmlElementType: DXO13WE.WebExtensionBinding, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO13WE.WebExtensionBinding openXmlElement, DMWE.WebExtensionBinding value)
  {
    SetId(openXmlElement, value?.Id);
    SetType(openXmlElement, value?.Type);
    SetAppReference(openXmlElement, value?.AppReference);
    SetOfficeArtExtensionList(openXmlElement, value?.OfficeArtExtensionList);
  }
}
