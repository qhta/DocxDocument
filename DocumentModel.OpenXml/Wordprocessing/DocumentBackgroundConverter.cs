namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Document Background.
/// </summary>
public static class DocumentBackgroundConverter
{
  /// <summary>
  /// color
  /// </summary>
  public static String? GetColor(DocumentFormat.OpenXml.Wordprocessing.DocumentBackground? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetColor(DocumentFormat.OpenXml.Wordprocessing.DocumentBackground? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// themeColor
  /// </summary>
  public static DocumentModel.Wordprocessing.ThemeColorKind? GetThemeColor(DocumentFormat.OpenXml.Wordprocessing.DocumentBackground? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.ThemeColorValues, DocumentModel.Wordprocessing.ThemeColorKind>(openXmlElement?.ThemeColor?.Value);
  }
  
  public static void SetThemeColor(DocumentFormat.OpenXml.Wordprocessing.DocumentBackground? openXmlElement, DocumentModel.Wordprocessing.ThemeColorKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.ThemeColor = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.ThemeColorValues, DocumentModel.Wordprocessing.ThemeColorKind>(value);
  }
  
  /// <summary>
  /// themeTint
  /// </summary>
  public static String? GetThemeTint(DocumentFormat.OpenXml.Wordprocessing.DocumentBackground? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetThemeTint(DocumentFormat.OpenXml.Wordprocessing.DocumentBackground? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// themeShade
  /// </summary>
  public static String? GetThemeShade(DocumentFormat.OpenXml.Wordprocessing.DocumentBackground? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetThemeShade(DocumentFormat.OpenXml.Wordprocessing.DocumentBackground? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Background.
  /// </summary>
  public static DocumentModel.Vml.Background? GetBackground(DocumentFormat.OpenXml.Wordprocessing.DocumentBackground? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetBackground(DocumentFormat.OpenXml.Wordprocessing.DocumentBackground? openXmlElement, DocumentModel.Vml.Background? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
