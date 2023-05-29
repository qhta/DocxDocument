namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Most Recently Used Colors.
/// </summary>
public static class ColorMostRecentlyUsedConverter
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  private static DMVml.ExtensionHandlingBehaviorKind? GetExtension(DXVmlO.ColorMostRecentlyUsed openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DMVml.ExtensionHandlingBehaviorKind>(openXmlElement?.Extension?.Value);
  }
  
  private static bool CmpExtension(DXVmlO.ColorMostRecentlyUsed openXmlElement, DMVml.ExtensionHandlingBehaviorKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DMVml.ExtensionHandlingBehaviorKind>(openXmlElement?.Extension?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetExtension(DXVmlO.ColorMostRecentlyUsed openXmlElement, DMVml.ExtensionHandlingBehaviorKind? value)
  {
    openXmlElement.Extension = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DMVml.ExtensionHandlingBehaviorKind>(value);
  }
  
  /// <summary>
  /// Recent colors
  /// </summary>
  private static String? GetColors(DXVmlO.ColorMostRecentlyUsed openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Colors);
  }
  
  private static bool CmpColors(DXVmlO.ColorMostRecentlyUsed openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Colors, value, diffs, objName, "Colors");
  }
  
  private static void SetColors(DXVmlO.ColorMostRecentlyUsed openXmlElement, String? value)
  {
    openXmlElement.Colors = StringValueConverter.CreateStringValue(value);
  }
  
  public static DocumentModel.Vml.ColorMostRecentlyUsed? CreateModelElement(DXVmlO.ColorMostRecentlyUsed? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Vml.ColorMostRecentlyUsed();
      value.Extension = GetExtension(openXmlElement);
      value.Colors = GetColors(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXVmlO.ColorMostRecentlyUsed? openXmlElement, DMVml.ColorMostRecentlyUsed? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpExtension(openXmlElement, value.Extension, diffs, objName))
        ok = false;
      if (!CmpColors(openXmlElement, value.Colors, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMVml.ColorMostRecentlyUsed value)
    where OpenXmlElementType: DXVmlO.ColorMostRecentlyUsed, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXVmlO.ColorMostRecentlyUsed openXmlElement, DMVml.ColorMostRecentlyUsed value)
  {
    SetExtension(openXmlElement, value?.Extension);
    SetColors(openXmlElement, value?.Colors);
  }
}
