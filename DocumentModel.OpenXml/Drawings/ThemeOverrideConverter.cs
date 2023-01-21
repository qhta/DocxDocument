namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Theme Override.
/// </summary>
public static class ThemeOverrideConverter
{
  /// <summary>
  /// Color Scheme.
  /// </summary>
  private static DMDraws.ColorScheme? GetColorScheme(DXDraw.ThemeOverride openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.ColorScheme>();
    if (itemElement != null)
      return DMXDraws.ColorSchemeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetColorScheme(DXDraw.ThemeOverride openXmlElement, DMDraws.ColorScheme? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.ColorScheme>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.ColorSchemeConverter.CreateOpenXmlElement<DXDraw.ColorScheme>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// FontScheme.
  /// </summary>
  private static DMDraws.FontScheme? GetFontScheme(DXDraw.ThemeOverride openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.FontScheme>();
    if (itemElement != null)
      return DMXDraws.FontSchemeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetFontScheme(DXDraw.ThemeOverride openXmlElement, DMDraws.FontScheme? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.FontScheme>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.FontSchemeConverter.CreateOpenXmlElement<DXDraw.FontScheme>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// FormatScheme.
  /// </summary>
  private static DMDraws.FormatScheme? GetFormatScheme(DXDraw.ThemeOverride openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.FormatScheme>();
    if (itemElement != null)
      return DMXDraws.FormatSchemeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetFormatScheme(DXDraw.ThemeOverride openXmlElement, DMDraws.FormatScheme? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.FormatScheme>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.FormatSchemeConverter.CreateOpenXmlElement<DXDraw.FormatScheme>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDraws.ThemeOverride? CreateModelElement(DXDraw.ThemeOverride? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.ThemeOverride();
      value.ColorScheme = GetColorScheme(openXmlElement);
      value.FontScheme = GetFontScheme(openXmlElement);
      value.FormatScheme = GetFormatScheme(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.ThemeOverride? value)
    where OpenXmlElementType: DXDraw.ThemeOverride, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetColorScheme(openXmlElement, value?.ColorScheme);
      SetFontScheme(openXmlElement, value?.FontScheme);
      SetFormatScheme(openXmlElement, value?.FormatScheme);
      return openXmlElement;
    }
    return default;
  }
}
