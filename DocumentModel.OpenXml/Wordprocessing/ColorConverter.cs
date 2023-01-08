namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the Color Class.
/// </summary>
public static class ColorConverter
{
  /// <summary>
  /// Run Content Color
  /// </summary>
  public static String? GetVal(DocumentFormat.OpenXml.Wordprocessing.Color? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetVal(DocumentFormat.OpenXml.Wordprocessing.Color? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Run Content Theme Color
  /// </summary>
  public static DocumentModel.Wordprocessing.ThemeColorKind? GetThemeColor(DocumentFormat.OpenXml.Wordprocessing.Color? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.ThemeColorValues, DocumentModel.Wordprocessing.ThemeColorKind>(openXmlElement?.ThemeColor?.Value);
  }
  
  public static void SetThemeColor(DocumentFormat.OpenXml.Wordprocessing.Color? openXmlElement, DocumentModel.Wordprocessing.ThemeColorKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.ThemeColor = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.ThemeColorValues, DocumentModel.Wordprocessing.ThemeColorKind>(value);
  }
  
  /// <summary>
  /// Run Content Theme Color Tint
  /// </summary>
  public static String? GetThemeTint(DocumentFormat.OpenXml.Wordprocessing.Color? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetThemeTint(DocumentFormat.OpenXml.Wordprocessing.Color? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Run Content Theme Color Shade
  /// </summary>
  public static String? GetThemeShade(DocumentFormat.OpenXml.Wordprocessing.Color? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetThemeShade(DocumentFormat.OpenXml.Wordprocessing.Color? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
