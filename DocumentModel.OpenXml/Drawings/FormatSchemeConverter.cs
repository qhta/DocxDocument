namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Format Scheme.
/// </summary>
public static class FormatSchemeConverter
{
  /// <summary>
  /// Name
  /// </summary>
  private static String? GetName(DXD.FormatScheme openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Name);
  }
  
  private static bool CmpName(DXD.FormatScheme openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Name, value, diffs, objName, "Name");
  }
  
  private static void SetName(DXD.FormatScheme openXmlElement, String? value)
  {
    openXmlElement.Name = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Fill Style List.
  /// </summary>
  private static DMD.FillStyleList? GetFillStyleList(DXD.FormatScheme openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.FillStyleList>();
    if (element != null)
      return DMXD.FillStyleListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFillStyleList(DXD.FormatScheme openXmlElement, DMD.FillStyleList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.FillStyleListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.FillStyleList>(), value, diffs, objName, propName);
  }
  
  private static void SetFillStyleList(DXD.FormatScheme openXmlElement, DMD.FillStyleList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.FillStyleList>();
    if (itemElement != null && value != null)
      DMXD.FillStyleListConverter.UpdateOpenXmlElement(itemElement, value);
    else
    if (value != null)
    {
      itemElement = DMXD.FillStyleListConverter.CreateOpenXmlElement<DXD.FillStyleList>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Line Style List.
  /// </summary>
  private static DMD.LineStyleList? GetLineStyleList(DXD.FormatScheme openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.LineStyleList>();
    if (element != null)
      return DMXD.LineStyleListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLineStyleList(DXD.FormatScheme openXmlElement, DMD.LineStyleList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.LineStyleListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.LineStyleList>(), value, diffs, objName, propName);
  }
  
  private static void SetLineStyleList(DXD.FormatScheme openXmlElement, DMD.LineStyleList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.LineStyleList>();
    if (itemElement != null && value != null)
      DMXD.LineStyleListConverter.UpdateOpenXmlElement(itemElement, value);
    else
    if (value != null)
    {
      itemElement = DMXD.LineStyleListConverter.CreateOpenXmlElement(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Effect Style List.
  /// </summary>
  private static DMD.EffectStyleList? GetEffectStyleList(DXD.FormatScheme openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.EffectStyleList>();
    if (element != null)
      return DMXD.EffectStyleListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpEffectStyleList(DXD.FormatScheme openXmlElement, DMD.EffectStyleList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.EffectStyleListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.EffectStyleList>(), value, diffs, objName, propName);
  }
  
  private static void SetEffectStyleList(DXD.FormatScheme openXmlElement, DMD.EffectStyleList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.EffectStyleList>();
    if (itemElement != null && value != null)
      DMXD.EffectStyleListConverter.UpdateOpenXmlElement(itemElement, value);
    else
    if (value != null)
    {
      itemElement = DMXD.EffectStyleListConverter.CreateOpenXmlElement<DXD.EffectStyleList>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Background Fill Style List.
  /// </summary>
  private static DMD.FillStyleList? GetBackgroundFillStyleList(DXD.FormatScheme openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.BackgroundFillStyleList>();
    if (element != null)
      return DMXD.FillStyleListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBackgroundFillStyleList(DXD.FormatScheme openXmlElement, DMD.FillStyleList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.FillStyleListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.BackgroundFillStyleList>(), value, diffs, objName, propName);
  }
  
  private static void SetBackgroundFillStyleList(DXD.FormatScheme openXmlElement, DMD.FillStyleList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.BackgroundFillStyleList>();
    if (itemElement != null && value != null)
      DMXD.FillStyleListConverter.UpdateOpenXmlElement(itemElement, value);
    else
    if (value != null)
    {
      itemElement = DMXD.FillStyleListConverter.CreateOpenXmlElement<DXD.BackgroundFillStyleList>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMD.FormatScheme? CreateModelElement(DXD.FormatScheme? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.FormatScheme();
      value.Name = GetName(openXmlElement);
      value.FillStyleList = GetFillStyleList(openXmlElement);
      value.LineStyleList = GetLineStyleList(openXmlElement);
      value.EffectStyleList = GetEffectStyleList(openXmlElement);
      value.BackgroundFillStyleList = GetBackgroundFillStyleList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXD.FormatScheme? openXmlElement, DMD.FormatScheme? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpName(openXmlElement, value.Name, diffs, objName, propName))
        ok = false;
      if (!CmpFillStyleList(openXmlElement, value.FillStyleList, diffs, objName, propName))
        ok = false;
      if (!CmpLineStyleList(openXmlElement, value.LineStyleList, diffs, objName, propName))
        ok = false;
      if (!CmpEffectStyleList(openXmlElement, value.EffectStyleList, diffs, objName, propName))
        ok = false;
      if (!CmpBackgroundFillStyleList(openXmlElement, value.BackgroundFillStyleList, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.FormatScheme value)
    where OpenXmlElementType: DXD.FormatScheme, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static bool UpdateOpenXmlElement(DXD.FormatScheme openXmlElement, DMD.FormatScheme value)
  {
    SetName(openXmlElement, value?.Name);
    SetFillStyleList(openXmlElement, value?.FillStyleList);
    SetLineStyleList(openXmlElement, value?.LineStyleList);
    SetEffectStyleList(openXmlElement, value?.EffectStyleList);
    SetBackgroundFillStyleList(openXmlElement, value?.BackgroundFillStyleList);
    return true;
  }
}
