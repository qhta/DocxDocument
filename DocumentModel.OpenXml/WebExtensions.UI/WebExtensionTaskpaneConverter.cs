namespace DocumentModel.OpenXml.WebExtensions.UI;

/// <summary>
/// Defines the WebExtensionTaskpane Class.
/// </summary>
public static class WebExtensionTaskpaneConverter
{
  /// <summary>
  /// dockstate, this property is only available in Office 2013 and later.
  /// </summary>
  private static String? GetDockState(DXO13WEP.WebExtensionTaskpane openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.DockState);
  }
  
  private static bool CmpDockState(DXO13WEP.WebExtensionTaskpane openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.DockState, value, diffs, objName, "DockState");
  }
  
  private static void SetDockState(DXO13WEP.WebExtensionTaskpane openXmlElement, String? value)
  {
    openXmlElement.DockState = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// visibility, this property is only available in Office 2013 and later.
  /// </summary>
  private static Boolean? GetVisibility(DXO13WEP.WebExtensionTaskpane openXmlElement)
  {
    return openXmlElement?.Visibility?.Value;
  }
  
  private static bool CmpVisibility(DXO13WEP.WebExtensionTaskpane openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Visibility?.Value == value) return true;
    diffs?.Add(objName, "Visibility", openXmlElement?.Visibility?.Value, value);
    return false;
  }
  
  private static void SetVisibility(DXO13WEP.WebExtensionTaskpane openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Visibility = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Visibility = null;
  }
  
  /// <summary>
  /// width, this property is only available in Office 2013 and later.
  /// </summary>
  private static Double? GetWidth(DXO13WEP.WebExtensionTaskpane openXmlElement)
  {
    return openXmlElement?.Width?.Value;
  }
  
  private static bool CmpWidth(DXO13WEP.WebExtensionTaskpane openXmlElement, Double? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Width?.Value == value) return true;
    diffs?.Add(objName, "Value", openXmlElement?.Width?.Value, value);
    return false;
  }
  
  private static void SetWidth(DXO13WEP.WebExtensionTaskpane openXmlElement, Double? value)
  {
    openXmlElement.Width = value;
  }
  
  /// <summary>
  /// row, this property is only available in Office 2013 and later.
  /// </summary>
  private static UInt32? GetRow(DXO13WEP.WebExtensionTaskpane openXmlElement)
  {
    return openXmlElement?.Row?.Value;
  }
  
  private static bool CmpRow(DXO13WEP.WebExtensionTaskpane openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Row?.Value == value) return true;
    diffs?.Add(objName, "Row", openXmlElement?.Row?.Value, value);
    return false;
  }
  
  private static void SetRow(DXO13WEP.WebExtensionTaskpane openXmlElement, UInt32? value)
  {
    openXmlElement.Row = value;
  }
  
  /// <summary>
  /// locked, this property is only available in Office 2013 and later.
  /// </summary>
  private static Boolean? GetLocked(DXO13WEP.WebExtensionTaskpane openXmlElement)
  {
    return openXmlElement?.Locked?.Value;
  }
  
  private static bool CmpLocked(DXO13WEP.WebExtensionTaskpane openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Locked?.Value == value) return true;
    diffs?.Add(objName, "Locked", openXmlElement?.Locked?.Value, value);
    return false;
  }
  
  private static void SetLocked(DXO13WEP.WebExtensionTaskpane openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Locked = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Locked = null;
  }
  
  /// <summary>
  /// WebExtensionPartReference.
  /// </summary>
  private static DMWEUI.WebExtensionPartReference? GetWebExtensionPartReference(DXO13WEP.WebExtensionTaskpane openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13WEP.WebExtensionPartReference>();
    if (element != null)
      return DMXWEUI.WebExtensionPartReferenceConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpWebExtensionPartReference(DXO13WEP.WebExtensionTaskpane openXmlElement, DMWEUI.WebExtensionPartReference? value, DiffList? diffs, string? objName)
  {
    return DMXWEUI.WebExtensionPartReferenceConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO13WEP.WebExtensionPartReference>(), value, diffs, objName);
  }
  
  private static void SetWebExtensionPartReference(DXO13WEP.WebExtensionTaskpane openXmlElement, DMWEUI.WebExtensionPartReference? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO13WEP.WebExtensionPartReference>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXWEUI.WebExtensionPartReferenceConverter.CreateOpenXmlElement<DXO13WEP.WebExtensionPartReference>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  private static DMWEUI.OfficeArtExtensionList? GetOfficeArtExtensionList(DXO13WEP.WebExtensionTaskpane openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13WEP.OfficeArtExtensionList>();
    if (element != null)
      return DMXWEUI.OfficeArtExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpOfficeArtExtensionList(DXO13WEP.WebExtensionTaskpane openXmlElement, DMWEUI.OfficeArtExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXWEUI.OfficeArtExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO13WEP.OfficeArtExtensionList>(), value, diffs, objName);
  }
  
  private static void SetOfficeArtExtensionList(DXO13WEP.WebExtensionTaskpane openXmlElement, DMWEUI.OfficeArtExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO13WEP.OfficeArtExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXWEUI.OfficeArtExtensionListConverter.CreateOpenXmlElement<DXO13WEP.OfficeArtExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.WebExtensions.UI.WebExtensionTaskpane? CreateModelElement(DXO13WEP.WebExtensionTaskpane? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.WebExtensions.UI.WebExtensionTaskpane();
      value.DockState = GetDockState(openXmlElement);
      value.Visibility = GetVisibility(openXmlElement);
      value.Width = GetWidth(openXmlElement);
      value.Row = GetRow(openXmlElement);
      value.Locked = GetLocked(openXmlElement);
      value.WebExtensionPartReference = GetWebExtensionPartReference(openXmlElement);
      value.OfficeArtExtensionList = GetOfficeArtExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO13WEP.WebExtensionTaskpane? openXmlElement, DMWEUI.WebExtensionTaskpane? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpDockState(openXmlElement, value.DockState, diffs, objName))
        ok = false;
      if (!CmpVisibility(openXmlElement, value.Visibility, diffs, objName))
        ok = false;
      if (!CmpWidth(openXmlElement, value.Width, diffs, objName))
        ok = false;
      if (!CmpRow(openXmlElement, value.Row, diffs, objName))
        ok = false;
      if (!CmpLocked(openXmlElement, value.Locked, diffs, objName))
        ok = false;
      if (!CmpWebExtensionPartReference(openXmlElement, value.WebExtensionPartReference, diffs, objName))
        ok = false;
      if (!CmpOfficeArtExtensionList(openXmlElement, value.OfficeArtExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMWEUI.WebExtensionTaskpane value)
    where OpenXmlElementType: DXO13WEP.WebExtensionTaskpane, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO13WEP.WebExtensionTaskpane openXmlElement, DMWEUI.WebExtensionTaskpane value)
  {
    SetDockState(openXmlElement, value?.DockState);
    SetVisibility(openXmlElement, value?.Visibility);
    SetWidth(openXmlElement, value?.Width);
    SetRow(openXmlElement, value?.Row);
    SetLocked(openXmlElement, value?.Locked);
    SetWebExtensionPartReference(openXmlElement, value?.WebExtensionPartReference);
    SetOfficeArtExtensionList(openXmlElement, value?.OfficeArtExtensionList);
  }
}
