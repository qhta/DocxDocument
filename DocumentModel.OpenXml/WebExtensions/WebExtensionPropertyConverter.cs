namespace DocumentModel.OpenXml.WebExtensions;

/// <summary>
/// Defines the WebExtensionProperty Class.
/// </summary>
public static class WebExtensionPropertyConverter
{
  /// <summary>
  /// name, this property is only available in Office 2013 and later.
  /// </summary>
  private static String? GetName(DXO2013WebExt.WebExtensionProperty openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Name);
  }
  
  private static bool CmpName(DXO2013WebExt.WebExtensionProperty openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Name, value, diffs, objName, "Name");
  }
  
  private static void SetName(DXO2013WebExt.WebExtensionProperty openXmlElement, String? value)
  {
    openXmlElement.Name = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// value, this property is only available in Office 2013 and later.
  /// </summary>
  private static String? GetValue(DXO2013WebExt.WebExtensionProperty openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Value);
  }
  
  private static bool CmpValue(DXO2013WebExt.WebExtensionProperty openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Value, value, diffs, objName, "Value");
  }
  
  private static void SetValue(DXO2013WebExt.WebExtensionProperty openXmlElement, String? value)
  {
    openXmlElement.Value = StringValueConverter.CreateStringValue(value);
  }
  
  public static DocumentModel.WebExtensions.WebExtensionProperty? CreateModelElement(DXO2013WebExt.WebExtensionProperty? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.WebExtensions.WebExtensionProperty();
      value.Name = GetName(openXmlElement);
      value.Value = GetValue(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2013WebExt.WebExtensionProperty? openXmlElement, DMWebExt.WebExtensionProperty? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpName(openXmlElement, value.Name, diffs, objName))
        ok = false;
      if (!CmpValue(openXmlElement, value.Value, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMWebExt.WebExtensionProperty value)
    where OpenXmlElementType: DXO2013WebExt.WebExtensionProperty, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2013WebExt.WebExtensionProperty openXmlElement, DMWebExt.WebExtensionProperty value)
  {
    SetName(openXmlElement, value?.Name);
    SetValue(openXmlElement, value?.Value);
    }
  }
