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
    var element = openXmlElement?.GetFirstChild<DXDraw.ColorScheme>();
    if (element != null)
      return DMXDraws.ColorSchemeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpColorScheme(DXDraw.ExtraColorScheme openXmlElement, DMDraws.ColorScheme? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.ColorSchemeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.ColorScheme>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXDraw.ColorMap>();
    if (element != null)
      return DMXDraws.ColorMapConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpColorMap(DXDraw.ExtraColorScheme openXmlElement, DMDraws.ColorMap? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.ColorMapConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.ColorMap>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  public static DocumentModel.Drawings.ExtraColorScheme? CreateModelElement(DXDraw.ExtraColorScheme? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ExtraColorScheme();
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
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDraws.ExtraColorScheme value)
    where OpenXmlElementType: DXDraw.ExtraColorScheme, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDraw.ExtraColorScheme openXmlElement, DMDraws.ExtraColorScheme value)
  {
    SetColorScheme(openXmlElement, value?.ColorScheme);
    SetColorMap(openXmlElement, value?.ColorMap);
    }
  }
