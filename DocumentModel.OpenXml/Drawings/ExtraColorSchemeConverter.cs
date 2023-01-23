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
    return DMXDraws.ColorSchemeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.ColorScheme>());
  }
  
  private static bool CmpColorScheme(DXDraw.ExtraColorScheme openXmlElement, DMDraws.ColorScheme? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.ColorSchemeConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.ColorScheme>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXDraws.ColorMapConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.ColorMap>());
  }
  
  private static bool CmpColorMap(DXDraw.ExtraColorScheme openXmlElement, DMDraws.ColorMap? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.ColorMapConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.ColorMap>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  public static bool CompareModelElement(DXDraw.ExtraColorScheme? openXmlElement, DMDraws.ExtraColorScheme? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpColorScheme(openXmlElement, value.ColorScheme, diffs, objName))
        ok = false;
      if (!CmpColorMap(openXmlElement, value.ColorMap, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
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
