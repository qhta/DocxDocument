namespace DocumentModel.OpenXml.WebExtensions.UI;

/// <summary>
/// Defines the WebExtensionTaskpane Class.
/// </summary>
public static class WebExtensionTaskpaneConverter
{
  /// <summary>
  /// dockstate, this property is only available in Office 2013 and later.
  /// </summary>
  private static String? GetDockState(DXO2013WebExtPane.WebExtensionTaskpane openXmlElement)
  {
    return openXmlElement?.DockState?.Value;
  }
  
  private static void SetDockState(DXO2013WebExtPane.WebExtensionTaskpane openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.DockState = new StringValue { Value = value };
    else
      openXmlElement.DockState = null;
  }
  
  /// <summary>
  /// visibility, this property is only available in Office 2013 and later.
  /// </summary>
  private static Boolean? GetVisibility(DXO2013WebExtPane.WebExtensionTaskpane openXmlElement)
  {
    return openXmlElement?.Visibility?.Value;
  }
  
  private static void SetVisibility(DXO2013WebExtPane.WebExtensionTaskpane openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Visibility = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Visibility = null;
  }
  
  /// <summary>
  /// width, this property is only available in Office 2013 and later.
  /// </summary>
  private static Double? GetWidth(DXO2013WebExtPane.WebExtensionTaskpane openXmlElement)
  {
    return openXmlElement.Width?.Value;
  }
  
  private static void SetWidth(DXO2013WebExtPane.WebExtensionTaskpane openXmlElement, Double? value)
  {
    openXmlElement.Width = value;
  }
  
  /// <summary>
  /// row, this property is only available in Office 2013 and later.
  /// </summary>
  private static UInt32? GetRow(DXO2013WebExtPane.WebExtensionTaskpane openXmlElement)
  {
    return openXmlElement.Row?.Value;
  }
  
  private static void SetRow(DXO2013WebExtPane.WebExtensionTaskpane openXmlElement, UInt32? value)
  {
    openXmlElement.Row = value;
  }
  
  /// <summary>
  /// locked, this property is only available in Office 2013 and later.
  /// </summary>
  private static Boolean? GetLocked(DXO2013WebExtPane.WebExtensionTaskpane openXmlElement)
  {
    return openXmlElement?.Locked?.Value;
  }
  
  private static void SetLocked(DXO2013WebExtPane.WebExtensionTaskpane openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Locked = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Locked = null;
  }
  
  /// <summary>
  /// WebExtensionPartReference.
  /// </summary>
  private static DMWebExtUI.WebExtensionPartReference? GetWebExtensionPartReference(DXO2013WebExtPane.WebExtensionTaskpane openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2013WebExtPane.WebExtensionPartReference>();
    if (itemElement != null)
      return DMXWebExtUI.WebExtensionPartReferenceConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetWebExtensionPartReference(DXO2013WebExtPane.WebExtensionTaskpane openXmlElement, DMWebExtUI.WebExtensionPartReference? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013WebExtPane.WebExtensionPartReference>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXWebExtUI.WebExtensionPartReferenceConverter.CreateOpenXmlElement<DXO2013WebExtPane.WebExtensionPartReference>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  private static DMWebExtUI.OfficeArtExtensionList? GetOfficeArtExtensionList(DXO2013WebExtPane.WebExtensionTaskpane openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2013WebExtPane.OfficeArtExtensionList>();
    if (itemElement != null)
      return DMXWebExtUI.OfficeArtExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetOfficeArtExtensionList(DXO2013WebExtPane.WebExtensionTaskpane openXmlElement, DMWebExtUI.OfficeArtExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013WebExtPane.OfficeArtExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXWebExtUI.OfficeArtExtensionListConverter.CreateOpenXmlElement<DXO2013WebExtPane.OfficeArtExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMWebExtUI.WebExtensionTaskpane? CreateModelElement(DXO2013WebExtPane.WebExtensionTaskpane? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMWebExtUI.WebExtensionTaskpane();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMWebExtUI.WebExtensionTaskpane? value)
    where OpenXmlElementType: DXO2013WebExtPane.WebExtensionTaskpane, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetDockState(openXmlElement, value?.DockState);
      SetVisibility(openXmlElement, value?.Visibility);
      SetWidth(openXmlElement, value?.Width);
      SetRow(openXmlElement, value?.Row);
      SetLocked(openXmlElement, value?.Locked);
      SetWebExtensionPartReference(openXmlElement, value?.WebExtensionPartReference);
      SetOfficeArtExtensionList(openXmlElement, value?.OfficeArtExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
