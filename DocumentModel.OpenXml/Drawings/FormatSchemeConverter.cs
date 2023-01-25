namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Format Scheme.
/// </summary>
public static class FormatSchemeConverter
{
  /// <summary>
  /// Name
  /// </summary>
  private static String? GetName(DXDraw.FormatScheme openXmlElement)
  {
    return openXmlElement?.Name?.Value;
  }
  
  private static bool CmpName(DXDraw.FormatScheme openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Name?.Value == value;
  }
  
  private static void SetName(DXDraw.FormatScheme openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Name = new StringValue { Value = value };
    else
      openXmlElement.Name = null;
  }
  
  /// <summary>
  /// Fill Style List.
  /// </summary>
  private static DMDraws.FillStyleList? GetFillStyleList(DXDraw.FormatScheme openXmlElement)
  {
    return DMXDraws.FillStyleListConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.FillStyleList>());
  }
  
  private static bool CmpFillStyleList(DXDraw.FormatScheme openXmlElement, DMDraws.FillStyleList? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.FillStyleListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.FillStyleList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetFillStyleList(DXDraw.FormatScheme openXmlElement, DMDraws.FillStyleList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.FillStyleList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.FillStyleListConverter.CreateOpenXmlElement<DXDraw.FillStyleList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Line Style List.
  /// </summary>
  private static DMDraws.LineStyleList? GetLineStyleList(DXDraw.FormatScheme openXmlElement)
  {
    return DMXDraws.LineStyleListConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.LineStyleList>());
  }
  
  private static bool CmpLineStyleList(DXDraw.FormatScheme openXmlElement, DMDraws.LineStyleList? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.LineStyleListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.LineStyleList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetLineStyleList(DXDraw.FormatScheme openXmlElement, DMDraws.LineStyleList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.LineStyleList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.LineStyleListConverter.CreateOpenXmlElement<DXDraw.LineStyleList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Effect Style List.
  /// </summary>
  private static DMDraws.EffectStyleList? GetEffectStyleList(DXDraw.FormatScheme openXmlElement)
  {
    return DMXDraws.EffectStyleListConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.EffectStyleList>());
  }
  
  private static bool CmpEffectStyleList(DXDraw.FormatScheme openXmlElement, DMDraws.EffectStyleList? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.EffectStyleListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.EffectStyleList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetEffectStyleList(DXDraw.FormatScheme openXmlElement, DMDraws.EffectStyleList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.EffectStyleList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.EffectStyleListConverter.CreateOpenXmlElement<DXDraw.EffectStyleList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Background Fill Style List.
  /// </summary>
  private static DMDraws.BackgroundFillStyleList? GetBackgroundFillStyleList(DXDraw.FormatScheme openXmlElement)
  {
    return DMXDraws.BackgroundFillStyleListConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.BackgroundFillStyleList>());
  }
  
  private static bool CmpBackgroundFillStyleList(DXDraw.FormatScheme openXmlElement, DMDraws.BackgroundFillStyleList? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.BackgroundFillStyleListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.BackgroundFillStyleList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetBackgroundFillStyleList(DXDraw.FormatScheme openXmlElement, DMDraws.BackgroundFillStyleList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.BackgroundFillStyleList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.BackgroundFillStyleListConverter.CreateOpenXmlElement<DXDraw.BackgroundFillStyleList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDraws.FormatScheme? CreateModelElement(DXDraw.FormatScheme? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.FormatScheme();
      value.Name = GetName(openXmlElement);
      value.FillStyleList = GetFillStyleList(openXmlElement);
      value.LineStyleList = GetLineStyleList(openXmlElement);
      value.EffectStyleList = GetEffectStyleList(openXmlElement);
      value.BackgroundFillStyleList = GetBackgroundFillStyleList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDraw.FormatScheme? openXmlElement, DMDraws.FormatScheme? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.FormatScheme? value)
    where OpenXmlElementType: DXDraw.FormatScheme, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetName(openXmlElement, value?.Name);
      SetFillStyleList(openXmlElement, value?.FillStyleList);
      SetLineStyleList(openXmlElement, value?.LineStyleList);
      SetEffectStyleList(openXmlElement, value?.EffectStyleList);
      SetBackgroundFillStyleList(openXmlElement, value?.BackgroundFillStyleList);
      return openXmlElement;
    }
    return default;
  }
}
