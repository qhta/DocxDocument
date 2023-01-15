using DocumentFormat.OpenXml.Vml;
using DocumentModel.Vml;
using ColorMostRecentlyUsed = DocumentFormat.OpenXml.Vml.Office.ColorMostRecentlyUsed;

namespace DocumentModel.OpenXml.Vml;

/// <summary>
///   Most Recently Used Colors.
/// </summary>
public static class ColorMostRecentlyUsedConverter
{
  /// <summary>
  ///   VML Extension Handling Behavior
  /// </summary>
  public static ExtensionHandlingBehaviorKind? GetExtension(ColorMostRecentlyUsed? openXmlElement)
  {
    return EnumValueConverter.GetValue<ExtensionHandlingBehaviorValues, ExtensionHandlingBehaviorKind>(openXmlElement?.Extension?.Value);
  }

  public static void SetExtension(ColorMostRecentlyUsed? openXmlElement, ExtensionHandlingBehaviorKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Extension = EnumValueConverter.CreateEnumValue<ExtensionHandlingBehaviorValues, ExtensionHandlingBehaviorKind>(value);
  }

  /// <summary>
  ///   Recent colors
  /// </summary>
  public static String? GetColors(ColorMostRecentlyUsed? openXmlElement)
  {
    return openXmlElement?.Colors?.Value;
  }

  public static void SetColors(ColorMostRecentlyUsed? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Colors = new StringValue { Value = value };
      else
        openXmlElement.Colors = null;
  }

  public static DocumentModel.Vml.ColorMostRecentlyUsed? CreateModelElement(ColorMostRecentlyUsed? openXmlElement)
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

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Vml.ColorMostRecentlyUsed? value)
    where OpenXmlElementType : ColorMostRecentlyUsed, new()
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