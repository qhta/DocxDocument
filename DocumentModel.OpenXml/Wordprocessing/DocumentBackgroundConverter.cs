namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Document Background.
/// </summary>
public static class DocumentBackgroundConverter
{
  /// <summary>
  /// color
  /// </summary>
  private static String? GetColor(DocumentFormat.OpenXml.Wordprocessing.DocumentBackground openXmlElement)
  {
    return openXmlElement?.Color?.Value;
  }
  
  private static void SetColor(DocumentFormat.OpenXml.Wordprocessing.DocumentBackground openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Color = new StringValue { Value = value };
    else
      openXmlElement.Color = null;
  }
  
  /// <summary>
  /// themeColor
  /// </summary>
  private static DocumentModel.Wordprocessing.ThemeColorKind? GetThemeColor(DocumentFormat.OpenXml.Wordprocessing.DocumentBackground openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.ThemeColorValues, DocumentModel.Wordprocessing.ThemeColorKind>(openXmlElement?.ThemeColor?.Value);
  }
  
  private static void SetThemeColor(DocumentFormat.OpenXml.Wordprocessing.DocumentBackground openXmlElement, DocumentModel.Wordprocessing.ThemeColorKind? value)
  {
    openXmlElement.ThemeColor = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.ThemeColorValues, DocumentModel.Wordprocessing.ThemeColorKind>(value);
  }
  
  /// <summary>
  /// themeTint
  /// </summary>
  private static String? GetThemeTint(DocumentFormat.OpenXml.Wordprocessing.DocumentBackground openXmlElement)
  {
    return openXmlElement?.ThemeTint?.Value;
  }
  
  private static void SetThemeTint(DocumentFormat.OpenXml.Wordprocessing.DocumentBackground openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.ThemeTint = new StringValue { Value = value };
    else
      openXmlElement.ThemeTint = null;
  }
  
  /// <summary>
  /// themeShade
  /// </summary>
  private static String? GetThemeShade(DocumentFormat.OpenXml.Wordprocessing.DocumentBackground openXmlElement)
  {
    return openXmlElement?.ThemeShade?.Value;
  }
  
  private static void SetThemeShade(DocumentFormat.OpenXml.Wordprocessing.DocumentBackground openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.ThemeShade = new StringValue { Value = value };
    else
      openXmlElement.ThemeShade = null;
  }
  
  /// <summary>
  /// Background.
  /// </summary>
  private static DocumentModel.Vml.Background? GetBackground(DocumentFormat.OpenXml.Wordprocessing.DocumentBackground openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Background>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.BackgroundConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBackground(DocumentFormat.OpenXml.Wordprocessing.DocumentBackground openXmlElement, DocumentModel.Vml.Background? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Background>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Vml.BackgroundConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Background>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Wordprocessing.DocumentBackground? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.DocumentBackground? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.DocumentBackground();
      value.Color = GetColor(openXmlElement);
      value.ThemeColor = GetThemeColor(openXmlElement);
      value.ThemeTint = GetThemeTint(openXmlElement);
      value.ThemeShade = GetThemeShade(openXmlElement);
      value.Background = GetBackground(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.DocumentBackground? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.DocumentBackground, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetColor(openXmlElement, value?.Color);
      SetThemeColor(openXmlElement, value?.ThemeColor);
      SetThemeTint(openXmlElement, value?.ThemeTint);
      SetThemeShade(openXmlElement, value?.ThemeShade);
      SetBackground(openXmlElement, value?.Background);
      return openXmlElement;
    }
    return default;
  }
}
