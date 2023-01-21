namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the ThemeElements Class.
/// </summary>
public static class ThemeElementsConverter
{
  /// <summary>
  /// ColorScheme.
  /// </summary>
  private static DMDraws.ColorScheme? GetColorScheme(DXDraw.ThemeElements openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.ColorScheme>();
    if (itemElement != null)
      return DMXDraws.ColorSchemeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetColorScheme(DXDraw.ThemeElements openXmlElement, DMDraws.ColorScheme? value)
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
  /// Font Scheme.
  /// </summary>
  private static DMDraws.FontScheme? GetFontScheme(DXDraw.ThemeElements openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.FontScheme>();
    if (itemElement != null)
      return DMXDraws.FontSchemeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetFontScheme(DXDraw.ThemeElements openXmlElement, DMDraws.FontScheme? value)
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
  /// Format Scheme.
  /// </summary>
  private static DMDraws.FormatScheme? GetFormatScheme(DXDraw.ThemeElements openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.FormatScheme>();
    if (itemElement != null)
      return DMXDraws.FormatSchemeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetFormatScheme(DXDraw.ThemeElements openXmlElement, DMDraws.FormatScheme? value)
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
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  private static DMDraws.ExtensionList? GetExtensionList(DXDraw.ThemeElements openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.ExtensionList>();
    if (itemElement != null)
      return DMXDraws.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetExtensionList(DXDraw.ThemeElements openXmlElement, DMDraws.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.ExtensionListConverter.CreateOpenXmlElement<DXDraw.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDraws.ThemeElements? CreateModelElement(DXDraw.ThemeElements? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.ThemeElements();
      value.ColorScheme = GetColorScheme(openXmlElement);
      value.FontScheme = GetFontScheme(openXmlElement);
      value.FormatScheme = GetFormatScheme(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.ThemeElements? value)
    where OpenXmlElementType: DXDraw.ThemeElements, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetColorScheme(openXmlElement, value?.ColorScheme);
      SetFontScheme(openXmlElement, value?.FontScheme);
      SetFormatScheme(openXmlElement, value?.FormatScheme);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
