namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Most Recently Used Colors.
/// </summary>
public static class ColorMostRecentlyUsedConverter
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  private static DocumentModel.Vml.ExtensionHandlingBehaviorKind? GetExtension(DocumentFormat.OpenXml.Vml.Office.ColorMostRecentlyUsed openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DocumentModel.Vml.ExtensionHandlingBehaviorKind>(openXmlElement?.Extension?.Value);
  }
  
  private static void SetExtension(DocumentFormat.OpenXml.Vml.Office.ColorMostRecentlyUsed openXmlElement, DocumentModel.Vml.ExtensionHandlingBehaviorKind? value)
  {
    openXmlElement.Extension = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DocumentModel.Vml.ExtensionHandlingBehaviorKind>(value);
  }
  
  /// <summary>
  /// Recent colors
  /// </summary>
  private static String? GetColors(DocumentFormat.OpenXml.Vml.Office.ColorMostRecentlyUsed openXmlElement)
  {
    return openXmlElement?.Colors?.Value;
  }
  
  private static void SetColors(DocumentFormat.OpenXml.Vml.Office.ColorMostRecentlyUsed openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Colors = new StringValue { Value = value };
    else
      openXmlElement.Colors = null;
  }
  
  public static DocumentModel.Vml.ColorMostRecentlyUsed? CreateModelElement(DocumentFormat.OpenXml.Vml.Office.ColorMostRecentlyUsed? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Vml.Office.ColorMostRecentlyUsed, new()
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
