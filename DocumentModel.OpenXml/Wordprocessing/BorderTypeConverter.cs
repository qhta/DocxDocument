namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the BorderType Class.
/// </summary>
public static class BorderTypeConverter
{
  /// <summary>
  /// Border Style
  /// </summary>
  private static DocumentModel.Wordprocessing.BorderKind? GetVal(DocumentFormat.OpenXml.Wordprocessing.BorderType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.BorderValues, DocumentModel.Wordprocessing.BorderKind>(openXmlElement?.Val?.Value);
  }
  
  private static void SetVal(DocumentFormat.OpenXml.Wordprocessing.BorderType openXmlElement, DocumentModel.Wordprocessing.BorderKind? value)
  {
    openXmlElement.Val = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.BorderValues, DocumentModel.Wordprocessing.BorderKind>(value);
  }
  
  /// <summary>
  /// Border Color
  /// </summary>
  private static String? GetColor(DocumentFormat.OpenXml.Wordprocessing.BorderType openXmlElement)
  {
    return openXmlElement?.Color?.Value;
  }
  
  private static void SetColor(DocumentFormat.OpenXml.Wordprocessing.BorderType openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Color = new StringValue { Value = value };
    else
      openXmlElement.Color = null;
  }
  
  /// <summary>
  /// Border Theme Color
  /// </summary>
  private static DocumentModel.Wordprocessing.ThemeColorKind? GetThemeColor(DocumentFormat.OpenXml.Wordprocessing.BorderType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.ThemeColorValues, DocumentModel.Wordprocessing.ThemeColorKind>(openXmlElement?.ThemeColor?.Value);
  }
  
  private static void SetThemeColor(DocumentFormat.OpenXml.Wordprocessing.BorderType openXmlElement, DocumentModel.Wordprocessing.ThemeColorKind? value)
  {
    openXmlElement.ThemeColor = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.ThemeColorValues, DocumentModel.Wordprocessing.ThemeColorKind>(value);
  }
  
  /// <summary>
  /// Border Theme Color Tint
  /// </summary>
  private static String? GetThemeTint(DocumentFormat.OpenXml.Wordprocessing.BorderType openXmlElement)
  {
    return openXmlElement?.ThemeTint?.Value;
  }
  
  private static void SetThemeTint(DocumentFormat.OpenXml.Wordprocessing.BorderType openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.ThemeTint = new StringValue { Value = value };
    else
      openXmlElement.ThemeTint = null;
  }
  
  /// <summary>
  /// Border Theme Color Shade
  /// </summary>
  private static String? GetThemeShade(DocumentFormat.OpenXml.Wordprocessing.BorderType openXmlElement)
  {
    return openXmlElement?.ThemeShade?.Value;
  }
  
  private static void SetThemeShade(DocumentFormat.OpenXml.Wordprocessing.BorderType openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.ThemeShade = new StringValue { Value = value };
    else
      openXmlElement.ThemeShade = null;
  }
  
  /// <summary>
  /// Border Width
  /// </summary>
  private static UInt32? GetSize(DocumentFormat.OpenXml.Wordprocessing.BorderType openXmlElement)
  {
    return openXmlElement.Size?.Value;
  }
  
  private static void SetSize(DocumentFormat.OpenXml.Wordprocessing.BorderType openXmlElement, UInt32? value)
  {
    openXmlElement.Size = value;
  }
  
  /// <summary>
  /// Border Spacing Measurement
  /// </summary>
  private static UInt32? GetSpace(DocumentFormat.OpenXml.Wordprocessing.BorderType openXmlElement)
  {
    return openXmlElement.Space?.Value;
  }
  
  private static void SetSpace(DocumentFormat.OpenXml.Wordprocessing.BorderType openXmlElement, UInt32? value)
  {
    openXmlElement.Space = value;
  }
  
  /// <summary>
  /// Border Shadow
  /// </summary>
  private static Boolean? GetShadow(DocumentFormat.OpenXml.Wordprocessing.BorderType openXmlElement)
  {
    return openXmlElement?.Shadow?.Value;
  }
  
  private static void SetShadow(DocumentFormat.OpenXml.Wordprocessing.BorderType openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Shadow = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.Shadow = null;
  }
  
  /// <summary>
  /// Create Frame Effect
  /// </summary>
  private static Boolean? GetFrame(DocumentFormat.OpenXml.Wordprocessing.BorderType openXmlElement)
  {
    return openXmlElement?.Frame?.Value;
  }
  
  private static void SetFrame(DocumentFormat.OpenXml.Wordprocessing.BorderType openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Frame = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.Frame = null;
  }
  
  public static DocumentModel.Wordprocessing.BorderType? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.BorderType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.BorderType();
      value.Val = GetVal(openXmlElement);
      value.Color = GetColor(openXmlElement);
      value.ThemeColor = GetThemeColor(openXmlElement);
      value.ThemeTint = GetThemeTint(openXmlElement);
      value.ThemeShade = GetThemeShade(openXmlElement);
      value.Size = GetSize(openXmlElement);
      value.Space = GetSpace(openXmlElement);
      value.Shadow = GetShadow(openXmlElement);
      value.Frame = GetFrame(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.BorderType? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.BorderType, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetVal(openXmlElement, value?.Val);
      SetColor(openXmlElement, value?.Color);
      SetThemeColor(openXmlElement, value?.ThemeColor);
      SetThemeTint(openXmlElement, value?.ThemeTint);
      SetThemeShade(openXmlElement, value?.ThemeShade);
      SetSize(openXmlElement, value?.Size);
      SetSpace(openXmlElement, value?.Space);
      SetShadow(openXmlElement, value?.Shadow);
      SetFrame(openXmlElement, value?.Frame);
      return openXmlElement;
    }
    return default;
  }
}
