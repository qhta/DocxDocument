namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Extra Color Scheme.
/// </summary>
public static class ExtraColorSchemeConverter
{
  /// <summary>
  /// ColorScheme.
  /// </summary>
  private static DMD.ColorScheme? GetColorScheme(DXD.ExtraColorScheme openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.ColorScheme>();
    if (element != null)
      return DMXD.ColorSchemeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpColorScheme(DXD.ExtraColorScheme openXmlElement, DMD.ColorScheme? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.ColorSchemeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.ColorScheme>(), value, diffs, objName, propName);
  }
  
  private static void SetColorScheme(DXD.ExtraColorScheme openXmlElement, DMD.ColorScheme? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.ColorScheme>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.ColorSchemeConverter.CreateOpenXmlElement(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// ColorMap.
  /// </summary>
  private static DMD.ColorMap? GetColorMap(DXD.ExtraColorScheme openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.ColorMap>();
    if (element != null)
      return DMXD.ColorMapConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpColorMap(DXD.ExtraColorScheme openXmlElement, DMD.ColorMap? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.ColorMapConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.ColorMap>(), value, diffs, objName, propName);
  }
  
  private static void SetColorMap(DXD.ExtraColorScheme openXmlElement, DMD.ColorMap? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.ColorMap>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.ColorMapConverter.CreateOpenXmlElement<DXD.ColorMap>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMD.ExtraColorScheme? CreateModelElement(DXD.ExtraColorScheme? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.ExtraColorScheme();
      value.ColorScheme = GetColorScheme(openXmlElement);
      value.ColorMap = GetColorMap(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXD.ExtraColorScheme? openXmlElement, DMD.ExtraColorScheme? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpColorScheme(openXmlElement, value.ColorScheme, diffs, objName, propName))
        ok = false;
      if (!CmpColorMap(openXmlElement, value.ColorMap, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.ExtraColorScheme value)
    where OpenXmlElementType: DXD.ExtraColorScheme, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.ExtraColorScheme openXmlElement, DMD.ExtraColorScheme value)
  {
    SetColorScheme(openXmlElement, value?.ColorScheme);
    SetColorMap(openXmlElement, value?.ColorMap);
  }
}
