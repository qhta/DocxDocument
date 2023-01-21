namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Extra Color Scheme.
/// </summary>
public static class ExtraColorSchemeConverter
{
  /// <summary>
  /// ColorScheme.
  /// </summary>
  private static DMDraws.ColorScheme? GetColorScheme(DXDraw.ExtraColorScheme openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.ColorScheme>();
    if (itemElement != null)
      return DMXDraws.ColorSchemeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetColorScheme(DXDraw.ExtraColorScheme openXmlElement, DMDraws.ColorScheme? value)
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
  /// ColorMap.
  /// </summary>
  private static DMDraws.ColorMap? GetColorMap(DXDraw.ExtraColorScheme openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.ColorMap>();
    if (itemElement != null)
      return DMXDraws.ColorMapConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetColorMap(DXDraw.ExtraColorScheme openXmlElement, DMDraws.ColorMap? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.ColorMap>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.ColorMapConverter.CreateOpenXmlElement<DXDraw.ColorMap>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDraws.ExtraColorScheme? CreateModelElement(DXDraw.ExtraColorScheme? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.ExtraColorScheme();
      value.ColorScheme = GetColorScheme(openXmlElement);
      value.ColorMap = GetColorMap(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.ExtraColorScheme? value)
    where OpenXmlElementType: DXDraw.ExtraColorScheme, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetColorScheme(openXmlElement, value?.ColorScheme);
      SetColorMap(openXmlElement, value?.ColorMap);
      return openXmlElement;
    }
    return default;
  }
}
