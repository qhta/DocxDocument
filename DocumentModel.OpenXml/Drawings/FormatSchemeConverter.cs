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
  
  private static bool CmpName(DXD.FormatScheme openXmlElement, String? value, DiffList? diffs, string? objName)
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
  
  private static bool CmpFillStyleList(DXD.FormatScheme openXmlElement, DMD.FillStyleList? value, DiffList? diffs, string? objName)
  {
    return DMXD.FillStyleListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.FillStyleList>(), value, diffs, objName);
  }
  
  private static void SetFillStyleList(DXD.FormatScheme openXmlElement, DMD.FillStyleList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.FillStyleList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.FillStyleListConverter.CreateOpenXmlElement<DXD.FillStyleList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
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
  
  private static bool CmpLineStyleList(DXD.FormatScheme openXmlElement, DMD.LineStyleList? value, DiffList? diffs, string? objName)
  {
    return DMXD.LineStyleListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.LineStyleList>(), value, diffs, objName);
  }
  
  private static void SetLineStyleList(DXD.FormatScheme openXmlElement, DMD.LineStyleList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.LineStyleList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.LineStyleListConverter.CreateOpenXmlElement<DXD.LineStyleList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
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
  
  private static bool CmpEffectStyleList(DXD.FormatScheme openXmlElement, DMD.EffectStyleList? value, DiffList? diffs, string? objName)
  {
    return DMXD.EffectStyleListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.EffectStyleList>(), value, diffs, objName);
  }
  
  private static void SetEffectStyleList(DXD.FormatScheme openXmlElement, DMD.EffectStyleList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.EffectStyleList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.EffectStyleListConverter.CreateOpenXmlElement<DXD.EffectStyleList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Background Fill Style List.
  /// </summary>
  private static DMD.BackgroundFillStyleList? GetBackgroundFillStyleList(DXD.FormatScheme openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.BackgroundFillStyleList>();
    if (element != null)
      return DMXD.BackgroundFillStyleListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBackgroundFillStyleList(DXD.FormatScheme openXmlElement, DMD.BackgroundFillStyleList? value, DiffList? diffs, string? objName)
  {
    return DMXD.BackgroundFillStyleListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.BackgroundFillStyleList>(), value, diffs, objName);
  }
  
  private static void SetBackgroundFillStyleList(DXD.FormatScheme openXmlElement, DMD.BackgroundFillStyleList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.BackgroundFillStyleList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.BackgroundFillStyleListConverter.CreateOpenXmlElement<DXD.BackgroundFillStyleList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.FormatScheme? CreateModelElement(DXD.FormatScheme? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.FormatScheme();
      value.Name = GetName(openXmlElement);
      value.FillStyleList = GetFillStyleList(openXmlElement);
      value.LineStyleList = GetLineStyleList(openXmlElement);
      value.EffectStyleList = GetEffectStyleList(openXmlElement);
      value.BackgroundFillStyleList = GetBackgroundFillStyleList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXD.FormatScheme? openXmlElement, DMD.FormatScheme? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpName(openXmlElement, value.Name, diffs, objName))
        ok = false;
      if (!CmpFillStyleList(openXmlElement, value.FillStyleList, diffs, objName))
        ok = false;
      if (!CmpLineStyleList(openXmlElement, value.LineStyleList, diffs, objName))
        ok = false;
      if (!CmpEffectStyleList(openXmlElement, value.EffectStyleList, diffs, objName))
        ok = false;
      if (!CmpBackgroundFillStyleList(openXmlElement, value.BackgroundFillStyleList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.FormatScheme value)
    where OpenXmlElementType: DXD.FormatScheme, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.FormatScheme openXmlElement, DMD.FormatScheme value)
  {
    SetName(openXmlElement, value?.Name);
    SetFillStyleList(openXmlElement, value?.FillStyleList);
    SetLineStyleList(openXmlElement, value?.LineStyleList);
    SetEffectStyleList(openXmlElement, value?.EffectStyleList);
    SetBackgroundFillStyleList(openXmlElement, value?.BackgroundFillStyleList);
  }
}
