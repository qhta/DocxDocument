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
  
  private static void SetExtension(DXVmlO.ColorMostRecentlyUsed openXmlElement, DMVml.ExtensionHandlingBehaviorKind? value)
  {
    openXmlElement.Extension = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DMVml.ExtensionHandlingBehaviorKind>(value);
  }
  
  /// <summary>
  /// Recent colors
  /// </summary>
  private static String? GetColors(DXVmlO.ColorMostRecentlyUsed openXmlElement)
  {
    return openXmlElement?.Colors?.Value;
  }
  
  private static void SetColors(DXVmlO.ColorMostRecentlyUsed openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Colors = new StringValue { Value = value };
    else
      openXmlElement.Colors = null;
  }
  
  public static DMVml.ColorMostRecentlyUsed? CreateModelElement(DXVmlO.ColorMostRecentlyUsed? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMVml.ColorMostRecentlyUsed();
      value.Extension = GetExtension(openXmlElement);
      value.Colors = GetColors(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMVml.ColorMostRecentlyUsed? value)
    where OpenXmlElementType: DXVmlO.ColorMostRecentlyUsed, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetExtension(openXmlElement, value?.Extension);
      SetColors(openXmlElement, value?.Colors);
      return openXmlElement;
    }
    return default;
  }
}
